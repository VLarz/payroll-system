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
    public partial class Position : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = celes_and_lolit-payroll");
        string PositionID = "";
        string SalaryID = "";
        public Position()
        {
            InitializeComponent();
            showPosition();
            showSalary();
            getPosition();
        }

        private void getPosition()
        {
            try
            {
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT id, description FROM position";
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                conn.Open();
                DataSet ds = new DataSet();
                sda.Fill(ds, "position");
                cmbPosition.DisplayMember = "description";
                cmbPosition.ValueMember = "id";
                cmbPosition.DataSource = ds.Tables["position"];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showSalary()
        {
            try
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT salary.id, position.description, salary.rate FROM salary " +
                                   "INNER JOIN position ON position.id = salary.position_id";
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();
                dgvSalaryList.DataSource = dt;
                if (dgvSalaryList.Rows.Count > 0)
                {
                    dgvSalaryList.Rows[0].Selected = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showPosition()
        {
            try
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT * FROM position WHERE description != '- Select -'";
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();
                dgvPositionList.DataSource = dt;
                if (dgvPositionList.Rows.Count > 0)
                {
                    dgvPositionList.Rows[0].Selected = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void tabSSSCalamity_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (txtDescription.Text != "")
            {
                try
                {
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "INSERT INTO position (description) VALUES (@description)";
                    scom.Parameters.AddWithValue("@description", txtDescription.Text);
                    scom.ExecuteNonQuery();
                    conn.Close();
                    alert.Show("Successfully Added.", alert.AlertType.success);
                    showPosition();
                    getPosition();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text != "")
            {
                try
                {
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "UPDATE position SET description = @description WHERE id = @id";
                    scom.Parameters.AddWithValue("@description", txtDescription.Text);
                    scom.Parameters.AddWithValue("@id", PositionID);
                    scom.ExecuteNonQuery();
                    conn.Close();
                    alert.Show("Successfully Updated.", alert.AlertType.success);
                    showPosition();
                    getPosition();
                    showSalary();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                alert.Show("Please select data to update.", alert.AlertType.warning);
            }
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            if (txtRate.Text != "" && cmbPosition.Text != "")
            {
                try
                {
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "INSERT INTO salary (position_id, rate) VALUES (@pos_id, @rate)";
                    scom.Parameters.AddWithValue("@pos_id", cmbPosition.SelectedValue.ToString());
                    scom.Parameters.AddWithValue("@rate", txtRate.Text);
                    scom.ExecuteNonQuery();
                    conn.Close();
                    alert.Show("Successfully Added.", alert.AlertType.success);
                    showSalary();
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

        private void dgvPositionList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPositionList.Rows.Count > 0)
            {
                PositionID = dgvPositionList.CurrentRow.Cells["id"].Value.ToString();
                txtDescription.Text = dgvPositionList.CurrentRow.Cells["description"].Value.ToString();
            }
        }

        private void Position_Load(object sender, EventArgs e)
        {
            if (dgvPositionList.Rows.Count > 0)
            {
                dgvPositionList.Rows[0].Selected = false;
            }
            if (dgvSalaryList.Rows.Count > 0)
            {
                dgvSalaryList.Rows[0].Selected = false;
            }
        }

        private void dgvSalaryList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSalaryList.Rows.Count > 0)
            {
                SalaryID = dgvSalaryList.CurrentRow.Cells["id1"].Value.ToString();
                cmbPosition.Text = dgvSalaryList.CurrentRow.Cells["position1"].Value.ToString();
                txtRate.Text = dgvSalaryList.CurrentRow.Cells["rate1"].Value.ToString();
            }
        }

        private void txtUpdate1_Click(object sender, EventArgs e)
        {
            if (txtRate.Text != "" && cmbPosition.Text != "")
            {
                try
                {
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "UPDATE salary SET position_id = @pos_id, rate = @rate " +
                                       "WHERE id = @id";
                    scom.Parameters.AddWithValue("@pos_id", cmbPosition.SelectedValue.ToString());
                    scom.Parameters.AddWithValue("@rate", txtRate.Text);
                    scom.Parameters.AddWithValue("@id", SalaryID);
                    scom.ExecuteNonQuery();
                    conn.Close();
                    alert.Show("Successfully Updated.", alert.AlertType.success);
                    showSalary();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                alert.Show("Please select data to update.", alert.AlertType.warning);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
