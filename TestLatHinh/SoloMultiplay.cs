using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestLatHinh
{
    public partial class SoloMultiplay : Form
    {
        bool isServer = false;
        bool isLastPlayer = false;

        SocketManager socket= new SocketManager();
        ListCard LISTCARD=new ListCard();

        frmLanGameplay frmlangame = new frmLanGameplay();
        public SoloMultiplay()
        {
            InitializeComponent();
            btnRecieveAndCreate.Enabled = false;
            btnCreateandSend.Enabled = false;
            btnPlay.Enabled = false;
            btnCreateandSend.Enabled = false;
            btnRecieveAndCreate.Enabled = false;
            this.IsMdiContainer = false;
            this.BackgroundImage = Properties.Resources.backgroundThresh;
            this.BackgroundImageLayout = ImageLayout.Stretch;


            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Cursor = CreateCursor.cur;
        }

        private void SoloMultiplay_Shown(object sender, EventArgs e)
        {
            tbIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            if(string.IsNullOrEmpty(tbIP.Text))
            {
                tbIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);
            }
            if(string.IsNullOrEmpty(tbIP.Text))
            {
                MessageBoxEx.Show("Kiểm tra lại mạng LAN");
                this.Close();
            }
            

        }

        private void btnLan_Click(object sender, EventArgs e)
        {   

            this.IsMdiContainer = true;
            socket.IP = tbIP.Text;
            if(!socket.ConnectServer())
            {   
                socket.CreateServer();
                MessageBoxEx.Show("Tạo Server thành công, đang đợi người chơi khác kết nối vào");
                isServer = true;
                btnLan.Enabled = false;
                btnCreateandSend.Enabled = true;
                Listen();
            }
            else
            {
                
                btnLan.Enabled = false;
                
                
                socket.Send(new SocketData((int)SocketCommand.NOTIFY,"Đã có người chơi kết nối tới, Tạo bàn và chơi thôi",null));
                              
                Listen();
            }
        }
        void Listen()
        {
        
                Thread listenThread = new Thread(() =>
                {
                    while (true)
                    {
                        try
                        {
                            SocketData data = (SocketData)socket.Receive();
                            ProcessData(data);
                        }
                        catch
                        {

                        }
                    }
                });
                listenThread.IsBackground = true;
                listenThread.Start();
                
            

        }

        private void ProcessData(SocketData data)
        {
            switch (data.Command)
            {
                case (int)SocketCommand.NOTIFY:
                    MessageBoxEx.Show(data.Message);
                    break;
                case (int)SocketCommand.NEW_GAME:
                    
                    break;
                case (int)SocketCommand.SEND_LISTCARD:
                    sendlistcard(data.listcard);
                    btnRecieveAndCreate.Enabled = true;
                    
                    break;
                case (int)SocketCommand.QUIT:

                    MessageBoxEx.Show("Người chơi bên kia đã đầu hàng và thoát! Game Over!");
                    frmlangame.Hide();
                    isLastPlayer = true;
                    this.Close();
                    break;
                case (int)SocketCommand.END_GAME:
                    break;
                case (int)SocketCommand.START_PLAY:
                    startplay();
                    break;
                case (int)SocketCommand.WIN:
                    MessageBoxEx.Show(data.Message);
                    frmlangame.Hide();
                    if(isServer)
                        btnCreateandSend.Enabled = true;
                    
                    
                    break;
                default:
                    break;
            }

        }


        private void btnCreateandSend_Click(object sender, EventArgs e)
        {
            if (cbbStyleCard.SelectedIndex == -1 || String.IsNullOrEmpty(tbRow.Text) || String.IsNullOrEmpty(tbCol.Text))
                MessageBoxEx.Show("Nhập đầy đủ thông tin bàn chơi!");
            else if ((Int32.Parse(tbRow.Text) * Int32.Parse(tbCol.Text)) % 2 != 0 || (Int32.Parse(tbRow.Text) * Int32.Parse(tbCol.Text)) > 200)
                MessageBoxEx.Show("Tích số cột và dòng là một số chẵn và nhỏ hơn hoặc bằng 200");
            else
            {
                int numrow = Int32.Parse(tbRow.Text);
                int numcol = Int32.Parse(tbCol.Text);
                string typecard = cbbStyleCard.SelectedItem.ToString();

                ListCard listcard = new ListCard();
                listcard.setListCard(numcol, numrow, 0, 0, 0, typecard);
                listcard.randomimage();

                frmlangame = new frmLanGameplay();

                frmlangame.setGame(listcard);
                frmlangame.MdiParent = this;
                frmlangame.Show();
                frmlangame.Location = new Point(0, 0);
                panel1.Location = new Point(frmlangame.Width, 0);
                this.Width = frmlangame.Width + panel1.Width + 30;
                this.Height = (panel1.Height > frmlangame.Height ? panel1.Height + 30 : frmlangame.Height + 30);
                frmlangame.DisableAll();

                socket.Send(new SocketData((int)SocketCommand.NOTIFY, "Nhận bàn chơi thành công", null));
                socket.Send(new SocketData((int)SocketCommand.SEND_LISTCARD, "", listcard));

                btnCreateandSend.Enabled = false;
                btnPlay.Enabled = true;
            }

        }
        void sendlistcard(ListCard _listcard)
        {

            LISTCARD = _listcard;
            

        }
        void startplay()
        {
            frmlangame.help();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            frmlangame.help();
            socket.Send(new SocketData((int)SocketCommand.START_PLAY, "", null));
            btnPlay.Enabled = false;
        }



        private void SoloMultiplay_Load(object sender, EventArgs e)
        {
            
            

        }

        private void btnRecieveAndCreate_Click(object sender, EventArgs e)
        {
            frmlangame = new frmLanGameplay();


            frmlangame.setGame(LISTCARD);
            frmlangame.TopLevel = false;
            frmlangame.MdiParent = this;
            frmlangame.Show();
            frmlangame.Location = new Point(0, 0);
            panel1.Location = new Point(frmlangame.Width, 0);
            this.Width = frmlangame.Width + panel1.Width+30;
            this.Height = (panel1.Height > frmlangame.Height ? panel1.Height+30 : frmlangame.Height+30);
            frmlangame.DisableAll();
            btnRecieveAndCreate.Enabled = false;
        }
        internal void Win()
        {
            frmlangame.Hide();
            socket.Send(new SocketData((int)SocketCommand.WIN, "Người chơi với bạn đã chiến thắng! Hãy chúc mừng anh ấy hoặc gạ kèo chơi lại", null));
            
            if(isServer) btnCreateandSend.Enabled = true;
        }

        private void SoloMultiplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isLastPlayer)
            {
                switch (MessageBoxEx.Show("Bạn có chắc chắn muốn thoát", "Thoát game!"
                                , MessageBoxButtons.YesNo))
                {
                    case (DialogResult.Yes):
                        {

                            try
                            {
                                socket.Send(new SocketData((int)SocketCommand.QUIT, "", null));

                            }
                            catch
                            {

                            }
                            break;
                        }
                    case (DialogResult.No):
                        {
                            e.Cancel = true;

                            break;
                        }


                }
            }
        }
        private void SoloMultiplay_FormClosingwithoutask(object sender, FormClosingEventArgs e)
        {

        }

    }
}
