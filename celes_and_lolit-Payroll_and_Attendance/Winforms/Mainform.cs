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
    public partial class Mainform : Form
    {
        public object Dispatcher { get; internal set; }

        public Mainform()
        {
            InitializeComponent();
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
            Panel p = pnlForm as Panel;

            if (p != null)
            {
                while (pnlForm.Controls.Count > 0)
                {
                    pnlForm.Controls[0].Dispose();
                }

                Dashboard dash = new Dashboard();
                dash.FormBorderStyle = FormBorderStyle.None;
                dash.TopLevel = false;
                dash.AutoScroll = true;
                pnlForm.Controls.Add(dash);
                dash.Show();
            }
        }
        private void btnDeductions_Click(object sender, EventArgs e)
        {
            //Panel p = pnlForm as Panel;
            //if (p != null)
            //{
            //    while (pnlForm.Controls.Count > 0)
            //    {
            //        pnlForm.Controls[0].Dispose();
            //    }

            //    PhilHealth deduct = new PhilHealth();
            //    deduct.FormBorderStyle = FormBorderStyle.None;
            //    deduct.TopLevel = false;
            //    deduct.AutoScroll = true;
            //    pnlForm.Controls.Add(deduct);
            //    deduct.Show();
            //}
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
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Panel p = pnlForm as Panel;
            if (p != null)
            {
                while (pnlForm.Controls.Count > 0)
                {
                    pnlForm.Controls[0].Dispose();
                }

                Dashboard dash = new Dashboard();
                dash.FormBorderStyle = FormBorderStyle.None;
                dash.TopLevel = false;
                dash.AutoScroll = true;
                pnlForm.Controls.Add(dash);
                dash.Show();
            }
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

                Position pos = new Position();
                pos.FormBorderStyle = FormBorderStyle.None;
                pos.TopLevel = false;
                pos.AutoScroll = true;
                pnlForm.Controls.Add(pos);
                pos.Show();
            }
        }

        private void btnPhilHealth_Click(object sender, EventArgs e)
        {
            Panel p = pnlForm as Panel;
            if (p != null)
            {
                while (pnlForm.Controls.Count > 0)
                {
                    pnlForm.Controls[0].Dispose();
                }

                PhilHealth phil = new PhilHealth();
                phil.FormBorderStyle = FormBorderStyle.None;
                phil.TopLevel = false;
                phil.AutoScroll = true;
                pnlForm.Controls.Add(phil);
                phil.Show();
            }
        }

        private void btnSSS_Click(object sender, EventArgs e)
        {
            Panel p = pnlForm as Panel;
            if (p != null)
            {
                while (pnlForm.Controls.Count > 0)
                {
                    pnlForm.Controls[0].Dispose();
                }

                SSS sss = new SSS();
                sss.FormBorderStyle = FormBorderStyle.None;
                sss.TopLevel = false;
                sss.AutoScroll = true;
                pnlForm.Controls.Add(sss);
                sss.Show();
            }
        }

        private void btnPagIbig_Click(object sender, EventArgs e)
        {
            Panel p = pnlForm as Panel;
            if (p != null)
            {
                while (pnlForm.Controls.Count > 0)
                {
                    pnlForm.Controls[0].Dispose();
                }

                Pag_IBIG ibig = new Pag_IBIG();
                ibig.FormBorderStyle = FormBorderStyle.None;
                ibig.TopLevel = false;
                ibig.AutoScroll = true;
                pnlForm.Controls.Add(ibig);
                ibig.Show();
            }
        }

        private void btnDeductions_Click_1(object sender, EventArgs e)
        {
            if (pnlDeductions.Height == 0)
            {
                pnlDeductions.Height = 115;
                PanelAnimator.ShowSync(pnlDeductions);
                btnDeductions.Iconimage_right = Properties.Resources.down;

            }
            else
            {
                PanelAnimator.HideSync(pnlDeductions);
                pnlDeductions.Height = 0;
                btnDeductions.Iconimage_right = Properties.Resources.right;
            }
        }

        private void btnPositions_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            //Panel p = pnlForm as Panel;
            //if (p != null)
            //{
            //    while (pnlForm.Controls.Count > 0)
            //    {
            //        pnlForm.Controls[0].Dispose();
            //    }
            //    Salary sal = new Salary();
            //    sal.FormBorderStyle = FormBorderStyle.None;
            //    sal.TopLevel = false;
            //    sal.AutoScroll = true;
            //    pnlForm.Controls.Add(sal);
            //    sal.Show();
            //}
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            Panel p = pnlForm as Panel;
            if (p != null)
            {
                while (pnlForm.Controls.Count > 0)
                {
                    pnlForm.Controls[0].Dispose();
                }
                Payroll pay = new Payroll();
                pay.FormBorderStyle = FormBorderStyle.None;
                pay.TopLevel = false;
                pay.AutoScroll = true;
                pnlForm.Controls.Add(pay);
                pay.Show();
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            Panel p = pnlForm as Panel;
            if (p != null)
            {
                while (pnlForm.Controls.Count > 0)
                {
                    pnlForm.Controls[0].Dispose();
                }
                Attendance attend = new Attendance();
                attend.FormBorderStyle = FormBorderStyle.None;
                attend.TopLevel = false;
                attend.AutoScroll = true;
                pnlForm.Controls.Add(attend);
                attend.Show();
            }
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
        }

        private void btnAttendance_Click_1(object sender, EventArgs e)
        {
            Panel p = pnlForm as Panel;
            if (p != null)
            {
                while (pnlForm.Controls.Count > 0)
                {
                    pnlForm.Controls[0].Dispose();
                }
                Attendance cash = new Attendance();
                cash.FormBorderStyle = FormBorderStyle.None;
                cash.TopLevel = false;
                cash.AutoScroll = true;
                pnlForm.Controls.Add(cash);
                cash.Show();
            }
        }

        private void btnPayroll_Click_1(object sender, EventArgs e)
        {
            Panel p = pnlForm as Panel;
            if (p != null)
            {
                while (pnlForm.Controls.Count > 0)
                {
                    pnlForm.Controls[0].Dispose();
                }
                Payroll cash = new Payroll();
                cash.FormBorderStyle = FormBorderStyle.None;
                cash.TopLevel = false;
                cash.AutoScroll = true;
                pnlForm.Controls.Add(cash);
                cash.Show();
            }
        }

        private void btnBIR_Click(object sender, EventArgs e)
        {
            Panel p = pnlForm as Panel;
            if (p != null)
            {
                while (pnlForm.Controls.Count > 0)
                {
                    pnlForm.Controls[0].Dispose();
                }
                BIR cash = new BIR();
                cash.FormBorderStyle = FormBorderStyle.None;
                cash.TopLevel = false;
                cash.AutoScroll = true;
                pnlForm.Controls.Add(cash);
                cash.Show();
            }
        }

        private void btnPositions_Click_2(object sender, EventArgs e)
        {
            Panel p = pnlForm as Panel;
            if (p != null)
            {
                while (pnlForm.Controls.Count > 0)
                {
                    pnlForm.Controls[0].Dispose();
                }
                Position cash = new Position();
                cash.FormBorderStyle = FormBorderStyle.None;
                cash.TopLevel = false;
                cash.AutoScroll = true;
                pnlForm.Controls.Add(cash);
                cash.Show();
            }
        }

        private void pnlForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
