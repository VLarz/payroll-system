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

namespace celes_and_lolit_Payroll_and_Attendance.Winforms
{
    public partial class Attendance : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = LOCALHOST; USERNAME = root; PASSWORD =; DATABASE = celes_and_lolit-payroll");
        public static string EmployeeID = "";
        public static string id2 = "";
        public static string date1 = "";
        public Attendance()
        {
            InitializeComponent();
            showAttendanceListCurrenDate();
        }

        private void showAttendanceListCurrenDate()
        {
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT attendance.id, DATE(attendance.time_in) AS date, attendance.employee_id, " +
                                "CONCAT(employee.firstname,' ', employee.middlename,' ', lastname) AS name, TIME(attendance.time_in) AS time_in, TIME(attendance.time_out) AS time_out, attendance.status " +
                                "FROM attendance " +
                                "INNER JOIN employee " +
                                "ON attendance.employee_id = employee.id " +
                                "WHERE DATE(time_in) = @dateNow " +
                                "ORDER BY TIME(time_in)";
            scom.Parameters.AddWithValue("@dateNow", System.DateTime.Now.ToString("yyyy/MM/dd"));
            MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            dgvAttendanceList.DataSource = dt;

            if (dgvAttendanceList.Rows.Count > 0)
            {
                dgvAttendanceList.Rows[0].Selected = false;
            }
        }

        private void showAttendanceList()
        {
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT attendance.id, DATE(attendance.time_in) AS date,  attendance.employee_id, " +
                                "CONCAT(employee.firstname,' ', employee.middlename,' ', lastname) AS name, TIME(attendance.time_in) AS time_in, TIME(attendance.time_out) AS time_out, attendance.status " +
                                "FROM attendance " +
                                "INNER JOIN employee " +
                                "ON attendance.employee_id = employee.id " +
                                "WHERE DATE(attendance.time_in) BETWEEN @from AND @to " +
                                "ORDER BY DATE";
            scom.Parameters.AddWithValue("@from", dtpFrom.Text);
            scom.Parameters.AddWithValue("@to", dtpTo.Text);
            MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            dgvAttendanceList.DataSource = dt;


            if (dgvAttendanceList.Rows.Count > 0)
            {
                dgvAttendanceList.Rows[0].Selected = false;
            }
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            showAttendanceList();
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            showAttendanceList();
        }

        private void btnCurrentDay_Click(object sender, EventArgs e)
        {
            showAttendanceListCurrenDate();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {

        }

        private void dgvAttendanceList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAttendanceList_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAttendanceList.Rows.Count > 0)
            {
                id2 = dgvAttendanceList.CurrentRow.Cells["id1"].Value.ToString();
                EmployeeID = dgvAttendanceList.CurrentRow.Cells["employee_id"].Value.ToString();
                txtName.Text = dgvAttendanceList.CurrentRow.Cells["name"].Value.ToString();
                date1 = dgvAttendanceList.CurrentRow.Cells["date"].Value.ToString();
            
            }
        }

        private void btnUpdateEmployee_Click_1(object sender, EventArgs e)
        {
            if(id2 != "")
            {
                panel2.Visible = true;
            }
            else
            {
                alert.Show("Please select employee first.", alert.AlertType.warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DateTime start = Convert.ToDateTime(dtpDateReceived.Text);
            String start1 = start.ToString("yyyy/MM/dd HH:mm:ss");
            DateTime date = Convert.ToDateTime(date1);
            String date2 = date.ToString("yyyy/MM/dd");
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "UPDATE attendance SET time_out = @timeOut WHERE employee_id = @employee_id AND id = @id";
            scom.Parameters.AddWithValue("@id", id2);
            scom.Parameters.AddWithValue("@employee_id", EmployeeID);
            scom.Parameters.AddWithValue("timeOut", start1);
            scom.ExecuteNonQuery();
            conn.Close();
            alert.Show("Successfully Update", alert.AlertType.success);
            showAttendanceListCurrenDate();

            conn.Open();
            MySqlCommand scom1 = conn.CreateCommand();
            scom1.CommandText = "INSERT INTO day_work (date, employee_id, regular_hour) VALUES (@date, @employee_id, (SELECT salary.rate*8 FROM salary INNER JOIN employee ON employee.salary_id = salary.id WHERE employee.id = @employee_id))";
            scom1.Parameters.AddWithValue("@employee_id", EmployeeID);
            scom1.Parameters.AddWithValue("date", date2);
            scom1.ExecuteNonQuery();
            conn.Close();

            conn.Open();
            MySqlCommand scom2 = conn.CreateCommand();
            scom2.CommandText = "INSERT INTO overtime (date, employee_id) VALUES (@date, @employee_id)";
            scom2.Parameters.AddWithValue("@employee_id", EmployeeID);
            scom2.Parameters.AddWithValue("date", date2);
            scom2.ExecuteNonQuery();
            conn.Close();
        }
    }
}
