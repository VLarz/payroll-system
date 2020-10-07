using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace celes_and_lolit_Payroll_and_Attendance.Winforms
{
    public partial class Admin_Mainform : Form
    {
        public Admin_Mainform()
        {
            InitializeComponent();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            Panel p = pnlForm as Panel;
            if (p != null)
            {
                while (pnlForm.Controls.Count > 0)
                {
                    pnlForm.Controls[0].Dispose();
                }
                Employees emp = new Employees();
                emp.FormBorderStyle = FormBorderStyle.None;
                emp.TopLevel = false;
                emp.AutoScroll = true;
                pnlForm.Controls.Add(emp);
                emp.Show();
            }
            lblTitle.Text = "Employees";
        }

        private void btnPositions_Click(object sender, EventArgs e)
        {
            Panel p = pnlForm as Panel;
            if (p != null)
            {
                while (pnlForm.Controls.Count > 0)
                {
                    pnlForm.Controls[0].Dispose();
                }
                Position position = new Position();
                position.FormBorderStyle = FormBorderStyle.None;
                position.TopLevel = false;
                position.AutoScroll = true;
                pnlForm.Controls.Add(position);
                position.Show();
            }
            lblTitle.Text = "Position";
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            Panel p = pnlForm as Panel;
            if (p != null)
            {
                while (pnlForm.Controls.Count > 0)
                {
                    pnlForm.Controls[0].Dispose();
                }
                Backup backup = new Backup();
                backup.FormBorderStyle = FormBorderStyle.None;
                backup.TopLevel = false;
                backup.AutoScroll = true;
                pnlForm.Controls.Add(backup);
                backup.Show();
            }
            lblTitle.Text = "Backup and Restore";
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            Panel p = pnlForm as Panel;
            if (p != null)
            {
                while (pnlForm.Controls.Count > 0)
                {
                    pnlForm.Controls[0].Dispose();
                }
                User_Management user = new User_Management();
                user.FormBorderStyle = FormBorderStyle.None;
                user.TopLevel = false;
                user.AutoScroll = true;
                pnlForm.Controls.Add(user);
                user.Show();
            }
            lblTitle.Text = "User Management";
        }

        private void btnAuditTrail_Click(object sender, EventArgs e)
        {
            Panel p = pnlForm as Panel;
            if (p != null)
            {
                while (pnlForm.Controls.Count > 0)
                {
                    pnlForm.Controls[0].Dispose();
                }
                Audit_Trail user = new Audit_Trail();
                user.FormBorderStyle = FormBorderStyle.None;
                user.TopLevel = false;
                user.AutoScroll = true;
                pnlForm.Controls.Add(user);
                user.Show();
            }
            lblTitle.Text = "Audit Trail";
        }

        private void picLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Log Out", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login log = new Login();
                log.Show();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
