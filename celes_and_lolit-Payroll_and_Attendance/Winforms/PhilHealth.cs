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
    public partial class PhilHealth : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = celes_and_lolit-payroll");
        int GetID = 0;
        public PhilHealth()
        {
            InitializeComponent();
            showPhilHealthList();
        }

        private void showPhilHealthList()
        {
            try
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT id, minimum_range, maximum_range, CONCAT (minimum_range, ' - ', maximum_range) AS roc, compensation FROM philhealth ORDER BY minimum_range";
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();
                dgvPhilHealthList.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMinimumRange.Text != "" && txtMinimumRange.Text != "" && txtContribution.Text != "")
            {
                try
                {
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "INSERT INTO philhealth (minimum_range, maximum_range, compensation) VALUES (@min, @max, @compen)";
                    scom.Parameters.AddWithValue("@min", txtMinimumRange.Text);
                    scom.Parameters.AddWithValue("@max", txtMaximumRange.Text);
                    scom.Parameters.AddWithValue("@compen", txtContribution.Text);
                    scom.ExecuteNonQuery();
                    conn.Close();
                    alert.Show("Successfully Added.", alert.AlertType.success);
                    txtMinimumRange.Text = "";
                    txtMaximumRange.Text = "";
                    txtContribution.Text = "";
                    showPhilHealthList();
                    txtMinimumRange.Focus();
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

        private void txtContribution_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                try
                {
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "SELECT id, minimum_range, maximum_range, CONCAT (minimum_range, ' - ', maximum_range) AS roc,                       compensation " +
                                       "FROM philhealth " +
                                       "WHERE minimum_range LIKE '%" + txtSearch.Text + "%' OR maximum_range LIKE '%" + txtSearch.Text + "%'  OR compensation LIKE '%" + txtSearch.Text + "%'" +
                                       "ORDER BY minimum_range";
                    MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    conn.Close();
                    dgvPhilHealthList.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                showPhilHealthList();
            }
        }

        private void dgvPhilHealthList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPhilHealthList.Rows.Count > 0)
            {
                GetID = Convert.ToInt32(dgvPhilHealthList.CurrentRow.Cells["id"].Value.ToString());
                txtMinimumRange.Text = dgvPhilHealthList.CurrentRow.Cells["minimum"].Value.ToString();
                txtMaximumRange.Text = dgvPhilHealthList.CurrentRow.Cells["maximum"].Value.ToString();
                txtContribution.Text = dgvPhilHealthList.CurrentRow.Cells["contribution"].Value.ToString();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (GetID != 0)
            {
                if (txtMinimumRange.Text != "" && txtMinimumRange.Text != "" && txtContribution.Text != "")
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand scom = conn.CreateCommand();
                        scom.CommandText = "UPDATE philhealth SET minimum_range = @min, maximum_range = @max, compensation = @contrib " +
                                           "WHERE id = @id";
                        scom.Parameters.AddWithValue("@id", GetID);
                        scom.Parameters.AddWithValue("@min", txtMinimumRange.Text);
                        scom.Parameters.AddWithValue("@max", txtMaximumRange.Text);
                        scom.Parameters.AddWithValue("@contrib", txtContribution.Text);
                        scom.ExecuteNonQuery();
                        conn.Close();
                        alert.Show("Successfully Updated.", alert.AlertType.success);
                        showPhilHealthList();
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
                alert.Show("Please select data first.", alert.AlertType.warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (GetID != 0)
            {
                try
                {
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "DELETE FROM philhealth WHERE id = @id";
                    scom.Parameters.AddWithValue("@id", GetID);
                    scom.ExecuteNonQuery();
                    conn.Close();
                    alert.Show("Successfully Deleted.", alert.AlertType.success);
                    showPhilHealthList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                alert.Show("Please select data first to delete.", alert.AlertType.warning);
            }
        }

        private void PhilHealth_Load(object sender, EventArgs e)
        {
            if (dgvPhilHealthList.Rows.Count > 0)
            {
                dgvPhilHealthList .Rows[0].Selected = false;
            }
        }

        private void txtMaximumRange_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as Bunifu.Framework.UI.BunifuMetroTextbox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar))
            {

                Bunifu.Framework.UI.BunifuMetroTextbox textBox = (Bunifu.Framework.UI.BunifuMetroTextbox)sender;

                if (textBox.Text.IndexOf('.') > -1 &&
                         textBox.Text.Substring(textBox.Text.IndexOf('.')).Length >= 3)
                {
                    e.Handled = true;
                }

            }
        }
    }
}
