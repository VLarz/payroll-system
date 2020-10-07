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
    public partial class SSS : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = celes_and_lolit-payroll");
        int GetID = 0;
        public SSS()
        {
            InitializeComponent();
            showSSSList();
        }

        private void showSSSList()
        {
            try
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT id, minimum_range, maximum_range, CONCAT (minimum_range, ' - ', maximum_range) AS roc, contribution FROM sss ORDER BY minimum_range";
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();
                dgvSSSList.DataSource = dt;
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
                    scom.CommandText = "INSERT INTO sss (minimum_range, maximum_range, contribution) VALUES (@min, @max, @contrib)";
                    scom.Parameters.AddWithValue("@min", txtMinimumRange.Text);
                    scom.Parameters.AddWithValue("@max", txtMaximumRange.Text);
                    scom.Parameters.AddWithValue("@contrib", txtContribution.Text);
                    scom.ExecuteNonQuery();
                    conn.Close();
                    alert.Show("Successfully Added.", alert.AlertType.success);
                    txtMinimumRange.Text = "";
                    txtMaximumRange.Text = "";
                    txtContribution.Text = "";
                    showSSSList();
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

        private void txtContribution_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text != "")
            {
                try
                {
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "SELECT id, minimum_range, maximum_range, CONCAT (minimum_range, ' - ', maximum_range) AS roc,                       contribution " +
                                       "FROM sss " +
                                       "WHERE minimum_range LIKE '%" + txtSearch.Text + "%' OR maximum_range LIKE '%" + txtSearch.Text +       "%'  OR contribution LIKE '%" + txtSearch.Text + "%'" +
                                       "ORDER BY minimum_range";
                    MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    conn.Close();
                    dgvSSSList.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                showSSSList();
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
                        scom.CommandText = "UPDATE sss SET minimum_range = @min, maximum_range = @max, contribution = @contrib " +
                                           "WHERE id = @id";
                        scom.Parameters.AddWithValue("@id", GetID);
                        scom.Parameters.AddWithValue("@min", txtMinimumRange.Text);
                        scom.Parameters.AddWithValue("@max", txtMaximumRange.Text);
                        scom.Parameters.AddWithValue("@contrib", txtContribution.Text);
                        scom.ExecuteNonQuery();
                        conn.Close();
                        alert.Show("Successfully Updated.", alert.AlertType.success);
                        showSSSList();
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

        private void dgvSSSList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSSSList.Rows.Count > 0)
            {
                GetID = Convert.ToInt32(dgvSSSList.CurrentRow.Cells["id"].Value.ToString());
                txtMinimumRange.Text = dgvSSSList.CurrentRow.Cells["minimum"].Value.ToString();
                txtMaximumRange.Text = dgvSSSList.CurrentRow.Cells["maximum"].Value.ToString();
                txtContribution.Text = dgvSSSList.CurrentRow.Cells["contribution"].Value.ToString();

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
                    scom.CommandText = "DELETE FROM sss WHERE id = @id";
                    scom.Parameters.AddWithValue("@id", GetID);
                    scom.ExecuteNonQuery();
                    conn.Close();
                    alert.Show("Successfully Deleted.", alert.AlertType.success);
                    showSSSList();
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

        private void SSS_Load(object sender, EventArgs e)
        {
            if (dgvSSSList.Rows.Count > 0)
            {
                dgvSSSList.Rows[0].Selected = false;
            }
        }

        private void txtMinimumRange_KeyPress(object sender, KeyPressEventArgs e)
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
