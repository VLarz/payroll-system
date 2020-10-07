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
    public partial class Audit_Trail : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = LOCALHOST; USERNAME = root; PASSWORD =; DATABASE = celes_and_lolit-payroll");
        public Audit_Trail()
        {
            InitializeComponent();
            showAttendanceListCurrenDate();
        }
        private void showAttendanceListCurrenDate()
        {
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT userlog.id, user.username, userlog.userlevel, userlog.time_in, userlog.time_out FROM userlog INNER JOIN user ON userlog.user_id = user.id";
            scom.Parameters.AddWithValue("@dateNow", System.DateTime.Now.ToString("yyyy/MM/dd"));
            MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            dgvPayrollList.DataSource = dt;

            if (dgvPayrollList.Rows.Count > 0)
            {
                dgvPayrollList.Rows[0].Selected = false;
            }
        }
    }
}
