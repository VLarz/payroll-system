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
    public partial class SSS_Loan : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = LOCALHOST; USERNAME = root; PASSWORD =; DATABASE = celes_and_lolit-payroll");
        public static string SalaryID = "";
        public static string CalamityID = "";
        public SSS_Loan()
        {
            InitializeComponent();
            showSSSSalaryLoanList();
            showSSSCalamityLoanList();
        }

        private void AddFormClosing(object sender, FormClosingEventArgs e)
        {
            showSSSSalaryLoanList();
            showSSSCalamityLoanList();
            if (dgvSSSalaryLoan.Rows.Count > 0)
            {
                dgvSSSalaryLoan.Rows[0].Selected = false;
            }

            if (dgvSSSCalamityLoan.Rows.Count > 0)
            {
                dgvSSSCalamityLoan.Rows[0].Selected = false;
            }
            SalaryID = "";
            CalamityID = "";
        }

        private void showSSSSalaryLoanList()
        {
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT sss_salary_loan.id, sss_salary_loan.employee_id, CONCAT(employee.lastname,', ', employee.firstname,' ',              employee.middlename) AS 'name', sss_salary_loan.amount, sss_salary_loan.start, sss_salary_loan.end, sss_salary_loan.amount_per_month, sss_salary_loan.amount_per_week " +
                               "FROM sss_salary_loan " +
                               "INNER JOIN employee " +
                               "ON sss_salary_loan.employee_id = employee.id";
            MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            dgvSSSalaryLoan.DataSource = dt;
        }

        private void showSSSCalamityLoanList()
        {
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT sss_calamity_loan.id, sss_calamity_loan.employee_id, CONCAT(employee.lastname,', ', employee.firstname,' ',              employee.middlename) AS 'name', sss_calamity_loan.amount, sss_calamity_loan.start, sss_calamity_loan.end, sss_calamity_loan.amount_per_month, sss_calamity_loan.amount_per_week " +
                               "FROM sss_calamity_loan " +
                               "INNER JOIN employee " +
                               "ON sss_calamity_loan.employee_id = employee.id";
            MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            dgvSSSCalamityLoan.DataSource = dt;
        }

        private void SSS_Salary_Loan_Load(object sender, EventArgs e)
        {
            if (dgvSSSalaryLoan.Rows.Count > 0)
            {
                dgvSSSalaryLoan.Rows[0].Selected = false;
            }

            if (dgvSSSCalamityLoan.Rows.Count > 0)
            {
                dgvSSSCalamityLoan.Rows[0].Selected = false;
            }
            btnAddSalaryLoan.IconZoom = 80;
            btnUpdateSalaryLoan.IconZoom = 75;
            btnAddCalamityLoan.IconZoom = 80;
            btnUpdateCalamityLoan.IconZoom = 75;
        }

        private void dgvSSSalaryLoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabSSSLoan_Click(object sender, EventArgs e)
        {
            indicator.Location = new Point(17, 41);
            pnlSalaryLoan.BringToFront();
            tabSSSLoan.Normalcolor = Color.White;
            tabSSSCalamity.Normalcolor = Color.FromArgb(242, 242, 242);
        }

        private void tabSSSCalamity_Click(object sender, EventArgs e)
        {
            indicator.Location = new Point(180, 41);
            pnlCalamityLoan.BringToFront();
            tabSSSLoan.Normalcolor = Color.FromArgb(242, 242, 242);
            tabSSSCalamity.Normalcolor = Color.White;
        }

        private void dgvSSSalaryLoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSSSalaryLoan.Rows.Count > 0)
            {
                SalaryID = dgvSSSalaryLoan.CurrentRow.Cells["id"].Value.ToString();           
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddSalaryLoan_Click(object sender, EventArgs e)
        {
            SalaryID = "";
            Add_SSS_Salary_Loan add_salary = new Add_SSS_Salary_Loan();
            add_salary.FormClosing += new FormClosingEventHandler(AddFormClosing);
            add_salary.Show();   
        }

        private void btnUpdateSalaryLoan_Click(object sender, EventArgs e)
        {
            if(SalaryID != "")
            {
                Add_SSS_Salary_Loan add_salary = new Add_SSS_Salary_Loan();
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
            showSSSSalaryLoanList();
            showSSSCalamityLoanList();
            CalamityID = "";
            SalaryID = "";
            Add_SSS_Calamity_Loan add_calamity = new Add_SSS_Calamity_Loan();
            add_calamity.FormClosing += new FormClosingEventHandler(AddFormClosing);
            add_calamity.Show();
        }

        private void dgvSSSCalamityLoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSSSCalamityLoan.Rows.Count > 0)
            {
                CalamityID = dgvSSSCalamityLoan.CurrentRow.Cells["id1"].Value.ToString();
            }
        }

        private void btnUpdateCalamityLoan_Click(object sender, EventArgs e)
        {
            if(CalamityID != "")
            {
                Add_SSS_Calamity_Loan add_calamity = new Add_SSS_Calamity_Loan();
                add_calamity.FormClosing += new FormClosingEventHandler(AddFormClosing);
                add_calamity.Show();
            }
            else
            {
                alert.Show("Please select employee first.", alert.AlertType.warning);
            }
        }
    }
}
