namespace celes_and_lolit_Payroll_and_Attendance.Winforms
{
    partial class User_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Management));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlEmployee = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnUpdateEmployee = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddEmployee = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvUserList = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userlevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel1.SuspendLayout();
            this.pnlEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
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
            this.pnlEmployee.Controls.Add(this.btnUpdateEmployee);
            this.pnlEmployee.Controls.Add(this.btnAddEmployee);
            this.pnlEmployee.Controls.Add(this.textBox1);
            this.pnlEmployee.Controls.Add(this.bunifuCustomLabel2);
            this.pnlEmployee.Controls.Add(this.bunifuSeparator2);
            this.pnlEmployee.Controls.Add(this.bunifuCustomLabel1);
            this.pnlEmployee.Controls.Add(this.dgvUserList);
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
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.btnUpdateEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnUpdateEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateEmployee.BorderRadius = 5;
            this.btnUpdateEmployee.ButtonText = "Update User";
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
            this.btnUpdateEmployee.Location = new System.Drawing.Point(196, 56);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnUpdateEmployee.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.btnUpdateEmployee.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdateEmployee.selected = false;
            this.btnUpdateEmployee.Size = new System.Drawing.Size(161, 33);
            this.btnUpdateEmployee.TabIndex = 10;
            this.btnUpdateEmployee.Text = "Update User";
            this.btnUpdateEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateEmployee.Textcolor = System.Drawing.Color.White;
            this.btnUpdateEmployee.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddEmployee.BorderRadius = 5;
            this.btnAddEmployee.ButtonText = "Add User";
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
            this.btnAddEmployee.Text = "Add User";
            this.btnAddEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmployee.Textcolor = System.Drawing.Color.White;
            this.btnAddEmployee.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox1.Location = new System.Drawing.Point(865, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 25);
            this.textBox1.TabIndex = 6;
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(84, 25);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "User List";
            // 
            // dgvUserList
            // 
            this.dgvUserList.AllowUserToAddRows = false;
            this.dgvUserList.AllowUserToDeleteRows = false;
            this.dgvUserList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvUserList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserList.BackgroundColor = System.Drawing.Color.White;
            this.dgvUserList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUserList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUserList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUserList.ColumnHeadersHeight = 40;
            this.dgvUserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.contact,
            this.username,
            this.userlevel});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(58)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUserList.DoubleBuffered = true;
            this.dgvUserList.EnableHeadersVisualStyles = false;
            this.dgvUserList.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dgvUserList.HeaderBgColor = System.Drawing.Color.White;
            this.dgvUserList.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvUserList.Location = new System.Drawing.Point(22, 99);
            this.dgvUserList.MultiSelect = false;
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.ReadOnly = true;
            this.dgvUserList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUserList.RowHeadersVisible = false;
            this.dgvUserList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUserList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUserList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvUserList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUserList.RowTemplate.DividerHeight = 1;
            this.dgvUserList.RowTemplate.Height = 40;
            this.dgvUserList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserList.Size = new System.Drawing.Size(1013, 399);
            this.dgvUserList.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // contact
            // 
            this.contact.DataPropertyName = "contact_number";
            this.contact.HeaderText = "Contact Number";
            this.contact.Name = "contact";
            this.contact.ReadOnly = true;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // userlevel
            // 
            this.userlevel.DataPropertyName = "userlevel";
            this.userlevel.HeaderText = "User Level";
            this.userlevel.Name = "userlevel";
            this.userlevel.ReadOnly = true;
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
            // User_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1136, 768);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "User_Management";
            this.Load += new System.EventHandler(this.User_Management_Load);
            this.panel1.ResumeLayout(false);
            this.pnlEmployee.ResumeLayout(false);
            this.pnlEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlEmployee;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdateEmployee;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddEmployee;
        private System.Windows.Forms.TextBox textBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvUserList;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn userlevel;
    }
}