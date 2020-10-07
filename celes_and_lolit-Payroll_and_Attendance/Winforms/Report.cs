using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Reporting.WinForms;

namespace celes_and_lolit_Payroll_and_Attendance.Winforms
{
    public partial class Report : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = celes_and_lolit-payroll");
        public string from = "";
        public string to = "";
        public Report()
        {
            InitializeComponent();
            from = Reports.from;
            to = Reports.to;
        }

        private void Report_Load(object sender, EventArgs e)
        {

            EmployeeDS employeeDS = new EmployeeDS();
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT report.id, CONCAT(employee.lastname, ', ', employee.firstname, ' ', employee.middlename) AS Name, SUM(report.weekly_basicpay) AS weekly_basicpay, SUM(report.weekly_overtime) AS weekly_overtime, SUM(report.weekly_grosspay) AS weekly_grosspay, SUM(report.weekly_sss) AS weekly_sss, SUM(report.weekly_philhealth) AS weekly_philhealth, SUM(report.weekly_pagibig) AS weekly_pagibig, SUM(report.weekly_deductions) weekly_deductions, SUM(report.weekly_cash_advance) AS weekly_cash_advance, SUM(report.weekly_company_loan) AS weekly_company_loan, SUM(report.weekly_pagibig_salary) AS weekly_pagibig_salary, SUM(report.weekly_pagibig_calamity) AS weekly_pagibig_calamity, SUM(report.weekly_sss_salary) AS weekly_sss_salary, SUM(report.weekly_sss_calamity) AS weekly_sss_calamity, SUM(report.weekly_netpay) AS weekly_netpay FROM report INNER JOIN employee ON report.employee_id = employee.id WHERE report.week_start = @from AND report.week_end = @to GROUP BY Name, report.id";
            scom.Parameters.AddWithValue("@from", from);
            scom.Parameters.AddWithValue("@to", to);

            MySqlDataAdapter sda = new MySqlDataAdapter(scom);

            sda.Fill(employeeDS, employeeDS.Tables["report"].TableName);

            ReportDataSource rds = new ReportDataSource("report", employeeDS.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            //reportParameters.Add(new ReportParameter("dateCovered", from + " - " + to));
            var setup = reportViewer1.GetPageSettings();
            setup.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            reportViewer1.SetPageSettings(setup);
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.reportViewer1.LocalReport.ReportPath = @"..\..\Winforms\Report2.rdlc";
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();

        }
    }
}
