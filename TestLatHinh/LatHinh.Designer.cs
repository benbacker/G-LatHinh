namespace TestLatHinh
{
    partial class LatHinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.picMini = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.switchButton1 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.buttonInfo = new DevComponents.DotNetBar.ButtonX();
            this.btnInfo = new DevComponents.DotNetBar.ButtonX();
            this.btnRank = new DevComponents.DotNetBar.ButtonX();
            this.btnMultiplay = new DevComponents.DotNetBar.ButtonX();
            this.btnContinues = new DevComponents.DotNetBar.ButtonX();
            this.button1 = new DevComponents.DotNetBar.ButtonX();
            this.btnSinglePlay = new DevComponents.DotNetBar.ButtonX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.picMini);
            this.panelEx1.Controls.Add(this.picExit);
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(961, 463);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // picMini
            // 
            this.picMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMini.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picMini.Image = global::TestLatHinh.Properties.Resources.Minimize;
            this.picMini.Location = new System.Drawing.Point(892, 3);
            this.picMini.Name = "picMini";
            this.picMini.Size = new System.Drawing.Size(30, 30);
            this.picMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMini.TabIndex = 1;
            this.picMini.TabStop = false;
            this.picMini.Click += new System.EventHandler(this.picMini_Click);
            this.picMini.MouseLeave += new System.EventHandler(this.picMini_MouseLeave);
            this.picMini.MouseHover += new System.EventHandler(this.picMini_MouseHover);
            // 
            // picExit
            // 
            this.picExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picExit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picExit.Image = global::TestLatHinh.Properties.Resources.Exit;
            this.picExit.Location = new System.Drawing.Point(928, 3);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(30, 30);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 1;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            this.picExit.MouseLeave += new System.EventHandler(this.picExit_MouseLeave);
            this.picExit.MouseHover += new System.EventHandler(this.picExit_MouseHover);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.switchButton1);
            this.groupPanel1.Controls.Add(this.btnExit);
            this.groupPanel1.Controls.Add(this.buttonInfo);
            this.groupPanel1.Controls.Add(this.btnInfo);
            this.groupPanel1.Controls.Add(this.btnRank);
            this.groupPanel1.Controls.Add(this.btnMultiplay);
            this.groupPanel1.Controls.Add(this.btnContinues);
            this.groupPanel1.Controls.Add(this.button1);
            this.groupPanel1.Controls.Add(this.btnSinglePlay);
            this.groupPanel1.Controls.Add(this.pictureBox1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupPanel1.Location = new System.Drawing.Point(0, 24);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(961, 439);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "GAME MENU";
            // 
            // switchButton1
            // 
            // 
            // 
            // 
            this.switchButton1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton1.Location = new System.Drawing.Point(880, 3);
            this.switchButton1.Name = "switchButton1";
            this.switchButton1.Size = new System.Drawing.Size(66, 22);
            this.switchButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton1.TabIndex = 17;
            this.switchButton1.ValueChanged += new System.EventHandler(this.switchButton1_ValueChanged);
            this.switchButton1.MouseHover += new System.EventHandler(this.switchButton1_MouseHover);
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExit.Location = new System.Drawing.Point(16, 347);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 35);
            this.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonInfo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonInfo.Location = new System.Drawing.Point(16, 291);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(128, 35);
            this.buttonInfo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonInfo.TabIndex = 16;
            this.buttonInfo.Text = "Thông tin trò chơi";
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInfo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnInfo.Location = new System.Drawing.Point(16, 235);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(128, 35);
            this.btnInfo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnInfo.TabIndex = 16;
            this.btnInfo.Text = "Cài đặt";
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnRank
            // 
            this.btnRank.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRank.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRank.Location = new System.Drawing.Point(16, 179);
            this.btnRank.Name = "btnRank";
            this.btnRank.Size = new System.Drawing.Size(128, 35);
            this.btnRank.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRank.TabIndex = 16;
            this.btnRank.Text = "Bảng điểm";
            this.btnRank.Click += new System.EventHandler(this.btnRank_Click);
            // 
            // btnMultiplay
            // 
            this.btnMultiplay.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMultiplay.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnMultiplay.Location = new System.Drawing.Point(16, 123);
            this.btnMultiplay.Name = "btnMultiplay";
            this.btnMultiplay.Size = new System.Drawing.Size(128, 35);
            this.btnMultiplay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMultiplay.TabIndex = 16;
            this.btnMultiplay.Text = "Solo qua LAN";
            this.btnMultiplay.Click += new System.EventHandler(this.btnMultiplay_Click);
            // 
            // btnContinues
            // 
            this.btnContinues.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnContinues.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnContinues.Location = new System.Drawing.Point(16, 67);
            this.btnContinues.Name = "btnContinues";
            this.btnContinues.Size = new System.Drawing.Size(128, 35);
            this.btnContinues.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnContinues.TabIndex = 16;
            this.btnContinues.Text = "Tiếp tục";
            this.btnContinues.Click += new System.EventHandler(this.btnContinues_Click);
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button1.Location = new System.Drawing.Point(228, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 35);
            this.button1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.button1.TabIndex = 16;
            this.button1.Text = "Nghe nhạc online";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSinglePlay
            // 
            this.btnSinglePlay.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSinglePlay.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSinglePlay.Location = new System.Drawing.Point(16, 11);
            this.btnSinglePlay.Name = "btnSinglePlay";
            this.btnSinglePlay.Size = new System.Drawing.Size(128, 35);
            this.btnSinglePlay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSinglePlay.TabIndex = 16;
            this.btnSinglePlay.Text = "Chơi đơn";
            this.btnSinglePlay.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::TestLatHinh.Properties.Resources.YasuoBackground;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(955, 416);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LatHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 463);
            this.Controls.Add(this.panelEx1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LatHinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Lật hình";
            this.Load += new System.EventHandler(this.LatHinh_Load);
            this.Shown += new System.EventHandler(this.LatHinh_Shown);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.PictureBox picExit;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picMini;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private DevComponents.DotNetBar.ButtonX buttonInfo;
        private DevComponents.DotNetBar.ButtonX btnInfo;
        private DevComponents.DotNetBar.ButtonX btnRank;
        private DevComponents.DotNetBar.ButtonX btnMultiplay;
        private DevComponents.DotNetBar.ButtonX btnContinues;
        private DevComponents.DotNetBar.ButtonX button1;
        private DevComponents.DotNetBar.ButtonX btnSinglePlay;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton1;
        private System.Windows.Forms.Timer timer1;
    }
}