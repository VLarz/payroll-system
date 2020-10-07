namespace celes_and_lolit_Payroll_and_Attendance.Winforms
{
    partial class Payslip
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.employee_workBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeeDS = new celes_and_lolit_Payroll_and_Attendance.Winforms.EmployeeDS();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.employee_workBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDS)).BeginInit();
            this.SuspendLayout();
            // 
            // employee_workBindingSource
            // 
            this.employee_workBindingSource.DataMember = "employee_work";
            this.employee_workBindingSource.DataSource = this.EmployeeDS;
            // 
            // EmployeeDS
            // 
            this.EmployeeDS.DataSetName = "EmployeeDS";
            this.EmployeeDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "employee_work";
            reportDataSource1.Value = this.employee_workBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "celes_and_lolit_Payroll_and_Attendance.Winforms.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(850, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Payslip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Payslip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payslip";
            this.Load += new System.EventHandler(this.Payslip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employee_workBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource employee_workBindingSource;
        private EmployeeDS EmployeeDS;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}