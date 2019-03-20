using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Configuration;
using System.IO;

namespace TestLatHinh
{
    public partial class frmGame : Form
    {
        public string typeCard;
        public int quick;
        public int quickmax;
        bool isSoundOn = false;
        public int numCardbonustime;
        public int numCardbonusscore;
        public int numCardDangerous;
        public int _TIME_;
        public int _NUMCOLUMN_;
        public int _CARDSIZE_;
        public int _NUMROW_;
        public int _LEVEL_;
        internal void setGame(GameLevel _gmlv)
        {
            _LEVEL_ = _gmlv.level;
            _TIME_= _gmlv.time;
            quickmax = _TIME_ * 10;
            quick = quickmax;
            _NUMCOLUMN_ = _gmlv.NumColumn;
            _NUMROW_ = _gmlv.NumRow;
            _CARDSIZE_ = _gmlv.CardSize;
            numCardbonusscore = _gmlv.numCardbonusscore;
            numCardbonustime = _gmlv.numCardbonustime;
            numCardDangerous = _gmlv.numCardDangerous;
            typeCard = _gmlv.typeCard;
            
            LISTCARD = new ListCard();
            LISTCARD.setListCard(_NUMCOLUMN_, _NUMROW_,numCardbonustime,numCardbonusscore,numCardDangerous,typeCard);
            this.Cursor = CreateCursor.cur;
        }

        public int socardxong = 0;
        public static int Diem = 0;

        int socarddangmo = 0;
        int cardmo1 = 0;
        int cardmo2 = 0;
        SoundPlayer SPcorrect,SPwrong;
        public ListCard LISTCARD;
        PictureBox PrePic;

        public frmGame()
        {
            InitializeComponent();
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            if( ConfigurationManager.AppSettings["isSoundOn"] == "true")
            {
                isSoundOn = true;
                string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
                string correct = string.Format("{0}Resources\\correct.wav", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
                string wrong = string.Format("{0}Resources\\wrong1.wav", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));

                SPcorrect = new SoundPlayer(correct);
                SPwrong = new SoundPlayer(wrong);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
            int count = 1;
  
            for (int i = 0; i < _NUMROW_; i++)

            {
                for (int j = 0; j <_NUMCOLUMN_; j++)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Location = new System.Drawing.Point(j* _CARDSIZE_, i*_CARDSIZE_);
                    pictureBox.Name = "Card" +count;                    
                    pictureBox.Size = new System.Drawing.Size(_CARDSIZE_, _CARDSIZE_);
                    pictureBox.BackColor = Color.Black;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Click += pictureBox_click;
                    panel1.Controls.Add(pictureBox);
                    count++;
                }

            }
            LISTCARD.randomimage();
            object background = Properties.Resources.ResourceManager.GetObject("background"+(_LEVEL_+1));
            panel1.BackgroundImage = (Image)background;

            foreach (PictureBox picture in panel1.Controls)
            {
                covercard(picture);



            }
            this.panel1.Width = _NUMCOLUMN_ * _CARDSIZE_;
            this.panel1.Height = _NUMROW_ * _CARDSIZE_;
            this.progressBar1.Width = this.panel1.Width;
            this.Width= _NUMCOLUMN_ * _CARDSIZE_;
            
            this.Height= _NUMROW_ * _CARDSIZE_+this.progressBar1.Height;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            quick--;
            ((SinglePlay)this.MdiParent).updateCooldownTime(quick);
            float t = (quick*100 / quickmax);
            int i = (int)t;
            this.progressBar1.Value =(i<=100?100-i:0);
            
            if (quick == 00)
            {
                timer1.Stop();
                
                ((SinglePlay)this.MdiParent).levelfailed();
                this.Close();
                
                
                


            }
        }


