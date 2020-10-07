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
    public partial class Company_Loan : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = LOCALHOST; USERNAME = root; PASSWORD =; DATABASE = celes_and_lolit-payroll");
        public static string LoanID = "";
        public Company_Loan()
        {
            InitializeComponent();
            showCashAdvanceList();
        }

        private void btnUpdateSalaryLoan_Click(object sender, EventArgs e)
        {
            if (LoanID != "")
            {
                Add_Company_Loan loan = new Add_Company_Loan();
                loan.FormClosing += new FormClosingEventHandler(AddFormClosing);
                loan.Show();
            }
            else
            {
                alert.Show("Please select data first.", alert.AlertType.warning);
            }
        }

        private void AddFormClosing(object sender, FormClosingEventArgs e)
        {
            showCashAdvanceList();
            if (dgvCashAdvanceList.Rows.Count > 0)
            {
                dgvCashAdvanceList.Rows[0].Selected = false;
            }
            LoanID = "";
        }

        private void showCashAdvanceList()
        {
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT company_loan.id, company_loan.employee_id, CONCAT(employee.lastname,', ', employee.firstname,' ', employee.middlename) AS 'name', company_loan.amount, company_loan.interest, company_loan.start, company_loan.week, company_loan.end, company_loan.amount_per_week, company_loan.description " +
                               "FROM company_loan " +
                               "INNER JOIN employee " +
                               "ON company_loan.employee_id = employee.id";
            MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            dgvCashAdvanceList.DataSource = dt;
        }
        private void btnAddSalaryLoan_Click(object sender, EventArgs e)
        {
            LoanID = "";
            Add_Company_Loan loan = new Add_Company_Loan();
            loan.FormClosing += new FormClosingEventHandler(AddFormClosing);
            loan.Show();
        }

        private void Company_Loan_Load(object sender, EventArgs e)
        {
            if (dgvCashAdvanceList.Rows.Count > 0)
            {
                dgvCashAdvanceList.Rows[0].Selected = false;
            }
            btnAddSalaryLoan.IconZoom = 80;
            btnUpdateSalaryLoan.IconZoom = 75;
        }

        private void dgvCashAdvanceList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCashAdvanceList.Rows.Count > 0)
            {
                LoanID = dgvCashAdvanceList.CurrentRow.Cells["id"].Value.ToString();
            }
        }
    }
}
