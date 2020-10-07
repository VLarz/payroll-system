namespace celes_and_lolit_Payroll_and_Attendance.Winforms
{
    partial class Employee_Attendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Attendance));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTimeout = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtTimeOut = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTimeIn = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTimein = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panel1.Controls.Add(this.pnlForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 768);
            this.panel1.TabIndex = 1;
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.Controls.Add(this.button1);
            this.pnlForm.Controls.Add(this.label1);
            this.pnlForm.Controls.Add(this.textBox1);
            this.pnlForm.Controls.Add(this.btnTimeout);
            this.pnlForm.Controls.Add(this.txtTimeOut);
            this.pnlForm.Controls.Add(this.txtTimeIn);
            this.pnlForm.Controls.Add(this.pictureBox1);
            this.pnlForm.Controls.Add(this.btnTimein);
            this.pnlForm.Controls.Add(this.bunifuCustomLabel3);
            this.pnlForm.Controls.Add(this.bunifuCustomLabel2);
            this.pnlForm.Location = new System.Drawing.Point(377, 148);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(580, 470);
            this.pnlForm.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 401);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 22;
            // 
            // btnTimeout
            // 
            this.btnTimeout.ActiveBorderThickness = 1;
            this.btnTimeout.ActiveCornerRadius = 5;
            this.btnTimeout.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.btnTimeout.ActiveForecolor = System.Drawing.Color.White;
            this.btnTimeout.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.btnTimeout.BackColor = System.Drawing.Color.White;
            this.btnTimeout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimeout.BackgroundImage")));
            this.btnTimeout.ButtonText = "Time Out";
            this.btnTimeout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimeout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTimeout.IdleBorderThickness = 1;
            this.btnTimeout.IdleCornerRadius = 5;
            this.btnTimeout.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTimeout.IdleForecolor = System.Drawing.Color.White;
            this.btnTimeout.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTimeout.Location = new System.Drawing.Point(428, 320);
            this.btnTimeout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimeout.Name = "btnTimeout";
            this.btnTimeout.Size = new System.Drawing.Size(86, 51);
            this.btnTimeout.TabIndex = 21;
            this.btnTimeout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTimeout.Click += new System.EventHandler(this.btnTimeout_Click);
            // 
            // txtTimeOut
            // 
            this.txtTimeOut.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimeOut.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimeOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimeOut.HintForeColor = System.Drawing.Color.Empty;
            this.txtTimeOut.HintText = "";
            this.txtTimeOut.isPassword = false;
            this.txtTimeOut.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtTimeOut.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.txtTimeOut.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtTimeOut.LineThickness = 2;
            this.txtTimeOut.Location = new System.Drawing.Point(68, 333);
            this.txtTimeOut.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimeOut.Name = "txtTimeOut";
            this.txtTimeOut.Size = new System.Drawing.Size(334, 33);
            this.txtTimeOut.TabIndex = 20;
            this.txtTimeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTimeIn
            // 
            this.txtTimeIn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimeIn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimeIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimeIn.HintForeColor = System.Drawing.Color.Empty;
            this.txtTimeIn.HintText = "";
            this.txtTimeIn.isPassword = false;
            this.txtTimeIn.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtTimeIn.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.txtTimeIn.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtTimeIn.LineThickness = 2;
            this.txtTimeIn.Location = new System.Drawing.Point(68, 236);
            this.txtTimeIn.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimeIn.Name = "txtTimeIn";
            this.txtTimeIn.Size = new System.Drawing.Size(334, 33);
            this.txtTimeIn.TabIndex = 19;
            this.txtTimeIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(221, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnTimein
            // 
            this.btnTimein.ActiveBorderThickness = 1;
            this.btnTimein.ActiveCornerRadius = 5;
            this.btnTimein.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.btnTimein.ActiveForecolor = System.Drawing.Color.White;
            this.btnTimein.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.btnTimein.BackColor = System.Drawing.Color.White;
            this.btnTimein.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimein.BackgroundImage")));
            this.btnTimein.ButtonText = "Time In";
            this.btnTimein.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimein.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimein.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTimein.IdleBorderThickness = 1;
            this.btnTimein.IdleCornerRadius = 5;
            this.btnTimein.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTimein.IdleForecolor = System.Drawing.Color.White;
            this.btnTimein.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTimein.Location = new System.Drawing.Point(428, 223);
            this.btnTimein.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimein.Name = "btnTimein";
            this.btnTimein.Size = new System.Drawing.Size(86, 51);
            this.btnTimein.TabIndex = 17;
            this.btnTimein.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTimein.Click += new System.EventHandler(this.btnTimein_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(64, 308);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(74, 21);
            this.bunifuCustomLabel3.TabIndex = 11;
            this.bunifuCustomLabel3.Text = "Time Out";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(64, 211);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(61, 21);
            this.bunifuCustomLabel2.TabIndex = 7;
            this.bunifuCustomLabel2.Text = "Time In";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 8;
            this.bunifuElipse1.TargetControl = this.pnlForm;
            // 
            // Employee_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee_Attendance";
            this.Text = "Employee_Attendance";
            this.panel1.ResumeLayout(false);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlForm;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTimeOut;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTimeIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTimein;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTimeout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}