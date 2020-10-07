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
    public partial class Manager_Mainform : Form
    {
        public Manager_Mainform()
        {
            InitializeComponent();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            if (pnlLoan.Height == 0)
            {
                pnlLoan.Height = 76;
                PanelAnimator.ShowSync(pnlLoan);
                btnLoan.Iconimage_right = Properties.Resources.down;

            }
            else
            {
                PanelAnimator.HideSync(pnlLoan);
                pnlLoan.Height = 0;
                btnLoan.Iconimage_right = Properties.Resources.right;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Dashboard";
        }

        private void btnCashAdvance_Click(object sender, EventArgs e)
        {
            Panel p = pnlForm as Panel;
            if (p != null)
            {
                while (pnlForm.Controls.Count > 0)
                {
                    pnlForm.Controls[0].Dispose();
                }
                Cash_Advance cash = new Cash_Advance();
                cash.FormBorderStyle = FormBorderStyle.None;
                cash.TopLevel = false;
                cash.AutoScroll = true;
                pnlForm.Controls.Add(cash);
                cash.Show();
            }
            lblTitle.Text = "Cash Advance";
            btnPagIBIGLoan.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_2;
            btnSSSLoan.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_2;
        }

        private void btnPagIBIGLoan_Click(object sender, EventArgs e)
        {
            Panel p = pnlForm as Panel;
            if (p != null)
            {
                while (pnlForm.Controls.Count > 0)
                {
                    pnlForm.Controls[0].Dispose();
                }
                Pag_IBIG_Loan PagIBIGLoan = new Pag_IBIG_Loan();
                PagIBIGLoan.FormBorderStyle = FormBorderStyle.None;
                PagIBIGLoan.TopLevel = false;
                PagIBIGLoan.AutoScroll = true;
                pnlForm.Controls.Add(PagIBIGLoan);
                PagIBIGLoan.Show();
            }
            lblTitle.Text = "Pag-IBIG Loan";
            btnPagIBIGLoan.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_1;
            btnSSSLoan.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_2;
        }

        private void btnSSSLoan_Click(object sender, EventArgs e)
        {
            Panel p = pnlForm as Panel;
            if (p != null)
            {
                while (pnlForm.Controls.Count > 0)
                {
                    pnlForm.Controls[0].Dispose();
                }
                SSS_Loan SSSLoan = new SSS_Loan();
                SSSLoan.FormBorderStyle = FormBorderStyle.None;
                SSSLoan.TopLevel = false;
                SSSLoan.AutoScroll = true;
                pnlForm.Controls.Add(SSSLoan);
                SSSLoan.Show();
            }
            lblTitle.Text = "SSS Loan";
            btnSSSLoan.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_1;
            btnPagIBIGLoan.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_2;
        }

        private void btnCompanyLoan_Click(object sender, EventArgs e)
        {
            Panel p = pnlForm as Panel;
            if (p != null)
            {
                while (pnlForm.Controls.Count > 0)
                {
                    pnlForm.Controls[0].Dispose();
                }
                Company_Loan loan = new Company_Loan();
                loan.FormBorderStyle = FormBorderStyle.None;
                loan.TopLevel = false;
                loan.AutoScroll = true;
                pnlForm.Controls.Add(loan);
                loan.Show();
            }
            lblTitle.Text = "Company Loan";
            btnPagIBIGLoan.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_2;
            btnSSSLoan.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_2;
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHoliday_Click(object sender, EventArgs e)
        {
            Panel p = pnlForm as Panel;
            if (p != null)
            {
                while (pnlForm.Controls.Count > 0)
                {
                    pnlForm.Controls[0].Dispose();
                }
                Holiday holiday = new Holiday();
                holiday.FormBorderStyle = FormBorderStyle.None;
                holiday.TopLevel = false;
                holiday.AutoScroll = true;
                pnlForm.Controls.Add(holiday);
                holiday.Show();
            }
            lblTitle.Text = "Holiday";
            btnPagIBIGLoan.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_2;
            btnSSSLoan.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_2;
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            Panel p = pnlForm as Panel;
            if (p != null)
            {
                while (pnlForm.Controls.Count > 0)
                {
                    pnlForm.Controls[0].Dispose();
                }
                Leave leave = new Leave();
                leave.FormBorderStyle = FormBorderStyle.None;
                leave.TopLevel = false;
                leave.AutoScroll = true;
                pnlForm.Controls.Add(leave);
                leave.Show();
            }
            lblTitle.Text = "Leave";
            btnPagIBIGLoan.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_2;
            btnSSSLoan.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_2;
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Panel p = pnlForm as Panel;
            if (p != null)
            {
                while (pnlForm.Controls.Count > 0)
                {
                    pnlForm.Controls[0].Dispose();
                }
                Reports leave = new Reports();
                leave.FormBorderStyle = FormBorderStyle.None;
                leave.TopLevel = false;
                leave.AutoScroll = true;
                pnlForm.Controls.Add(leave);
                leave.Show();
            }
            lblTitle.Text = "Report";
            btnPagIBIGLoan.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_2;
            btnSSSLoan.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_2;
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
            btnPagIBIGLoan.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_2;
            btnSSSLoan.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_2;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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
