namespace celes_and_lolit_Payroll_and_Attendance.Winforms
{
    partial class PhilHealth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhilHealth));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtMinimumRange = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtContribution = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtMaximumRange = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvPhilHealthList = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maximum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.range = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contribution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDeduction = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhilHealthList)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlDeduction.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMinimumRange
            // 
            this.txtMinimumRange.BackColor = System.Drawing.Color.White;
            this.txtMinimumRange.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtMinimumRange.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.txtMinimumRange.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtMinimumRange.BorderThickness = 2;
            this.txtMinimumRange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinimumRange.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMinimumRange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMinimumRange.isPassword = false;
            this.txtMinimumRange.Location = new System.Drawing.Point(48, 144);
            this.txtMinimumRange.Margin = new System.Windows.Forms.Padding(4);
            this.txtMinimumRange.Name = "txtMinimumRange";
            this.txtMinimumRange.Size = new System.Drawing.Size(296, 35);
            this.txtMinimumRange.TabIndex = 0;
            this.txtMinimumRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMinimumRange.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContribution_KeyDown_1);
            this.txtMinimumRange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaximumRange_KeyPress);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.BorderRadius = 5;
            this.btnUpdate.ButtonText = "Update";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdate.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Iconimage")));
            this.btnUpdate.Iconimage_right = null;
            this.btnUpdate.Iconimage_right_Selected = null;
            this.btnUpdate.Iconimage_Selected = null;
            this.btnUpdate.IconMarginLeft = 5;
            this.btnUpdate.IconMarginRight = 0;
            this.btnUpdate.IconRightVisible = true;
            this.btnUpdate.IconRightZoom = 0D;
            this.btnUpdate.IconVisible = false;
            this.btnUpdate.IconZoom = 90D;
            this.btnUpdate.IsTab = false;
            this.btnUpdate.Location = new System.Drawing.Point(200, 372);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdate.selected = false;
            this.btnUpdate.Size = new System.Drawing.Size(144, 53);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Textcolor = System.Drawing.Color.White;
            this.btnUpdate.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 5;
            this.btnSave.ButtonText = "Save";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSave.Iconimage")));
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 5;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = false;
            this.btnSave.IconZoom = 90D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(48, 372);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(144, 53);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(44, 281);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(98, 21);
            this.bunifuCustomLabel5.TabIndex = 14;
            this.bunifuCustomLabel5.Text = "Contribution";
            // 
            // txtContribution
            // 
            this.txtContribution.BackColor = System.Drawing.Color.White;
            this.txtContribution.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtContribution.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.txtContribution.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtContribution.BorderThickness = 2;
            this.txtContribution.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContribution.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtContribution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContribution.isPassword = false;
            this.txtContribution.Location = new System.Drawing.Point(48, 306);
            this.txtContribution.Margin = new System.Windows.Forms.Padding(4);
            this.txtContribution.Name = "txtContribution";
            this.txtContribution.Size = new System.Drawing.Size(296, 35);
            this.txtContribution.TabIndex = 2;
            this.txtContribution.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContribution.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContribution_KeyDown_1);
            this.txtContribution.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaximumRange_KeyPress);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(44, 199);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(128, 21);
            this.bunifuCustomLabel4.TabIndex = 12;
            this.bunifuCustomLabel4.Text = "Maximum Range";
            // 
            // txtMaximumRange
            // 
            this.txtMaximumRange.BackColor = System.Drawing.Color.White;
            this.txtMaximumRange.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtMaximumRange.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.txtMaximumRange.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtMaximumRange.BorderThickness = 2;
            this.txtMaximumRange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaximumRange.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaximumRange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaximumRange.isPassword = false;
            this.txtMaximumRange.Location = new System.Drawing.Point(48, 224);
            this.txtMaximumRange.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaximumRange.Name = "txtMaximumRange";
            this.txtMaximumRange.Size = new System.Drawing.Size(296, 35);
            this.txtMaximumRange.TabIndex = 1;
            this.txtMaximumRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaximumRange.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContribution_KeyDown_1);
            this.txtMaximumRange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaximumRange_KeyPress);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(44, 119);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(126, 21);
            this.bunifuCustomLabel3.TabIndex = 10;
            this.bunifuCustomLabel3.Text = "Minimum Range";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(385, 132);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(650, 10);
            this.bunifuSeparator2.TabIndex = 55;
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(212, 25);
            this.bunifuCustomLabel1.TabIndex = 88;
            this.bunifuCustomLabel1.Text = "PhilHealth Premium List";
            // 
            // dgvPhilHealthList
            // 
            this.dgvPhilHealthList.AllowUserToAddRows = false;
            this.dgvPhilHealthList.AllowUserToDeleteRows = false;
            this.dgvPhilHealthList.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvPhilHealthList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPhilHealthList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhilHealthList.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhilHealthList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhilHealthList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPhilHealthList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhilHealthList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPhilHealthList.ColumnHeadersHeight = 40;
            this.dgvPhilHealthList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.minimum,
            this.maximum,
            this.range,
            this.contribution});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(58)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhilHealthList.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPhilHealthList.DoubleBuffered = true;
            this.dgvPhilHealthList.EnableHeadersVisualStyles = false;
            this.dgvPhilHealthList.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dgvPhilHealthList.HeaderBgColor = System.Drawing.Color.White;
            this.dgvPhilHealthList.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvPhilHealthList.Location = new System.Drawing.Point(385, 99);
            this.dgvPhilHealthList.MultiSelect = false;
            this.dgvPhilHealthList.Name = "dgvPhilHealthList";
            this.dgvPhilHealthList.ReadOnly = true;
            this.dgvPhilHealthList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPhilHealthList.RowHeadersVisible = false;
            this.dgvPhilHealthList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPhilHealthList.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPhilHealthList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhilHealthList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPhilHealthList.RowTemplate.DividerHeight = 1;
            this.dgvPhilHealthList.RowTemplate.Height = 40;
            this.dgvPhilHealthList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhilHealthList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhilHealthList.Size = new System.Drawing.Size(650, 389);
            this.dgvPhilHealthList.TabIndex = 6;
            this.dgvPhilHealthList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhilHealthList_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // minimum
            // 
            this.minimum.DataPropertyName = "minimum_range";
            this.minimum.HeaderText = "min";
            this.minimum.Name = "minimum";
            this.minimum.ReadOnly = true;
            this.minimum.Visible = false;
            // 
            // maximum
            // 
            this.maximum.DataPropertyName = "maximum_range";
            this.maximum.HeaderText = "max";
            this.maximum.Name = "maximum";
            this.maximum.ReadOnly = true;
            this.maximum.Visible = false;
            // 
            // range
            // 
            this.range.DataPropertyName = "roc";
            this.range.HeaderText = "Range of Compensation";
            this.range.Name = "range";
            this.range.ReadOnly = true;
            // 
            // contribution
            // 
            this.contribution.DataPropertyName = "compensation";
            this.contribution.HeaderText = "Compensation";
            this.contribution.Name = "contribution";
            this.contribution.ReadOnly = true;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(385, 80);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(650, 35);
            this.bunifuSeparator1.TabIndex = 11;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.pnlDeduction);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1136, 768);
            this.panel1.TabIndex = 3;
            // 
            // pnlDeduction
            // 
            this.pnlDeduction.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDeduction.BackgroundImage")));
            this.pnlDeduction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDeduction.Controls.Add(this.btnDelete);
            this.pnlDeduction.Controls.Add(this.txtSearch);
            this.pnlDeduction.Controls.Add(this.bunifuCustomLabel2);
            this.pnlDeduction.Controls.Add(this.btnUpdate);
            this.pnlDeduction.Controls.Add(this.btnSave);
            this.pnlDeduction.Controls.Add(this.bunifuCustomLabel5);
            this.pnlDeduction.Controls.Add(this.txtContribution);
            this.pnlDeduction.Controls.Add(this.bunifuCustomLabel4);
            this.pnlDeduction.Controls.Add(this.txtMaximumRange);
            this.pnlDeduction.Controls.Add(this.bunifuCustomLabel3);
            this.pnlDeduction.Controls.Add(this.txtMinimumRange);
            this.pnlDeduction.Controls.Add(this.bunifuSeparator2);
            this.pnlDeduction.Controls.Add(this.bunifuCustomLabel1);
            this.pnlDeduction.Controls.Add(this.dgvPhilHealthList);
            this.pnlDeduction.Controls.Add(this.bunifuSeparator1);
            this.pnlDeduction.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlDeduction.GradientBottomRight = System.Drawing.Color.White;
            this.pnlDeduction.GradientTopLeft = System.Drawing.Color.White;
            this.pnlDeduction.GradientTopRight = System.Drawing.Color.White;
            this.pnlDeduction.Location = new System.Drawing.Point(35, 134);
            this.pnlDeduction.Name = "pnlDeduction";
            this.pnlDeduction.Quality = 10;
            this.pnlDeduction.Size = new System.Drawing.Size(1071, 523);
            this.pnlDeduction.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.ButtonText = "Delete";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDelete.Iconimage")));
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 5;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = false;
            this.btnDelete.IconZoom = 90D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(116, 435);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(138)))), ((int)(((byte)(238)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(144, 53);
            this.btnDelete.TabIndex = 95;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(865, 49);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(170, 25);
            this.txtSearch.TabIndex = 94;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(799, 53);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(60, 21);
            this.bunifuCustomLabel2.TabIndex = 93;
            this.bunifuCustomLabel2.Text = "Search:";
            // 
            // PhilHealth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 768);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhilHealth";
            this.Text = "PhilHealth";
            this.Load += new System.EventHandler(this.PhilHealth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhilHealthList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlDeduction.ResumeLayout(false);
            this.pnlDeduction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox txtMinimumRange;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtContribution;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMaximumRange;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvPhilHealthList;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlDeduction;
        private System.Windows.Forms.TextBox txtSearch;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimum;
        private System.Windows.Forms.DataGridViewTextBoxColumn maximum;
        private System.Windows.Forms.DataGridViewTextBoxColumn range;
        private System.Windows.Forms.DataGridViewTextBoxColumn contribution;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
    }
}