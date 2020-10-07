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
using Microsoft.Reporting.WinForms;

namespace celes_and_lolit_Payroll_and_Attendance.Winforms
{
    public partial class Reports : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = celes_and_lolit-payroll");
        public static string from;
        public static string to;
        public Reports()
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
            scom.CommandText = "SELECT report.id, CONCAT(employee.lastname, ', ', employee.firstname, ' ', employee.middlename) AS Name, SUM(report.weekly_basicpay) AS weekly_basicpay, SUM(report.weekly_overtime) AS weekly_overtime, SUM(report.weekly_grosspay) AS weekly_grosspay, SUM(report.weekly_sss) AS weekly_sss, SUM(report.weekly_philhealth) AS weekly_philhealth, SUM(report.weekly_pagibig) AS weekly_pagibig, SUM(report.weekly_deductions) weekly_deductions, SUM(report.weekly_cash_advance) AS weekly_cash_advance, SUM(report.weekly_company_loan) AS weekly_company_loan, SUM(report.weekly_pagibig_salary) AS weekly_pagibig_salary, SUM(report.weekly_pagibig_calamity) AS weekly_pagibig_calamity, SUM(report.weekly_sss_salary) AS weekly_sss_salary, SUM(report.weekly_sss_calamity) AS weekly_sss_calamity, SUM(report.weekly_netpay) AS weekly_netpay FROM report INNER JOIN employee ON report.employee_id = employee.id WHERE YEARWEEK(report.week_start,1) = YEARWEEK(CURDATE(),1) GROUP BY Name, report.id";
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

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMonth.SelectedIndex != 0)
            {
                cmbWeek.Items.Clear();
                cmbWeek.Items.Add("Select Week");
                cmbWeek.SelectedIndex = 0;

                string monthName = cmbMonth.Text;
                int monthNo = Convert.ToDateTime("01-" + monthName + "-2011").Month;
                Console.WriteLine(monthNo);
                int year = Convert.ToInt32(cmbYear.Text);

                CultureInfo ci = new CultureInfo("en-US");
                for (int i = 1; i <= ci.Calendar.GetDaysInMonth(year, monthNo); i++)
                {
                    if (new DateTime(year, monthNo, i).DayOfWeek == DayOfWeek.Monday)
                        cmbWeek.Items.Add(year + "-" + monthNo + "-" + i.ToString());
                }

                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT report.id, CONCAT(employee.lastname, ', ', employee.firstname, ' ', employee.middlename) AS Name, SUM(report.weekly_basicpay) AS weekly_basicpay, SUM(report.weekly_overtime) AS weekly_overtime, SUM(report.weekly_grosspay) AS weekly_grosspay, SUM(report.weekly_sss) AS weekly_sss, SUM(report.weekly_philhealth) AS weekly_philhealth, SUM(report.weekly_pagibig) AS weekly_pagibig, SUM(report.weekly_deductions) weekly_deductions, SUM(report.weekly_cash_advance) AS weekly_cash_advance, SUM(report.weekly_company_loan) AS weekly_company_loan, SUM(report.weekly_pagibig_salary) AS weekly_pagibig_salary, SUM(report.weekly_pagibig_calamity) AS weekly_pagibig_calamity, SUM(report.weekly_sss_salary) AS weekly_sss_salary, SUM(report.weekly_sss_calamity) AS weekly_sss_calamity, SUM(report.weekly_netpay) AS weekly_netpay FROM report INNER JOIN employee ON report.employee_id = employee.id WHERE YEAR(report.week_start) = @year AND  MONTH(report.week_start) = @month GROUP BY Name, report.id";
                scom.Parameters.AddWithValue("@year", cmbYear.Text);
                scom.Parameters.AddWithValue("@month", monthNo);
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();
                dgvPayrollList.DataSource = dt;
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
            if (cmbWeek.SelectedIndex != 0)
            {
                DateTime monday = Convert.ToDateTime(cmbWeek.Text);
                DateTime sunday = monday.AddDays(6);
                Console.WriteLine(monday + " - " + sunday);

                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT report.id, CONCAT(employee.lastname, ', ', employee.firstname, ' ', employee.middlename) AS Name, SUM(report.weekly_basicpay) AS weekly_basicpay, SUM(report.weekly_overtime) AS weekly_overtime, SUM(report.weekly_grosspay) AS weekly_grosspay, SUM(report.weekly_sss) AS weekly_sss, SUM(report.weekly_philhealth) AS weekly_philhealth, SUM(report.weekly_pagibig) AS weekly_pagibig, SUM(report.weekly_deductions) weekly_deductions, SUM(report.weekly_cash_advance) AS weekly_cash_advance, SUM(report.weekly_company_loan) AS weekly_company_loan, SUM(report.weekly_pagibig_salary) AS weekly_pagibig_salary, SUM(report.weekly_pagibig_calamity) AS weekly_pagibig_calamity, SUM(report.weekly_sss_salary) AS weekly_sss_salary, SUM(report.weekly_sss_calamity) AS weekly_sss_calamity, SUM(report.weekly_netpay) AS weekly_netpay FROM report INNER JOIN employee ON report.employee_id = employee.id WHERE report.week_start = @monday AND report.week_end = @sunday GROUP BY Name, report.id";
                scom.Parameters.AddWithValue("@monday", monday);
                scom.Parameters.AddWithValue("@sunday", sunday);
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();
                dgvPayrollList.DataSource = dt;

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
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            if (dgvPayrollList.Rows.Count > 0)
            {
                dgvPayrollList.Rows[0].Selected = false;
            }
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYear.SelectedIndex != 0)
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT report.id, CONCAT(employee.lastname, ', ', employee.firstname, ' ', employee.middlename) AS Name, SUM(report.weekly_basicpay) AS weekly_basicpay, SUM(report.weekly_overtime) AS weekly_overtime, SUM(report.weekly_grosspay) AS weekly_grosspay, SUM(report.weekly_sss) AS weekly_sss, SUM(report.weekly_philhealth) AS weekly_philhealth, SUM(report.weekly_pagibig) AS weekly_pagibig, SUM(report.weekly_deductions) weekly_deductions, SUM(report.weekly_cash_advance) AS weekly_cash_advance, SUM(report.weekly_company_loan) AS weekly_company_loan, SUM(report.weekly_pagibig_salary) AS weekly_pagibig_salary, SUM(report.weekly_pagibig_calamity) AS weekly_pagibig_calamity, SUM(report.weekly_sss_salary) AS weekly_sss_salary, SUM(report.weekly_sss_calamity) AS weekly_sss_calamity, SUM(report.weekly_netpay) AS weekly_netpay FROM report INNER JOIN employee ON report.employee_id = employee.id  WHERE YEAR(report.week_start) = @year GROUP BY Name, report.id";
                scom.Parameters.AddWithValue("@year", cmbYear.Text);
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();
                dgvPayrollList.DataSource = dt;

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

        private void dgvPayrollList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void btnCurrentWeek_Click_1(object sender, EventArgs e)
        {
            ShowCurrentWeekPayrollList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnPayslip_Click(object sender, EventArgs e)
        {
            if(cmbWeek.Text != "")
            {
                Report rep = new Report();
                rep.Show();
            }
            else
            {
                alert.Show("Please select week to print.", alert.AlertType.warning);
            }
            //DGVPrinter print = new DGVPrinter();
            //print.Title = "Report List";
            //print.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToLongDateString());
            //print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            //print.PageNumbers = true;
            //print.PageNumberInHeader = false;
            //print.PorportionalColumns = true;
            //print.HeaderCellAlignment = StringAlignment.Near;
            //print.Footer = "Lolit Coco Lumber & Construction Supply Corp.";
            //print.FooterSpacing = 15;
            //print.printDocument.DefaultPageSettings.Landscape = true;
            //print.PrintDataGridView(dgvPayrollList);
        }
    }
}
