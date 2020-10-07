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
    public partial class Cash_Advance : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = LOCALHOST; USERNAME = root; PASSWORD =; DATABASE = celes_and_lolit-payroll");
        public static string CashAdvanceID = "";
        public Cash_Advance()
        {
            InitializeComponent();
            showCashAdvanceList();
        }

        private void showCashAdvanceList()
        {
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT cash_advance.id, cash_advance.employee_id, CONCAT(employee.lastname,', ', employee.firstname,' ',              employee.middlename) AS 'name', cash_advance.amount, cash_advance.interest, cash_advance.start, cash_advance.week, cash_advance.end, cash_advance.amount_per_week, cash_advance.description " +
                               "FROM cash_advance " +
                               "INNER JOIN employee " +
                               "ON cash_advance.employee_id = employee.id";
            MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            dgvCashAdvanceList.DataSource = dt;
        }


        private void AddFormClosing(object sender, FormClosingEventArgs e)
        {
            showCashAdvanceList();
            if (dgvCashAdvanceList.Rows.Count > 0)
            {
                dgvCashAdvanceList.Rows[0].Selected = false;
            }
            CashAdvanceID = "";
        }

        private void btnAddSalaryLoan_Click(object sender, EventArgs e)
        {
            CashAdvanceID = "";
            Add_Cash_Advance add_cash_advance = new Add_Cash_Advance();
            add_cash_advance.FormClosing += new FormClosingEventHandler(AddFormClosing);
            add_cash_advance.Show();
        }

        private void btnUpdateSalaryLoan_Click(object sender, EventArgs e)
        {
            if (CashAdvanceID != "")
            {
                Add_Cash_Advance add_cash_advance = new Add_Cash_Advance();
                add_cash_advance.FormClosing += new FormClosingEventHandler(AddFormClosing);
                add_cash_advance.Show();
            }
            else
            {
                alert.Show("Please select data first.", alert.AlertType.warning);
            }
        }

        private void Cash_Advance_Load(object sender, EventArgs e)
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
                CashAdvanceID = dgvCashAdvanceList.CurrentRow.Cells["id"].Value.ToString();
            }
        }
    }
}
