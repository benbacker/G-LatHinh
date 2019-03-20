using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestLatHinh
{
    public partial class LatHinh : Form
    {

        Thread loopmusicbackground;
        SoundPlayer BM;
        public bool isContinues = false;
        int scoreContinues = 0;
        int lvcontinues = 0;
        void setContinues(int _level, int _score)
        {
            isContinues = true;
            lvcontinues = _level;
            scoreContinues = _score;
            btnContinues.Enabled = true;
        }

        public LatHinh()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            if (isContinues)
            {
                this.btnContinues.Enabled = true;
            }
            else
            {
                this.btnContinues.Enabled = false;
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            if (/*button2.Text == "Tắt nhạc nền"*/ switchButton1.Value == true)
            {
                //button2.PerformClick();
                switchButton1.Value = false;
            }
            SinglePlay frmNewGame = new SinglePlay(this);
            frmNewGame.Show();

            btnSinglePlay.Enabled = false;

        }
        private void btnContinues_Click(object sender, EventArgs e)
        {
            SinglePlay frmNewGame = new SinglePlay(this, lvcontinues, scoreContinues);
            frmNewGame.Show();

            btnContinues.Enabled = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        internal void exitSinglePlay(bool isSaveGame, int _lv = 0, int _score = 0)
        {
            btnSinglePlay.Enabled = true;
            if (isSaveGame)
                setContinues(_lv, _score);

        }

        private void LatHinh_Shown(object sender, EventArgs e)
        {
            //string a = "";
            //if (ConfigurationManager.AppSettings["MB1"] != "")
            //{
            //    a = Helper.getlinkmp3(ConfigurationManager.AppSettings["MB1"]);
            //    //newThreadMusicPlying(a,listenMusicThread);
            //}

            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string mp3Path = string.Format("{0}Resources\\backgroundmusic.wav", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));

            BM = new SoundPlayer(mp3Path);
            if (ConfigurationManager.AppSettings["IsMusicOn"] == "true")

            {

                loopmusicbackground = new Thread(() =>
                {

                    BM.PlayLooping();

                });
                loopmusicbackground.IsBackground = true;
                loopmusicbackground.Start();
                //button2.Text = "Tắt nhạc nền";
                switchButton1.Value = true;

            }
            else //button2.Text = "Bật nhạc nền";
                switchButton1.Value = false;

        }
        
       

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Setting frmSt = new Setting();
            frmSt.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            if(/*button2.Text=="Tắt nhạc nền"*/ switchButton1.Value==true)
            {
                //button2.PerformClick();
                switchButton1.Value = false;
            }

            Stream frmstream = new Stream();
            frmstream.Show();
        }

        private void btnMultiplay_Click(object sender, EventArgs e)
        {
            SoloMultiplay frmslml = new SoloMultiplay();
            frmslml.Show();
        }

        private void btnRank_Click(object sender, EventArgs e)
        {
            Rank frmrank = new Rank();
            frmrank.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if(button2.Text=="Tắt nhạc nền")
            //{
            //    BM.Stop();
            //    button2.Text = "Bật nhạc nền";
            //}
            //else if(button2.Text == "Bật nhạc nền")
            //{
            //    BM.PlayLooping();
            //    button2.Text = "Tắt nhạc nền";
            //}

        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            GameInfo frminfo = new GameInfo();
            frminfo.Show();
        }

        private void picMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMini_MouseHover(object sender, EventArgs e)
        {
            picMini.BorderStyle = BorderStyle.None;
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.picMini, "Minimize");
        }

        private void picMini_MouseLeave(object sender, EventArgs e)
        {
            picMini.BorderStyle = BorderStyle.Fixed3D;
        }

        private void picExit_MouseHover(object sender, EventArgs e)
        {
            picExit.BorderStyle = BorderStyle.None;
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.picExit, "Exit");
        }

        private void picExit_MouseLeave(object sender, EventArgs e)
        {
            picExit.BorderStyle = BorderStyle.Fixed3D;
        }

        private void LatHinh_Load(object sender, EventArgs e)
        {
            groupPanel1.Cursor = CreateCursor.cur;
            timer1.Start();
        }

        private void switchButton1_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            if(switchButton1.Value==true)
                tt.SetToolTip(this.switchButton1, "Tắt nhạc nền");
            else tt.SetToolTip(this.switchButton1, "Bật nhạc nền");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (InternetConnection.IsConnectedToInternet())
            {
                button1.Enabled = true;
            }
            else button1.Enabled = false;
        }

        private void switchButton1_ValueChanged(object sender, EventArgs e)
        {
            if (switchButton1.Value == true)
            {
                BM.PlayLooping();
                //button2.Text = "Tắt nhạc nền";

            }
            else
            {
                BM.Stop();
                //button2.Text = "Bật nhạc nền";

            }

        }
    }
}
    
    

