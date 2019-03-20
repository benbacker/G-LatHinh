namespace TestLatHinh
{
    partial class SinglePlay
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
            this.lbTimeCooldown = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.btnHelp = new DevExpress.XtraEditors.SimpleButton();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.lbScore = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lbLv = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTimeCooldown);
            this.panel1.Controls.Add(this.lb3);
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.lbScore);
            this.panel1.Controls.Add(this.lb2);
            this.panel1.Controls.Add(this.lbLv);
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Location = new System.Drawing.Point(533, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 334);
            this.panel1.TabIndex = 1;
            // 
            // lbTimeCooldown
            // 
            this.lbTimeCooldown.AutoSize = true;
            this.lbTimeCooldown.Location = new System.Drawing.Point(93, 92);
            this.lbTimeCooldown.Name = "lbTimeCooldown";
            this.lbTimeCooldown.Size = new System.Drawing.Size(13, 13);
            this.lbTimeCooldown.TabIndex = 5;
            this.lbTimeCooldown.Text = "0";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(27, 92);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(30, 13);
            this.lb3.TabIndex = 4;
            this.lb3.Text = "Time";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(32, 160);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 22);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "Help";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(32, 131);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Location = new System.Drawing.Point(93, 62);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(13, 13);
            this.lbScore.TabIndex = 1;
            this.lbScore.Text = "0";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(27, 62);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(35, 13);
            this.lb2.TabIndex = 1;
            this.lb2.Text = "Score";
            // 
            // lbLv
            // 
            this.lbLv.AutoSize = true;
            this.lbLv.Location = new System.Drawing.Point(93, 27);
            this.lbLv.Name = "lbLv";
            this.lbLv.Size = new System.Drawing.Size(13, 13);
            this.lbLv.TabIndex = 1;
            this.lbLv.Text = "0";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(29, 27);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(33, 13);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Level";
            // 
            // SinglePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(686, 337);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "SinglePlay";
            this.Text = "Chơi đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SinglePlay_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lbLv;
        private System.Windows.Forms.Label lb1;
        private DevExpress.XtraEditors.SimpleButton btnStart;
        private DevExpress.XtraEditors.SimpleButton btnHelp;
        private System.Windows.Forms.Label lbTimeCooldown;
        private System.Windows.Forms.Label lb3;
    }
}