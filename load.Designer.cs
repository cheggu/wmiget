namespace Hardware
{
    partial class frm_splash
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
            this.progress = new System.Windows.Forms.ProgressBar();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbldone = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progress
            // 
            this.progress.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.progress.Location = new System.Drawing.Point(13, 262);
            this.progress.Margin = new System.Windows.Forms.Padding(4);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(646, 16);
            this.progress.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.ForeColor = System.Drawing.Color.Black;
            this.lbl1.Location = new System.Drawing.Point(13, 9);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(143, 17);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "cpu info loaded";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.ForeColor = System.Drawing.Color.Black;
            this.lbl2.Location = new System.Drawing.Point(13, 26);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(170, 17);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "memory info loaded";
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.ForeColor = System.Drawing.Color.Black;
            this.lbl3.Location = new System.Drawing.Point(13, 43);
            this.lbl3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(143, 17);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "hdd info loaded";
            this.lbl3.Click += new System.EventHandler(this.lbl3_Click);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.ForeColor = System.Drawing.Color.Black;
            this.lbl4.Location = new System.Drawing.Point(13, 60);
            this.lbl4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(143, 17);
            this.lbl4.TabIndex = 4;
            this.lbl4.Text = "ssd info loaded";
            this.lbl4.Click += new System.EventHandler(this.lbl4_Click);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.ForeColor = System.Drawing.Color.Black;
            this.lbl5.Location = new System.Drawing.Point(13, 77);
            this.lbl5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(143, 17);
            this.lbl5.TabIndex = 5;
            this.lbl5.Text = "gpu info loaded";
            this.lbl5.Click += new System.EventHandler(this.lbl5_Click);
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.ForeColor = System.Drawing.Color.Black;
            this.lbl6.Location = new System.Drawing.Point(13, 94);
            this.lbl6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(215, 17);
            this.lbl6.TabIndex = 6;
            this.lbl6.Text = "motherboard info loaded";
            this.lbl6.Click += new System.EventHandler(this.lbl6_Click);
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.ForeColor = System.Drawing.Color.Black;
            this.lbl8.Location = new System.Drawing.Point(13, 128);
            this.lbl8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(179, 17);
            this.lbl8.TabIndex = 7;
            this.lbl8.Text = "monitor info loaded";
            this.lbl8.Click += new System.EventHandler(this.lbl8_Click);
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.ForeColor = System.Drawing.Color.Black;
            this.lbl7.Location = new System.Drawing.Point(13, 111);
            this.lbl7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(251, 17);
            this.lbl7.TabIndex = 8;
            this.lbl7.Text = "network adapter info loaded";
            this.lbl7.Click += new System.EventHandler(this.lbl7_Click);
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.ForeColor = System.Drawing.Color.Black;
            this.lbl9.Location = new System.Drawing.Point(13, 145);
            this.lbl9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(152, 17);
            this.lbl9.TabIndex = 9;
            this.lbl9.Text = "bios info loaded";
            this.lbl9.Click += new System.EventHandler(this.lbl9_Click);
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.ForeColor = System.Drawing.Color.Black;
            this.lbl10.Location = new System.Drawing.Point(13, 162);
            this.lbl10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(134, 17);
            this.lbl10.TabIndex = 10;
            this.lbl10.Text = "os info loaded";
            this.lbl10.Click += new System.EventHandler(this.lbl10_Click);
            // 
            // lbldone
            // 
            this.lbldone.AutoSize = true;
            this.lbldone.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold);
            this.lbldone.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbldone.Location = new System.Drawing.Point(13, 224);
            this.lbldone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldone.Name = "lbldone";
            this.lbldone.Size = new System.Drawing.Size(70, 23);
            this.lbldone.TabIndex = 11;
            this.lbldone.Text = "done!";
            this.lbldone.Click += new System.EventHandler(this.lbldone_Click);
            // 
            // timer
            // 
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(480, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "developed by cheggu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(498, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "github.com/cheggu";
            // 
            // frm_splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(672, 291);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbldone);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.progress);
            this.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_splash";
            this.Text = "Loading...";
            this.Load += new System.EventHandler(this.frm_splash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbldone;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}