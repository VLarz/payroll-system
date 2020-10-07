using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace celes_and_lolit_Payroll_and_Attendance.Winforms
{
    public partial class Payroll : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = celes_and_lolit-payroll");
        public static string from;
        public static string to;
        public Payroll()
        {
            InitializeComponent();
            GetYear();
            cmbYear.SelectedIndex = 0;
            cmbMonth.SelectedIndex = 0;
            cmbWeek.SelectedIndex = 0;
        }

        private void GetYear()
        {
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT YEAR(date) AS 'date' FROM day_work GROUP BY YEAR(date)";
            MySqlDataReader sdr = scom.ExecuteReader();

            while (sdr.Read())
            {
                cmbYear.Items.Add(sdr["date"].ToString());
            }
            conn.Close();
            sdr.Close();
            
        }

        private void GetMonth()
        {
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT MONTHNAME(date) AS 'month' FROM day_work GROUP BY  MONTHNAME(date)";
            MySqlDataReader sdr = scom.ExecuteReader();

            while (sdr.Read())
            {
                cmbMonth.Items.Add(sdr["month"].ToString());
            }
            conn.Close();
            sdr.Close();

        }

        private void ShowCurrentWeekPayrollList()
        {
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT @'employee_id':=day_work.employee_id, CONCAT(employee.lastname, ', ', employee.firstname, ' ', employee.middlename) AS full_name, @'basic_pay':= salary.rate * 48 AS basic_pay, SUM(day_work.regular_hour) AS regular_pay, " +
                "@'overtime':=(SELECT SUM(overtime) + SUM(dayoff_on_duty_overtime) + SUM(regular_holiday_overtime) + SUM(dayoff_regular_holiday_overtime) + SUM(special_holiday_overtime) + SUM(dayoff_special_holiday_overtime) FROM overtime WHERE employee_id = @employee_id AND approval = 'Approved') AS overtime," +
                " SUM(day_work.dayoff_on_duty) AS dayoff_on_duty, SUM(day_work.regular_holiday) AS regular_holiday, SUM(day_work.dayoff_regular_holiday) AS dod_regular_holiday, SUM(day_work.special_holiday) AS special_holiday, SUM(day_work.dayoff_special_holiday) AS dod_special_holiday , SUM(day_work.regular_hour) + SUM(day_work.dayoff_on_duty) + SUM(day_work.regular_holiday) + SUM(day_work.dayoff_regular_holiday) + SUM(day_work.special_holiday) + SUM(day_work.dayoff_special_holiday) + SUM(day_work.vacation_leave) + SUM(overtime.overtime) + SUM(overtime.dayoff_on_duty_overtime) + SUM(overtime.regular_holiday_overtime) + SUM(overtime.dayoff_regular_holiday_overtime) + SUM(overtime.special_holiday_overtime) + SUM(overtime.dayoff_special_holiday_overtime) AS gross_pay, (SELECT contribution / 4 FROM sss WHERE salary.rate * 192 BETWEEN minimum_range AND maximum_range) AS sss_contribution, (SELECT CASE WHEN compensation = 137.5000 THEN 137.5000 / 4  WHEN compensation = 0.0275 THEN ((salary.rate * 192 * 0.0275) /2)/ 4 END AS 'QuantityText' FROM philhealth WHERE salary.rate * 192 BETWEEN minimum_range AND maximum_range) AS philhealth_contribution, (SELECT CASE WHEN compensation = 0.01 THEN (salary.rate * 192 * 0.01) / 4 WHEN compensation = 0.02 THEN (salary.rate * 48 * 0.02) / 4 ELSE 100.00 / 4 END AS 'QuantityText' FROM pagibig WHERE salary.rate * 192 BETWEEN minimum_range AND maximum_range) AS pagibig_contribution, @'deductions':=(SELECT contribution / 4 FROM sss WHERE salary.rate * 192 BETWEEN minimum_range AND maximum_range) + (SELECT CASE WHEN compensation = 137.5000 THEN 137.5000 / 4  WHEN compensation = 0.0275 THEN ((salary.rate * 192 * 0.0275) / 2)/ 4 ELSE 550.00 / 4 END AS 'QuantityText' FROM philhealth WHERE salary.rate * 192 BETWEEN minimum_range AND maximum_range) + (SELECT CASE WHEN compensation = 0.01 THEN (salary.rate * 192 * 0.01) / 4 WHEN compensation = 0.02 THEN (salary.rate * 48 * 0.02) / 4 ELSE 100.00 / 4 END AS 'QuantityText' FROM pagibig WHERE salary.rate * 192 BETWEEN minimum_range AND maximum_range) AS deductions, (SELECT amount_per_week FROM cash_advance WHERE employee_id = day_work.employee_id AND NOW() BETWEEN start AND end) AS cash_advance, (SELECT amount_per_week FROM company_loan WHERE employee_id = day_work.employee_id AND NOW() BETWEEN start AND end) AS company_loan, (SELECT amount_per_week FROM pagibig_salary_loan WHERE employee_id = day_work.employee_id AND NOW() BETWEEN start AND end) AS pagibig_loan, (SELECT amount_per_week FROM pagibig_calamity_loan WHERE employee_id = day_work.employee_id AND NOW() BETWEEN start AND end) AS pagibig_calamity, (SELECT amount_per_week FROM sss_salary_loan WHERE employee_id = day_work.employee_id AND NOW() BETWEEN start AND end) AS sss_loan, (SELECT amount_per_week FROM sss_calamity_loan WHERE employee_id = day_work.employee_id AND NOW() BETWEEN start AND end) AS sss_calamity FROM day_work  INNER JOIN overtime  ON day_work.overtime_id = overtime.id  INNER JOIN employee  ON employee.id = day_work.employee_id  INNER JOIN salary  ON employee.salary_id = salary.id WHERE YEARWEEK(day_work.date,1) = YEARWEEK(CURDATE(),1) GROUP BY day_work.employee_id, full_name";
            MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            dgvPayrollList.DataSource = dt;

           
        }

        private void btnCurrentWeek_Click(object sender, EventArgs e)
        {
            ShowCurrentWeekPayrollList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////Employee_Payslip slip = new Employee_Payslip();
            //slip.Show();
            ////CultureInfo ci = new CultureInfo("en-US");
            ////for (int i = 1; i <= ci.Calendar.GetDaysInMonth(2019, 10); i++)
            ////{
            ////    if (new DateTime(2019, 10, i).DayOfWeek == DayOfWeek.Monday)
            ////        Console.WriteLine(2019 + i.ToString());
            ////    //cmbWeek.Items.Add(i);
            ////}

            //conn.Open();
            //MySqlCommand scom = conn.CreateCommand();
            //scom.CommandText = "SELECT * FROM employee";
            //MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            //DataSet ds = new DataSet();
            //sda.Fill(ds, "employee");
            ////CrystalReport2 cr1 = new CrystalReport2();
            //cr1.SetDataSource(ds);
            //conn.Close();
            //slip.crystalReportViewer1.Refresh();
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbMonth.SelectedIndex != 0)
            {
                cmbWeek.Items.Clear();
                cmbWeek.Items.Add("Select Week");
                cmbWeek.SelectedIndex = 0;

                string monthName = cmbMonth.Text;
                int monthNo = Convert.ToDateTime("01-" + monthName + "-2011").Month;
                int year = Convert.ToInt32(cmbYear.Text);

                CultureInfo ci = new CultureInfo("en-US");
                for (int i = 1; i <= ci.Calendar.GetDaysInMonth(year, monthNo); i++)
                {
                    if (new DateTime(year, monthNo, i).DayOfWeek == DayOfWeek.Monday)
                        cmbWeek.Items.Add(year + "-" + monthNo + "-" + i.ToString());
                }
            }
            else
            {
                cmbWeek.Items.Clear();
                cmbWeek.Items.Add("Select Week");
                cmbWeek.SelectedIndex = 0;

            }
        }

        private void cmbWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbWeek.SelectedIndex != 0)
            {
                DateTime monday = Convert.ToDateTime(cmbWeek.Text);
                DateTime sunday = monday.AddDays(6);
                //Console.WriteLine(monday + " - " + sunday);
                from = monday.ToString("yyyy/MM/dd");
                to = sunday.ToString("yyyy/MM/dd");
                Console.WriteLine(from);
                Console.WriteLine(to);
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT @'employee_id':=day_work.employee_id AS employee_id, CONCAT(employee.lastname, ', ', employee.firstname, ' ', employee.middlename) AS full_name, @'basic_pay':= salary.rate * 48 AS basic_pay, SUM(day_work.regular_hour) AS regular_pay, " +
                    "@'overtime':=(SELECT SUM(overtime) + SUM(dayoff_on_duty_overtime) + SUM(regular_holiday_overtime) + SUM(dayoff_regular_holiday_overtime) + SUM(special_holiday_overtime) + SUM(dayoff_special_holiday_overtime) FROM overtime WHERE employee_id = @'employee_id' AND approval = 'Approved') AS overtime, " +
                    "SUM(day_work.dayoff_on_duty) AS dayoff_on_duty, SUM(day_work.regular_holiday) AS regular_holiday, SUM(day_work.dayoff_regular_holiday) AS dod_regular_holiday, SUM(day_work.special_holiday) AS special_holiday, SUM(day_work.dayoff_special_holiday) AS dod_special_holiday , SUM(day_work.regular_hour) + SUM(day_work.dayoff_on_duty) + SUM(day_work.regular_holiday) + SUM(day_work.dayoff_regular_holiday) + SUM(day_work.special_holiday) + SUM(day_work.dayoff_special_holiday) + SUM(day_work.vacation_leave) + SUM(overtime.overtime) + SUM(overtime.dayoff_on_duty_overtime) + SUM(overtime.regular_holiday_overtime) + SUM(overtime.dayoff_regular_holiday_overtime) + SUM(overtime.special_holiday_overtime) + SUM(overtime.dayoff_special_holiday_overtime) AS gross_pay, (SELECT contribution / 4 FROM sss WHERE salary.rate * 192 BETWEEN minimum_range AND maximum_range) AS sss_contribution, (SELECT CASE WHEN compensation = 137.5000 THEN 137.5000 / 4  WHEN compensation = 0.0275 THEN ((salary.rate * 192 * 0.0275) /2)/ 4 END AS 'QuantityText' FROM philhealth WHERE salary.rate * 192 BETWEEN minimum_range AND maximum_range) AS philhealth_contribution, (SELECT CASE WHEN compensation = 0.01 THEN (salary.rate * 192 * 0.01) / 4 WHEN compensation = 0.02 THEN (salary.rate * 48 * 0.02) / 4 ELSE 100.00 / 4 END AS 'QuantityText' FROM pagibig WHERE salary.rate * 192 BETWEEN minimum_range AND maximum_range) AS pagibig_contribution, @'deductions':=(SELECT contribution / 4 FROM sss WHERE salary.rate * 192 BETWEEN minimum_range AND maximum_range) + (SELECT CASE WHEN compensation = 137.5000 THEN 137.5000 / 4  WHEN compensation = 0.0275 THEN ((salary.rate * 192 * 0.0275) / 2)/ 4 ELSE 550.00 / 4 END AS 'QuantityText' FROM philhealth WHERE salary.rate * 192 BETWEEN minimum_range AND maximum_range) + (SELECT CASE WHEN compensation = 0.01 THEN (salary.rate * 192 * 0.01) / 4 WHEN compensation = 0.02 THEN (salary.rate * 48 * 0.02) / 4 ELSE 100.00 / 4 END AS 'QuantityText' FROM pagibig WHERE salary.rate * 192 BETWEEN minimum_range AND maximum_range) AS deductions, (SELECT amount_per_week FROM cash_advance WHERE employee_id = day_work.employee_id AND NOW() BETWEEN start AND end) AS cash_advance, (SELECT amount_per_week FROM company_loan WHERE employee_id = day_work.employee_id AND NOW() BETWEEN start AND end) AS company_loan, (SELECT amount_per_week FROM pagibig_salary_loan WHERE employee_id = day_work.employee_id AND NOW() BETWEEN start AND end) AS pagibig_loan, (SELECT amount_per_week FROM pagibig_calamity_loan WHERE employee_id = day_work.employee_id AND NOW() BETWEEN start AND end) AS pagibig_calamity, (SELECT amount_per_week FROM sss_salary_loan WHERE employee_id = day_work.employee_id AND NOW() BETWEEN start AND end) AS sss_loan, (SELECT amount_per_week FROM sss_calamity_loan WHERE employee_id = day_work.employee_id AND NOW() BETWEEN start AND end) AS sss_calamity FROM day_work  INNER JOIN overtime  ON day_work.overtime_id = overtime.id  INNER JOIN employee  ON employee.id = day_work.employee_id  INNER JOIN salary  ON employee.salary_id = salary.id WHERE day_work.date BETWEEN @monday AND @sunday GROUP BY day_work.employee_id, full_name";
                scom.Parameters.AddWithValue("@monday", monday);
                scom.Parameters.AddWithValue("@sunday", sunday);
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();
                dgvPayrollList.DataSource = dt;

                if(dgvPayrollList.Rows.Count > 0)
                {
                    dgvPayrollList.Rows[0].Selected = false;
                }

                //conn.Open();
                //MySqlCommand scom = conn.CreateCommand();
                //scom.CommandText = "SELECT CONCAT(employee.lastname, ', ', employee.firstname, ' ', employee.middlename) AS 'Name', SUM(regular_hour) AS 'regHour', SUM(overtime) AS 'overtime', SUM(dayoff_on_duty)  AS 'dayoff', SUM(dayoff_on_duty_overtime) AS 'dayoffOT', SUM(regular_holiday) AS 'regHoliday', SUM(regular_holiday_overtime) AS 'regHolidayOT', SUM(dayoff_regular_holiday) AS 'dayoffRegHoliday',  SUM(dayoff_regular_holiday_overtime) AS 'dayoffRegHolidayOT', SUM(special_holiday) AS 'specHoliday', SUM(special_holiday_overtime) AS 'specHolidayOT', SUM(dayoff_special_holiday) AS 'dayoffSpecHoliday', SUM(dayoff_special_holiday_overtime) AS 'dayoffSpecHolidayOT', SUM(late) AS 'late', SUM(undertime) AS 'undertime', SUM(sick_leave) AS 'sick', SUM(vacation_leave) AS 'vacation' " +
                //                    "FROM hour_work " +
                //                    "INNER JOIN employee " +
                //                    "ON hour_work.employee_id = employee.id " +
                //                    "WHERE date BETWEEN @monday AND @sunday " +
                //                    "GROUP BY Name";
                //scom.Parameters.AddWithValue("@monday", monday);
                //scom.Parameters.AddWithValue("@sunday", sunday);
                //MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                //DataTable dt = new DataTable();
                //sda.Fill(dt);
                //dgvPayrollList.DataSource = dt;
                //conn.Close();
            }
            //else
            //{
            //    dgvPayrollList.DataSource = null;
            //    //string monthName = cmbMonth.Text;
            //    //int monthNo = Convert.ToDateTime("01-" + monthName + "-2011").Month;
            //    //conn.Open();
            //    //MySqlCommand scom = conn.CreateCommand();
            //    //scom.CommandText = "SELECT CONCAT(employee.lastname, ', ', employee.firstname, ' ', employee.middlename) AS Name, salary.rate * 48 AS GrossPay, day_work.employee_id, SUM(day_work.regular_hour) + SUM(day_work.dayoff_on_duty) + SUM(day_work.regular_holiday) + SUM(day_work.dayoff_regular_holiday) + SUM(day_work.special_holiday) + SUM(day_work.dayoff_special_holiday) + SUM(day_work.sick_leave) + SUM(day_work.vacation_leave) + SUM(overtime.overtime) + SUM(overtime.dayoff_on_duty_overtime) + SUM(overtime.regular_holiday_overtime) + SUM(overtime.dayoff_regular_holiday_overtime) + SUM(overtime.special_holiday_overtime) + SUM(overtime.dayoff_special_holiday_overtime) AS TotalEarn, (SELECT contribution / 4 FROM sss WHERE salary.rate * 192 BETWEEN minimum_range AND maximum_range) AS sss,(SELECT CASE WHEN compensation = 137.5000 THEN 137.5000 / 4  WHEN compensation = 0.0275 THEN (salary.rate * 192 * 0.02) / 4 WHEN compensation = 550.0000 THEN 550.00 / 4 END AS 'QuantityText' FROM philhealth WHERE salary.rate * 192 BETWEEN minimum_range AND maximum_range) AS philhealth, (SELECT CASE WHEN compensation = 0.01 THEN (salary.rate * 192 * 0.01) / 4 WHEN compensation = 0.02 THEN (salary.rate * 48 * 0.02) / 4 WHEN compensation = 100.00 THEN 100.00 / 4 END AS 'QuantityText' FROM pagibig WHERE salary.rate * 192 BETWEEN minimum_range AND maximum_range) AS pagibig, (SELECT contribution / 4 FROM sss WHERE salary.rate * 192 BETWEEN minimum_range AND maximum_range) + (SELECT CASE WHEN compensation = 137.5000 THEN 137.5000 / 4  WHEN compensation = 0.0275 THEN (salary.rate * 192 * 0.02) / 4 WHEN compensation = 550.0000 THEN 550.00 / 4 END AS 'QuantityText' FROM philhealth WHERE salary.rate * 192 BETWEEN minimum_range AND maximum_range) + (SELECT CASE WHEN compensation = 0.01 THEN (salary.rate * 192 * 0.01) / 4 WHEN compensation = 0.02 THEN (salary.rate * 48 * 0.02) / 4 WHEN compensation = 100.00 THEN 100.00 / 4 END AS 'QuantityText' FROM pagibig WHERE salary.rate * 192 BETWEEN minimum_range AND maximum_range) AS deductions, (SELECT amount_per_week FROM cash_advance WHERE employee_id = day_work.employee_id AND NOW() BETWEEN start AND end) AS cash_advance, (SELECT amount_per_week FROM pagibig_salary_loan WHERE employee_id = day_work.employee_id AND NOW() BETWEEN start AND end) AS pagibigloan, (SELECT amount_per_week FROM pagibig_calamity_loan WHERE employee_id = day_work.employee_id AND NOW() BETWEEN start AND end) AS pagibigcalamity, (SELECT amount_per_week FROM sss_salary_loan WHERE employee_id = day_work.employee_id AND NOW() BETWEEN start AND end) AS sssloan, (SELECT amount_per_week FROM sss_calamity_loan WHERE employee_id = day_work.employee_id AND NOW() BETWEEN start AND end) AS ssscalamity, SUM(day_work.late) AS late, SUM(day_work.undertime) AS undertime, SUM(overtime.overtime) AS overtime FROM day_work INNER JOIN overtime ON day_work.overtime_id = overtime.id INNER JOIN employee ON employee.id = day_work.employee_id INNER JOIN salary ON employee.salary_id = salary.id WHERE YEAR(day_work.date) = @year AND  MONTH(day_work.date) = @month GROUP BY day_work.employee_id, Name";
            //    //scom.Parameters.AddWithValue("@year", cmbYear.Text);
            //    //scom.Parameters.AddWithValue("@month", monthNo);
            //    //MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            //    //DataTable dt = new DataTable();
            //    //sda.Fill(dt);
            //    //conn.Close();
            //    //dgvPayrollList.DataSource = dt;
            //}
        }

        private void Payroll_Load(object sender, EventArgs e)
        {
            if (dgvPayrollList.Rows.Count > 0)
            {
                dgvPayrollList.Rows[0].Selected = false;
            }
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbYear.SelectedIndex != 0)
            {
                //conn.Open();
                //MySqlCommand scom = conn.CreateCommand();
                //scom.CommandText = "SELECT CONCAT(employee.lastname, ', ', employee.firstname, ' ', employee.middlename) AS Name, salary.rate * 48 AS GrossPay, day_work.employee_id, SUM(day_work.regular_hour) + SUM(day_work.dayoff_on_duty) + SUM(day_work.regular_holiday) + SUM(day_work.dayoff_regular_holiday) + SUM(day_work.special_holiday) + SUM(day_work.dayoff_special_holiday) + SUM(day_work.sick_leave) + SUM(day_work.vacation_leave) + SUM(overtime.overtime) + SUM(overtime.dayoff_on_duty_overtime) + SUM(overtime.regular_holiday_overtime) + SUM(overtime.dayoff_regular_holiday_overtime) + SUM(overtime.special_holiday_overtime) + SUM(overtime.dayoff_special_holiday_overtime) AS TotalEarn, (SELECT contribution / 4 FROM sss WHERE salary.rate * 192 BETWEEN minimum_range AND maximum_range) AS sss,(SELECT CASE WHEN compensation = 137.5000 THEN 137.5000 / 4  WHEN compensation = 0.0275 THEN (salary.rate * 192 * 0.02) / 4 WHEN compensation = 550.0000 THEN 550.00 / 4 END AS 'QuantityText' FROM philhealth WHERE salary.rate * 192 BETWEEN minimum_range AND maximum_range) AS philhealth, (SELECT CASE WHEN compensation = 0.01 THEN (salary.rate * 192 * 0.01) / 4 WHEN compensation = 0.02 THEN (salary.rate * 48 * 0.02) / 4 WHEN compensation = 100.00 THEN 100.00 / 4 END AS 'QuantityText' FROM pagibig WHERE salary.rate * 192 BETWEEN minimum_range AND maximum_range) AS pagibig, (SELECT contribution / 4 FROM sss WHERE salary.rate * 192 BETWEEN minimum_range AND maximum_range) + (SELECT CASE WHEN compensation = 137.5000 THEN 137.5000 / 4  WHEN compensation = 0.0275 THEN (salary.rate * 192 * 0.02) / 4 WHEN compensation = 550.0000 THEN 550.00 / 4 END AS 'QuantityText' FROM philhealth WHERE salary.rate * 192 BETWEEN minimum_range AND maximum_range) + (SELECT CASE WHEN compensation = 0.01 THEN (salary.rate * 192 * 0.01) / 4 WHEN compensation = 0.02 THEN (salary.rate * 48 * 0.02) / 4 WHEN compensation = 100.00 THEN 100.00 / 4 END AS 'QuantityText' FROM pagibig WHERE salary.rate * 192 BETWEEN minimum_range AND maximum_range) AS deductions, (SELECT amount_per_week FROM cash_advance WHERE employee_id = day_work.employee_id AND NOW() BETWEEN start AND end) AS cash_advance, (SELECT amount_per_week FROM pagibig_salary_loan WHERE employee_id = day_work.employee_id AND NOW() BETWEEN start AND end) AS pagibigloan, (SELECT amount_per_week FROM pagibig_calamity_loan WHERE employee_id = day_work.employee_id AND NOW() BETWEEN start AND end) AS pagibigcalamity, (SELECT amount_per_week FROM sss_salary_loan WHERE employee_id = day_work.employee_id AND NOW() BETWEEN start AND end) AS sssloan, (SELECT amount_per_week FROM sss_calamity_loan WHERE employee_id = day_work.employee_id AND NOW() BETWEEN start AND end) AS ssscalamity, SUM(day_work.late) AS late, SUM(day_work.undertime) AS undertime, SUM(overtime.overtime) AS overtime FROM day_work INNER JOIN overtime ON day_work.overtime_id = overtime.id INNER JOIN employee ON employee.id = day_work.employee_id INNER JOIN salary ON employee.salary_id = salary.id WHERE YEAR(day_work.date) = @year GROUP BY day_work.employee_id, Name";
                //scom.Parameters.AddWithValue("@year", cmbYear.Text);
                //MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                //DataTable dt = new DataTable();
                //sda.Fill(dt);
                //conn.Close();
                //dgvPayrollList.DataSource = dt;

                //conn.Open();
                //MySqlCommand scom = conn.CreateCommand();
                //scom.CommandText = "SELECT CONCAT(employee.lastname, ', ', employee.firstname, ' ', employee.middlename) AS 'Name', SUM(regular_hour) AS 'regHour', SUM(overtime) AS 'overtime', SUM(dayoff_on_duty)  AS 'dayoff', SUM(dayoff_on_duty_overtime) AS 'dayoffOT', SUM(regular_holiday) AS 'regHoliday', SUM(regular_holiday_overtime) AS 'regHolidayOT', SUM(dayoff_regular_holiday) AS 'dayoffRegHoliday',  SUM(dayoff_regular_holiday_overtime) AS 'dayoffRegHolidayOT', SUM(special_holiday) AS 'specHoliday', SUM(special_holiday_overtime) AS 'specHolidayOT', SUM(dayoff_special_holiday) AS 'dayoffSpecHoliday', SUM(dayoff_special_holiday_overtime) AS 'dayoffSpecHolidayOT', SUM(late) AS 'late', SUM(undertime) AS 'undertime', SUM(sick_leave) AS 'sick', SUM(vacation_leave) AS 'vacation' " +
                //                    "FROM hour_work " +
                //                    "INNER JOIN employee " +
                //                    "ON hour_work.employee_id = employee.id " +
                //                    "WHERE YEAR(date) = @year " +
                //                    "GROUP BY Name";
                //scom.Parameters.AddWithValue("@year", cmbYear.Text);
                //MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                //DataTable dt = new DataTable();
                //sda.Fill(dt);
                //dgvPayrollList.DataSource = dt;
                //conn.Close();

                cmbMonth.Items.Clear();
                cmbMonth.Items.Add("Select Month");
                cmbMonth.SelectedIndex = 0;
                GetMonth();
            }
            else
            {
                cmbMonth.Items.Clear();
                cmbMonth.Items.Add("Select Month");
                cmbMonth.SelectedIndex = 0;
            }
        }

        private void pnlEmployee_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPayslip_Click(object sender, EventArgs e)
        {

        }

        private void btnCurrentWeek_Click_1(object sender, EventArgs e)
        {
            ShowCurrentWeekPayrollList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnPayslip_Click_1(object sender, EventArgs e)
        {
            if (cmbWeek.Text != "Select Week")
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT id FROM report " +
                                   "WHERE week_start = @start AND week_end = @end";
                scom.Parameters.AddWithValue("@start", from);
                scom.Parameters.AddWithValue("@end", to);
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();
                if (dt.Rows.Count > 0)
                {
                    conn.Open();
                    MySqlCommand scom1 = conn.CreateCommand();
                    scom1.CommandText = "DELETE FROM report " +
                                        "WHERE week_start = @start AND week_end = @end";
                    scom1.Parameters.AddWithValue("@start", from);
                    scom1.Parameters.AddWithValue("@end", to);
                    scom1.ExecuteNonQuery();
                    conn.Close();
                    foreach (DataGridViewRow order in dgvPayrollList.Rows)
                    {
                        Decimal cashAdv = 0;
                        Decimal companyLoan = 0;
                        Decimal pagibigLoan = 0;
                        Decimal pagibigCal = 0;
                        Decimal sssLoan = 0;
                        Decimal sssCal = 0;
                        foreach (DataGridViewRow order1 in dgvPayrollList.Rows)
                        {
                            conn.Open();
                            MySqlCommand scom2 = conn.CreateCommand();
                            scom2.CommandText = "INSERT INTO report(employee_id, week_start, week_end, weekly_basicpay, weekly_overtime, weekly_grosspay, weekly_sss, weekly_philhealth, weekly_pagibig, weekly_deductions, weekly_cash_advance, weekly_company_loan, weekly_pagibig_salary, weekly_pagibig_calamity, weekly_sss_salary, weekly_sss_calamity, weekly_netpay) " +
                                "VALUES (@id, @start, @end, @basic,@ot, @gross, @sss, @phil, @pagibig, @deductions, @cash, @company, @pagibig_salary, @pagibig_calamity, @sss_salary, @sss_calamity, @netpay)";
                            scom2.Parameters.AddWithValue("@id", order1.Cells["id"].Value);
                            scom2.Parameters.AddWithValue("@start", from);
                            scom2.Parameters.AddWithValue("@end", to);
                            scom2.Parameters.AddWithValue("@basic", order1.Cells["basicPay"].Value);
                            scom2.Parameters.AddWithValue("@reg", order1.Cells["regPay"].Value);
                            scom2.Parameters.AddWithValue("@ot", order1.Cells["overtime"].Value);
                            scom2.Parameters.AddWithValue("@dod", order1.Cells["dod"].Value);
                            scom2.Parameters.AddWithValue("@regHoli", order1.Cells["regHoliday"].Value);
                            scom2.Parameters.AddWithValue("@dodRegHoli", order1.Cells["dodRegHoli"].Value);
                            scom2.Parameters.AddWithValue("@specHoli", order1.Cells["specHoli"].Value);
                            scom2.Parameters.AddWithValue("@dodSpecHoli", order1.Cells["dodSpecHoli"].Value);
                            scom2.Parameters.AddWithValue("@gross", order1.Cells["grossPay"].Value);
                            scom2.Parameters.AddWithValue("@sss", order1.Cells["sss"].Value);
                            scom2.Parameters.AddWithValue("@phil", order1.Cells["philhealth"].Value);
                            scom2.Parameters.AddWithValue("@pagibig", order1.Cells["pagibig"].Value);
                            scom2.Parameters.AddWithValue("@deductions", order1.Cells["deductions"].Value);
                            if (Convert.ToString(order1.Cells["cashAdvance"].Value) == "")
                            {
                                cashAdv = 0;
                            }
                            else
                            {
                                cashAdv = Convert.ToDecimal(order1.Cells["cashAdvance"].Value);
                            }
                            if (Convert.ToString(order1.Cells["companyLoan"].Value) == "")
                            {
                                companyLoan = 0;
                            }
                            else
                            {
                                companyLoan = Convert.ToDecimal(order1.Cells["companyLoan"].Value);
                            }
                            if (Convert.ToString(order1.Cells["pagibigloan"].Value) == "")
                            {
                                pagibigLoan = 0;
                            }
                            else
                            {
                                pagibigLoan = Convert.ToDecimal(order1.Cells["pagibigloan"].Value);
                            }
                            if (Convert.ToString(order1.Cells["pagibigcalamity"].Value) == "")
                            {
                                pagibigCal = 0;
                            }
                            else
                            {
                                pagibigCal = Convert.ToDecimal(order1.Cells["pagibigcalamity"].Value);
                            }
                            if (Convert.ToString(order1.Cells["sssloan"].Value) == "")
                            {
                                sssLoan = 0;
                            }
                            else
                            {
                                sssLoan = Convert.ToDecimal(order1.Cells["sssloan"].Value);
                            }
                            if (Convert.ToString(order1.Cells["ssscalamity"].Value) == "")
                            {
                                sssCal = 0;
                            }
                            else
                            {
                                sssCal = Convert.ToDecimal(order1.Cells["ssscalamity"].Value);
                            }
                            scom2.Parameters.AddWithValue("@cash", cashAdv);
                            scom2.Parameters.AddWithValue("@company", companyLoan);
                            scom2.Parameters.AddWithValue("@pagibig_salary", pagibigLoan);
                            scom2.Parameters.AddWithValue("@pagibig_calamity", pagibigCal);
                            scom2.Parameters.AddWithValue("@sss_salary", sssLoan);
                            scom2.Parameters.AddWithValue("@sss_calamity", sssCal);

                            Decimal grossPay = Convert.ToDecimal(order1.Cells["grossPay"].Value);
                            Console.WriteLine(grossPay);

                            Decimal deductions = Convert.ToDecimal(order1.Cells["deductions"].Value);
                            Console.WriteLine(deductions);
                            Decimal netPay = grossPay - (deductions + cashAdv + companyLoan + pagibigLoan + pagibigCal + sssLoan + sssCal);
                            scom2.Parameters.AddWithValue("@netpay", netPay);
                            scom2.ExecuteNonQuery();
                            conn.Close();
                            scom2.Parameters.Clear();
                        }
                    }
                }
                else
                {
                    Decimal cashAdv = 0;
                    Decimal companyLoan = 0;
                    Decimal pagibigLoan = 0;
                    Decimal pagibigCal = 0;
                    Decimal sssLoan = 0;
                    Decimal sssCal = 0;
                    foreach (DataGridViewRow order in dgvPayrollList.Rows)
                    {
                        conn.Open();
                        MySqlCommand scom2 = conn.CreateCommand();
                        scom2.CommandText = "INSERT INTO report(employee_id, week_start, week_end, weekly_basicpay, weekly_overtime, weekly_grosspay, weekly_sss, weekly_philhealth, weekly_pagibig, weekly_deductions, weekly_cash_advance, weekly_company_loan, weekly_pagibig_salary, weekly_pagibig_calamity, weekly_sss_salary, weekly_sss_calamity, weekly_netpay) " +
                            "VALUES (@id, @start, @end, @basic,@ot, @gross, @sss, @phil, @pagibig, @deductions, @cash, @company, @pagibig_salary, @pagibig_calamity, @sss_salary, @sss_calamity, @netpay)";
                        scom2.Parameters.AddWithValue("@id", order.Cells["id"].Value);
                        scom2.Parameters.AddWithValue("@start", from);
                        scom2.Parameters.AddWithValue("@end", to);
                        scom2.Parameters.AddWithValue("@basic", order.Cells["basicPay"].Value);
                        scom2.Parameters.AddWithValue("@reg", order.Cells["regPay"].Value);
                        scom2.Parameters.AddWithValue("@ot", order.Cells["overtime"].Value);
                        scom2.Parameters.AddWithValue("@dod", order.Cells["dod"].Value);
                        scom2.Parameters.AddWithValue("@regHoli", order.Cells["regHoliday"].Value);
                        scom2.Parameters.AddWithValue("@dodRegHoli", order.Cells["dodRegHoli"].Value);
                        scom2.Parameters.AddWithValue("@specHoli", order.Cells["specHoli"].Value);
                        scom2.Parameters.AddWithValue("@dodSpecHoli", order.Cells["dodSpecHoli"].Value);
                        scom2.Parameters.AddWithValue("@gross", order.Cells["grossPay"].Value);
                        scom2.Parameters.AddWithValue("@sss", order.Cells["sss"].Value);
                        scom2.Parameters.AddWithValue("@phil", order.Cells["philhealth"].Value);
                        scom2.Parameters.AddWithValue("@pagibig", order.Cells["pagibig"].Value);
                        scom2.Parameters.AddWithValue("@deductions", order.Cells["deductions"].Value);
                        if(Convert.ToString(order.Cells["cashAdvance"].Value) == "")
                        {
                            cashAdv = 0;
                        }
                        else
                        {
                            cashAdv = Convert.ToDecimal(order.Cells["cashAdvance"].Value);
                        }
                        if (Convert.ToString(order.Cells["companyLoan"].Value) == "")
                        {
                            companyLoan = 0;
                        }
                        else
                        {
                            companyLoan = Convert.ToDecimal(order.Cells["companyLoan"].Value);
                        }
                        if (Convert.ToString(order.Cells["pagibigloan"].Value) == "")
                        {
                            pagibigLoan = 0;
                        }
                        else
                        {
                            pagibigLoan = Convert.ToDecimal(order.Cells["pagibigloan"].Value);
                        }
                        if (Convert.ToString(order.Cells["pagibigcalamity"].Value) == "")
                        {
                            pagibigCal = 0;
                        }
                        else
                        {
                            pagibigCal = Convert.ToDecimal(order.Cells["pagibigcalamity"].Value);
                        }
                        if (Convert.ToString(order.Cells["sssloan"].Value) == "")
                        {
                            sssLoan = 0;
                        }
                        else
                        {
                            sssLoan = Convert.ToDecimal(order.Cells["sssloan"].Value);
                        }
                        if (Convert.ToString(order.Cells["ssscalamity"].Value) == "")
                        {
                            sssCal = 0;
                        }
                        else
                        {
                            sssCal = Convert.ToDecimal(order.Cells["ssscalamity"].Value);
                        }
                        scom2.Parameters.AddWithValue("@cash", cashAdv);
                        scom2.Parameters.AddWithValue("@company", companyLoan);
                        scom2.Parameters.AddWithValue("@pagibig_salary", pagibigLoan);
                        scom2.Parameters.AddWithValue("@pagibig_calamity", pagibigCal);
                        scom2.Parameters.AddWithValue("@sss_salary", sssLoan);
                        scom2.Parameters.AddWithValue("@sss_calamity", sssCal);

                        Decimal grossPay = 0;
                        if (Convert.ToString(order.Cells["grossPay"].Value) == "")
                        {
                            grossPay = 0;
                        }
                        else
                        {
                            grossPay = Convert.ToDecimal(order.Cells["grossPay"].Value);
                        }
                      
                        Console.WriteLine(grossPay);

                        Decimal deductions = 0;
                        if (Convert.ToString(order.Cells["deductions"].Value) == "")
                        {
                            deductions = 0;
                        }
                        else
                        {
                            deductions = Convert.ToDecimal(order.Cells["deductions"].Value);
                        }
                        Console.WriteLine(deductions);
                        Decimal netPay = grossPay - (deductions + cashAdv + companyLoan + pagibigLoan + pagibigCal + sssLoan + sssCal);
                        scom2.Parameters.AddWithValue("@netpay", netPay);
                        scom2.ExecuteNonQuery();
                        conn.Close();
                        scom2.Parameters.Clear();
                    }
                }

                //foreach (DataGridViewRow order in dgvPayrollList.Rows)
                //{    
                //    conn.Open();
                //    MySqlCommand scom = conn.CreateCommand();
                //    scom.CommandText = "INSERT INTO order_list (purchase_no, supplier, barcode, name, brand, category, description, cost_price, selling_price, quantity, total_price, purchase_date) VALUES (@purchase_no, @supplier, @barcode, @name, @brand, @category, @description, @costPrice, @sellingPrice, @quantity, @total_price, @date)";
                //    //scom.Parameters.AddWithValue("@purchase_no", purchaseNo);
                //    scom.Parameters.AddWithValue("@supplier", order.Cells["supplierName"].Value);
                //    scom.Parameters.AddWithValue("@barcode", order.Cells["barcode"].Value);
                //    scom.Parameters.AddWithValue("@name", order.Cells["itemName"].Value);
                //    scom.Parameters.AddWithValue("@brand", order.Cells["brand"].Value);
                //    scom.Parameters.AddWithValue("@category", order.Cells["category"].Value);
                //    scom.Parameters.AddWithValue("@description", order.Cells["description"].Value);
                //    scom.Parameters.AddWithValue("@costPrice", order.Cells["costPrice"].Value);
                //    scom.Parameters.AddWithValue("@sellingPrice", order.Cells["sellingPrice"].Value);
                //    scom.Parameters.AddWithValue("@quantity", order.Cells["quantity"].Value);
                //    scom.Parameters.AddWithValue("@total_price", order.Cells["totalPrice"].Value);
                //    scom.Parameters.AddWithValue("@date", System.DateTime.Now.ToString("yyyy/MM/dd"));
                //    scom.ExecuteNonQuery();
                //    conn.Close();
                //    scom.Parameters.Clear();
                //}

                Payslip slip = new Payslip();
                slip.Show();
            }
            else
            {
                alert.Show("Please select week to print payslip.", alert.AlertType.warning);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
