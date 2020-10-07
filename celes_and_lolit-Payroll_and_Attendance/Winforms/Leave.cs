using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace celes_and_lolit_Payroll_and_Attendance.Winforms
{
    public partial class Leave : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = LOCALHOST; USERNAME = root; PASSWORD =; DATABASE = celes_and_lolit-payroll");
        public static string LeaveID = "";
        public static string EmployeeLeaveID = "";
        public static string LeaveID1 = "";
        public static int allowableDay = 0;
        public Leave()
        {
            InitializeComponent();
            showLeaveList();
            showEmployeeLeaveList();
            cmbType.SelectedIndex = 0;
            getEmployeeID();
            getLeave();
        }

        private void getLeave()
        {
            try
            {
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT id, name FROM leaves";
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                conn.Open();
                DataSet ds = new DataSet();
                sda.Fill(ds, "leaves");
                cmbLeave.DisplayMember = "name";
                cmbLeave.ValueMember = "id";
                cmbLeave.DataSource = ds.Tables["leaves"];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getEmployeeID()
        {
            try
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT id FROM employee";
                MySqlDataReader sdr = scom.ExecuteReader();

                while (sdr.Read())
                {
                    cmbEmployeeID.Items.Add(sdr["id"].ToString());
                }
                conn.Close();
                sdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showEmployeeLeaveList()
        {
            try
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT employee_leave.id, employee_leave.employee_id, CONCAT(employee.lastname, ', ', employee.firstname, ' ', employee.middlename) AS 'employee_name', leaves.name, employee_leave.from_date, employee_leave.to_date, employee_leave.days_use, employee_leave.days_left " +
                                   "FROM employee_leave " +
                                   "INNER JOIN employee " +
                                   "ON employee_leave.employee_id = employee.id " +
                                   "INNER JOIN leaves " +
                                   "ON employee_leave.leave_id = leaves.id";
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();
                dgvEmployeeLeaveList.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void showLeaveList()
        {
            try
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT id, name, allowable_day " +
                                   "FROM leaves " +
                                   "WHERE name != 'Select' " +
                                   "ORDER BY name";
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();
                dgvLeaveList.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAllowable.Text != "" && cmbType.SelectedIndex != 0)
            {
                try
                {
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "SELECT name FROM leaves WHERE name = @leave";
                    scom.Parameters.AddWithValue("@leave", cmbType.Text);
                    MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    conn.Close();
                    if (dt.Rows.Count > 0)
                    {
                        alert.Show(cmbType.Text + " is already exist.", alert.AlertType.warning);
                    }
                    else
                    {
                        conn.Open();
                        MySqlCommand scom1 = conn.CreateCommand();
                        scom1.CommandText = "INSERT INTO leaves (name, allowable_day) VALUES (@name, @allowable)";
                        scom1.Parameters.AddWithValue("@name", cmbType.Text);
                        scom1.Parameters.AddWithValue("@allowable", txtAllowable.Text);
                        scom1.ExecuteNonQuery();
                        conn.Close();
                        alert.Show("Successfully Added.", alert.AlertType.success);
                        txtAllowable.Text = "";
                        cmbType.SelectedIndex = 0;
                        showLeaveList();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                alert.Show("Please fill in required fields.", alert.AlertType.warning);
            }
        }

        private void txtLeave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
        }

        private void Leave_Leave(object sender, EventArgs e)
        {
            if(dgvLeaveList.Rows.Count > 0)
            {
                dgvLeaveList.Rows[0].Selected = false;
            }
        }

        private void cmbEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmployeeID.Text != "")
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT CONCAT (lastname, ', ', firstname, ' ', middlename) AS 'Name' " +
                                    "FROM employee " +
                                    "WHERE id = @id";
                scom.Parameters.AddWithValue("id", cmbEmployeeID.Text);
                MySqlDataReader sdr = scom.ExecuteReader();
                while (sdr.Read())
                {
                    txtName.Text = sdr["Name"].ToString();
                }
                conn.Close();
                sdr.Close();
            }
            else
            {
                txtName.Text = "";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (LeaveID != "")
            {
                if (txtAllowable.Text != "" && cmbType.SelectedIndex != 0)
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand scom = conn.CreateCommand();
                        scom.CommandText = "UPDATE leaves SET name = @name, allowable_day = @allowable " +
                                           "WHERE id = @id";
                        scom.Parameters.AddWithValue("@id", LeaveID);
                        scom.Parameters.AddWithValue("@name", cmbType.Text);
                        scom.Parameters.AddWithValue("@allowable", txtAllowable.Text);
                        scom.ExecuteNonQuery();
                        conn.Close();
                        alert.Show("Successfully Updated.", alert.AlertType.success);
                        showLeaveList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    alert.Show("Please fill in required fields.", alert.AlertType.warning);
                }
            }
            else
            {
                alert.Show("Please select data first to update.", alert.AlertType.warning);
            }
        }

        private void dgvLeaveList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLeaveList.Rows.Count > 0)
            {
                LeaveID = dgvLeaveList.CurrentRow.Cells["id"].Value.ToString();
                cmbType.Text = dgvLeaveList.CurrentRow.Cells["name"].Value.ToString();
                txtAllowable.Text = dgvLeaveList.CurrentRow.Cells["allowable"].Value.ToString();
            }
        }

        private void tabLeave_Click(object sender, EventArgs e)
        {
            indicator.Location = new Point(17, 41);
            pnlLeave.BringToFront();
            tabEmployeeLeave.Normalcolor = Color.FromArgb(242, 242, 242);
            tabLeave.Normalcolor = Color.White;
        }

        private void tabEmployeeLeave_Click(object sender, EventArgs e)
        {
            indicator.Location = new Point(180, 41);
            pnlEmployeeLeave.BringToFront();
            tabLeave.Normalcolor = Color.FromArgb(242, 242, 242);
            tabEmployeeLeave.Normalcolor = Color.White;
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            double total = 0;
            if(cmbEmployeeID.Text != "" && txtName.Text != "" && cmbLeave.SelectedIndex !=  0)
            {
                DateTime from = Convert.ToDateTime(dtpFrom.Text);
                string fromDate = from.ToString("yyyy/MM/dd");
                DateTime to = Convert.ToDateTime(dtpTo.Text);
                string toDate = to.ToString("yyyy/MM/dd");

                if (from == to)
                {
                    total = 1;
                }
                else
                {
                    TimeSpan count = to - from;
                    total = count.TotalDays + 1;
                }

                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT days_use FROM employee_leave WHERE employee_id = @id AND leave_id = @leaveID";
                scom.Parameters.AddWithValue("@id", cmbEmployeeID.Text);
                scom.Parameters.AddWithValue("@leaveID", cmbLeave.SelectedValue.ToString());
                MySqlDataReader sdr = scom.ExecuteReader();

                if (sdr.Read())
                {
                    int daysLeft = Convert.ToInt32(sdr["days_use"].ToString());
                    int total1 = daysLeft + Convert.ToInt32(total);
                    conn.Close();
                    conn.Open();
                    MySqlCommand scom1 = conn.CreateCommand();
                    scom1.CommandText = "UPDATE employee_leave SET from_date = @from, to_date = @to, days_use = @days_use " +
                                        "WHERE employee_id = @id";
                    scom1.Parameters.AddWithValue("@id", cmbEmployeeID.Text);
                    scom1.Parameters.AddWithValue("@leave_id", cmbLeave.SelectedValue.ToString());
                    scom1.Parameters.AddWithValue("@from", fromDate);
                    scom1.Parameters.AddWithValue("@to", toDate);
                    scom1.Parameters.AddWithValue("@days_use", total1);
                    scom1.Parameters.AddWithValue("@days_left", allowableDay);
                    scom1.ExecuteNonQuery();
                    conn.Close();
                    alert.Show("Successfully Saved.", alert.AlertType.success);
                    showEmployeeLeaveList();
                }
                else
                {
                    conn.Close();
                    conn.Open();
                    MySqlCommand scom1 = conn.CreateCommand();
                    scom1.CommandText = "INSERT INTO employee_leave (employee_id, leave_id, from_date, to_date, days_use, days_left) VALUES " +
                                       "(@id, @leave_id, @from, @to, @days_use,  @days_left)";
                    scom1.Parameters.AddWithValue("@id", cmbEmployeeID.Text);
                    scom1.Parameters.AddWithValue("@leave_id", cmbLeave.SelectedValue.ToString());
                    scom1.Parameters.AddWithValue("@from", fromDate);
                    scom1.Parameters.AddWithValue("@to", toDate);
                    scom1.Parameters.AddWithValue("@days_use", total);
                    scom1.Parameters.AddWithValue("@days_left", allowableDay);
                    scom1.ExecuteNonQuery();
                    conn.Close();
                    alert.Show("Successfully Saved.", alert.AlertType.success);
                    showEmployeeLeaveList();
                }
                decimal salary = 0;
                if(cmbLeave.Text == "Vacation")
                {
                    if (from == to)
                    {
                        conn.Open();
                        MySqlCommand scom2 = conn.CreateCommand();
                        scom2.CommandText = "INSERT INTO hour_work (date, employee_id, vacation_leave) " +
                                            "VALUES (@date, @id, @leave)";
                        scom2.Parameters.AddWithValue("@date", dtpFrom.Text);
                        scom2.Parameters.AddWithValue("@id", cmbEmployeeID.Text);
                        scom2.Parameters.AddWithValue("@leave", 1);
                        scom2.ExecuteNonQuery();
                        conn.Close();

                        conn.Open();
                        MySqlCommand scom3 = conn.CreateCommand();
                        scom3.CommandText = "SELECT salary.rate * 8 AS 'salary'" +
                                            "FROM employee " +
                                            "INNER JOIN salary " +
                                            "ON salary_id = salary.id " +
                                            "WHERE employee.id = @id";
                        MySqlDataReader sdr1 = scom3.ExecuteReader();
                        if (sdr1.Read())
                        {   
                            
                            salary = Convert.ToDecimal(sdr["salary"].ToString());

                        }
                        conn.Close();
                        sdr1.Close();
                        sdr1.Dispose();

                        conn.Open();
                        MySqlCommand scom4 = conn.CreateCommand();
                        scom4.CommandText = "INSERT INTO day_work (date, employee_id, vacation_leave) " +
                                            "VALUES (@date, @id, @leave)";
                        scom4.Parameters.AddWithValue("@date", dtpFrom.Text);
                        scom4.Parameters.AddWithValue("@id", cmbEmployeeID.Text);
                        scom4.Parameters.AddWithValue("@leave", salary);
                        scom4.ExecuteNonQuery();
                        conn.Close();
                    }
                    else
                    {
                        while (from <= to)
                        {
                            Console.WriteLine(from);

                            conn.Open();
                            MySqlCommand scom2 = conn.CreateCommand();
                            scom2.CommandText = "INSERT INTO hour_work (date, employee_id, vacation_leave) " +
                                                "VALUES (@date, @id, @leave)";
                            scom2.Parameters.AddWithValue("@date", from);
                            scom2.Parameters.AddWithValue("@id", cmbEmployeeID.Text);
                            scom2.Parameters.AddWithValue("@leave", 1);
                            scom2.ExecuteNonQuery();
                            conn.Close();

                            conn.Open();
                            MySqlCommand scom3 = conn.CreateCommand();
                            scom3.CommandText = "SELECT salary.rate * 8 AS 'salary'" +
                                                "FROM employee " +
                                                "INNER JOIN salary " +
                                                "ON salary_id = salary.id " +
                                                "WHERE employee.id = @id";
                            scom3.Parameters.AddWithValue("id", cmbEmployeeID.Text);
                            MySqlDataReader sdr1 = scom3.ExecuteReader();
                            if (sdr1.Read())
                            {

                                salary = Convert.ToDecimal(sdr1["salary"].ToString());

                            }
                            conn.Close();
                            sdr1.Close();
                            sdr1.Dispose();

                            conn.Open();
                            MySqlCommand scom4 = conn.CreateCommand();
                            scom4.CommandText = "INSERT INTO day_work (date, employee_id, vacation_leave) " +
                                                "VALUES (@date, @id, @leave)";
                            scom4.Parameters.AddWithValue("@date", from);
                            scom4.Parameters.AddWithValue("@id", cmbEmployeeID.Text);
                            scom4.Parameters.AddWithValue("@leave", salary);
                            scom4.ExecuteNonQuery();
                            conn.Close();

                            from = from.AddDays(1);
                           
                        }
                    }
                }
                else if(cmbLeave.Text == "Sick")
                {
                    if (from == to)
                    {
                        conn.Open();
                        MySqlCommand scom2 = conn.CreateCommand();
                        scom2.CommandText = "INSERT INTO hour_work (date, employee_id, sick_leave) " +
                                            "VALUES (@date, @id, @leave)";
                        scom2.Parameters.AddWithValue("@date", dtpFrom.Text);
                        scom2.Parameters.AddWithValue("@id", cmbEmployeeID.Text);
                        scom2.Parameters.AddWithValue("@leave", 1);
                        scom2.ExecuteNonQuery();
                        conn.Close();

                        conn.Open();
                        MySqlCommand scom3 = conn.CreateCommand();
                        scom3.CommandText = "SELECT salary.rate * 8 AS 'salary'" +
                                            "FROM employee " +
                                            "INNER JOIN salary " +
                                            "ON salary_id = salary.id " +
                                            "WHERE employee.id = @id";
                        scom3.Parameters.AddWithValue("@id", cmbEmployeeID.Text);
                        MySqlDataReader sdr1 = scom3.ExecuteReader();
                        if (sdr1.Read())
                        {

                            salary = Convert.ToDecimal(sdr1["salary"].ToString());

                        }
                        conn.Close();
                        sdr1.Close();
                        sdr1.Dispose();

                        conn.Open();
                        MySqlCommand scom4 = conn.CreateCommand();
                        scom4.CommandText = "INSERT INTO day_work (date, employee_id, sick_leave) " +
                                            "VALUES (@date, @id, @leave)";
                        scom4.Parameters.AddWithValue("@date", dtpFrom.Text);
                        scom4.Parameters.AddWithValue("@id", cmbEmployeeID.Text);
                        scom4.Parameters.AddWithValue("@leave", salary);
                        scom4.ExecuteNonQuery();
                        conn.Close();
                    }
                    else
                    {
                        while (from <= to)
                        {
                            Console.WriteLine(from);

                            conn.Open();
                            MySqlCommand scom2 = conn.CreateCommand();
                            scom2.CommandText = "INSERT INTO hour_work (date, employee_id, sick_leave) " +
                                                "VALUES (@date, @id, @leave)";
                            scom2.Parameters.AddWithValue("@date", from);
                            scom2.Parameters.AddWithValue("@id", cmbEmployeeID.Text);
                            scom2.Parameters.AddWithValue("@leave", 1);
                            scom2.ExecuteNonQuery();
                            conn.Close();

                            conn.Open();
                            MySqlCommand scom3 = conn.CreateCommand();
                            scom3.CommandText = "SELECT salary.rate * 8 AS 'salary'" +
                                                "FROM employee " +
                                                "INNER JOIN salary " +
                                                "ON salary_id = salary.id " +
                                                "WHERE employee.id = @id";
                            scom3.Parameters.AddWithValue("id", cmbEmployeeID.Text);
                            MySqlDataReader sdr1 = scom3.ExecuteReader();
                            if (sdr1.Read())
                            {

                                salary = Convert.ToDecimal(sdr1["salary"].ToString());

                            }
                            conn.Close();
                            sdr1.Close();
                            sdr1.Dispose();

                            conn.Open();
                            MySqlCommand scom4 = conn.CreateCommand();
                            scom4.CommandText = "INSERT INTO day_work (date, employee_id, sick_leave) " +
                                                "VALUES (@date, @id, @leave)";
                            scom4.Parameters.AddWithValue("@date", from);
                            scom4.Parameters.AddWithValue("@id", cmbEmployeeID.Text);
                            scom4.Parameters.AddWithValue("@leave", salary);
                            scom4.ExecuteNonQuery();
                            conn.Close();

                            from = from.AddDays(1);

                        }
                    }
                }
            }
            else
            {
                alert.Show("Please fill in required fields.", alert.AlertType.warning);
            }
        }

        private void cmbLeave_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbLeave.SelectedIndex != 0)
            {
                DataRowView drv = cmbLeave.SelectedItem as DataRowView;
                LeaveID1 = drv.Row["id"].ToString();
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT allowable_day " +
                                    "FROM leaves " +
                                    "WHERE id = @id";
                scom.Parameters.AddWithValue("id", LeaveID1);
                MySqlDataReader sdr = scom.ExecuteReader();
                while (sdr.Read())
                {
                    allowableDay = Convert.ToInt32(sdr["allowable_day"].ToString());
                }
                conn.Close();
                sdr.Close();
            }
            else
            {
                LeaveID1 = "";
                allowableDay = 0;
            }
        }

        private void Leave_Load(object sender, EventArgs e)
        {
            if(dgvLeaveList.Rows.Count > 0)
            {
                dgvLeaveList.Rows[0].Selected = false;
            }
            if (dgvEmployeeLeaveList.Rows.Count > 0)
            {
                dgvEmployeeLeaveList.Rows[0].Selected = false;
            }
        }

        private void btnUpdate1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = 0;
            DateTime from = Convert.ToDateTime(dtpFrom.Text);
           
            DateTime to = Convert.ToDateTime(dtpTo.Text);
            if(from == to)
            {
                total = 1;
            }
            else
            {
                TimeSpan count = to - from;
                total = count.TotalDays + 1;
                //total = Convert.ToInt32(NrOfDays);
            }

            while (from <= to)
            {
                Console.WriteLine(from);
                //String from1 = from.ToString("yyyy/MM/dd");
                from = from.AddDays(1);
            }
        }

        private void cmbLeave_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbLeave.Text != "Select")
            {
                DataRowView drv = cmbLeave.SelectedItem as DataRowView;
                LeaveID1 = drv.Row["id"].ToString();
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT allowable_day " +
                                    "FROM leaves " +
                                    "WHERE id = @id";
                scom.Parameters.AddWithValue("id", LeaveID1);
                MySqlDataReader sdr = scom.ExecuteReader();
                while (sdr.Read())
                {
                    allowableDay = Convert.ToInt32(sdr["allowable_day"].ToString());
                }
                conn.Close();
                sdr.Close();
            }
            else
            {
                LeaveID1 = "";
                allowableDay = 0;
            }
        }
    }
}
