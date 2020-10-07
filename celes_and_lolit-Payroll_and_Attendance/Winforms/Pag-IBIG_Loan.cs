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
    public partial class Pag_IBIG_Loan : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = LOCALHOST; USERNAME = root; PASSWORD =; DATABASE = celes_and_lolit-payroll");
        public static string SalaryID = "";
        public static string CalamityID = "";
        public Pag_IBIG_Loan()
        {
            InitializeComponent();
            showPagIBIGSalaryLoanList();
            showPagIBIGCalamityLoanList();
        }

        private void AddFormClosing(object sender, FormClosingEventArgs e)
        {
            showPagIBIGSalaryLoanList();
            showPagIBIGCalamityLoanList();
            CalamityID = "";
            SalaryID = "";
            if (dgvPagIBIGSalaryLoan.Rows.Count > 0)
            {
                dgvPagIBIGSalaryLoan.Rows[0].Selected = false;
            }

            if (dgvPagIBIGCalamityLoan.Rows.Count > 0)
            {
                dgvPagIBIGCalamityLoan.Rows[0].Selected = false;
            }
        }

        private void showPagIBIGSalaryLoanList()
        {
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT pagibig_salary_loan.id, pagibig_salary_loan.employee_id, CONCAT(employee.lastname,', ', employee.firstname,' ',              employee.middlename) AS 'name', pagibig_salary_loan.amount, pagibig_salary_loan.start, pagibig_salary_loan.end, pagibig_salary_loan.amount_per_month, pagibig_salary_loan.amount_per_week " +
                               "FROM pagibig_salary_loan " +
                               "INNER JOIN employee " +
                               "ON pagibig_salary_loan.employee_id = employee.id " +
                               "WHERE pagibig_salary_loan.end >= @date";
            scom.Parameters.AddWithValue("@date", System.DateTime.Now.ToString("yyyy/MM/dd"));
            MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            dgvPagIBIGSalaryLoan.DataSource = dt;
        }

        private void showPagIBIGCalamityLoanList()
        {
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT pagibig_calamity_loan.id, pagibig_calamity_loan.employee_id, CONCAT(employee.lastname,', ', employee.firstname,' ',              employee.middlename) AS 'name', pagibig_calamity_loan.amount, pagibig_calamity_loan.start, pagibig_calamity_loan.end, pagibig_calamity_loan.amount_per_month, pagibig_calamity_loan.amount_per_week " +
                               "FROM pagibig_calamity_loan " +
                               "INNER JOIN employee " +
                               "ON pagibig_calamity_loan.employee_id = employee.id " +
                               "WHERE pagibig_calamity_loan.end >= @date";
            scom.Parameters.AddWithValue("@date", System.DateTime.Now.ToString("yyyy/MM/dd"));
            MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            dgvPagIBIGCalamityLoan.DataSource = dt;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pag_IBIG_Loan_Load(object sender, EventArgs e)
        {
            if (dgvPagIBIGSalaryLoan.Rows.Count > 0)
            {
                dgvPagIBIGSalaryLoan.Rows[0].Selected = false;
            }

            if (dgvPagIBIGCalamityLoan.Rows.Count > 0)
            {
                dgvPagIBIGCalamityLoan.Rows[0].Selected = false;
            }
            btnAddSalaryLoan.IconZoom = 80;
            btnUpdateSalaryLoan.IconZoom = 75;
            btnAddCalamityLoan.IconZoom = 80;
            btnUpdateCalamityLoan.IconZoom = 75;
        }

        private void tabPagIbigSalary_Click(object sender, EventArgs e)
        {
            indicator.Location = new Point(20, 41);
            pnlSalaryLoan.BringToFront();
            tabPagIbigSalary.Normalcolor = Color.White;
            tabPagIbigCalamity.Normalcolor = Color.FromArgb(242, 242, 242);
        }

        private void tabPagIbigCalamity_Click(object sender, EventArgs e)
        {
            indicator.Location = new Point(186, 41);
            pnlCalamityLoan.BringToFront();
            tabPagIbigSalary.Normalcolor = Color.FromArgb(242, 242, 242);
            tabPagIbigCalamity.Normalcolor = Color.White;         
        }

        private void dgvPagIBIGSalaryLoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPagIBIGSalaryLoan.Rows.Count > 0)
            {
                SalaryID = dgvPagIBIGSalaryLoan.CurrentRow.Cells["id"].Value.ToString();
            }
        }

        private void dgvPagIBIGCalamityLoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPagIBIGCalamityLoan.Rows.Count > 0)
            {
                CalamityID = dgvPagIBIGCalamityLoan.CurrentRow.Cells["id1"].Value.ToString();
            }
        }

        private void btnAddSalaryLoan_Click(object sender, EventArgs e)
        {
            SalaryID = "";
            Add_Pag_IBIG_Salary_Loan add_salary = new Add_Pag_IBIG_Salary_Loan();
            add_salary.FormClosing += new FormClosingEventHandler(AddFormClosing);
            add_salary.Show();
        }

        private void btnUpdateSalaryLoan_Click(object sender, EventArgs e)
        {
            if(SalaryID != "")
            {
                Add_Pag_IBIG_Salary_Loan add_salary = new Add_Pag_IBIG_Salary_Loan();
                add_salary.FormClosing += new FormClosingEventHandler(AddFormClosing);
                add_salary.Show();
            }
            else
            {
                alert.Show("Please select employee first.", alert.AlertType.warning);
            }
           
        }

        private void btnAddCalamityLoan_Click(object sender, EventArgs e)
        {
            CalamityID = "";
            Add_Pag_IBIG_Calamity_Loan add_calamity = new Add_Pag_IBIG_Calamity_Loan();
            add_calamity.FormClosing += new FormClosingEventHandler(AddFormClosing);
            add_calamity.Show();
        }

        private void btnUpdateCalamityLoan_Click(object sender, EventArgs e)
        {
            if(CalamityID != "")
            {
                Add_Pag_IBIG_Calamity_Loan add_calamity = new Add_Pag_IBIG_Calamity_Loan();
                add_calamity.FormClosing += new FormClosingEventHandler(AddFormClosing);
                add_calamity.Show();
            }
            else
            {
                alert.Show("Please select employee first.", alert.AlertType.warning);
            }
           
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {

        }

        private void ossShowLoan_OnValueChange(object sender, EventArgs e)
        {
            if (ossShowLoan.Value == true)
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT pagibig_salary_loan.id, pagibig_salary_loan.employee_id, CONCAT(employee.lastname,', ', employee.firstname,' ',              employee.middlename) AS 'name', pagibig_salary_loan.amount, pagibig_salary_loan.start, pagibig_salary_loan.end, pagibig_salary_loan.amount_per_month, pagibig_salary_loan.amount_per_week " +
                                   "FROM pagibig_salary_loan " +
                                   "INNER JOIN employee " +
                                   "ON pagibig_salary_loan.employee_id = employee.id " +
                                   "WHERE pagibig_salary_loan.end < @date";
                scom.Parameters.AddWithValue("@date", System.DateTime.Now.ToString("yyyy/MM/dd"));
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();
                dgvPagIBIGSalaryLoan.DataSource = dt;
                
                if(dgvPagIBIGSalaryLoan.Rows.Count > 0)
                {
                    dgvPagIBIGSalaryLoan.Rows[0].Selected = false;
                }
            }
            else
            {
                showPagIBIGSalaryLoanList();
                if (dgvPagIBIGSalaryLoan.Rows.Count > 0)
                {
                    dgvPagIBIGSalaryLoan.Rows[0].Selected = false;
                }
            }
        }

        private void ossShowCalamity_OnValueChange(object sender, EventArgs e)
        {
            if (ossShowCalamity.Value == true)
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT pagibig_calamity_loan.id, pagibig_calamity_loan.employee_id, CONCAT(employee.lastname,', ', employee.firstname,' ',              employee.middlename) AS 'name', pagibig_calamity_loan.amount, pagibig_calamity_loan.start, pagibig_calamity_loan.end, pagibig_calamity_loan.amount_per_month, pagibig_calamity_loan.amount_per_week " +
                                   "FROM pagibig_calamity_loan " +
                                   "INNER JOIN employee " +
                                   "ON pagibig_calamity_loan.employee_id = employee.id " +
                                   "WHERE pagibig_calamity_loan.end < @date";
                scom.Parameters.AddWithValue("@date", System.DateTime.Now.ToString("yyyy/MM/dd"));
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();
                dgvPagIBIGCalamityLoan.DataSource = dt;

                if (dgvPagIBIGCalamityLoan.Rows.Count > 0)
                {
                    dgvPagIBIGCalamityLoan.Rows[0].Selected = false;
                }
            }
            else
            {
                showPagIBIGCalamityLoanList();
                if (dgvPagIBIGCalamityLoan.Rows.Count > 0)
                {
                    dgvPagIBIGCalamityLoan.Rows[0].Selected = false;
                }
            }
        }
    }
}
