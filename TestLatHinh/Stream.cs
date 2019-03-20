using DevComponents.DotNetBar;
using HtmlAgilityPack;
using NAudio.Wave;
using NAudioDemo.Mp3StreamingDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestLatHinh
{
    public partial class Stream : Form
    {
        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);
        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        enum StreamingPlaybackState
        {
            Stopped,
            Playing,
            Buffering,
            Paused
        }

        public Stream()
        {
            InitializeComponent();
            //volumeSlider1.VolumeChanged += OnVolumeSliderChanged;
            Disposed += MP3StreamingPanel_Disposing;
            dgvSearch.Hide();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

        }


        void OnVolumeSliderChanged(object sender, EventArgs e)
        {
            //if (volumeProvider != null)
            //{
            //    volumeProvider.Volume = volumeSlider1.Volume;
            //}
        }

        private BufferedWaveProvider bufferedWaveProvider;
        private IWavePlayer waveOut;
        private volatile StreamingPlaybackState playbackState;
        private volatile bool fullyDownloaded;
        private HttpWebRequest webRequest;
        private VolumeWaveProvider16 volumeProvider;

        delegate void ShowErrorDelegate(string message);

        private void ShowError(string message)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new ShowErrorDelegate(ShowError), message);
            }
            else
            {
                MessageBoxEx.Show(message);
            }
        }

        private void StreamMp3(object state)
        {
            fullyDownloaded = false;
            var url = (string)state;
            webRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse resp;
            try
            {
                resp = (HttpWebResponse)webRequest.GetResponse();
            }
            catch (WebException e)
            {
                if (e.Status != WebExceptionStatus.RequestCanceled)
                {
                    ShowError(e.Message);
                }
                return;
            }
            var buffer = new byte[16384 * 4]; // needs to be big enough to hold a decompressed frame

            IMp3FrameDecompressor decompressor = null;
            try
            {
                using (var responseStream = resp.GetResponseStream())
                {
                    var readFullyStream = new ReadFullyStream(responseStream);
                    do
                    {
                        if (IsBufferNearlyFull)
                        {
                            Debug.WriteLine("Buffer getting full, taking a break");
                            Thread.Sleep(500);
                        }
                        else
                        {
                            Mp3Frame frame;
                            try
                            {
                                frame = Mp3Frame.LoadFromStream(readFullyStream);
                            }
                            catch (EndOfStreamException)
                            {
                                fullyDownloaded = true;
                                // reached the end of the MP3 file / stream
                                break;
                            }
                            catch (WebException)
                            {
                                // probably we have aborted download from the GUI thread
                                break;
                            }
                            if (frame == null) break;
                            if (decompressor == null)
                            {
                                // don't think these details matter too much - just help ACM select the right codec
                                // however, the buffered provider doesn't know what sample rate it is working at
                                // until we have a frame
                                decompressor = CreateFrameDecompressor(frame);
                                bufferedWaveProvider = new BufferedWaveProvider(decompressor.OutputFormat);
                                bufferedWaveProvider.BufferDuration =
                                    TimeSpan.FromSeconds(20); // allow us to get well ahead of ourselves
                                //this.bufferedWaveProvider.BufferedDuration = 250;
                            }
                            try
                            {
                                int decompressed = decompressor.DecompressFrame(frame, buffer, 0);
                                //Debug.WriteLine(String.Format("Decompressed a frame {0}", decompressed));
                                bufferedWaveProvider.AddSamples(buffer, 0, decompressed);
                            }
                            catch
                            {

                            }
                        }

                    } while (playbackState != StreamingPlaybackState.Stopped);
                    Debug.WriteLine("Exiting");
                    // was doing this in a finally block, but for some reason
                    // we are hanging on response stream .Dispose so never get there
                    decompressor.Dispose();
                }
            }
            finally
            {
                if (decompressor != null)
                {
                    decompressor.Dispose();
                }
            }
        }

        private static IMp3FrameDecompressor CreateFrameDecompressor(Mp3Frame frame)
        {
            WaveFormat waveFormat = new Mp3WaveFormat(frame.SampleRate, frame.ChannelMode == ChannelMode.Mono ? 1 : 2,
                frame.FrameLength, frame.BitRate);
            return new AcmMp3FrameDecompressor(waveFormat);
        }

        private bool IsBufferNearlyFull
        {
            get
            {
                return bufferedWaveProvider != null &&
                       bufferedWaveProvider.BufferLength - bufferedWaveProvider.BufferedBytes
                       < bufferedWaveProvider.WaveFormat.AverageBytesPerSecond / 4;
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (playbackState == StreamingPlaybackState.Stopped)
            {
                playbackState = StreamingPlaybackState.Buffering;
                bufferedWaveProvider = null;
                int index = dataGridView1.CurrentCell.RowIndex;
                ThreadPool.QueueUserWorkItem(StreamMp3, Helper.getlinkmp3(dataGridView1.Rows[index].Cells[1].Value.ToString()));

                timer1.Enabled = true;
            }
            else if (playbackState == StreamingPlaybackState.Paused)
            {
                playbackState = StreamingPlaybackState.Buffering;
            }
            else if(playbackState==StreamingPlaybackState.Playing)
            {
                StopPlayback();
                
                playbackState = StreamingPlaybackState.Buffering;
                bufferedWaveProvider = null;
                int index = dataGridView1.CurrentCell.RowIndex;
                ThreadPool.QueueUserWorkItem(StreamMp3, Helper.getlinkmp3(dataGridView1.Rows[index].Cells[1].Value.ToString()));
                
                timer1.Enabled = true;
            }
            
        }

        private void StopPlayback()
        {
            if (playbackState != StreamingPlaybackState.Stopped)
            {
                if (!fullyDownloaded)
                {
                    webRequest.Abort();
                }

                playbackState = StreamingPlaybackState.Stopped;
                if (waveOut != null)
                {
                    waveOut.Stop();
                    waveOut.Dispose();
                    waveOut = null;
                }
                timer1.Enabled = false;
                // n.b. streaming thread may not yet have exited
                Thread.Sleep(500);
                ShowBufferState(0);
            }
        }

        private void ShowBufferState(double totalSeconds)
        {
            labelBuffered.Text = String.Format("{0:0.0}s", totalSeconds);
            progressBarBuffer.Value = (int)(totalSeconds * 1000);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (playbackState != StreamingPlaybackState.Stopped)
            {
                if (waveOut == null && bufferedWaveProvider != null)
                {
                    Debug.WriteLine("Creating WaveOut Device");
                    waveOut = CreateWaveOut();
                    waveOut.PlaybackStopped += OnPlaybackStopped;
                    volumeProvider = new VolumeWaveProvider16(bufferedWaveProvider);
                    //volumeProvider.Volume = volumeSlider1.Volume;
                    waveOut.Init(volumeProvider);
                    progressBarBuffer.Maximum = (int)bufferedWaveProvider.BufferDuration.TotalMilliseconds;
                }
                else if (bufferedWaveProvider != null)
                {
                    var bufferedSeconds = bufferedWaveProvider.BufferedDuration.TotalSeconds;
                    ShowBufferState(bufferedSeconds);
                    // make it stutter less if we buffer up a decent amount before playing
                    if (bufferedSeconds < 0.5 && playbackState == StreamingPlaybackState.Playing && !fullyDownloaded)
                    {
                        Pause();
                        autonextsong();
                    }
                    else if (bufferedSeconds > 4 && playbackState == StreamingPlaybackState.Buffering)
                    {
                        Play();
                    }
                    else if (fullyDownloaded && bufferedSeconds == 0)
                    {
                        Debug.WriteLine("Reached end of stream");
                        StopPlayback();
                        autonextsong();
                       
                    }
                   
                }

            }
        }
        void autonextsong()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            if (index == 9) index = 0;
            else index++;
            StopPlayback();
            dataGridView1.CurrentCell = dataGridView1.Rows[index].Cells[0];
            Thread.Sleep(500);
            buttonPlay.PerformClick();
        }
        private void Play()
        {
            waveOut.Play();
            Debug.WriteLine(String.Format("Started playing, waveOut.PlaybackState={0}", waveOut.PlaybackState));
            playbackState = StreamingPlaybackState.Playing;
        }

        private void Pause()
        {
            playbackState = StreamingPlaybackState.Buffering;
            waveOut.Pause();
            Debug.WriteLine(String.Format("Paused to buffer, waveOut.PlaybackState={0}", waveOut.PlaybackState));
        }

        private IWavePlayer CreateWaveOut()
        {
            return new WaveOut();
        }

        private void MP3StreamingPanel_Disposing(object sender, EventArgs e)
        {
            StopPlayback();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (playbackState == StreamingPlaybackState.Playing || playbackState == StreamingPlaybackState.Buffering)
            {
                waveOut.Pause();
                Debug.WriteLine(String.Format("User requested Pause, waveOut.PlaybackState={0}", waveOut.PlaybackState));
                playbackState = StreamingPlaybackState.Paused;
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            StopPlayback();
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs e)
        {
            Debug.WriteLine("Playback Stopped");
            if (e.Exception != null)
            {
                MessageBoxEx.Show(String.Format("Playback Error {0}", e.Exception.Message));
            }
        }

        private void Stream_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for(int i=0;i<=10;i++)
            {
                dataGridView1.Rows.Add(ConfigurationManager.AppSettings["MB" + (i + 1)+"name"], ConfigurationManager.AppSettings["MB"+(i+1)]);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            dgvSearch.Rows.Clear();

            HtmlWeb htmlWeb = new HtmlWeb()
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8  //Set UTF8 để hiển thị tiếng Việt
            };

            //Load trang web, nạp html vào document
            HtmlAgilityPack.HtmlDocument document = htmlWeb.Load("https://www.nhaccuatui.com/tim-nang-cao?title=" + textBoxStreamingUrl.Text + "&singer=&user=&type=1&kbit=0&sort=0&direction=2");

            //Load các tag li trong tag ul
            var threadItems = document.DocumentNode.SelectNodes("//ul[@class='search_returns_list']/li").ToList();

            var items = new List<object>();

            foreach (var item in threadItems)
            {

                //Extract các giá trị từ các tag con của tag li
                var linkNode = item.SelectSingleNode(".//div[@class='item_content']");
                var linkNode1 = linkNode.SelectSingleNode(".//a");

                var link = linkNode1.Attributes["href"].Value;
                var text = linkNode.InnerText;

                dgvSearch.Rows.Add(text, link);
                dgvSearch.Show();
                trackWave.Hide();

            }
        }



        private void Stream_Click(object sender, EventArgs e)
        {
            dgvSearch.Hide();
            trackWave.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int indexsearch = dgvSearch.CurrentCell.RowIndex;
            int indexPlaylist = dataGridView1.CurrentCell.RowIndex;
            dataGridView1[0, indexPlaylist].Value = dgvSearch.Rows[indexsearch].Cells[0].Value.ToString();
            dataGridView1[1, indexPlaylist].Value = dgvSearch.Rows[indexsearch].Cells[1].Value.ToString();
            
        }

        private void labelBuffered_Click(object sender, EventArgs e)
        {

        }

        private void progressBarBuffer_Click(object sender, EventArgs e)
        {

        }

        private void btnSavePL_Click(object sender, EventArgs e)
        {
            for(int i=0;i<10;i++)
            {
                Helper.EditAppSetting("MB"+(i+1), dataGridView1.Rows[i].Cells[1].Value.ToString());
                Helper.EditAppSetting("MB"+(i+1)+"name", dataGridView1.Rows[i].Cells[0].Value.ToString());
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int NewVolume = ((ushort.MaxValue / 10) * trackWave.Value);
            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
        }

        private void btnDeleteall_Click(object sender, EventArgs e)
        {
            for(int i= 0; i< dataGridView1.RowCount; i++)
            {
                for(int j=0; j<2; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = "";
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[1].Visible = false;
        }
    }

}
