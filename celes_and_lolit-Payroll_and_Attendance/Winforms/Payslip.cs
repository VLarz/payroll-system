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
    public partial class Payslip : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = celes_and_lolit-payroll");
        public string from = "";
        public string to = "";
        public Payslip()
        {
            InitializeComponent();
            from = Payroll.from;
            to = Payroll.to;

        }

        private void Payslip_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_celes_and_lolit_payrollDataSet.DataTable1' table. You can move, or remove it, as needed.
            //this.DataTable1TableAdapter.Fill(this._celes_and_lolit_payrollDataSet.DataTable1);
            // TODO: This line of code loads data into the '_celes_and_lolit_payrollDataSet.emp_day_work' table. You can move, or remove it, as needed.
            //this.emp_day_workTableAdapter.Fill(this._celes_and_lolit_payrollDataSet.emp_day_work);

            Console.WriteLine(from);
            Console.WriteLine(to);
            EmployeeDS employeeDS = new EmployeeDS();
                                                        
            
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT @'employee_id':=day_work.employee_id AS employee_id, CONCAT(employee.lastname, ', ', employee.firstname, ' ', employee.middlename) AS full_name, @'basic_pay':= salary.rate * 48 AS basic_pay, @'overtime':= (SELECT SUM(overtime) + SUM(dayoff_on_duty_overtime) + SUM(regular_holiday_overtime) + SUM(dayoff_regular_holiday_overtime) + SUM(special_holiday_overtime) + SUM(dayoff_special_holiday_overtime) FROM overtime WHERE employee_id = @'employee_id' AND approval = 'Approved') AS overtime, SUM(day_work.regular_hour) +SUM(day_work.dayoff_on_duty) + SUM(day_work.regular_holiday) + SUM(day_work.dayoff_regular_holiday) + SUM(day_work.special_holiday) + SUM(day_work.dayoff_special_holiday) + SUM(day_work.vacation_leave) + SUM(overtime.overtime) + SUM(overtime.dayoff_on_duty_overtime) + SUM(overtime.regular_holiday_overtime) + SUM(overtime.dayoff_regular_holiday_overtime) + SUM(overtime.special_holiday_overtime) + SUM(overtime.dayoff_special_holiday_overtime) AS gross_pay, (SELECT contribution / 4 FROM sss WHERE salary.rate * 192 BETWEEN minimum_range AND maximum_range) AS sss_contribution, (SELECT CASE WHEN compensation = 137.5000 THEN 137.5000 / 4  WHEN compensation = 0.0275 THEN((salary.rate * 192 * 0.0275) / 2) / 4 ELSE 550.00 / 4 END AS 'QuantityText' FROM philhealth WHERE salary.rate * 192 BETWEEN minimum_range AND maximum_range) AS philhealth_contribution, (SELECT CASE WHEN compensation = 0.01 THEN(salary.rate * 192 * 0.01) / 4 WHEN compensation = 0.02 THEN(salary.rate * 48 * 0.02) / 4 ELSE 100.00 / 4 END AS 'QuantityText' FROM pagibig WHERE salary.rate * 192 BETWEEN minimum_range AND maximum_range) AS pagibig_contribution, @'deductions':= (SELECT contribution / 4 FROM sss WHERE salary.rate * 192 BETWEEN minimum_range AND maximum_range) +(SELECT CASE WHEN compensation = 137.5000 THEN 137.5000 / 4  WHEN compensation = 0.0275 THEN(salary.rate * 192 * 0.02) / 4 ELSE 550.00 / 4 END AS 'QuantityText' FROM philhealth WHERE salary.rate * 192 BETWEEN minimum_range AND maximum_range) +(SELECT CASE WHEN compensation = 0.01 THEN(salary.rate * 192 * 0.01) / 4 WHEN compensation = 0.02 THEN(salary.rate * 48 * 0.02) / 4 ELSE 100.00 / 4 END AS 'QuantityText' FROM pagibig WHERE salary.rate * 192 BETWEEN minimum_range AND maximum_range) AS deductions, SUM(day_work.regular_hour) +SUM(day_work.dayoff_on_duty) + SUM(day_work.regular_holiday) + SUM(day_work.dayoff_regular_holiday) + SUM(day_work.special_holiday) + SUM(day_work.dayoff_special_holiday) + SUM(day_work.sick_leave) + SUM(day_work.vacation_leave) + SUM(overtime.overtime) + SUM(overtime.dayoff_on_duty_overtime) + SUM(overtime.regular_holiday_overtime) + SUM(overtime.dayoff_regular_holiday_overtime) + SUM(overtime.special_holiday_overtime) + SUM(overtime.dayoff_special_holiday_overtime) - @'deductions' AS tax, (SELECT CASE WHEN tax_percentage = 0.20 THEN(((SUM(day_work.regular_hour) + SUM(day_work.dayoff_on_duty) + SUM(day_work.regular_holiday) + SUM(day_work.dayoff_regular_holiday) + SUM(day_work.special_holiday) + SUM(day_work.dayoff_special_holiday) + SUM(day_work.sick_leave) + SUM(day_work.vacation_leave) + SUM(overtime.overtime) + SUM(overtime.dayoff_on_duty_overtime) + SUM(overtime.regular_holiday_overtime) + SUM(overtime.dayoff_regular_holiday_overtime) + SUM(overtime.special_holiday_overtime) + SUM(overtime.dayoff_special_holiday_overtime) - @'deductions') - minimum_range) *0.20) +tax_rate WHEN tax_percentage = 0.25 THEN(((SUM(day_work.regular_hour) + SUM(day_work.dayoff_on_duty) + SUM(day_work.regular_holiday) + SUM(day_work.dayoff_regular_holiday) + SUM(day_work.special_holiday) + SUM(day_work.dayoff_special_holiday) + SUM(day_work.sick_leave) + SUM(day_work.vacation_leave) + SUM(overtime.overtime) + SUM(overtime.dayoff_on_duty_overtime) + SUM(overtime.regular_holiday_overtime) + SUM(overtime.dayoff_regular_holiday_overtime) + SUM(overtime.special_holiday_overtime) + SUM(overtime.dayoff_special_holiday_overtime) - @'deductions') - minimum_range) *0.25) +tax_rate WHEN tax_percentage = 0.30 THEN(((SUM(day_work.regular_hour) + SUM(day_work.dayoff_on_duty) + SUM(day_work.regular_holiday) + SUM(day_work.dayoff_regular_holiday) + SUM(day_work.special_holiday) + SUM(day_work.dayoff_special_holiday) + SUM(day_work.sick_leave) + SUM(day_work.vacation_leave) + SUM(overtime.overtime) + SUM(overtime.dayoff_on_duty_overtime) + SUM(overtime.regular_holiday_overtime) + SUM(overtime.dayoff_regular_holiday_overtime) + SUM(overtime.special_holiday_overtime) + SUM(overtime.dayoff_special_holiday_overtime) - @'deductions') - minimum_range) *0.30) +tax_rate WHEN tax_percentage = 0.32 THEN(((SUM(day_work.regular_hour) + SUM(day_work.dayoff_on_duty) + SUM(day_work.regular_holiday) + SUM(day_work.dayoff_regular_holiday) + SUM(day_work.special_holiday) + SUM(day_work.dayoff_special_holiday) + SUM(day_work.sick_leave) + SUM(day_work.vacation_leave) + SUM(overtime.overtime) + SUM(overtime.dayoff_on_duty_overtime) + SUM(overtime.regular_holiday_overtime) + SUM(overtime.dayoff_regular_holiday_overtime) + SUM(overtime.special_holiday_overtime) + SUM(overtime.dayoff_special_holiday_overtime) - @'deductions') - minimum_range) *0.32) +tax_rate WHEN tax_percentage = 0.35 THEN(((SUM(day_work.regular_hour) + SUM(day_work.dayoff_on_duty) + SUM(day_work.regular_holiday) + SUM(day_work.dayoff_regular_holiday) + SUM(day_work.special_holiday) + SUM(day_work.dayoff_special_holiday) + SUM(day_work.sick_leave) + SUM(day_work.vacation_leave) + SUM(overtime.overtime) + SUM(overtime.dayoff_on_duty_overtime) + SUM(overtime.regular_holiday_overtime) + SUM(overtime.dayoff_regular_holiday_overtime) + SUM(overtime.special_holiday_overtime) + SUM(overtime.dayoff_special_holiday_overtime) - @'deductions') - minimum_range) *0.35) +tax_rate ELSE 0 END AS 'QuantityText' FROM bir WHERE(SUM(day_work.regular_hour) + SUM(day_work.dayoff_on_duty) + SUM(day_work.regular_holiday) + SUM(day_work.dayoff_regular_holiday) + SUM(day_work.special_holiday) + SUM(day_work.dayoff_special_holiday) + SUM(day_work.sick_leave) + SUM(day_work.vacation_leave) + SUM(overtime.overtime) + SUM(overtime.dayoff_on_duty_overtime) + SUM(overtime.regular_holiday_overtime) + SUM(overtime.dayoff_regular_holiday_overtime) + SUM(overtime.special_holiday_overtime) + SUM(overtime.dayoff_special_holiday_overtime) - @'deductions') BETWEEN minimum_range AND maximum_range) AS bir_tax, (SELECT amount_per_week FROM cash_advance WHERE employee_id = day_work.employee_id AND NOW() + INTERVAL 1 DAY >= start AND end >= NOW()) AS cash_advance, (SELECT amount_per_week FROM company_loan WHERE employee_id = day_work.employee_id AND NOW() + INTERVAL 1 DAY >= start AND end >= NOW()) AS company_loan, (SELECT amount_per_week FROM pagibig_salary_loan WHERE employee_id = day_work.employee_id AND NOW() + INTERVAL 1 DAY >= start AND end >= NOW()) AS pagibig_loan, (SELECT amount_per_week FROM pagibig_calamity_loan WHERE employee_id = day_work.employee_id AND NOW() + INTERVAL 1 DAY >= start AND end >= NOW()) AS pagibig_calamity, (SELECT amount_per_week FROM sss_salary_loan WHERE employee_id = day_work.employee_id AND NOW() + INTERVAL 1 DAY >= start AND end >= NOW()) AS sss_loan, (SELECT amount_per_week FROM sss_calamity_loan WHERE employee_id = day_work.employee_id AND NOW() + INTERVAL 1 DAY >= start AND end >= NOW()) AS sss_calamity, SUM(day_work.regular_hour) AS regular_pay, SUM(day_work.dayoff_on_duty) AS dayoff_on_duty, SUM(day_work.regular_holiday) AS regular_holiday, SUM(day_work.dayoff_regular_holiday) AS dod_regular_holiday, SUM(day_work.special_holiday) AS special_holiday, SUM(day_work.dayoff_special_holiday) AS dod_special_holiday,(SELECT(ROUND(DATEDIFF(end, start) / 7, 0) - 1) * amount_per_week FROM cash_advance WHERE employee_id = day_work.employee_id AND NOW() + INTERVAL 1 DAY >= start AND end >= NOW()) AS cash_advance_balance,(SELECT(ROUND(DATEDIFF(end, start) / 7, 0) - 1) * amount_per_week FROM company_loan WHERE employee_id = day_work.employee_id AND NOW() + INTERVAL 1 DAY >= start AND end >= NOW()) AS company_loan_balance, (SELECT(ROUND(DATEDIFF(end, start) / 7, 0) - 1) * amount_per_week FROM sss_salary_loan WHERE employee_id = day_work.employee_id AND NOW() + INTERVAL 1 DAY >= start AND end >= NOW()) AS sss_salary_balance, (SELECT(ROUND(DATEDIFF(end, start) / 7, 0) - 1) * amount_per_week FROM sss_calamity_loan WHERE employee_id = day_work.employee_id AND NOW() + INTERVAL 1 DAY >= start AND end >= NOW()) AS sss_calamity_balance, (SELECT(ROUND(DATEDIFF(end, start) / 7, 0) - 1) * amount_per_week FROM pagibig_salary_loan WHERE employee_id = day_work.employee_id AND NOW() + INTERVAL 1 DAY >= start AND end >= NOW()) AS pagibig_salary_balance, (SELECT(ROUND(DATEDIFF(end, start) / 7, 0) - 1) * amount_per_week FROM pagibig_calamity_loan WHERE employee_id = day_work.employee_id AND NOW() + INTERVAL 1 DAY >= start AND end >= NOW()) AS pagibig_calamity_balance, SUM(day_work.late) AS late, SUM(day_work.undertime) AS undertime,7 - COUNT(day_work.employee_id) AS absent " +
                "FROM day_work " +
                "INNER JOIN overtime " +
                "ON day_work.overtime_id = overtime.id " +
                "INNER JOIN employee " +
                "ON employee.id = day_work.employee_id " +
                "INNER JOIN salary " +
                "ON employee.salary_id = salary.id " +
                "WHERE day_work.date BETWEEN @from AND @to " +
                "GROUP BY day_work.employee_id, full_name";
            scom.Parameters.AddWithValue("@from", from);
            scom.Parameters.AddWithValue("@to", to);

            MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            
            sda.Fill(employeeDS, employeeDS.Tables["employee_work"].TableName);
            
            ReportDataSource rds = new ReportDataSource("employee_work", employeeDS.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("dateCovered", from + " - " + to));
            var setup = reportViewer1.GetPageSettings();
            setup.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            reportViewer1.SetPageSettings(setup);
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            //this.reportViewer1.LocalReport.ReportPath = @"..\..\Winforms\Report1.rdlc";
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();

        }

    }
}
