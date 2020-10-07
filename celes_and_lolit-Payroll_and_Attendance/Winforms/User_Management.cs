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
    public partial class User_Management : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = LOCALHOST; USERNAME = root; PASSWORD =; DATABASE = celes_and_lolit-payroll");
        public User_Management()
        {
            InitializeComponent();
            showEmployeeList();
        }

        private void AddFormClosing(object sender, FormClosingEventArgs e)
        {
            showEmployeeList();
            if (dgvUserList.Rows.Count > 0)
            {
                dgvUserList.Rows[0].Selected = false;
            }
            //EmployeeID = "";
        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            //EmployeeID = "";
            Add_User add = new Add_User();
            add.FormClosing += new FormClosingEventHandler(AddFormClosing);
            add.Show();
        }

        private void showEmployeeList()
        {
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT id, CONCAT (firstname,' ', middlename,' ', lastname) AS name, contact_number, username, userlevel FROM user";
            MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            dgvUserList.DataSource = dt;

        }

        private void User_Management_Load(object sender, EventArgs e)
        {
            if(dgvUserList.Rows.Count > 0)
            {
                dgvUserList.Rows[0].Selected = false;
            }
            btnAddEmployee.IconZoom = 80;
            btnUpdateEmployee.IconZoom = 75;
        }
    }
}
