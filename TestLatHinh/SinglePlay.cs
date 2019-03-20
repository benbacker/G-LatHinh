using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestLatHinh
{
    public partial class SinglePlay : Form
    {
        LatHinh mainform;
        int backupscore = 0;
        int score = 0;
        int lv = 0;
        int numtimehelppress = 0;
        ListGameLevel lsgmlv= new ListGameLevel();
        GameLevel gmlv;



        public SinglePlay(LatHinh _mainform)
        {
            this.IsMdiContainer = false;
            this.BackgroundImage = Properties.Resources.backgroundThresh;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            

            mainform = _mainform;
            InitializeComponent();
            btnHelp.Hide();
            lsgmlv.setListGameLevel();
            lbTimeCooldown.Text = ((lsgmlv.listgl[lv].time)/10).ToString();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Cursor = CreateCursor.cur;
        }
        public SinglePlay(LatHinh _mainform,int _level=0, int _score=0)
        {
            this.IsMdiContainer = false;
            this.BackgroundImage = Properties.Resources.backgroundThresh;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            mainform = _mainform;
            InitializeComponent();
            lv = _level;
            score = _score;
            lbScore.Text = _score.ToString();
            lbLv.Text = _level.ToString();
            btnHelp.Hide();
            lsgmlv.setListGameLevel();
            lbTimeCooldown.Text = lsgmlv.listgl[lv].time.ToString();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {   

            this.IsMdiContainer = true;
            numtimehelppress = 0;
            if (btnHelp.Enabled == false)
                btnHelp.Enabled = true;
            frmGame frmgm;
            if (btnStart.Text == "Start")
            {   
                updateGameLevel(lv);
                frmgm = new frmGame();
                frmgm.MdiParent = this;
                
                frmgm.setGame(gmlv);

                frmgm.Show();
                frmgm.Location = new Point(0, 0);
                this.Width = frmgm.Width + panel1.Width;
                this.Height = frmgm.Height;
                panel1.Height = frmgm.Height;
                panel1.Location = new Point(frmgm.Width, 0);
                btnStart.Text = "Pause";
                btnHelp.Show();
                btnHelp.PerformClick();
            }
            else if(btnStart.Text=="Pause")
            {
                ((frmGame)this.ActiveMdiChild).pauseGame();
                btnHelp.Hide();
                btnStart.Text = "Continues";

            }
            else if(btnStart.Text == "Continues")
            {
                ((frmGame)this.ActiveMdiChild).continuesGame();
                btnHelp.Show();
                btnStart.Text = "Pause";
            }

        }
        internal void updateScore(int _addscore)
        {
            score += _addscore;
            lbScore.Text = score.ToString();
        }
        internal void levelPass(int bonustimescore)
        {
            if(lv==lsgmlv.numMaxlv)
            {

            }
            score += bonustimescore;
            backupscore = score;
            updateScore();
            btnStart.Text = "Start";
            switch (MessageBoxEx.Show("You pass Level " + lv + "\n" +
                            "Do you want to play next level?", "Note!", MessageBoxButtons.YesNo))
            {
                case (DialogResult.Yes):
                    {
                        lv++;
                        btnStart.PerformClick();
                        break;
                    }
                case (DialogResult.No):
                    {
                        break;
                    }
            }
           
        }
        internal void levelfailed()
        {
            btnStart.Text = "Start";
            switch( MessageBoxEx.Show("Time Out! Level " + lv + " Failed!\n" +
                            "Do you want to play this level again?", "Note!", MessageBoxButtons.YesNo))
            { 
            case (DialogResult.Yes):
                    {
                        btnStart.PerformClick();
                        break;
                    }
                case (DialogResult.No):
                    {
                        lv = 0;
                        score = 0;
                        break;
                    }
            }



        }
        public void updateScore()
        {
            lbScore.Text = score.ToString();
        }
        public void updateGameLevel(int lv)
        {
            gmlv = lsgmlv.getlv(lv);
            lbLv.Text = lv.ToString();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            ((frmGame)this.ActiveMdiChild).help();
            numtimehelppress++;
            if (numtimehelppress > 2) btnHelp.Enabled = false;
            
        }
        internal void updateCooldownTime(int _time)
        {
            int sec = _time / 100;
            int milisec = _time % 100;
            lbTimeCooldown.Text = sec+":"+milisec;
        }
        
        private void SinglePlay_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnStart.Text == "Pause") btnStart.PerformClick();
             
            switch (MessageBoxEx.Show("Save game before Exit" ,"Save Game!"
                            , MessageBoxButtons.YesNoCancel))
            {
                case (DialogResult.Yes):
                    {
                        mainform.exitSinglePlay(true, lv, backupscore);
                        
                        break;
                    }
                case (DialogResult.No):
                    {
                        mainform.exitSinglePlay(false);
                        
                        break;
                    }
                case (DialogResult.Cancel):
                    {
                        e.Cancel = true;
                        break;
                    }

            }
            
        }
    }
}
