namespace TestLatHinh
{
    partial class SoloMultiplay
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRecieveAndCreate = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.cbbStyleCard = new System.Windows.Forms.ComboBox();
            this.tbCol = new System.Windows.Forms.TextBox();
            this.tbRow = new System.Windows.Forms.TextBox();
            this.btnCreateandSend = new System.Windows.Forms.Button();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.btnLan = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRecieveAndCreate);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.cbbStyleCard);
            this.panel1.Controls.Add(this.tbCol);
            this.panel1.Controls.Add(this.tbRow);
            this.panel1.Controls.Add(this.btnCreateandSend);
            this.panel1.Controls.Add(this.tbIP);
            this.panel1.Controls.Add(this.btnLan);
            this.panel1.Location = new System.Drawing.Point(468, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 305);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kích cỡ bàn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Loại thẻ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "x";
            // 
            // btnRecieveAndCreate
            // 
            this.btnRecieveAndCreate.Location = new System.Drawing.Point(31, 122);
            this.btnRecieveAndCreate.Name = "btnRecieveAndCreate";
            this.btnRecieveAndCreate.Size = new System.Drawing.Size(121, 23);
            this.btnRecieveAndCreate.TabIndex = 7;
            this.btnRecieveAndCreate.Text = "Nhận và Vẽ Game";
            this.btnRecieveAndCreate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRecieveAndCreate.UseVisualStyleBackColor = true;
            this.btnRecieveAndCreate.Click += new System.EventHandler(this.btnRecieveAndCreate_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(31, 161);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(121, 35);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Bắt đầu";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // cbbStyleCard
            // 
            this.cbbStyleCard.FormattingEnabled = true;
            this.cbbStyleCard.Items.AddRange(new object[] {
            "Items",
            "Champions",
            "Jav idols"});
            this.cbbStyleCard.Location = new System.Drawing.Point(75, 56);
            this.cbbStyleCard.Name = "cbbStyleCard";
            this.cbbStyleCard.Size = new System.Drawing.Size(88, 21);
            this.cbbStyleCard.TabIndex = 4;
            // 
            // tbCol
            // 
            this.tbCol.Location = new System.Drawing.Point(127, 23);
            this.tbCol.Name = "tbCol";
            this.tbCol.Size = new System.Drawing.Size(36, 20);
            this.tbCol.TabIndex = 3;
            // 
            // tbRow
            // 
            this.tbRow.Location = new System.Drawing.Point(75, 23);
            this.tbRow.Name = "tbRow";
            this.tbRow.Size = new System.Drawing.Size(36, 20);
            this.tbRow.TabIndex = 3;
            // 
            // btnCreateandSend
            // 
            this.btnCreateandSend.Location = new System.Drawing.Point(31, 93);
            this.btnCreateandSend.Name = "btnCreateandSend";
            this.btnCreateandSend.Size = new System.Drawing.Size(121, 23);
            this.btnCreateandSend.TabIndex = 2;
            this.btnCreateandSend.Text = "Tạo và Gửi Game";
            this.btnCreateandSend.UseVisualStyleBackColor = true;
            this.btnCreateandSend.Click += new System.EventHandler(this.btnCreateandSend_Click);
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(52, 221);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(100, 20);
            this.tbIP.TabIndex = 1;
            // 
            // btnLan
            // 
            this.btnLan.Location = new System.Drawing.Point(52, 247);
            this.btnLan.Name = "btnLan";
            this.btnLan.Size = new System.Drawing.Size(75, 23);
            this.btnLan.TabIndex = 0;
            this.btnLan.Text = "LAN";
            this.btnLan.Click += new System.EventHandler(this.btnLan_Click);
            // 
            // SoloMultiplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 322);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "SoloMultiplay";
            this.Text = "Solo qua LAN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SoloMultiplay_FormClosing);
            this.Load += new System.EventHandler(this.SoloMultiplay_Load);
            this.Shown += new System.EventHandler(this.SoloMultiplay_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbIP;
        private DevExpress.XtraEditors.SimpleButton btnLan;
        private System.Windows.Forms.ComboBox cbbStyleCard;
        private System.Windows.Forms.TextBox tbCol;
        private System.Windows.Forms.TextBox tbRow;
        private System.Windows.Forms.Button btnCreateandSend;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnRecieveAndCreate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}