        private async void pictureBox_click(object sender, EventArgs e)
        {
            socarddangmo++;
            if (socarddangmo >= 3)
            {
                socarddangmo = 0;
                return;
            }

                PictureBox P = (PictureBox)(sender);

                int cardnum = Int32.Parse((P.Name.Substring(4)));

                if (LISTCARD.getCard(cardnum).getcardstatus() == 0 && PrePic == null || PrePic != null && PrePic.Name != P.Name)
                {
                    object o = Properties.Resources.ResourceManager.GetObject(LISTCARD.getCard(cardnum).getcardimagename()+typeCard);
                    P.Image = (Image)o;
                    LISTCARD.getCard(cardnum).setcardstatus(1);

                    

                    if (cardmo1 != 0&&cardmo2==0) cardmo2 = cardnum;
                    else if(cardmo1==0) cardmo1 = cardnum;
                    //check 2 cai neu giong nhau thi...
                    if (cardmo1 != 0 && cardmo2 != 0 && LISTCARD.getCard(cardmo1).getcardimagename() == LISTCARD.getCard(cardmo2).getcardimagename())
                    {
                        if (isSoundOn)
                            SPcorrect.Play();
                        await Task.Delay(300);
                        

                        P.Hide();
                        PrePic.Hide();
                        if (LISTCARD.getCard(cardmo1).isBonusScoreCard || LISTCARD.getCard(cardmo2).isBonusScoreCard)
                        {
                            ((SinglePlay)this.MdiParent).updateScore(10);
                        }
                        else ((SinglePlay)this.MdiParent).updateScore(2);
                        if (LISTCARD.getCard(cardmo1).isBonusTimeCard || LISTCARD.getCard(cardmo2).isBonusTimeCard)
                            {
                            quick += 200;
                            }
                        if (LISTCARD.getCard(cardmo1).isDangerousCard || LISTCARD.getCard(cardmo2).isDangerousCard)
                            
                            socarddangmo = 0;

                        cardmo1 = 0;
                        cardmo2 = 0;
                        PrePic = null;
                        socardxong += 2;

                        if(socardxong==_NUMCOLUMN_*_NUMROW_)
                        {
                            timer1.Stop();
                            
                            ((SinglePlay)this.MdiParent).levelPass(quick/10);
                            
                            this.Close();

                            
                        }
                        
                    }
                    if (cardmo1 != 0 && cardmo2 != 0 && LISTCARD.getCard(cardmo1).getcardimagename() != LISTCARD.getCard(cardmo2).getcardimagename())
                    {
                        if (isSoundOn)
                            SPcorrect.Play();
                        await Task.Delay(200);

                        covercard(P);
                        covercard(PrePic);
                        socarddangmo = 0;

                        LISTCARD.getCard(cardmo1).setcardstatus(0);
                        LISTCARD.getCard(cardmo2).setcardstatus(0);
                        cardmo1 = 0;
                        cardmo2 = 0;
                        PrePic = null;
                    }
                    if ((cardmo1 == 0 || cardmo2 == 0) && cardmo1 != cardmo2) PrePic = (PictureBox)(sender);
                }


            }


        
        internal async void help()
        {
            foreach (PictureBox picture in panel1.Controls)
            {
                int cardnum = Int32.Parse((picture.Name.Substring(4)));
                object o = Properties.Resources.ResourceManager.GetObject(LISTCARD.getCard(cardnum).getcardimagename()+typeCard);
                picture.Image = (Image)o;
                picture.Enabled = false;

            }
            timer1.Stop();
            await Task.Delay(2000*_LEVEL_);


            foreach (PictureBox picture in panel1.Controls)
            {
                covercard(picture);
                picture.Enabled = true;
            }
            timer1.Start();
        }



        private void panel1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            

        }

        private void frmGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.ToString()=="F1"))
            {
                this.help();

            }
            
            
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                this.help();
                return true;    // indicate that you handled this keystroke
            }

            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
        }

        

        


        private void frmGame_Resize(object sender, EventArgs e)
        {
            
        }

        private void frmGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {

                timer1.Stop();

            }
        }



        public void covercard(PictureBox P)
        {
            int cardnum = Int32.Parse((P.Name.Substring(4)));

            if (LISTCARD.getCard(cardnum).isBonusScoreCard)
                    P.Image = Properties.Resources.bonusscore;
            else if (LISTCARD.getCard(cardnum).isBonusTimeCard)
                P.Image = Properties.Resources.addtime;
            else if (LISTCARD.getCard(cardnum).isDangerousCard)
                P.Image = Properties.Resources.dangerous;
            else P.Image = Properties.Resources.missing;
        }
        internal void pauseGame()
        {
            
            foreach(PictureBox picture in panel1.Controls)
            {
                picture.Enabled = false;
            }
            timer1.Stop();
        }
        internal void continuesGame()
        {
            foreach (PictureBox picture in panel1.Controls)
            {
                picture.Enabled = true;
            }
            timer1.Start();
        }
    }
}
