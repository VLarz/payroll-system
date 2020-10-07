namespace celes_and_lolit_Payroll_and_Attendance.Winforms
{
    partial class Payroll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payroll));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlEmployee = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbWeek = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.btnPayslip = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCurrentWeek = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.dgvPayrollList = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basicPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regHoliday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dodRegHoli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specHoli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dodSpecHoli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.philhealth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagIBIG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deductions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashAdvance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyLoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagibigloan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagibigcalamity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sssloan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssscalamity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.pnlEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayrollList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.pnlEmployee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1136, 768);
            this.panel1.TabIndex = 2;
            // 
            // pnlEmployee
            // 
            this.pnlEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlEmployee.BackgroundImage")));
            this.pnlEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEmployee.Controls.Add(this.pictureBox2);
            this.pnlEmployee.Controls.Add(this.pictureBox1);
            this.pnlEmployee.Controls.Add(this.cmbWeek);
            this.pnlEmployee.Controls.Add(this.cmbMonth);
            this.pnlEmployee.Controls.Add(this.cmbYear);
            this.pnlEmployee.Controls.Add(this.btnPayslip);
            this.pnlEmployee.Controls.Add(this.btnCurrentWeek);
            this.pnlEmployee.Controls.Add(this.bunifuSeparator2);
            this.pnlEmployee.Controls.Add(this.bunifuCustomLabel1);
            this.pnlEmployee.Controls.Add(this.bunifuSeparator1);
            this.pnlEmployee.Controls.Add(this.dgvPayrollList);
            this.pnlEmployee.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlEmployee.GradientBottomRight = System.Drawing.Color.White;
            this.pnlEmployee.GradientTopLeft = System.Drawing.Color.White;
            this.pnlEmployee.GradientTopRight = System.Drawing.Color.White;
            this.pnlEmployee.Location = new System.Drawing.Point(35, 134);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Quality = 10;
            this.pnlEmployee.Size = new System.Drawing.Size(1059, 523);
            this.pnlEmployee.TabIndex = 3;
            this.pnlEmployee.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEmployee_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::celes_and_lolit_Payroll_and_Attendance.Properties.Resources.icons8_purchase_order_48px;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(924, 473);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.btnPayslip_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::celes_and_lolit_Payroll_and_Attendance.Properties.Resources.icons8_today_32px;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(890, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cmbWeek
            // 
            this.cmbWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.cmbWeek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWeek.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbWeek.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbWeek.FormattingEnabled = true;
            this.cmbWeek.Items.AddRange(new object[] {
            "Select Week"});
            this.cmbWeek.Location = new System.Drawing.Point(455, 55);
            this.cmbWeek.Name = "cmbWeek";
            this.cmbWeek.Size = new System.Drawing.Size(194, 29);
            this.cmbWeek.TabIndex = 20;
            this.cmbWeek.SelectedIndexChanged += new System.EventHandler(this.cmbWeek_SelectedIndexChanged);
            // 
            // cmbMonth
            // 
            this.cmbMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.cmbMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbMonth.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "Select Month",
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonth.Location = new System.Drawing.Point(238, 55);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(194, 29);
            this.cmbMonth.TabIndex = 19;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // cmbYear
            // 
            this.cmbYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.cmbYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbYear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "Select Year"});
            this.cmbYear.Location = new System.Drawing.Point(22, 55);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(194, 29);
            this.cmbYear.TabIndex = 18;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // btnPayslip
            // 
            this.btnPayslip.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.btnPayslip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnPayslip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPayslip.BorderRadius = 5;
            this.btnPayslip.ButtonText = "           Payslip";
            this.btnPayslip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayslip.DisabledColor = System.Drawing.Color.Gray;
            this.btnPayslip.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnPayslip.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPayslip.Iconimage = global::celes_and_lolit_Payroll_and_Attendance.Properties.Resources.icons8_purchase_order_48px;
            this.btnPayslip.Iconimage_right = null;
            this.btnPayslip.Iconimage_right_Selected = null;
            this.btnPayslip.Iconimage_Selected = null;
            this.btnPayslip.IconMarginLeft = 0;
            this.btnPayslip.IconMarginRight = 0;
            this.btnPayslip.IconRightVisible = false;
            this.btnPayslip.IconRightZoom = 0D;
            this.btnPayslip.IconVisible = false;
            this.btnPayslip.IconZoom = 70D;
            this.btnPayslip.IsTab = false;
            this.btnPayslip.Location = new System.Drawing.Point(921, 463);
            this.btnPayslip.Name = "btnPayslip";
            this.btnPayslip.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnPayslip.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.btnPayslip.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPayslip.selected = false;
            this.btnPayslip.Size = new System.Drawing.Size(114, 49);
            this.btnPayslip.TabIndex = 9;
            this.btnPayslip.Text = "           Payslip";
            this.btnPayslip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayslip.Textcolor = System.Drawing.Color.White;
            this.btnPayslip.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayslip.Click += new System.EventHandler(this.btnPayslip_Click_1);
            // 
            // btnCurrentWeek
            // 
            this.btnCurrentWeek.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.btnCurrentWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnCurrentWeek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCurrentWeek.BorderRadius = 5;
            this.btnCurrentWeek.ButtonText = "           Current Week";
            this.btnCurrentWeek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCurrentWeek.DisabledColor = System.Drawing.Color.Gray;
            this.btnCurrentWeek.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCurrentWeek.Iconimage = global::celes_and_lolit_Payroll_and_Attendance.Properties.Resources.icons8_today_32px;
            this.btnCurrentWeek.Iconimage_right = null;
            this.btnCurrentWeek.Iconimage_right_Selected = null;
            this.btnCurrentWeek.Iconimage_Selected = null;
            this.btnCurrentWeek.IconMarginLeft = 0;
            this.btnCurrentWeek.IconMarginRight = 0;
            this.btnCurrentWeek.IconRightVisible = true;
            this.btnCurrentWeek.IconRightZoom = 0D;
            this.btnCurrentWeek.IconVisible = false;
            this.btnCurrentWeek.IconZoom = 70D;
            this.btnCurrentWeek.IsTab = false;
            this.btnCurrentWeek.Location = new System.Drawing.Point(887, 44);
            this.btnCurrentWeek.Name = "btnCurrentWeek";
            this.btnCurrentWeek.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnCurrentWeek.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.btnCurrentWeek.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCurrentWeek.selected = false;
            this.btnCurrentWeek.Size = new System.Drawing.Size(148, 40);
            this.btnCurrentWeek.TabIndex = 8;
            this.btnCurrentWeek.Text = "           Current Week";
            this.btnCurrentWeek.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCurrentWeek.Textcolor = System.Drawing.Color.White;
            this.btnCurrentWeek.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrentWeek.Click += new System.EventHandler(this.btnCurrentWeek_Click_1);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(22, 139);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(1013, 2);
            this.bunifuSeparator2.TabIndex = 2;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(14, 12);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(68, 25);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Payroll";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(22, 94);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1013, 2);
            this.bunifuSeparator1.TabIndex = 1;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // dgvPayrollList
            // 
            this.dgvPayrollList.AllowUserToAddRows = false;
            this.dgvPayrollList.AllowUserToDeleteRows = false;
            this.dgvPayrollList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPayrollList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayrollList.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayrollList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayrollList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPayrollList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayrollList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayrollList.ColumnHeadersHeight = 40;
            this.dgvPayrollList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.basicPay,
            this.regPay,
            this.overtime,
            this.dod,
            this.regHoliday,
            this.dodRegHoli,
            this.specHoli,
            this.dodSpecHoli,
            this.grossPay,
            this.sss,
            this.philhealth,
            this.pagIBIG,
            this.deductions,
            this.cashAdvance,
            this.companyLoan,
            this.pagibigloan,
            this.pagibigcalamity,
            this.sssloan,
            this.ssscalamity});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(58)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayrollList.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPayrollList.DoubleBuffered = true;
            this.dgvPayrollList.EnableHeadersVisualStyles = false;
            this.dgvPayrollList.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dgvPayrollList.HeaderBgColor = System.Drawing.Color.White;
            this.dgvPayrollList.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvPayrollList.Location = new System.Drawing.Point(22, 99);
            this.dgvPayrollList.MultiSelect = false;
            this.dgvPayrollList.Name = "dgvPayrollList";
            this.dgvPayrollList.ReadOnly = true;
            this.dgvPayrollList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPayrollList.RowHeadersVisible = false;
            this.dgvPayrollList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPayrollList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPayrollList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvPayrollList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPayrollList.RowTemplate.DividerHeight = 1;
            this.dgvPayrollList.RowTemplate.Height = 40;
            this.dgvPayrollList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayrollList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayrollList.Size = new System.Drawing.Size(1013, 348);
            this.dgvPayrollList.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "employee_id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "full_name";
            this.name.HeaderText = "Employee Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 120;
            // 
            // basicPay
            // 
            this.basicPay.DataPropertyName = "basic_pay";
            this.basicPay.HeaderText = "Basic Pay";
            this.basicPay.Name = "basicPay";
            this.basicPay.ReadOnly = true;
            this.basicPay.Width = 85;
            // 
            // regPay
            // 
            this.regPay.DataPropertyName = "regular_pay";
            this.regPay.HeaderText = "Regular Pay";
            this.regPay.Name = "regPay";
            this.regPay.ReadOnly = true;
            // 
            // overtime
            // 
            this.overtime.DataPropertyName = "overtime";
            this.overtime.HeaderText = "Overtime";
            this.overtime.Name = "overtime";
            this.overtime.ReadOnly = true;
            this.overtime.Width = 85;
            // 
            // dod
            // 
            this.dod.DataPropertyName = "dayoff_on_duty";
            this.dod.HeaderText = "Dayoff on Duty";
            this.dod.Name = "dod";
            this.dod.ReadOnly = true;
            // 
            // regHoliday
            // 
            this.regHoliday.DataPropertyName = "regular_holiday";
            this.regHoliday.HeaderText = "Regular Holiday";
            this.regHoliday.Name = "regHoliday";
            this.regHoliday.ReadOnly = true;
            // 
            // dodRegHoli
            // 
            this.dodRegHoli.DataPropertyName = "dod_regular_holiday";
            this.dodRegHoli.HeaderText = "DOD Regulay Holiday";
            this.dodRegHoli.Name = "dodRegHoli";
            this.dodRegHoli.ReadOnly = true;
            // 
            // specHoli
            // 
            this.specHoli.DataPropertyName = "special_holiday";
            this.specHoli.HeaderText = "Special Holiday";
            this.specHoli.Name = "specHoli";
            this.specHoli.ReadOnly = true;
            // 
            // dodSpecHoli
            // 
            this.dodSpecHoli.DataPropertyName = "dod_special_holiday";
            this.dodSpecHoli.HeaderText = "DOD Special Holiday";
            this.dodSpecHoli.Name = "dodSpecHoli";
            this.dodSpecHoli.ReadOnly = true;
            // 
            // grossPay
            // 
            this.grossPay.DataPropertyName = "gross_pay";
            this.grossPay.HeaderText = "Gross Pay";
            this.grossPay.Name = "grossPay";
            this.grossPay.ReadOnly = true;
            this.grossPay.Width = 84;
            // 
            // sss
            // 
            this.sss.DataPropertyName = "sss_contribution";
            this.sss.HeaderText = "SSS Premium";
            this.sss.Name = "sss";
            this.sss.ReadOnly = true;
            this.sss.Visible = false;
            // 
            // philhealth
            // 
            this.philhealth.DataPropertyName = "philhealth_contribution";
            this.philhealth.HeaderText = "PhilHealth Premium";
            this.philhealth.Name = "philhealth";
            this.philhealth.ReadOnly = true;
            this.philhealth.Visible = false;
            // 
            // pagIBIG
            // 
            this.pagIBIG.DataPropertyName = "pagibig_contribution";
            this.pagIBIG.HeaderText = "Pag-IBIG Premium";
            this.pagIBIG.Name = "pagIBIG";
            this.pagIBIG.ReadOnly = true;
            this.pagIBIG.Visible = false;
            // 
            // deductions
            // 
            this.deductions.DataPropertyName = "deductions";
            dataGridViewCellStyle3.Format = "N2";
            this.deductions.DefaultCellStyle = dataGridViewCellStyle3;
            this.deductions.HeaderText = "Deductions";
            this.deductions.Name = "deductions";
            this.deductions.ReadOnly = true;
            // 
            // cashAdvance
            // 
            this.cashAdvance.DataPropertyName = "cash_advance";
            this.cashAdvance.HeaderText = "Cash Advance";
            this.cashAdvance.Name = "cashAdvance";
            this.cashAdvance.ReadOnly = true;
            this.cashAdvance.Width = 84;
            // 
            // companyLoan
            // 
            this.companyLoan.DataPropertyName = "company_loan";
            this.companyLoan.HeaderText = "Company Loan";
            this.companyLoan.Name = "companyLoan";
            this.companyLoan.ReadOnly = true;
            // 
            // pagibigloan
            // 
            this.pagibigloan.DataPropertyName = "pagibig_loan";
            this.pagibigloan.HeaderText = "Pag-IBIG Loan";
            this.pagibigloan.Name = "pagibigloan";
            this.pagibigloan.ReadOnly = true;
            this.pagibigloan.Width = 85;
            // 
            // pagibigcalamity
            // 
            this.pagibigcalamity.DataPropertyName = "pagibig_calamity";
            this.pagibigcalamity.HeaderText = "Pag-IBIG Calamity";
            this.pagibigcalamity.Name = "pagibigcalamity";
            this.pagibigcalamity.ReadOnly = true;
            this.pagibigcalamity.Width = 84;
            // 
            // sssloan
            // 
            this.sssloan.DataPropertyName = "sss_loan";
            this.sssloan.HeaderText = "SSS Loan";
            this.sssloan.Name = "sssloan";
            this.sssloan.ReadOnly = true;
            this.sssloan.Width = 85;
            // 
            // ssscalamity
            // 
            this.ssscalamity.DataPropertyName = "sss_calamity";
            this.ssscalamity.HeaderText = "SSS Calamity";
            this.ssscalamity.Name = "ssscalamity";
            this.ssscalamity.ReadOnly = true;
            this.ssscalamity.Width = 84;
            // 
            // Payroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 768);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payroll";
            this.Text = "Payroll";
            this.Load += new System.EventHandler(this.Payroll_Load);
            this.panel1.ResumeLayout(false);
            this.pnlEmployee.ResumeLayout(false);
            this.pnlEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayrollList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlEmployee;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvPayrollList;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuFlatButton btnPayslip;
        private Bunifu.Framework.UI.BunifuFlatButton btnCurrentWeek;
        private System.Windows.Forms.ComboBox cmbWeek;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn basicPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn regPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn overtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dod;
        private System.Windows.Forms.DataGridViewTextBoxColumn regHoliday;
        private System.Windows.Forms.DataGridViewTextBoxColumn dodRegHoli;
        private System.Windows.Forms.DataGridViewTextBoxColumn specHoli;
        private System.Windows.Forms.DataGridViewTextBoxColumn dodSpecHoli;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn sss;
        private System.Windows.Forms.DataGridViewTextBoxColumn philhealth;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagIBIG;
        private System.Windows.Forms.DataGridViewTextBoxColumn deductions;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashAdvance;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyLoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagibigloan;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagibigcalamity;
        private System.Windows.Forms.DataGridViewTextBoxColumn sssloan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssscalamity;
    }
}