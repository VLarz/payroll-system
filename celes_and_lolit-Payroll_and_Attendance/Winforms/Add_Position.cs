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
    public partial class Add_Position : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = celes_and_lolit-payroll");
        public Add_Position()
        {
            InitializeComponent();
            getEmployeeID();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cmbEmployeeID.Text != "" && txtName.Text != "")
            {
                try
                {
                    DateTime start = Convert.ToDateTime(dtpDateReceived.Text);
                    String start1 = start.ToString("yyyy/MM/dd");
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "INSERT INTO overtime (date, employee_id, approval) VALUES (@date, @id, 'Approved')";
                    scom.Parameters.AddWithValue("@date", start1);
                    scom.Parameters.AddWithValue("@id", cmbEmployeeID.Text);
                    scom.ExecuteNonQuery();
                    conn.Close();
                    alert.Show("Successfully Filed", alert.AlertType.success);
                    getEmployeeID();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                alert.Show("Please fill in required fields.", alert.AlertType.warning);
            }
        }

        private void cmbEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmployeeID.SelectedIndex != 0)
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

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
