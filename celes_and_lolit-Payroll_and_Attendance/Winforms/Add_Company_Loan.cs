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
    public partial class Add_Company_Loan : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD =; DATABASE = celes_and_lolit-payroll");
        string ID = "";
        public Add_Company_Loan()
        {
            InitializeComponent();
            ID = Company_Loan.LoanID;
            getEmployeeID();
            cmbEmployeeID.SelectedIndex = 0;
            if (ID != "")
            {
                btnUpdate.Visible = true;
                getEmployeeInformation();
                lblTitle.Text = "Update Company Loan";
            }
        }

        private void getEmployeeInformation()
        {
            if (ID != "")
            {
                string EmployeeID = "";
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT employee_id, amount, interest, start, week, end, amount_per_week, description " +
                                   "FROM company_loan " +
                                   "WHERE id = @id";
                scom.Parameters.AddWithValue("@id", ID);
                MySqlDataReader sdr = scom.ExecuteReader();
                while (sdr.Read())
                {
                    EmployeeID = sdr["employee_id"].ToString();
                    txtAmount.Text = sdr["amount"].ToString();
                    txtInterest.Text = sdr["interest"].ToString();
                    DateTime start = Convert.ToDateTime(sdr["start"].ToString());
                    dtpDateReceived.Text = start.ToString("dddd, MMMM d, yyyy");
                    txtWeeks.Text = sdr["week"].ToString();
                    DateTime end = Convert.ToDateTime(sdr["end"].ToString());
                    txtDateEnd.Text = end.ToString("dddd, MMMM d, yyyy");
                    lblPerWeek.Text = sdr["amount_per_week"].ToString();
                    txtDescription.Text = sdr["description"].ToString();
                }
                conn.Close();
                sdr.Close();
                cmbEmployeeID.Text = EmployeeID;
            }
        }

        private void ClearFields()
        {
            cmbEmployeeID.SelectedIndex = 0;
            txtName.Text = "";
            txtAmount.Text = "";
            dtpDateReceived.Text = System.DateTime.Now.ToString("dddd, MMMM d, yyyy");
            txtDateEnd.Text = "";
            lblPerWeek.Text = "";
            txtWeeks.Text = "";
            txtInterest.Text = "";
            txtDescription.Text = "";
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
            if (cmbEmployeeID.SelectedIndex != 0 && txtName.Text != "" && txtAmount.Text != "" && txtDateEnd.Text != "" && txtWeeks.Text != "" & lblPerWeek.Text != "0" && txtInterest.Text != "")
            {
                conn.Open();
                MySqlCommand scom1 = conn.CreateCommand();
                scom1.CommandText = "SELECT employee_id FROM company_loan WHERE employee_id = @id";
                scom1.Parameters.AddWithValue("@id", cmbEmployeeID.Text);
                MySqlDataReader sdr = scom1.ExecuteReader();
                if (sdr.Read())
                {
                    conn.Close();
                    sdr.Close();
                    alert.Show(txtName.Text + " has already loaned.", alert.AlertType.warning);
                }
                else
                {
                    conn.Close();
                    sdr.Close();
                    DateTime start = Convert.ToDateTime(dtpDateReceived.Text);
                    DateTime end = Convert.ToDateTime(txtDateEnd.Text);
                    String start1 = start.ToString("yyyy/MM/dd");
                    String end1 = end.ToString("yyyy/MM/dd");
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "INSERT INTO company_loan (employee_id, amount, interest, start, week, end, amount_per_week, description) " +
                                        "VALUES (@id, @amount, @interest, @start, @week, @end, @perWeek, @description)";
                    scom.Parameters.AddWithValue("@id", cmbEmployeeID.Text);
                    scom.Parameters.AddWithValue("@amount", txtAmount.Text);
                    scom.Parameters.AddWithValue("@interest", txtInterest.Text);
                    scom.Parameters.AddWithValue("@start", start1);
                    scom.Parameters.AddWithValue("@week", txtWeeks.Text);
                    scom.Parameters.AddWithValue("@end", end1);
                    scom.Parameters.AddWithValue("@perWeek", lblPerWeek.Text);
                    scom.Parameters.AddWithValue("@description", txtDescription.Text);
                    scom.ExecuteNonQuery();
                    conn.Close();
                    alert.Show("Successfully Saved.", alert.AlertType.success);
                    ClearFields();
                }
            }
            else
            {
                alert.Show("Please fill in required fields.", alert.AlertType.warning);
            }
        }

        private void txtAmount_OnValueChanged(object sender, EventArgs e)
        {
            if (txtAmount.Text != "" && txtWeeks.Text != "")
            {
                int weeks = Convert.ToInt32(txtWeeks.Text);
                decimal amount = Convert.ToDecimal(txtAmount.Text);
                decimal perWeek = amount / weeks;
                lblPerWeek.Text = Convert.ToString(String.Format("{0:0.00}", perWeek));


                DateTime start = dtpDateReceived.Value;
                DateTime end = start.AddDays(weeks * 7);
                string end1 = end.ToString("dddd, MMMM d, yyyy");
                txtDateEnd.Text = Convert.ToString(end1);
                if (txtInterest.Text != "" && txtAmount.Text != "")
                {
                    int interest = Convert.ToInt32(txtInterest.Text);
                    decimal total = amount + ((amount * interest) / 100);
                    decimal weekly = total / weeks;
                    lblPerWeek.Text = Convert.ToString(String.Format("{0:0.00}", weekly));
                }
            }
            else
            {
                lblPerWeek.Text = "0";
            }
        }

        private void txtInterest_OnValueChanged(object sender, EventArgs e)
        {
            if (txtInterest.Text != "" && txtAmount.Text != "" && txtWeeks.Text != "")
            {
                int weeks = Convert.ToInt32(txtWeeks.Text);
                decimal amount = Convert.ToDecimal(txtAmount.Text);
                int interest = Convert.ToInt32(txtInterest.Text);
                decimal total = amount + ((amount * interest) / 100);
                decimal weekly = total / weeks;
                lblPerWeek.Text = Convert.ToString(String.Format("{0:0.00}", weekly));
            }
            else if (txtWeeks.Text != "")
            {
                int weeks = Convert.ToInt32(txtWeeks.Text);
                decimal amount = Convert.ToDecimal(txtAmount.Text);
                decimal perWeek = amount / weeks;
                lblPerWeek.Text = Convert.ToString(String.Format("{0:0.00}", perWeek));
            }
        }

        private void txtWeeks_OnValueChanged(object sender, EventArgs e)
        {
            if (txtAmount.Text != "" && txtWeeks.Text != "")
            {

                int weeks = Convert.ToInt32(txtWeeks.Text);
                decimal amount = Convert.ToDecimal(txtAmount.Text);
                decimal perWeek = amount / weeks;
                lblPerWeek.Text = Convert.ToString(String.Format("{0:0.00}", perWeek));


                DateTime start = dtpDateReceived.Value;
                DateTime end = start.AddDays(weeks * 7);
                string end1 = end.ToString("dddd, MMMM d, yyyy");
                txtDateEnd.Text = Convert.ToString(end1);
                if (txtInterest.Text != "" && txtAmount.Text != "")
                {
                    int interest = Convert.ToInt32(txtInterest.Text);
                    decimal total = amount + ((amount * interest) / 100);
                    decimal weekly = total / weeks;
                    lblPerWeek.Text = Convert.ToString(String.Format("{0:0.00}", weekly));
                }
            }
            else
            {
                lblPerWeek.Text = "0";
                txtDateEnd.Text = "";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbEmployeeID.SelectedIndex != 0 && txtName.Text != "" && txtAmount.Text != "" && txtInterest.Text != "" && txtDateEnd.Text != "" && txtWeeks.Text != "" & lblPerWeek.Text != "0")
            {
                DateTime start = Convert.ToDateTime(dtpDateReceived.Text);
                DateTime end = Convert.ToDateTime(txtDateEnd.Text);
                String start1 = start.ToString("yyyy/MM/dd");
                String end1 = end.ToString("yyyy/MM/dd");
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "UPDATE company_loan SET employee_id = @id, amount = @amount, interest = @interest, start = @start, week = @week, end = @end, amount_per_week = @perWeek, description = @description " +
                                   "WHERE id = @getID";
                scom.Parameters.AddWithValue("@getID", ID);
                scom.Parameters.AddWithValue("@id", cmbEmployeeID.Text);
                scom.Parameters.AddWithValue("@amount", txtAmount.Text);
                scom.Parameters.AddWithValue("@interest", txtInterest.Text);
                scom.Parameters.AddWithValue("@start", start1);
                scom.Parameters.AddWithValue("@week", txtWeeks.Text);
                scom.Parameters.AddWithValue("@end", end1);
                scom.Parameters.AddWithValue("@perWeek", lblPerWeek.Text);
                scom.Parameters.AddWithValue("@description", txtDescription.Text);
                scom.ExecuteNonQuery();
                conn.Close();
                alert.Show("Successfully Updated.", alert.AlertType.success);
            }
            else
            {
                alert.Show("Please fill in required fields.", alert.AlertType.warning);
            }
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txtInterest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtWeeks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}