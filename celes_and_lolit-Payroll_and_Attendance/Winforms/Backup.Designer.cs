namespace celes_and_lolit_Payroll_and_Attendance.Winforms
{
    partial class Backup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Backup));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlSalaryLoan = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.picRestorePath = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtRestorePath = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.picBackupPath = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtBackupPath = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblStatus = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlSalaryLoan.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRestorePath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackupPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.pnlSalaryLoan;
            // 
            // pnlSalaryLoan
            // 
            this.pnlSalaryLoan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSalaryLoan.BackgroundImage")));
            this.pnlSalaryLoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSalaryLoan.Controls.Add(this.bunifuCards2);
            this.pnlSalaryLoan.Controls.Add(this.bunifuCards1);
            this.pnlSalaryLoan.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlSalaryLoan.GradientBottomRight = System.Drawing.Color.White;
            this.pnlSalaryLoan.GradientTopLeft = System.Drawing.Color.White;
            this.pnlSalaryLoan.GradientTopRight = System.Drawing.Color.White;
            this.pnlSalaryLoan.Location = new System.Drawing.Point(35, 134);
            this.pnlSalaryLoan.Name = "pnlSalaryLoan";
            this.pnlSalaryLoan.Quality = 10;
            this.pnlSalaryLoan.Size = new System.Drawing.Size(1059, 523);
            this.pnlSalaryLoan.TabIndex = 4;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuCards2.Controls.Add(this.bunifuFlatButton1);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuCards2.Controls.Add(this.picRestorePath);
            this.bunifuCards2.Controls.Add(this.pictureBox3);
            this.bunifuCards2.Controls.Add(this.txtRestorePath);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(556, 65);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(446, 286);
            this.bunifuCards2.TabIndex = 36;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(27, 243);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(51, 19);
            this.bunifuCustomLabel2.TabIndex = 34;
            this.bunifuCustomLabel2.Text = "Status:";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 5;
            this.bunifuFlatButton1.ButtonText = "  Restore";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::celes_and_lolit_Payroll_and_Attendance.Properties.Resources.icons8_save_26px;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = false;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = false;
            this.bunifuFlatButton1.IconZoom = 30D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(335, 222);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(80, 40);
            this.bunifuFlatButton1.TabIndex = 33;
            this.bunifuFlatButton1.Text = "  Restore";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(78, 55);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(157, 25);
            this.bunifuCustomLabel3.TabIndex = 10;
            this.bunifuCustomLabel3.Text = "Restore Database";
            // 
            // picRestorePath
            // 
            this.picRestorePath.BackColor = System.Drawing.Color.LightGray;
            this.picRestorePath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRestorePath.Location = new System.Drawing.Point(382, 146);
            this.picRestorePath.Name = "picRestorePath";
            this.picRestorePath.Size = new System.Drawing.Size(32, 33);
            this.picRestorePath.TabIndex = 7;
            this.picRestorePath.TabStop = false;
            this.picRestorePath.Click += new System.EventHandler(this.picRestorePath_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::celes_and_lolit_Payroll_and_Attendance.Properties.Resources.restore;
            this.pictureBox3.Location = new System.Drawing.Point(12, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // txtRestorePath
            // 
            this.txtRestorePath.BackColor = System.Drawing.Color.White;
            this.txtRestorePath.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.txtRestorePath.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.txtRestorePath.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.txtRestorePath.BorderThickness = 2;
            this.txtRestorePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRestorePath.Enabled = false;
            this.txtRestorePath.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtRestorePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRestorePath.isPassword = false;
            this.txtRestorePath.Location = new System.Drawing.Point(31, 145);
            this.txtRestorePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtRestorePath.Name = "txtRestorePath";
            this.txtRestorePath.Size = new System.Drawing.Size(384, 35);
            this.txtRestorePath.TabIndex = 8;
            this.txtRestorePath.Text = "Select .sql File To Restore >";
            this.txtRestorePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(74, 243);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(42, 19);
            this.bunifuCustomLabel4.TabIndex = 35;
            this.bunifuCustomLabel4.Text = "None";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuCards1.Controls.Add(this.btnSave);
            this.bunifuCards1.Controls.Add(this.lblTitle);
            this.bunifuCards1.Controls.Add(this.picBackupPath);
            this.bunifuCards1.Controls.Add(this.pictureBox2);
            this.bunifuCards1.Controls.Add(this.txtBackupPath);
            this.bunifuCards1.Controls.Add(this.lblStatus);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(55, 65);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(446, 286);
            this.bunifuCards1.TabIndex = 7;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(27, 243);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(51, 19);
            this.bunifuCustomLabel1.TabIndex = 34;
            this.bunifuCustomLabel1.Text = "Status:";
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 5;
            this.btnSave.ButtonText = "  Backup";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = global::celes_and_lolit_Payroll_and_Attendance.Properties.Resources.icons8_save_26px;
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = false;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = false;
            this.btnSave.IconZoom = 30D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(335, 222);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(80, 40);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "  Backup";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(78, 55);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(152, 25);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Backup Database";
            // 
            // picBackupPath
            // 
            this.picBackupPath.BackColor = System.Drawing.Color.LightGray;
            this.picBackupPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBackupPath.Location = new System.Drawing.Point(382, 146);
            this.picBackupPath.Name = "picBackupPath";
            this.picBackupPath.Size = new System.Drawing.Size(32, 33);
            this.picBackupPath.TabIndex = 7;
            this.picBackupPath.TabStop = false;
            this.picBackupPath.Click += new System.EventHandler(this.picBackupPath_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::celes_and_lolit_Payroll_and_Attendance.Properties.Resources.backup;
            this.pictureBox2.Location = new System.Drawing.Point(12, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.BackColor = System.Drawing.Color.White;
            this.txtBackupPath.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.txtBackupPath.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.txtBackupPath.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.txtBackupPath.BorderThickness = 2;
            this.txtBackupPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBackupPath.Enabled = false;
            this.txtBackupPath.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBackupPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBackupPath.isPassword = false;
            this.txtBackupPath.Location = new System.Drawing.Point(31, 145);
            this.txtBackupPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.Size = new System.Drawing.Size(384, 35);
            this.txtBackupPath.TabIndex = 8;
            this.txtBackupPath.Text = "Select Path Click The Button >";
            this.txtBackupPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStatus.Location = new System.Drawing.Point(74, 243);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 19);
            this.lblStatus.TabIndex = 35;
            this.lblStatus.Text = "None";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1131, 702);
            this.Controls.Add(this.pnlSalaryLoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Backup";
            this.Text = "Backup";
            this.pnlSalaryLoan.ResumeLayout(false);
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRestorePath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackupPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnlSalaryLoan;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.PictureBox picBackupPath;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtBackupPath;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private Bunifu.Framework.UI.BunifuCustomLabel lblStatus;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.PictureBox picRestorePath;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtRestorePath;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}