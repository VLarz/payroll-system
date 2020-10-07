namespace celes_and_lolit_Payroll_and_Attendance.Winforms
{
    partial class Attendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendance));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlEmployee = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCurrentDay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvAttendanceList = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnUpdateEmployee = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.dtpDateReceived = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeIn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOut1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.pnlEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceList)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
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
            this.pnlEmployee.Controls.Add(this.panel2);
            this.pnlEmployee.Controls.Add(this.btnUpdateEmployee);
            this.pnlEmployee.Controls.Add(this.pictureBox1);
            this.pnlEmployee.Controls.Add(this.btnCurrentDay);
            this.pnlEmployee.Controls.Add(this.bunifuSeparator1);
            this.pnlEmployee.Controls.Add(this.bunifuCustomLabel3);
            this.pnlEmployee.Controls.Add(this.dtpTo);
            this.pnlEmployee.Controls.Add(this.bunifuCustomLabel6);
            this.pnlEmployee.Controls.Add(this.dtpFrom);
            this.pnlEmployee.Controls.Add(this.bunifuSeparator2);
            this.pnlEmployee.Controls.Add(this.bunifuCustomLabel1);
            this.pnlEmployee.Controls.Add(this.dgvAttendanceList);
            this.pnlEmployee.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlEmployee.GradientBottomRight = System.Drawing.Color.White;
            this.pnlEmployee.GradientTopLeft = System.Drawing.Color.White;
            this.pnlEmployee.GradientTopRight = System.Drawing.Color.White;
            this.pnlEmployee.Location = new System.Drawing.Point(35, 134);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Quality = 10;
            this.pnlEmployee.Size = new System.Drawing.Size(1059, 523);
            this.pnlEmployee.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::celes_and_lolit_Payroll_and_Attendance.Properties.Resources.icons8_today_32px;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(872, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // btnCurrentDay
            // 
            this.btnCurrentDay.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.btnCurrentDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnCurrentDay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCurrentDay.BorderRadius = 5;
            this.btnCurrentDay.ButtonText = "           Current Day";
            this.btnCurrentDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCurrentDay.DisabledColor = System.Drawing.Color.Gray;
            this.btnCurrentDay.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCurrentDay.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCurrentDay.Iconimage")));
            this.btnCurrentDay.Iconimage_right = null;
            this.btnCurrentDay.Iconimage_right_Selected = null;
            this.btnCurrentDay.Iconimage_Selected = null;
            this.btnCurrentDay.IconMarginLeft = 0;
            this.btnCurrentDay.IconMarginRight = 0;
            this.btnCurrentDay.IconRightVisible = true;
            this.btnCurrentDay.IconRightZoom = 0D;
            this.btnCurrentDay.IconVisible = false;
            this.btnCurrentDay.IconZoom = 90D;
            this.btnCurrentDay.IsTab = false;
            this.btnCurrentDay.Location = new System.Drawing.Point(868, 55);
            this.btnCurrentDay.Name = "btnCurrentDay";
            this.btnCurrentDay.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnCurrentDay.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.btnCurrentDay.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCurrentDay.selected = false;
            this.btnCurrentDay.Size = new System.Drawing.Size(148, 40);
            this.btnCurrentDay.TabIndex = 43;
            this.btnCurrentDay.Text = "           Current Day";
            this.btnCurrentDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCurrentDay.Textcolor = System.Drawing.Color.White;
            this.btnCurrentDay.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrentDay.Click += new System.EventHandler(this.btnCurrentDay_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(26, 94);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(990, 13);
            this.bunifuSeparator1.TabIndex = 1;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(303, 66);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(28, 21);
            this.bunifuCustomLabel3.TabIndex = 18;
            this.bunifuCustomLabel3.Text = "To:";
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "yyyy/MM/dd";
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(337, 58);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(207, 29);
            this.dtpTo.TabIndex = 17;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(24, 66);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(50, 21);
            this.bunifuCustomLabel6.TabIndex = 16;
            this.bunifuCustomLabel6.Text = "From:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "yyyy/MM/dd";
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(80, 58);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(207, 29);
            this.dtpFrom.TabIndex = 15;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(26, 132);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(990, 10);
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(108, 25);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Attendance";
            // 
            // dgvAttendanceList
            // 
            this.dgvAttendanceList.AllowUserToAddRows = false;
            this.dgvAttendanceList.AllowUserToDeleteRows = false;
            this.dgvAttendanceList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAttendanceList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAttendanceList.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttendanceList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAttendanceList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAttendanceList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttendanceList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAttendanceList.ColumnHeadersHeight = 40;
            this.dgvAttendanceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id1,
            this.date,
            this.employee_id,
            this.name,
            this.timeIn1,
            this.timeOut1,
            this.status});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(58)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAttendanceList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAttendanceList.DoubleBuffered = true;
            this.dgvAttendanceList.EnableHeadersVisualStyles = false;
            this.dgvAttendanceList.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dgvAttendanceList.HeaderBgColor = System.Drawing.Color.White;
            this.dgvAttendanceList.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvAttendanceList.Location = new System.Drawing.Point(26, 99);
            this.dgvAttendanceList.MultiSelect = false;
            this.dgvAttendanceList.Name = "dgvAttendanceList";
            this.dgvAttendanceList.ReadOnly = true;
            this.dgvAttendanceList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAttendanceList.RowHeadersVisible = false;
            this.dgvAttendanceList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAttendanceList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAttendanceList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvAttendanceList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAttendanceList.RowTemplate.DividerHeight = 1;
            this.dgvAttendanceList.RowTemplate.Height = 40;
            this.dgvAttendanceList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAttendanceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendanceList.Size = new System.Drawing.Size(1013, 355);
            this.dgvAttendanceList.TabIndex = 0;
            this.dgvAttendanceList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttendanceList_CellClick_1);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.btnUpdateEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnUpdateEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateEmployee.BorderRadius = 5;
            this.btnUpdateEmployee.ButtonText = "Update Time Out";
            this.btnUpdateEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateEmployee.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdateEmployee.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdateEmployee.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUpdateEmployee.Iconimage")));
            this.btnUpdateEmployee.Iconimage_right = null;
            this.btnUpdateEmployee.Iconimage_right_Selected = null;
            this.btnUpdateEmployee.Iconimage_Selected = null;
            this.btnUpdateEmployee.IconMarginLeft = 0;
            this.btnUpdateEmployee.IconMarginRight = 0;
            this.btnUpdateEmployee.IconRightVisible = true;
            this.btnUpdateEmployee.IconRightZoom = 0D;
            this.btnUpdateEmployee.IconVisible = true;
            this.btnUpdateEmployee.IconZoom = 60D;
            this.btnUpdateEmployee.IsTab = false;
            this.btnUpdateEmployee.Location = new System.Drawing.Point(878, 460);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnUpdateEmployee.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.btnUpdateEmployee.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdateEmployee.selected = false;
            this.btnUpdateEmployee.Size = new System.Drawing.Size(161, 33);
            this.btnUpdateEmployee.TabIndex = 45;
            this.btnUpdateEmployee.Text = "Update Time Out";
            this.btnUpdateEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateEmployee.Textcolor = System.Drawing.Color.White;
            this.btnUpdateEmployee.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel2.Controls.Add(this.pnlBackground);
            this.panel2.Location = new System.Drawing.Point(337, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 292);
            this.panel2.TabIndex = 46;
            this.panel2.Visible = false;
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.White;
            this.pnlBackground.Controls.Add(this.btnUpdate);
            this.pnlBackground.Controls.Add(this.txtName);
            this.pnlBackground.Controls.Add(this.bunifuCustomLabel4);
            this.pnlBackground.Controls.Add(this.bunifuCustomLabel2);
            this.pnlBackground.Controls.Add(this.dtpDateReceived);
            this.pnlBackground.Controls.Add(this.btnSave);
            this.pnlBackground.Controls.Add(this.picExit);
            this.pnlBackground.Controls.Add(this.bunifuSeparator3);
            this.pnlBackground.Controls.Add(this.bunifuCustomLabel7);
            this.pnlBackground.Location = new System.Drawing.Point(11, 11);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(337, 269);
            this.pnlBackground.TabIndex = 2;
            // 
            // dtpDateReceived
            // 
            this.dtpDateReceived.CustomFormat = "";
            this.dtpDateReceived.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpDateReceived.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDateReceived.Location = new System.Drawing.Point(20, 170);
            this.dtpDateReceived.Name = "dtpDateReceived";
            this.dtpDateReceived.ShowUpDown = true;
            this.dtpDateReceived.Size = new System.Drawing.Size(296, 27);
            this.dtpDateReceived.TabIndex = 71;
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 2;
            this.btnSave.ButtonText = "File";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = global::celes_and_lolit_Payroll_and_Attendance.Properties.Resources.icons8_save_26px;
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 30D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(310, 317);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(80, 35);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "File";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.White;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(310, 13);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(15, 15);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picExit.TabIndex = 10;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(10, 45);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(315, 10);
            this.bunifuSeparator3.TabIndex = 9;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(4, 13);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(156, 25);
            this.bunifuCustomLabel7.TabIndex = 2;
            this.bunifuCustomLabel7.Text = "Update Time Out";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(17, 147);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(70, 20);
            this.bunifuCustomLabel2.TabIndex = 72;
            this.bunifuCustomLabel2.Text = "Time Out";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(16, 73);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(119, 20);
            this.bunifuCustomLabel4.TabIndex = 73;
            this.bunifuCustomLabel4.Text = "Employee Name";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.txtName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtName.BorderThickness = 2;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.isPassword = false;
            this.txtName.Location = new System.Drawing.Point(20, 97);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(295, 33);
            this.txtName.TabIndex = 74;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.BorderRadius = 2;
            this.btnUpdate.ButtonText = "     Update";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdate.Iconimage = global::celes_and_lolit_Payroll_and_Attendance.Properties.Resources.icons8_save_26px;
            this.btnUpdate.Iconimage_right = null;
            this.btnUpdate.Iconimage_right_Selected = null;
            this.btnUpdate.Iconimage_Selected = null;
            this.btnUpdate.IconMarginLeft = 0;
            this.btnUpdate.IconMarginRight = 0;
            this.btnUpdate.IconRightVisible = true;
            this.btnUpdate.IconRightZoom = 0D;
            this.btnUpdate.IconVisible = false;
            this.btnUpdate.IconZoom = 30D;
            this.btnUpdate.IsTab = false;
            this.btnUpdate.Location = new System.Drawing.Point(221, 216);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdate.selected = false;
            this.btnUpdate.Size = new System.Drawing.Size(95, 35);
            this.btnUpdate.TabIndex = 75;
            this.btnUpdate.Text = "     Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Textcolor = System.Drawing.Color.White;
            this.btnUpdate.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // id1
            // 
            this.id1.DataPropertyName = "id";
            this.id1.HeaderText = "ID";
            this.id1.Name = "id1";
            this.id1.ReadOnly = true;
            this.id1.Visible = false;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 160;
            // 
            // employee_id
            // 
            this.employee_id.DataPropertyName = "employee_id";
            this.employee_id.HeaderText = "Employee ID";
            this.employee_id.Name = "employee_id";
            this.employee_id.ReadOnly = true;
            this.employee_id.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 300;
            // 
            // timeIn1
            // 
            this.timeIn1.DataPropertyName = "time_in";
            this.timeIn1.HeaderText = "Time In";
            this.timeIn1.Name = "timeIn1";
            this.timeIn1.ReadOnly = true;
            this.timeIn1.Width = 180;
            // 
            // timeOut1
            // 
            this.timeOut1.DataPropertyName = "time_out";
            this.timeOut1.HeaderText = "Time Out";
            this.timeOut1.Name = "timeOut1";
            this.timeOut1.ReadOnly = true;
            this.timeOut1.Width = 180;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 170;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.panel2;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1136, 768);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Attendance";
            this.Text = "Attendance";
            this.panel1.ResumeLayout(false);
            this.pnlEmployee.ResumeLayout(false);
            this.pnlEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlEmployee;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvAttendanceList;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private Bunifu.Framework.UI.BunifuFlatButton btnCurrentDay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdateEmployee;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.DateTimePicker dtpDateReceived;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private System.Windows.Forms.PictureBox picExit;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtName;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn id1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeIn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOut1;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}