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
    public partial class Employees : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = LOCALHOST; USERNAME = root; PASSWORD =; DATABASE = celes_and_lolit-payroll");
        public static string EmployeeID = "";
        public Employees()
        {
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(pnlEmployee, 5);
            showEmployeeList();
        }

        private void showEmployeeList()
        {
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT employee.id, CONCAT (firstname,' ', middlename,' ', lastname) AS name, address, birthdate, date_hired,                            position.description, salary.rate ,contact_number " +
                               "FROM employee " +
                               "INNER JOIN position " +
                               "ON employee.position_id = position.id " +
                               "INNER JOIN salary " +
                               "ON employee.salary_id = salary.id " +
                               "WHERE active = 1";
            MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            dgvEmployeeList.DataSource = dt;

        }

        private void AddFormClosing(object sender, FormClosingEventArgs e)
        {
            showEmployeeList();
            if (dgvEmployeeList.Rows.Count > 0)
            {
                dgvEmployeeList.Rows[0].Selected = false;
            }
            EmployeeID = "";
        }
        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            if (dgvEmployeeList.Rows.Count > 0)
            {
                dgvEmployeeList.Rows[0].Selected = false;
            }
            btnAddEmployee.IconZoom = 80;
            btnUpdateEmployee.IconZoom = 75;    
        }

        private void pnlEmployee_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            Add_Employee add = new Add_Employee();
            add.Show();
            //Panel p = pnlForm as Panel;
            //if (p != null)
            //{
            //    while (pnlForm.Controls.Count > 0)
            //    {
            //        pnlForm.Controls[0].Dispose();
            //    }

            //    Dashboard dash = new Dashboard();
            //    dash.FormBorderStyle = FormBorderStyle.None;
            //    dash.TopLevel = false;
            //    dash.AutoScroll = true;
            //    pnlForm.Controls.Add(dash);
            //    dash.Show();
            //}
        }

        private void btnAddEmployee_Click_1(object sender, EventArgs e)
        {
            EmployeeID = "";
            Add_Employee add = new Add_Employee();
            add.FormClosing += new FormClosingEventHandler(AddFormClosing);
            add.Show();
        }

        private void dgvEmployeeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmployeeList.Rows.Count > 0)
            {
                EmployeeID = dgvEmployeeList.CurrentRow.Cells["id"].Value.ToString();
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (EmployeeID != "")
            {
                Add_Employee add = new Add_Employee();
                add.FormClosing += new FormClosingEventHandler(AddFormClosing);
                add.Show();
            }
            else
            {
                alert.Show("Please select employee first.", alert.AlertType.warning);
            }
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            if (EmployeeID != "")
            {
                DialogResult ask = MessageBox.Show("Are you sure you want to archive?", "Archive Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "UPDATE employee SET active = 0";
                    scom.ExecuteNonQuery();
                    conn.Close();
                    alert.Show("Successfully Archived.", alert.AlertType.success);
                    showEmployeeList();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT employee.id, CONCAT (firstname,' ', middlename,' ', lastname) AS name, address, birthdate, date_hired,                            position.description, contact_number " +
                                   "FROM employee " +
                                   "INNER JOIN position " +
                                   "ON employee.position_id = position.id " +
                                   "WHERE employee.lastname LIKE'%" + txtSearch.Text + "%' AND active = 1";
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();
                dgvEmployeeList.DataSource = dt;
            }
            else if(txtSearch.Text == "")
            {
                showEmployeeList();
            }
        }
    }
}



