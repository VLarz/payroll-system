namespace celes_and_lolit_Payroll_and_Attendance.Winforms
{
    partial class Manager_Mainform
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager_Mainform));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.btnMinimize = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.btnEmployees = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLoan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlLoan = new System.Windows.Forms.Panel();
            this.btnSSSLoan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPagIBIGLoan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCashAdvance = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCompanyLoan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHoliday = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLeave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.picImageProfile = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.doubleBitmapControl2 = new BunifuAnimatorNS.DoubleBitmapControl();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCards1.SuspendLayout();
            this.pnlLoan.SuspendLayout();
            this.bunifuCards3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImageProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 100;
            this.bunifuElipse1.TargetControl = this;
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.PanelAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.PanelAnimator.DefaultAnimation = animation1;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.btnMinimize.Location = new System.Drawing.Point(1102, -3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(34, 31);
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.Text = "_";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 0;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.bunifuCards1.Controls.Add(this.lblTitle);
            this.bunifuCards1.Controls.Add(this.btnMinimize);
            this.PanelAnimator.SetDecoration(this.bunifuCards1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(231, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 40;
            this.bunifuCards1.Size = new System.Drawing.Size(1136, 68);
            this.bunifuCards1.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.PanelAnimator.SetDecoration(this.lblTitle, BunifuAnimatorNS.DecorationType.None);
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.lblTitle.Location = new System.Drawing.Point(10, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(437, 47);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Dashboard";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlForm
            // 
            this.PanelAnimator.SetDecoration(this.pnlForm, BunifuAnimatorNS.DecorationType.None);
            this.pnlForm.Location = new System.Drawing.Point(231, 66);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1131, 702);
            this.pnlForm.TabIndex = 11;
            // 
            // btnEmployees
            // 
            this.btnEmployees.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnEmployees.BackColor = System.Drawing.Color.White;
            this.btnEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmployees.BorderRadius = 0;
            this.btnEmployees.ButtonText = "  Employees";
            this.btnEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnEmployees, BunifuAnimatorNS.DecorationType.None);
            this.btnEmployees.DisabledColor = System.Drawing.Color.Gray;
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.btnEmployees.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEmployees.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEmployees.Iconimage")));
            this.btnEmployees.Iconimage_right = null;
            this.btnEmployees.Iconimage_right_Selected = null;
            this.btnEmployees.Iconimage_Selected = null;
            this.btnEmployees.IconMarginLeft = 8;
            this.btnEmployees.IconMarginRight = 0;
            this.btnEmployees.IconRightVisible = false;
            this.btnEmployees.IconRightZoom = 0D;
            this.btnEmployees.IconVisible = true;
            this.btnEmployees.IconZoom = 35D;
            this.btnEmployees.IsTab = false;
            this.btnEmployees.Location = new System.Drawing.Point(0, 107);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Normalcolor = System.Drawing.Color.White;
            this.btnEmployees.OnHovercolor = System.Drawing.Color.White;
            this.btnEmployees.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.btnEmployees.selected = false;
            this.btnEmployees.Size = new System.Drawing.Size(225, 48);
            this.btnEmployees.TabIndex = 60;
            this.btnEmployees.Text = "  Employees";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.btnEmployees.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnLoan
            // 
            this.btnLoan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnLoan.BackColor = System.Drawing.Color.White;
            this.btnLoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoan.BorderRadius = 0;
            this.btnLoan.ButtonText = "  Loan";
            this.btnLoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnLoan, BunifuAnimatorNS.DecorationType.None);
            this.btnLoan.DisabledColor = System.Drawing.Color.Gray;
            this.btnLoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.btnLoan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLoan.Iconimage = global::celes_and_lolit_Payroll_and_Attendance.Properties.Resources.pay;
            this.btnLoan.Iconimage_right = global::celes_and_lolit_Payroll_and_Attendance.Properties.Resources.right;
            this.btnLoan.Iconimage_right_Selected = null;
            this.btnLoan.Iconimage_Selected = null;
            this.btnLoan.IconMarginLeft = 8;
            this.btnLoan.IconMarginRight = 0;
            this.btnLoan.IconRightVisible = true;
            this.btnLoan.IconRightZoom = 0D;
            this.btnLoan.IconVisible = true;
            this.btnLoan.IconZoom = 40D;
            this.btnLoan.IsTab = false;
            this.btnLoan.Location = new System.Drawing.Point(0, 155);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Normalcolor = System.Drawing.Color.White;
            this.btnLoan.OnHovercolor = System.Drawing.Color.White;
            this.btnLoan.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.btnLoan.selected = false;
            this.btnLoan.Size = new System.Drawing.Size(225, 48);
            this.btnLoan.TabIndex = 30;
            this.btnLoan.Text = "  Loan";
            this.btnLoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoan.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.btnLoan.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // pnlLoan
            // 
            this.pnlLoan.Controls.Add(this.btnSSSLoan);
            this.pnlLoan.Controls.Add(this.btnPagIBIGLoan);
            this.PanelAnimator.SetDecoration(this.pnlLoan, BunifuAnimatorNS.DecorationType.None);
            this.pnlLoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLoan.Location = new System.Drawing.Point(0, 203);
            this.pnlLoan.Name = "pnlLoan";
            this.pnlLoan.Size = new System.Drawing.Size(225, 0);
            this.pnlLoan.TabIndex = 33;
            // 
            // btnSSSLoan
            // 
            this.btnSSSLoan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnSSSLoan.BackColor = System.Drawing.Color.White;
            this.btnSSSLoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSSSLoan.BorderRadius = 0;
            this.btnSSSLoan.ButtonText = " SSS Loan";
            this.btnSSSLoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnSSSLoan, BunifuAnimatorNS.DecorationType.None);
            this.btnSSSLoan.DisabledColor = System.Drawing.Color.Gray;
            this.btnSSSLoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSSSLoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.btnSSSLoan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSSSLoan.Iconimage = global::celes_and_lolit_Payroll_and_Attendance.Properties.Resources.icons8_unchecked_radio_button_24px_2;
            this.btnSSSLoan.Iconimage_right = null;
            this.btnSSSLoan.Iconimage_right_Selected = null;
            this.btnSSSLoan.Iconimage_Selected = null;
            this.btnSSSLoan.IconMarginLeft = 30;
            this.btnSSSLoan.IconMarginRight = 0;
            this.btnSSSLoan.IconRightVisible = false;
            this.btnSSSLoan.IconRightZoom = 0D;
            this.btnSSSLoan.IconVisible = true;
            this.btnSSSLoan.IconZoom = 30D;
            this.btnSSSLoan.IsTab = false;
            this.btnSSSLoan.Location = new System.Drawing.Point(0, 37);
            this.btnSSSLoan.Name = "btnSSSLoan";
            this.btnSSSLoan.Normalcolor = System.Drawing.Color.White;
            this.btnSSSLoan.OnHovercolor = System.Drawing.Color.White;
            this.btnSSSLoan.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.btnSSSLoan.selected = false;
            this.btnSSSLoan.Size = new System.Drawing.Size(225, 37);
            this.btnSSSLoan.TabIndex = 18;
            this.btnSSSLoan.Text = " SSS Loan";
            this.btnSSSLoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSSSLoan.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.btnSSSLoan.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSSSLoan.Click += new System.EventHandler(this.btnSSSLoan_Click);
            // 
            // btnPagIBIGLoan
            // 
            this.btnPagIBIGLoan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnPagIBIGLoan.BackColor = System.Drawing.Color.White;
            this.btnPagIBIGLoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPagIBIGLoan.BorderRadius = 0;
            this.btnPagIBIGLoan.ButtonText = " Pag-IBIG Loan";
            this.btnPagIBIGLoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnPagIBIGLoan, BunifuAnimatorNS.DecorationType.None);
            this.btnPagIBIGLoan.DisabledColor = System.Drawing.Color.Gray;
            this.btnPagIBIGLoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPagIBIGLoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.btnPagIBIGLoan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPagIBIGLoan.Iconimage = global::celes_and_lolit_Payroll_and_Attendance.Properties.Resources.icons8_unchecked_radio_button_24px_2;
            this.btnPagIBIGLoan.Iconimage_right = null;
            this.btnPagIBIGLoan.Iconimage_right_Selected = null;
            this.btnPagIBIGLoan.Iconimage_Selected = null;
            this.btnPagIBIGLoan.IconMarginLeft = 30;
            this.btnPagIBIGLoan.IconMarginRight = 0;
            this.btnPagIBIGLoan.IconRightVisible = false;
            this.btnPagIBIGLoan.IconRightZoom = 0D;
            this.btnPagIBIGLoan.IconVisible = true;
            this.btnPagIBIGLoan.IconZoom = 30D;
            this.btnPagIBIGLoan.IsTab = false;
            this.btnPagIBIGLoan.Location = new System.Drawing.Point(0, 0);
            this.btnPagIBIGLoan.Name = "btnPagIBIGLoan";
            this.btnPagIBIGLoan.Normalcolor = System.Drawing.Color.White;
            this.btnPagIBIGLoan.OnHovercolor = System.Drawing.Color.White;
            this.btnPagIBIGLoan.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.btnPagIBIGLoan.selected = false;
            this.btnPagIBIGLoan.Size = new System.Drawing.Size(225, 37);
            this.btnPagIBIGLoan.TabIndex = 17;
            this.btnPagIBIGLoan.Text = " Pag-IBIG Loan";
            this.btnPagIBIGLoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagIBIGLoan.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.btnPagIBIGLoan.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPagIBIGLoan.Click += new System.EventHandler(this.btnPagIBIGLoan_Click);
            // 
            // btnCashAdvance
            // 
            this.btnCashAdvance.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnCashAdvance.BackColor = System.Drawing.Color.White;
            this.btnCashAdvance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCashAdvance.BorderRadius = 0;
            this.btnCashAdvance.ButtonText = "  Cash Advance";
            this.btnCashAdvance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnCashAdvance, BunifuAnimatorNS.DecorationType.None);
            this.btnCashAdvance.DisabledColor = System.Drawing.Color.Gray;
            this.btnCashAdvance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCashAdvance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.btnCashAdvance.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCashAdvance.Iconimage = global::celes_and_lolit_Payroll_and_Attendance.Properties.Resources.cash;
            this.btnCashAdvance.Iconimage_right = null;
            this.btnCashAdvance.Iconimage_right_Selected = null;
            this.btnCashAdvance.Iconimage_Selected = null;
            this.btnCashAdvance.IconMarginLeft = 8;
            this.btnCashAdvance.IconMarginRight = 0;
            this.btnCashAdvance.IconRightVisible = false;
            this.btnCashAdvance.IconRightZoom = 0D;
            this.btnCashAdvance.IconVisible = true;
            this.btnCashAdvance.IconZoom = 35D;
            this.btnCashAdvance.IsTab = false;
            this.btnCashAdvance.Location = new System.Drawing.Point(0, 203);
            this.btnCashAdvance.Name = "btnCashAdvance";
            this.btnCashAdvance.Normalcolor = System.Drawing.Color.White;
            this.btnCashAdvance.OnHovercolor = System.Drawing.Color.White;
            this.btnCashAdvance.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.btnCashAdvance.selected = false;
            this.btnCashAdvance.Size = new System.Drawing.Size(225, 48);
            this.btnCashAdvance.TabIndex = 39;
            this.btnCashAdvance.Text = "  Cash Advance";
            this.btnCashAdvance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCashAdvance.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.btnCashAdvance.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCashAdvance.Click += new System.EventHandler(this.btnCashAdvance_Click);
            // 
            // btnCompanyLoan
            // 
            this.btnCompanyLoan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnCompanyLoan.BackColor = System.Drawing.Color.White;
            this.btnCompanyLoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCompanyLoan.BorderRadius = 0;
            this.btnCompanyLoan.ButtonText = "  Company Loan";
            this.btnCompanyLoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnCompanyLoan, BunifuAnimatorNS.DecorationType.None);
            this.btnCompanyLoan.DisabledColor = System.Drawing.Color.Gray;
            this.btnCompanyLoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompanyLoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.btnCompanyLoan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCompanyLoan.Iconimage = global::celes_and_lolit_Payroll_and_Attendance.Properties.Resources.bank;
            this.btnCompanyLoan.Iconimage_right = null;
            this.btnCompanyLoan.Iconimage_right_Selected = null;
            this.btnCompanyLoan.Iconimage_Selected = null;
            this.btnCompanyLoan.IconMarginLeft = 8;
            this.btnCompanyLoan.IconMarginRight = 0;
            this.btnCompanyLoan.IconRightVisible = false;
            this.btnCompanyLoan.IconRightZoom = 0D;
            this.btnCompanyLoan.IconVisible = true;
            this.btnCompanyLoan.IconZoom = 35D;
            this.btnCompanyLoan.IsTab = false;
            this.btnCompanyLoan.Location = new System.Drawing.Point(0, 251);
            this.btnCompanyLoan.Name = "btnCompanyLoan";
            this.btnCompanyLoan.Normalcolor = System.Drawing.Color.White;
            this.btnCompanyLoan.OnHovercolor = System.Drawing.Color.White;
            this.btnCompanyLoan.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.btnCompanyLoan.selected = false;
            this.btnCompanyLoan.Size = new System.Drawing.Size(225, 48);
            this.btnCompanyLoan.TabIndex = 40;
            this.btnCompanyLoan.Text = "  Company Loan";
            this.btnCompanyLoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompanyLoan.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.btnCompanyLoan.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCompanyLoan.Click += new System.EventHandler(this.btnCompanyLoan_Click);
            // 
            // btnHoliday
            // 
            this.btnHoliday.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnHoliday.BackColor = System.Drawing.Color.White;
            this.btnHoliday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHoliday.BorderRadius = 0;
            this.btnHoliday.ButtonText = "  Holiday";
            this.btnHoliday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnHoliday, BunifuAnimatorNS.DecorationType.None);
            this.btnHoliday.DisabledColor = System.Drawing.Color.Gray;
            this.btnHoliday.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoliday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.btnHoliday.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHoliday.Iconimage = global::celes_and_lolit_Payroll_and_Attendance.Properties.Resources.document;
            this.btnHoliday.Iconimage_right = null;
            this.btnHoliday.Iconimage_right_Selected = null;
            this.btnHoliday.Iconimage_Selected = null;
            this.btnHoliday.IconMarginLeft = 8;
            this.btnHoliday.IconMarginRight = 0;
            this.btnHoliday.IconRightVisible = false;
            this.btnHoliday.IconRightZoom = 0D;
            this.btnHoliday.IconVisible = true;
            this.btnHoliday.IconZoom = 35D;
            this.btnHoliday.IsTab = false;
            this.btnHoliday.Location = new System.Drawing.Point(0, 299);
            this.btnHoliday.Name = "btnHoliday";
            this.btnHoliday.Normalcolor = System.Drawing.Color.White;
            this.btnHoliday.OnHovercolor = System.Drawing.Color.White;
            this.btnHoliday.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.btnHoliday.selected = false;
            this.btnHoliday.Size = new System.Drawing.Size(225, 48);
            this.btnHoliday.TabIndex = 41;
            this.btnHoliday.Text = "  Holiday";
            this.btnHoliday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoliday.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.btnHoliday.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            this.btnHoliday.Click += new System.EventHandler(this.btnHoliday_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnLeave.BackColor = System.Drawing.Color.White;
            this.btnLeave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeave.BorderRadius = 0;
            this.btnLeave.ButtonText = "  Leave";
            this.btnLeave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnLeave, BunifuAnimatorNS.DecorationType.None);
            this.btnLeave.DisabledColor = System.Drawing.Color.Gray;
            this.btnLeave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLeave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.btnLeave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLeave.Iconimage = global::celes_and_lolit_Payroll_and_Attendance.Properties.Resources.analytics;
            this.btnLeave.Iconimage_right = null;
            this.btnLeave.Iconimage_right_Selected = null;
            this.btnLeave.Iconimage_Selected = null;
            this.btnLeave.IconMarginLeft = 8;
            this.btnLeave.IconMarginRight = 0;
            this.btnLeave.IconRightVisible = false;
            this.btnLeave.IconRightZoom = 0D;
            this.btnLeave.IconVisible = true;
            this.btnLeave.IconZoom = 35D;
            this.btnLeave.IsTab = false;
            this.btnLeave.Location = new System.Drawing.Point(0, 347);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Normalcolor = System.Drawing.Color.White;
            this.btnLeave.OnHovercolor = System.Drawing.Color.White;
            this.btnLeave.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.btnLeave.selected = false;
            this.btnLeave.Size = new System.Drawing.Size(225, 48);
            this.btnLeave.TabIndex = 42;
            this.btnLeave.Text = "  Leave";
            this.btnLeave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLeave.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.btnLeave.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "  Reports";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::celes_and_lolit_Payroll_and_Attendance.Properties.Resources.file1;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 8;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = false;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 35D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 395);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(225, 48);
            this.bunifuFlatButton1.TabIndex = 59;
            this.bunifuFlatButton1.Text = "  Reports";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.White;
            this.bunifuCards3.BorderRadius = 0;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.White;
            this.bunifuCards3.Controls.Add(this.panel10);
            this.bunifuCards3.Controls.Add(this.panel12);
            this.bunifuCards3.Controls.Add(this.doubleBitmapControl2);
            this.PanelAnimator.SetDecoration(this.bunifuCards3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCards3.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(230, 768);
            this.bunifuCards3.TabIndex = 13;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel11);
            this.PanelAnimator.SetDecoration(this.panel10, BunifuAnimatorNS.DecorationType.None);
            this.panel10.Location = new System.Drawing.Point(5, 244);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(228, 520);
            this.panel10.TabIndex = 8;
            // 
            // panel11
            // 
            this.panel11.AllowDrop = true;
            this.panel11.Controls.Add(this.bunifuFlatButton1);
            this.panel11.Controls.Add(this.label2);
            this.panel11.Controls.Add(this.pictureBox2);
            this.panel11.Controls.Add(this.panel1);
            this.panel11.Controls.Add(this.btnLeave);
            this.panel11.Controls.Add(this.btnHoliday);
            this.panel11.Controls.Add(this.btnCompanyLoan);
            this.panel11.Controls.Add(this.btnCashAdvance);
            this.panel11.Controls.Add(this.pnlLoan);
            this.panel11.Controls.Add(this.btnLoan);
            this.panel11.Controls.Add(this.btnEmployees);
            this.panel11.Controls.Add(this.panel7);
            this.panel11.Controls.Add(this.bunifuFlatButton6);
            this.panel11.Controls.Add(this.panel8);
            this.PanelAnimator.SetDecoration(this.panel11, BunifuAnimatorNS.DecorationType.None);
            this.panel11.Location = new System.Drawing.Point(6, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(225, 540);
            this.panel11.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.PanelAnimator.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(162, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 52;
            this.label2.Text = "Log Out";
            // 
            // pictureBox2
            // 
            this.pictureBox2.AccessibleDescription = "";
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = global::celes_and_lolit_Payroll_and_Attendance.Properties.Resources.logout;
            this.pictureBox2.Location = new System.Drawing.Point(176, 474);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuFlatButton4);
            this.panel1.Controls.Add(this.bunifuFlatButton5);
            this.PanelAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(8, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 0);
            this.panel1.TabIndex = 33;
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "       - SSS Loan";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = null;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 8;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = false;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 35D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(0, 37);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(222, 37);
            this.bunifuFlatButton4.TabIndex = 18;
            this.bunifuFlatButton4.Text = "       - SSS Loan";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "       - Pag-IBIG Loan";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = null;
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 8;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = false;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 30D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(0, 0);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(222, 37);
            this.bunifuFlatButton5.TabIndex = 17;
            this.bunifuFlatButton5.Text = "       - Pag-IBIG Loan";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.bunifuCustomLabel5);
            this.PanelAnimator.SetDecoration(this.panel7, BunifuAnimatorNS.DecorationType.None);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 75);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(225, 32);
            this.panel7.TabIndex = 12;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.PanelAnimator.SetDecoration(this.bunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(5, 9);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(52, 13);
            this.bunifuCustomLabel5.TabIndex = 9;
            this.bunifuCustomLabel5.Text = "Manage";
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "  Dashboard";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = global::celes_and_lolit_Payroll_and_Attendance.Properties.Resources.home;
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 8;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = false;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 35D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(0, 27);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(225, 48);
            this.bunifuFlatButton6.TabIndex = 49;
            this.bunifuFlatButton6.Text = "  Dashboard";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.bunifuCustomLabel4);
            this.PanelAnimator.SetDecoration(this.panel8, BunifuAnimatorNS.DecorationType.None);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(225, 27);
            this.panel8.TabIndex = 48;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.PanelAnimator.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(5, 9);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(51, 13);
            this.bunifuCustomLabel4.TabIndex = 9;
            this.bunifuCustomLabel4.Text = "Reports";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.pictureBox3);
            this.panel12.Controls.Add(this.pictureBox4);
            this.panel12.Controls.Add(this.picImageProfile);
            this.panel12.Controls.Add(this.bunifuCustomLabel6);
            this.PanelAnimator.SetDecoration(this.panel12, BunifuAnimatorNS.DecorationType.None);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(230, 228);
            this.panel12.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(9, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(213, 81);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.PanelAnimator.SetDecoration(this.pictureBox4, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox4.Location = new System.Drawing.Point(0, -5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(236, 10);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // picImageProfile
            // 
            this.picImageProfile.BackColor = System.Drawing.Color.Gray;
            this.PanelAnimator.SetDecoration(this.picImageProfile, BunifuAnimatorNS.DecorationType.None);
            this.picImageProfile.Image = ((System.Drawing.Image)(resources.GetObject("picImageProfile.Image")));
            this.picImageProfile.ImageActive = null;
            this.picImageProfile.Location = new System.Drawing.Point(81, 132);
            this.picImageProfile.Name = "picImageProfile";
            this.picImageProfile.Size = new System.Drawing.Size(71, 71);
            this.picImageProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImageProfile.TabIndex = 3;
            this.picImageProfile.TabStop = false;
            this.picImageProfile.Zoom = 10;
            // 
            // bunifuCustomLabel6
            // 
            this.PanelAnimator.SetDecoration(this.bunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(3, 213);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(227, 13);
            this.bunifuCustomLabel6.TabIndex = 5;
            this.bunifuCustomLabel6.Text = "Aloy Rost";
            this.bunifuCustomLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // doubleBitmapControl2
            // 
            this.PanelAnimator.SetDecoration(this.doubleBitmapControl2, BunifuAnimatorNS.DecorationType.None);
            this.doubleBitmapControl2.Location = new System.Drawing.Point(77, 47);
            this.doubleBitmapControl2.Name = "doubleBitmapControl2";
            this.doubleBitmapControl2.Size = new System.Drawing.Size(75, 23);
            this.doubleBitmapControl2.TabIndex = 4;
            this.doubleBitmapControl2.Text = "doubleBitmapControl1";
            this.doubleBitmapControl2.Visible = false;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // Manager_Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.bunifuCards3);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.bunifuCards1);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manager_Mainform";
            this.Text = "Manager_Mainform";
            this.bunifuCards1.ResumeLayout(false);
            this.pnlLoan.ResumeLayout(false);
            this.bunifuCards3.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImageProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BunifuAnimatorNS.BunifuTransition PanelAnimator;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuCustomLabel btnMinimize;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
        public System.Windows.Forms.Panel pnlForm;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnLeave;
        private Bunifu.Framework.UI.BunifuFlatButton btnHoliday;
        private Bunifu.Framework.UI.BunifuFlatButton btnCompanyLoan;
        private Bunifu.Framework.UI.BunifuFlatButton btnCashAdvance;
        private System.Windows.Forms.Panel pnlLoan;
        private Bunifu.Framework.UI.BunifuFlatButton btnSSSLoan;
        private Bunifu.Framework.UI.BunifuFlatButton btnPagIBIGLoan;
        private Bunifu.Framework.UI.BunifuFlatButton btnLoan;
        private Bunifu.Framework.UI.BunifuFlatButton btnEmployees;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private System.Windows.Forms.Panel panel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        private System.Windows.Forms.Panel panel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Bunifu.Framework.UI.BunifuImageButton picImageProfile;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private BunifuAnimatorNS.DoubleBitmapControl doubleBitmapControl2;
    }
}