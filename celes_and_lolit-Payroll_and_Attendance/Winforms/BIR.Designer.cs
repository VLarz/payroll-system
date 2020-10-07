namespace celes_and_lolit_Payroll_and_Attendance.Winforms
{
    partial class BIR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BIR));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtRate = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtMaximumRange = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtMinimumRange = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvBIRList = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maximum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.range = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pnlDeduction = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPercentage = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBIRList)).BeginInit();
            this.pnlDeduction.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(44, 95);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(126, 21);
            this.bunifuCustomLabel3.TabIndex = 10;
            this.bunifuCustomLabel3.Text = "Minimum Range";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(865, 49);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(170, 25);
            this.txtSearch.TabIndex = 92;
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
            this.bunifuCustomLabel2.TabIndex = 91;
            this.bunifuCustomLabel2.Text = "Search:";
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
            this.btnUpdate.IconMarginLeft = 0;
            this.btnUpdate.IconMarginRight = 0;
            this.btnUpdate.IconRightVisible = true;
            this.btnUpdate.IconRightZoom = 0D;
            this.btnUpdate.IconVisible = false;
            this.btnUpdate.IconZoom = 90D;
            this.btnUpdate.IsTab = false;
            this.btnUpdate.Location = new System.Drawing.Point(203, 372);
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
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = false;
            this.btnSave.IconZoom = 90D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(51, 372);
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
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(44, 227);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(66, 21);
            this.bunifuCustomLabel5.TabIndex = 14;
            this.bunifuCustomLabel5.Text = "Tax Rate";
            // 
            // txtRate
            // 
            this.txtRate.BackColor = System.Drawing.Color.White;
            this.txtRate.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtRate.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.txtRate.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtRate.BorderThickness = 2;
            this.txtRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRate.isPassword = false;
            this.txtRate.Location = new System.Drawing.Point(48, 252);
            this.txtRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(296, 35);
            this.txtRate.TabIndex = 2;
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRate_KeyPress);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(44, 162);
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
            this.txtMaximumRange.Location = new System.Drawing.Point(48, 187);
            this.txtMaximumRange.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaximumRange.Name = "txtMaximumRange";
            this.txtMaximumRange.Size = new System.Drawing.Size(296, 35);
            this.txtMaximumRange.TabIndex = 1;
            this.txtMaximumRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaximumRange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRate_KeyPress);
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
            this.txtMinimumRange.Location = new System.Drawing.Point(48, 120);
            this.txtMinimumRange.Margin = new System.Windows.Forms.Padding(4);
            this.txtMinimumRange.Name = "txtMinimumRange";
            this.txtMinimumRange.Size = new System.Drawing.Size(296, 35);
            this.txtMinimumRange.TabIndex = 0;
            this.txtMinimumRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMinimumRange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRate_KeyPress);
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(135, 25);
            this.bunifuCustomLabel1.TabIndex = 88;
            this.bunifuCustomLabel1.Text = "BIR Tax Weekly";
            // 
            // dgvBIRList
            // 
            this.dgvBIRList.AllowUserToAddRows = false;
            this.dgvBIRList.AllowUserToDeleteRows = false;
            this.dgvBIRList.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvBIRList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBIRList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBIRList.BackgroundColor = System.Drawing.Color.White;
            this.dgvBIRList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBIRList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBIRList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBIRList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBIRList.ColumnHeadersHeight = 40;
            this.dgvBIRList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.minimum,
            this.maximum,
            this.range,
            this.taxRate,
            this.taxPercentage});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(58)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBIRList.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBIRList.DoubleBuffered = true;
            this.dgvBIRList.EnableHeadersVisualStyles = false;
            this.dgvBIRList.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dgvBIRList.HeaderBgColor = System.Drawing.Color.White;
            this.dgvBIRList.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvBIRList.Location = new System.Drawing.Point(385, 99);
            this.dgvBIRList.MultiSelect = false;
            this.dgvBIRList.Name = "dgvBIRList";
            this.dgvBIRList.ReadOnly = true;
            this.dgvBIRList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBIRList.RowHeadersVisible = false;
            this.dgvBIRList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBIRList.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBIRList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvBIRList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBIRList.RowTemplate.DividerHeight = 1;
            this.dgvBIRList.RowTemplate.Height = 40;
            this.dgvBIRList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBIRList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBIRList.Size = new System.Drawing.Size(650, 389);
            this.dgvBIRList.TabIndex = 6;
            this.dgvBIRList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBIRList_CellClick);
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
            // taxRate
            // 
            this.taxRate.DataPropertyName = "tax_rate";
            this.taxRate.HeaderText = "Tax Rate";
            this.taxRate.Name = "taxRate";
            this.taxRate.ReadOnly = true;
            // 
            // taxPercentage
            // 
            this.taxPercentage.DataPropertyName = "tax_percentage";
            this.taxPercentage.HeaderText = "Tax Rate Percentage";
            this.taxPercentage.Name = "taxPercentage";
            this.taxPercentage.ReadOnly = true;
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
            // pnlDeduction
            // 
            this.pnlDeduction.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDeduction.BackgroundImage")));
            this.pnlDeduction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDeduction.Controls.Add(this.btnDelete);
            this.pnlDeduction.Controls.Add(this.bunifuCustomLabel6);
            this.pnlDeduction.Controls.Add(this.txtPercentage);
            this.pnlDeduction.Controls.Add(this.txtSearch);
            this.pnlDeduction.Controls.Add(this.bunifuCustomLabel2);
            this.pnlDeduction.Controls.Add(this.btnUpdate);
            this.pnlDeduction.Controls.Add(this.btnSave);
            this.pnlDeduction.Controls.Add(this.bunifuCustomLabel5);
            this.pnlDeduction.Controls.Add(this.txtRate);
            this.pnlDeduction.Controls.Add(this.bunifuCustomLabel4);
            this.pnlDeduction.Controls.Add(this.txtMaximumRange);
            this.pnlDeduction.Controls.Add(this.bunifuCustomLabel3);
            this.pnlDeduction.Controls.Add(this.txtMinimumRange);
            this.pnlDeduction.Controls.Add(this.bunifuSeparator2);
            this.pnlDeduction.Controls.Add(this.bunifuCustomLabel1);
            this.pnlDeduction.Controls.Add(this.dgvBIRList);
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
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(44, 298);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(111, 21);
            this.bunifuCustomLabel6.TabIndex = 94;
            this.bunifuCustomLabel6.Text = "Tax Percentage";
            // 
            // txtPercentage
            // 
            this.txtPercentage.BackColor = System.Drawing.Color.White;
            this.txtPercentage.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtPercentage.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.txtPercentage.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtPercentage.BorderThickness = 2;
            this.txtPercentage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPercentage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPercentage.isPassword = false;
            this.txtPercentage.Location = new System.Drawing.Point(48, 323);
            this.txtPercentage.Margin = new System.Windows.Forms.Padding(4);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(296, 35);
            this.txtPercentage.TabIndex = 93;
            this.txtPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPercentage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPercentage_KeyPress);
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
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.btnDelete.Location = new System.Drawing.Point(129, 435);
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
            // BIR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1136, 768);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BIR";
            this.Text = "BIR";
            this.Load += new System.EventHandler(this.BIR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBIRList)).EndInit();
            this.pnlDeduction.ResumeLayout(false);
            this.pnlDeduction.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.TextBox txtSearch;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtRate;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMaximumRange;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMinimumRange;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvBIRList;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlDeduction;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimum;
        private System.Windows.Forms.DataGridViewTextBoxColumn maximum;
        private System.Windows.Forms.DataGridViewTextBoxColumn range;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxPercentage;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPercentage;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
    }
}