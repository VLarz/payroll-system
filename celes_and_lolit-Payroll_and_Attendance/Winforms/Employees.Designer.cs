namespace celes_and_lolit_Payroll_and_Attendance.Winforms
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlEmployee = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnArchive = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdateEmployee = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddEmployee = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvEmployeeList = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateHired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.TabIndex = 1;
            // 
            // pnlEmployee
            // 
            this.pnlEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlEmployee.BackgroundImage")));
            this.pnlEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEmployee.Controls.Add(this.btnArchive);
            this.pnlEmployee.Controls.Add(this.btnUpdateEmployee);
            this.pnlEmployee.Controls.Add(this.btnAddEmployee);
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
            this.pnlEmployee.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEmployee_Paint);
            // 
            // btnArchive
            // 
            this.btnArchive.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.btnArchive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnArchive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArchive.BorderRadius = 5;
            this.btnArchive.ButtonText = "Archive Employee";
            this.btnArchive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArchive.DisabledColor = System.Drawing.Color.Gray;
            this.btnArchive.Iconcolor = System.Drawing.Color.Transparent;
            this.btnArchive.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnArchive.Iconimage")));
            this.btnArchive.Iconimage_right = null;
            this.btnArchive.Iconimage_right_Selected = null;
            this.btnArchive.Iconimage_Selected = null;
            this.btnArchive.IconMarginLeft = 0;
            this.btnArchive.IconMarginRight = 0;
            this.btnArchive.IconRightVisible = true;
            this.btnArchive.IconRightZoom = 0D;
            this.btnArchive.IconVisible = true;
            this.btnArchive.IconZoom = 60D;
            this.btnArchive.IsTab = false;
            this.btnArchive.Location = new System.Drawing.Point(356, 56);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnArchive.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.btnArchive.OnHoverTextColor = System.Drawing.Color.White;
            this.btnArchive.selected = false;
            this.btnArchive.Size = new System.Drawing.Size(161, 33);
            this.btnArchive.TabIndex = 11;
            this.btnArchive.Text = "Archive Employee";
            this.btnArchive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArchive.Textcolor = System.Drawing.Color.White;
            this.btnArchive.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.btnUpdateEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnUpdateEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateEmployee.BorderRadius = 5;
            this.btnUpdateEmployee.ButtonText = "Update Employee";
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
            this.btnUpdateEmployee.Location = new System.Drawing.Point(189, 56);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnUpdateEmployee.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.btnUpdateEmployee.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdateEmployee.selected = false;
            this.btnUpdateEmployee.Size = new System.Drawing.Size(161, 33);
            this.btnUpdateEmployee.TabIndex = 10;
            this.btnUpdateEmployee.Text = "Update Employee";
            this.btnUpdateEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateEmployee.Textcolor = System.Drawing.Color.White;
            this.btnUpdateEmployee.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddEmployee.BorderRadius = 5;
            this.btnAddEmployee.ButtonText = "Add Employee";
            this.btnAddEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEmployee.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddEmployee.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddEmployee.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddEmployee.Iconimage")));
            this.btnAddEmployee.Iconimage_right = null;
            this.btnAddEmployee.Iconimage_right_Selected = null;
            this.btnAddEmployee.Iconimage_Selected = null;
            this.btnAddEmployee.IconMarginLeft = 0;
            this.btnAddEmployee.IconMarginRight = 0;
            this.btnAddEmployee.IconRightVisible = true;
            this.btnAddEmployee.IconRightZoom = 0D;
            this.btnAddEmployee.IconVisible = true;
            this.btnAddEmployee.IconZoom = 60D;
            this.btnAddEmployee.IsTab = false;
            this.btnAddEmployee.Location = new System.Drawing.Point(22, 56);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddEmployee.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.btnAddEmployee.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddEmployee.selected = false;
            this.btnAddEmployee.Size = new System.Drawing.Size(161, 33);
            this.btnAddEmployee.TabIndex = 9;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmployee.Textcolor = System.Drawing.Color.White;
            this.btnAddEmployee.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click_1);
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
            this.bunifuSeparator2.Location = new System.Drawing.Point(22, 138);
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(127, 25);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Employee List";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.AllowUserToAddRows = false;
            this.dgvEmployeeList.AllowUserToDeleteRows = false;
            this.dgvEmployeeList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvEmployeeList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            this.fullName,
            this.address1,
            this.birthDate,
            this.dateHired,
            this.position,
            this.salary,
            this.contactNumber});
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
            this.dgvEmployeeList.Size = new System.Drawing.Size(1013, 399);
            this.dgvEmployeeList.TabIndex = 0;
            this.dgvEmployeeList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeList_CellClick);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(22, 88);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1013, 13);
            this.bunifuSeparator1.TabIndex = 1;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // fullName
            // 
            this.fullName.DataPropertyName = "name";
            this.fullName.HeaderText = "Name";
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            this.fullName.Width = 245;
            // 
            // address1
            // 
            this.address1.DataPropertyName = "address";
            this.address1.HeaderText = "Address";
            this.address1.Name = "address1";
            this.address1.ReadOnly = true;
            this.address1.Width = 169;
            // 
            // birthDate
            // 
            this.birthDate.DataPropertyName = "birthdate";
            this.birthDate.HeaderText = "Date of Birth";
            this.birthDate.Name = "birthDate";
            this.birthDate.ReadOnly = true;
            this.birthDate.Width = 150;
            // 
            // dateHired
            // 
            this.dateHired.DataPropertyName = "date_hired";
            this.dateHired.HeaderText = "Date Hired";
            this.dateHired.Name = "dateHired";
            this.dateHired.ReadOnly = true;
            this.dateHired.Width = 150;
            // 
            // position
            // 
            this.position.DataPropertyName = "description";
            this.position.HeaderText = "Position";
            this.position.Name = "position";
            this.position.ReadOnly = true;
            this.position.Width = 150;
            // 
            // salary
            // 
            this.salary.DataPropertyName = "rate";
            this.salary.HeaderText = "Salary rate per hour";
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            // 
            // contactNumber
            // 
            this.contactNumber.DataPropertyName = "contact_number";
            this.contactNumber.HeaderText = "Contact Number";
            this.contactNumber.Name = "contactNumber";
            this.contactNumber.ReadOnly = true;
            this.contactNumber.Width = 150;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1136, 768);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employees";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            this.pnlEmployee.ResumeLayout(false);
            this.pnlEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlEmployee;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvEmployeeList;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.TextBox txtSearch;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddEmployee;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdateEmployee;
        private Bunifu.Framework.UI.BunifuFlatButton btnArchive;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn address1;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateHired;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumber;
    }
}