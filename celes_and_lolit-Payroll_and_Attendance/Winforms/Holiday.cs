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
    public partial class Holiday : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = celes_and_lolit-payroll");
        public Holiday()
        {
            InitializeComponent();
            showHolidayList();
            cmbType.SelectedIndex = 0;
        }

        private void showHolidayList()
        {
            try
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT id, holiday, date, type " +
                                   "FROM holiday ORDER BY date";
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();
                dgvHolidayList.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && cmbType.SelectedIndex != 0)
            {
                try
                {
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "SELECT holiday FROM holiday WHERE holiday = @holiday";
                    scom.Parameters.AddWithValue("@holiday", txtName.Text);
                    MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    conn.Close();
                    if (dt.Rows.Count > 0)
                    {
                        alert.Show(txtName.Text + " is already exist.", alert.AlertType.warning);
                    }
                    else
                    {
                        DateTime date = Convert.ToDateTime(dtpDate.Text);
                        String date1 = date.ToString("yyyy/MM/dd");
                        conn.Open();
                        MySqlCommand scom1 = conn.CreateCommand();
                        scom1.CommandText = "INSERT INTO holiday (holiday, date, type) VALUES (@name, @date, @type)";
                        scom1.Parameters.AddWithValue("@name", txtName.Text);
                        scom1.Parameters.AddWithValue("@date", date1);
                        scom1.Parameters.AddWithValue("@type", cmbType.Text);
                        scom1.ExecuteNonQuery();
                        conn.Close();
                        alert.Show("Successfully Added.", alert.AlertType.success);
                        txtName.Text = "";
                        dtpDate.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy");
                        cmbType.SelectedIndex = 0;
                        showHolidayList();
                        txtName.Focus();
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

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
        }
    }
}
