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
    public partial class Employee_Overtime : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = celes_and_lolit-payroll");
        public static string from;
        public static string to;
        public static string EmployeeID = "";
        public static string id1 = "";
        public DateTime monday;
        public DateTime sunday;
        public Employee_Overtime()
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
            scom.CommandText = "SELECT YEAR(date) AS 'date' FROM overtime GROUP BY YEAR(date)";
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
            scom.CommandText = "SELECT MONTHNAME(date) AS 'month' FROM overtime GROUP BY  MONTHNAME(date)";
            MySqlDataReader sdr = scom.ExecuteReader();

            while (sdr.Read())
            {
                cmbMonth.Items.Add(sdr["month"].ToString());
            }
            conn.Close();
            sdr.Close();

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

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYear.SelectedIndex != 0)
            {

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

        private void cmbWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbWeek.SelectedIndex != 0)
            {
                monday = Convert.ToDateTime(cmbWeek.Text);
                sunday = monday.AddDays(6);
                from = monday.ToString("yyyy/MM/dd");
                to = sunday.ToString("yyyy/MM/dd");
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT overtime.id, overtime.date, overtime.employee_id,  CONCAT(employee.firstname,' ', employee.middlename,' ', employee.lastname) AS name, SUM(overtime.overtime) + SUM(overtime.dayoff_on_duty_overtime) + SUM(overtime.regular_holiday_overtime) + SUM(overtime.dayoff_regular_holiday_overtime) + SUM(overtime.special_holiday_overtime) + SUM(overtime.dayoff_special_holiday_overtime) AS overtime, approval FROM overtime INNER JOIN employee ON overtime.employee_id = employee.id WHERE overtime.date BETWEEN @monday AND @sunday GROUP BY overtime.id, overtime.date";
                scom.Parameters.AddWithValue("@monday", monday);
                scom.Parameters.AddWithValue("@sunday", sunday);
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();
                dgvEmployeeList.DataSource = dt;

                if (dgvEmployeeList.Rows.Count > 0)
                {
                    dgvEmployeeList.Rows[0].Selected = false;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT overtime.id, overtime.date, overtime.employee_id,  CONCAT(employee.firstname,' ', employee.middlename,' ', employee.lastname) AS name, SUM(overtime.overtime) + SUM(overtime.dayoff_on_duty_overtime) + SUM(overtime.regular_holiday_overtime) + SUM(overtime.dayoff_regular_holiday_overtime) + SUM(overtime.special_holiday_overtime) + SUM(overtime.dayoff_special_holiday_overtime) AS overtime, approval FROM overtime INNER JOIN employee ON overtime.employee_id = employee.id WHERE overtime.date BETWEEN @monday AND @sunday AND employee.lastname LIKE'%" + txtSearch.Text + "%' GROUP BY overtime.id, overtime.date";
                scom.Parameters.AddWithValue("@monday", from);
                scom.Parameters.AddWithValue("@sunday", to);
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();
                dgvEmployeeList.DataSource = dt;
            }
            else
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT overtime.id, overtime.date, overtime.employee_id,  CONCAT(employee.firstname,' ', employee.middlename,' ', employee.lastname) AS name, SUM(overtime.overtime) + SUM(overtime.dayoff_on_duty_overtime) + SUM(overtime.regular_holiday_overtime) + SUM(overtime.dayoff_regular_holiday_overtime) + SUM(overtime.special_holiday_overtime) + SUM(overtime.dayoff_special_holiday_overtime) AS overtime, approval FROM overtime INNER JOIN employee ON overtime.employee_id = employee.id WHERE overtime.date BETWEEN @monday AND @sunday GROUP BY overtime.id, overtime.date";
                scom.Parameters.AddWithValue("@monday", from);
                scom.Parameters.AddWithValue("@sunday", to);
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();
                dgvEmployeeList.DataSource = dt;

                if (dgvEmployeeList.Rows.Count > 0)
                {
                    dgvEmployeeList.Rows[0].Selected = false;
                }

            }
        }

        private void dgvEmployeeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmployeeList.Rows.Count > 0)
            {
                EmployeeID = dgvEmployeeList.CurrentRow.Cells["employee_id"].Value.ToString();
                id1 = dgvEmployeeList.CurrentRow.Cells["id"].Value.ToString();
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if(EmployeeID != "" && cmbWeek.SelectedIndex != 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to approve this employee?", "Approve", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "UPDATE overtime SET approval = 'Approved' WHERE employee_id = @employee_id AND id = @id";
                    scom.Parameters.AddWithValue("@employee_id", EmployeeID);
                    scom.Parameters.AddWithValue("@id", id1);
                    scom.ExecuteNonQuery();
                    conn.Close();
                    alert.Show("Successfully Approved.", alert.AlertType.success);

                    conn.Open();
                    MySqlCommand scom1= conn.CreateCommand();
                    scom1.CommandText = "SELECT overtime.id, overtime.date, overtime.employee_id,  CONCAT(employee.firstname,' ', employee.middlename,' ', employee.lastname) AS name, SUM(overtime.overtime) + SUM(overtime.dayoff_on_duty_overtime) + SUM(overtime.regular_holiday_overtime) + SUM(overtime.dayoff_regular_holiday_overtime) + SUM(overtime.special_holiday_overtime) + SUM(overtime.dayoff_special_holiday_overtime) AS overtime, approval FROM overtime INNER JOIN employee ON overtime.employee_id = employee.id WHERE overtime.date BETWEEN @monday AND @sunday GROUP BY overtime.id, overtime.date";
                    scom1.Parameters.AddWithValue("@monday", from);
                    scom1.Parameters.AddWithValue("@sunday", to);
                    MySqlDataAdapter sda = new MySqlDataAdapter(scom1);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    conn.Close();
                    dgvEmployeeList.DataSource = dt;

                    if (dgvEmployeeList.Rows.Count > 0)
                    {
                        dgvEmployeeList.Rows[0].Selected = false;
                    }
                }
            }
            else
            {
                alert.Show("Please select employee first.", alert.AlertType.warning);
            }
        }

        private void btnFileEmployee_Click(object sender, EventArgs e)
        {
            Add_Position add = new Add_Position();
            add.Show();
        }

        private void Employee_Overtime_Load(object sender, EventArgs e)
        {
            btnFileEmployee.IconZoom = 80;
            btnUpdateEmployee.IconZoom = 75;
        }
    }
}
