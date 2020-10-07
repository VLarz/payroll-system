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
    public partial class Add_SSS_Salary_Loan : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = celes_and_lolit-payroll");
        string ID = "";
        public Add_SSS_Salary_Loan()
        {
            InitializeComponent();
            ID = SSS_Loan.SalaryID;
            getEmployeeID();
            cmbEmployeeID.SelectedIndex = 0;
            if (ID != "")
            {
                btnUpdate.Visible = true;
                getEmployeeInformation();
                lblTitle.Text = "Update SSS Salary Loan";
            }
        }

        private void getEmployeeInformation()
        {
            if(ID != "")
            {
                string EmployeeID = "";
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT employee_id, amount, start, end, amount_per_month, amount_per_week " +
                                   "FROM sss_salary_loan " +
                                   "WHERE id = @id";
                scom.Parameters.AddWithValue("@id", ID);
                MySqlDataReader sdr = scom.ExecuteReader();
                while (sdr.Read())
                {
                    EmployeeID = sdr["employee_id"].ToString();
                    txtAmount.Text = sdr["amount"].ToString();
                    DateTime start = Convert.ToDateTime(sdr["start"].ToString());
                    dtpDateReceived.Text = start.ToString("dddd, MMMM d, yyyy");
                    DateTime end = Convert.ToDateTime(sdr["end"].ToString());
                    txtDateEnd.Text = end.ToString("dddd, MMMM d, yyyy");
                    lblPerMonth.Text = sdr["amount_per_month"].ToString();
                    lblPerWeek.Text = sdr["amount_per_week"].ToString();
                }
                conn.Close();
                sdr.Close();
                cmbEmployeeID.Text = EmployeeID;
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

        private void clearFields()
        {
            cmbEmployeeID.SelectedIndex = 0;
            txtName.Text = "";
            txtAmount.Text = "";
            dtpDateReceived.Text = System.DateTime.Now.ToString("dddd, MMMM d, yyyy");
            txtDateEnd.Text = "";
            lblPerMonth.Text = "";
            lblPerWeek.Text = "";
        }

        private void txtMonths_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtAmount_OnValueChanged(object sender, EventArgs e)
        {
            if(txtAmount.Text != "")
            {     
                decimal amount = Convert.ToDecimal(txtAmount.Text);
                decimal months = 24;
                decimal perMonth = amount / months;
                decimal perWeek = (amount / months) / months;

                lblPerMonth.Text = Convert.ToString(String.Format("{0:0.00}", perMonth));
                lblPerWeek.Text = Convert.ToString(String.Format("{0:0.00}", perWeek));


                DateTime start = dtpDateReceived.Value;
                DateTime end = start.AddMonths(+24);
                string end1 = end.ToString("dddd, MMMM d, yyyy");
                txtDateEnd.Text = Convert.ToString(end1);
            }
            else
            {
                lblPerMonth.Text = "0";
                lblPerWeek.Text = "0";
            }
        }

        private void cmbEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbEmployeeID.SelectedIndex != 0)
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void t_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cmbEmployeeID.SelectedIndex != 0 && txtName.Text != "" && txtAmount.Text != "" && txtDateEnd.Text != "" && lblPerMonth.Text != "0" & lblPerWeek.Text != "0")
            {
                DateTime start = Convert.ToDateTime(dtpDateReceived.Text);
                DateTime end = Convert.ToDateTime(txtDateEnd.Text);
                String start1 = start.ToString("yyyy/MM/dd");
                String end1 = end.ToString("yyyy/MM/dd");
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "INSERT INTO sss_salary_loan (employee_id, amount, start, end, amount_per_month, amount_per_week) " +
                                    "VALUES (@id, @amount, @start, @end, @perMonth, @perWeek)";
                scom.Parameters.AddWithValue("@id", cmbEmployeeID.Text);
                scom.Parameters.AddWithValue("@amount", txtAmount.Text);
                scom.Parameters.AddWithValue("@start", start1);
                scom.Parameters.AddWithValue("@end", end1);
                scom.Parameters.AddWithValue("@perMonth", lblPerMonth.Text);
                scom.Parameters.AddWithValue("@perWeek", lblPerWeek.Text);
                scom.ExecuteNonQuery();
                conn.Close();
                alert.Show("Successfully Saved.", alert.AlertType.success);
                clearFields();
            }
            else
            {
                alert.Show("Please fill in required fields.", alert.AlertType.warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbEmployeeID.SelectedIndex != 0 && txtName.Text != "" && txtAmount.Text != "" && txtDateEnd.Text != "" && lblPerMonth.Text != "0" & lblPerWeek.Text != "0")
            {
                DateTime start = Convert.ToDateTime(dtpDateReceived.Text);
                DateTime end = Convert.ToDateTime(txtDateEnd.Text);
                String start1 = start.ToString("yyyy/MM/dd");
                String end1 = end.ToString("yyyy/MM/dd");
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "UPDATE sss_salary_loan SET employee_id = @employeeID, amount = @amount, start = @start, end = @end, amount_per_month = @perMonth, amount_per_week = @perWeek " +
                                    "WHERE id = @id";
                scom.Parameters.AddWithValue("@id", ID);
                scom.Parameters.AddWithValue("@employeeID", cmbEmployeeID.Text);
                scom.Parameters.AddWithValue("@amount", txtAmount.Text);
                scom.Parameters.AddWithValue("@start", start1);
                scom.Parameters.AddWithValue("@end", end1);
                scom.Parameters.AddWithValue("@perMonth", lblPerMonth.Text);
                scom.Parameters.AddWithValue("@perWeek", lblPerWeek.Text);
                scom.ExecuteNonQuery();
                conn.Close();
                alert.Show("Successfully Updated.", alert.AlertType.success);

            }
            else
            {
                alert.Show("Please fill in required fields.", alert.AlertType.warning);
            }
        }

        private void dtpDateReceived_ValueChanged(object sender, EventArgs e)
        {
            DateTime start = dtpDateReceived.Value;
            DateTime end = start.AddMonths(+24);
            string end1 = end.ToString("dddd, MMMM d, yyyy");
            txtDateEnd.Text = Convert.ToString(end1);
            if (txtAmount.Text != "")
            {
                decimal amount = Convert.ToDecimal(txtAmount.Text);
                decimal months = 24;
                decimal perMonth = amount / months;
                decimal perWeek = (amount / months) / months;

                lblPerMonth.Text = Convert.ToString(String.Format("{0:0.00}", perMonth));
                lblPerWeek.Text = Convert.ToString(String.Format("{0:0.00}", perWeek));
                
            }
            else
            {
                lblPerMonth.Text = "0";
                lblPerWeek.Text = "0";
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
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
