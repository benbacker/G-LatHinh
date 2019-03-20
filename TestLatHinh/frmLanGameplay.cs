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

namespace TestLatHinh
{
    public partial class frmLanGameplay : Form
    {
        public string typeCard;
        public int quick;
        public int quickmax;

        public int numCardbonustime;
        public int numCardbonusscore;
        public int numCardDangerous;
        public int _TIME_;
        public int _NUMCOLUMN_;
        public int _CARDSIZE_;
        public int _NUMROW_;
        public int _LEVEL_;
        internal void setGame(ListCard _listcard)
        {
            typeCard = ConfigurationManager.AppSettings[_listcard.typecard]; ;
            quick = quickmax;
            _NUMCOLUMN_ =_listcard._NUMCOLUMN_;
            _NUMROW_ = _listcard._NUMROW_;
            _CARDSIZE_ = 100;
            numCardbonusscore = _listcard.numCardbonusscore;
            numCardbonustime = _listcard.numCardbonustime;
            numCardDangerous = _listcard.numCardDangerous;
            LISTCARD = new ListCard();
            LISTCARD = _listcard;
        }

        public int socardxong = 0;
        

        int socarddangmo = 0;
        int cardmo1 = 0;
        int cardmo2 = 0;

        public ListCard LISTCARD;
        PictureBox PrePic;

        public frmLanGameplay()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            int count = 1;

            for (int i = 0; i < _NUMROW_; i++)

            {
                for (int j = 0; j < _NUMCOLUMN_; j++)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Location = new System.Drawing.Point(j * _CARDSIZE_, i * _CARDSIZE_);
                    pictureBox.Name = "Card" + count;
                    pictureBox.Size = new System.Drawing.Size(_CARDSIZE_, _CARDSIZE_);
                    pictureBox.BackColor = Color.Black;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Click += pictureBox_click;
                    panel1.Controls.Add(pictureBox);
                    count++;
                }
            }
            //LISTCARD.randomimage();



            foreach (PictureBox picture in panel1.Controls)
            {
                covercard(picture);



            }
            this.panel1.Width = _NUMCOLUMN_ * _CARDSIZE_;
            this.panel1.Height = _NUMROW_ * _CARDSIZE_;
            
            this.Width = _NUMCOLUMN_ * _CARDSIZE_;

            this.Height = _NUMROW_ * _CARDSIZE_ ;
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
                object o = Properties.Resources.ResourceManager.GetObject(LISTCARD.getCard(cardnum).getcardimagename() + typeCard);
                P.Image = (Image)o;
                LISTCARD.getCard(cardnum).setcardstatus(1);



                if (cardmo1 != 0 && cardmo2 == 0) cardmo2 = cardnum;
                else if (cardmo1 == 0) cardmo1 = cardnum;
                //check 2 cai neu giong nhau thi...
                if (cardmo1 != 0 && cardmo2 != 0 && LISTCARD.getCard(cardmo1).getcardimagename() == LISTCARD.getCard(cardmo2).getcardimagename())
                {

                    await Task.Delay(300);
                    //SoundPlayer sp = new SoundPlayer(@"C:\Users\abc\Desktop\item lol\Ys.wav");
                    //sp.Play();

                    P.Hide();
                    PrePic.Hide();
                    
                    socarddangmo = 0;

                    cardmo1 = 0;
                    cardmo2 = 0;
                    PrePic = null;
                    socardxong += 2;
                    if (socardxong == _NUMCOLUMN_ * _NUMROW_)
                    {


                        ((SoloMultiplay)this.MdiParent).Win();


                    }


                }
                if (cardmo1 != 0 && cardmo2 != 0 && LISTCARD.getCard(cardmo1).getcardimagename() != LISTCARD.getCard(cardmo2).getcardimagename())
                {
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

        public void DisableAll()
        {
            foreach(PictureBox picture in panel1.Controls)
            {
                picture.Enabled = false;
            }
        }
        public void ActiveAll()
        {
            foreach (PictureBox picture in panel1.Controls)
            {
                picture.Enabled = true;
            }
        }

        internal async void help()
        {
            foreach (PictureBox picture in panel1.Controls)
            {
                int cardnum = Int32.Parse((picture.Name.Substring(4)));
                object o = Properties.Resources.ResourceManager.GetObject(LISTCARD.getCard(cardnum).getcardimagename() + typeCard);
                picture.Image = (Image)o;
                picture.Enabled = false;

            }
            
            await Task.Delay(4000);


            foreach (PictureBox picture in panel1.Controls)
            {
                covercard(picture);
                picture.Enabled = true;
            }
            
        }



        private void panel1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {


        }

        private void frmGameplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.ToString() == "F1"))
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






        private void frmGameplay_Resize(object sender, EventArgs e)
        {

        }

        private void frmGameplay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {

                

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

            foreach (PictureBox picture in panel1.Controls)
            {
                picture.Enabled = false;
            }
            
        }
        internal void continuesGame()
        {
            foreach (PictureBox picture in panel1.Controls)
            {
                picture.Enabled = true;
            }
            
        }
    }
}
