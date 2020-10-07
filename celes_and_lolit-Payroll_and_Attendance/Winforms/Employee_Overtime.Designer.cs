namespace celes_and_lolit_Payroll_and_Attendance.Winforms
{
    partial class Employee_Overtime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Overtime));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlEmployee = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.cmbWeek = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.btnUpdateEmployee = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFileEmployee = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvEmployeeList = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel1.SuspendLayout();
            this.pnlEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
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
            this.pnlEmployee.Controls.Add(this.cmbWeek);
            this.pnlEmployee.Controls.Add(this.cmbMonth);
            this.pnlEmployee.Controls.Add(this.cmbYear);
            this.pnlEmployee.Controls.Add(this.btnUpdateEmployee);
            this.pnlEmployee.Controls.Add(this.btnFileEmployee);
            this.pnlEmployee.Controls.Add(this.txtSearch);
            this.pnlEmployee.Controls.Add(this.bunifuCustomLabel2);
            this.pnlEmployee.Controls.Add(this.bunifuSeparator2);
            this.pnlEmployee.Controls.Add(this.bunifuCustomLabel1);
            this.pnlEmployee.Controls.Add(this.dgvEmployeeList);
            this.pnlEmployee.Controls.Add(this.bunifuSeparator1);
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
            this.cmbWeek.Location = new System.Drawing.Point(448, 56);
            this.cmbWeek.Name = "cmbWeek";
            this.cmbWeek.Size = new System.Drawing.Size(194, 29);
            this.cmbWeek.TabIndex = 23;
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
            this.cmbMonth.Location = new System.Drawing.Point(238, 56);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(194, 29);
            this.cmbMonth.TabIndex = 22;
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
            this.cmbYear.Location = new System.Drawing.Point(22, 56);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(194, 29);
            this.cmbYear.TabIndex = 21;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.btnUpdateEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnUpdateEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateEmployee.BorderRadius = 5;
            this.btnUpdateEmployee.ButtonText = "Approve Overtime";
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
            this.btnUpdateEmployee.Location = new System.Drawing.Point(874, 470);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnUpdateEmployee.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.btnUpdateEmployee.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdateEmployee.selected = false;
            this.btnUpdateEmployee.Size = new System.Drawing.Size(161, 33);
            this.btnUpdateEmployee.TabIndex = 10;
            this.btnUpdateEmployee.Text = "Approve Overtime";
            this.btnUpdateEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateEmployee.Textcolor = System.Drawing.Color.White;
            this.btnUpdateEmployee.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnFileEmployee
            // 
            this.btnFileEmployee.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.btnFileEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnFileEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFileEmployee.BorderRadius = 5;
            this.btnFileEmployee.ButtonText = "File Employee Overtime ";
            this.btnFileEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFileEmployee.DisabledColor = System.Drawing.Color.Gray;
            this.btnFileEmployee.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFileEmployee.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnFileEmployee.Iconimage")));
            this.btnFileEmployee.Iconimage_right = null;
            this.btnFileEmployee.Iconimage_right_Selected = null;
            this.btnFileEmployee.Iconimage_Selected = null;
            this.btnFileEmployee.IconMarginLeft = 0;
            this.btnFileEmployee.IconMarginRight = 0;
            this.btnFileEmployee.IconRightVisible = true;
            this.btnFileEmployee.IconRightZoom = 0D;
            this.btnFileEmployee.IconVisible = true;
            this.btnFileEmployee.IconZoom = 60D;
            this.btnFileEmployee.IsTab = false;
            this.btnFileEmployee.Location = new System.Drawing.Point(664, 470);
            this.btnFileEmployee.Name = "btnFileEmployee";
            this.btnFileEmployee.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnFileEmployee.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.btnFileEmployee.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFileEmployee.selected = false;
            this.btnFileEmployee.Size = new System.Drawing.Size(195, 33);
            this.btnFileEmployee.TabIndex = 9;
            this.btnFileEmployee.Text = "File Employee Overtime ";
            this.btnFileEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileEmployee.Textcolor = System.Drawing.Color.White;
            this.btnFileEmployee.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            this.btnFileEmployee.Click += new System.EventHandler(this.btnFileEmployee_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(865, 56);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(170, 25);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(799, 60);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(60, 21);
            this.bunifuCustomLabel2.TabIndex = 5;
            this.bunifuCustomLabel2.Text = "Search:";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(22, 132);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(1013, 10);
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(211, 25);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Employee Overtime List";
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.AllowUserToAddRows = false;
            this.dgvEmployeeList.AllowUserToDeleteRows = false;
            this.dgvEmployeeList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvEmployeeList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployeeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeeList.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployeeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployeeList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEmployeeList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployeeList.ColumnHeadersHeight = 40;
            this.dgvEmployeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.date,
            this.employee_id,
            this.fullName,
            this.overtime,
            this.approval});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(58)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployeeList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmployeeList.DoubleBuffered = true;
            this.dgvEmployeeList.EnableHeadersVisualStyles = false;
            this.dgvEmployeeList.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dgvEmployeeList.HeaderBgColor = System.Drawing.Color.White;
            this.dgvEmployeeList.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvEmployeeList.Location = new System.Drawing.Point(22, 99);
            this.dgvEmployeeList.MultiSelect = false;
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.ReadOnly = true;
            this.dgvEmployeeList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEmployeeList.RowHeadersVisible = false;
            this.dgvEmployeeList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEmployeeList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEmployeeList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmployeeList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEmployeeList.RowTemplate.DividerHeight = 1;
            this.dgvEmployeeList.RowTemplate.Height = 40;
            this.dgvEmployeeList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployeeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeList.Size = new System.Drawing.Size(1013, 356);
            this.dgvEmployeeList.TabIndex = 0;
            this.dgvEmployeeList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeList_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // employee_id
            // 
            this.employee_id.DataPropertyName = "employee_id";
            this.employee_id.HeaderText = "Employee ID";
            this.employee_id.Name = "employee_id";
            this.employee_id.ReadOnly = true;
            this.employee_id.Visible = false;
            // 
            // fullName
            // 
            this.fullName.DataPropertyName = "name";
            this.fullName.HeaderText = "Name";
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            // 
            // overtime
            // 
            this.overtime.DataPropertyName = "overtime";
            this.overtime.HeaderText = "Overtime";
            this.overtime.Name = "overtime";
            this.overtime.ReadOnly = true;
            // 
            // approval
            // 
            this.approval.DataPropertyName = "approval";
            this.approval.HeaderText = "Status";
            this.approval.Name = "approval";
            this.approval.ReadOnly = true;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(22, 80);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1013, 35);
            this.bunifuSeparator1.TabIndex = 1;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // Employee_Overtime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 768);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee_Overtime";
            this.Text = "Employee_Overtime";
            this.Load += new System.EventHandler(this.Employee_Overtime_Load);
            this.panel1.ResumeLayout(false);
            this.pnlEmployee.ResumeLayout(false);
            this.pnlEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TextBox txtSearch;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvEmployeeList;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlEmployee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbWeek;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbYear;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdateEmployee;
        private Bunifu.Framework.UI.BunifuFlatButton btnFileEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn overtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn approval;
    }
}