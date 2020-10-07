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
    public partial class BIR : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = celes_and_lolit-payroll");
        String GetID = "";
        public BIR()
        {
            InitializeComponent();
            showBIRList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtMinimumRange.Text != "" && txtMaximumRange.Text != "" && txtRate.Text != "" && txtPercentage.Text != "")
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "INSERT INTO bir (minimum_range, maximum_range, tax_rate,tax_percentage) " +
                                   "VALUES (@min, @max, @rate, @percentage)";
                scom.Parameters.AddWithValue("@min", txtMinimumRange.Text);
                scom.Parameters.AddWithValue("@max", txtMaximumRange.Text);
                scom.Parameters.AddWithValue("@rate", txtRate.Text);
                scom.Parameters.AddWithValue("@percentage", txtPercentage.Text);
                scom.ExecuteNonQuery();
                conn.Close();

                txtMinimumRange.Text = "";
                txtMaximumRange.Text = "";
                txtRate.Text = "";
                txtPercentage.Text = "";
                txtMinimumRange.Focus();
                alert.Show("Successfully Added.", alert.AlertType.success);
                showBIRList();
            }
            else
            {
                alert.Show("Please fill required fields.", alert.AlertType.warning);
            }
        }
        private void showBIRList()
        {
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT * FROM bir";
            MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            dgvBIRList.DataSource = dt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BIR_Load(object sender, EventArgs e)
        {
            showBIRList();
            if(dgvBIRList.Rows.Count > 0)
            {
                dgvBIRList.Rows[0].Selected = false;
            }
        }

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPercentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

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

        private void dgvBIRList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBIRList.Rows.Count > 0)
            {
                GetID = dgvBIRList.CurrentRow.Cells["id"].Value.ToString();
                txtMinimumRange.Text = dgvBIRList.CurrentRow.Cells["minimum"].Value.ToString();
                txtMaximumRange.Text = dgvBIRList.CurrentRow.Cells["maximum"].Value.ToString();
                txtRate.Text = dgvBIRList.CurrentRow.Cells["taxRate"].Value.ToString();
                txtPercentage.Text = dgvBIRList.CurrentRow.Cells["taxPercentage"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (GetID != "" && txtMinimumRange.Text != "" && txtMaximumRange.Text != "" && txtRate.Text != "" && txtPercentage.Text != "")
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "UPDATE bir SET minimum_range = @min, maximum_range = @max, tax_rate = @rate,tax_percentage = @percentage WHERE id = @id";
                scom.Parameters.AddWithValue("@id", GetID);
                scom.Parameters.AddWithValue("@min", txtMinimumRange.Text);
                scom.Parameters.AddWithValue("@max", txtMaximumRange.Text);
                scom.Parameters.AddWithValue("@rate", txtRate.Text);
                scom.Parameters.AddWithValue("@percentage", txtPercentage.Text);
                scom.ExecuteNonQuery();
                conn.Close();
                alert.Show("Successfully Updated.", alert.AlertType.success);
                showBIRList();
            }
            else
            {
                alert.Show("Please select data to update.", alert.AlertType.warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (GetID != "" && txtMinimumRange.Text != "" && txtMaximumRange.Text != "" && txtRate.Text != "" && txtPercentage.Text != "")
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "DELETE FROM bir WHERE id = @id";
                scom.Parameters.AddWithValue("@id", GetID);;
                scom.ExecuteNonQuery();
                conn.Close();
                alert.Show("Successfully Deleted.", alert.AlertType.success);
                showBIRList();
            }
            else
            {
                alert.Show("Please select data to delete.", alert.AlertType.warning);
            }
        }
    }
}
