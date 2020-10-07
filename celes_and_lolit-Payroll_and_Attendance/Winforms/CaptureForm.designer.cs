namespace celes_and_lolit_Payroll_and_Attendance
{
    partial class CaptureForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptureForm));
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.StatusLine = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.StatusText = new System.Windows.Forms.TextBox();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.Prompt = new System.Windows.Forms.TextBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.PrompLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.White;
            this.pnlBackground.Controls.Add(this.StatusLine);
            this.pnlBackground.Controls.Add(this.bunifuCustomLabel3);
            this.pnlBackground.Controls.Add(this.StatusText);
            this.pnlBackground.Controls.Add(this.Picture);
            this.pnlBackground.Controls.Add(this.Prompt);
            this.pnlBackground.Controls.Add(this.picExit);
            this.pnlBackground.Controls.Add(this.bunifuSeparator2);
            this.pnlBackground.Controls.Add(this.PrompLabel);
            this.pnlBackground.Controls.Add(this.bunifuCustomLabel1);
            this.pnlBackground.Location = new System.Drawing.Point(13, 13);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(644, 418);
            this.pnlBackground.TabIndex = 4;
            // 
            // StatusLine
            // 
            this.StatusLine.BackColor = System.Drawing.Color.Transparent;
            this.StatusLine.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.StatusLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.StatusLine.Location = new System.Drawing.Point(19, 352);
            this.StatusLine.Name = "StatusLine";
            this.StatusLine.Size = new System.Drawing.Size(604, 39);
            this.StatusLine.TabIndex = 14;
            this.StatusLine.Text = "Tries";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(277, 131);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(50, 19);
            this.bunifuCustomLabel3.TabIndex = 13;
            this.bunifuCustomLabel3.Text = "Status:";
            // 
            // StatusText
            // 
            this.StatusText.AllowDrop = true;
            this.StatusText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.StatusText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StatusText.Location = new System.Drawing.Point(281, 153);
            this.StatusText.Multiline = true;
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(342, 196);
            this.StatusText.TabIndex = 12;
            // 
            // Picture
            // 
            this.Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Picture.Location = new System.Drawing.Point(23, 61);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(248, 288);
            this.Picture.TabIndex = 11;
            this.Picture.TabStop = false;
            // 
            // Prompt
            // 
            this.Prompt.AllowDrop = true;
            this.Prompt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Prompt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Prompt.Location = new System.Drawing.Point(281, 83);
            this.Prompt.Name = "Prompt";
            this.Prompt.Size = new System.Drawing.Size(342, 25);
            this.Prompt.TabIndex = 4;
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.White;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(620, 11);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(15, 15);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picExit.TabIndex = 10;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(9, 45);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(625, 10);
            this.bunifuSeparator2.TabIndex = 9;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // PrompLabel
            // 
            this.PrompLabel.AutoSize = true;
            this.PrompLabel.BackColor = System.Drawing.Color.Transparent;
            this.PrompLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PrompLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.PrompLabel.Location = new System.Drawing.Point(277, 61);
            this.PrompLabel.Name = "PrompLabel";
            this.PrompLabel.Size = new System.Drawing.Size(58, 19);
            this.PrompLabel.TabIndex = 8;
            this.PrompLabel.Text = "Prompt:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(10, 11);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(213, 25);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Fingerprint Registration";
            // 
            // CaptureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 444);
            this.ControlBox = false;
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CaptureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capture Enrollment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CaptureForm_FormClosed);
            this.Load += new System.EventHandler(this.CaptureForm_Load);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private Bunifu.Framework.UI.BunifuCustomLabel StatusLine;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.TextBox StatusText;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.TextBox Prompt;
        private System.Windows.Forms.PictureBox picExit;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuCustomLabel PrompLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}