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
    public partial class Accountant_Mainform : Form
    {
        public Accountant_Mainform()
        {
            InitializeComponent();
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
                Attendance cash = new Attendance();
                cash.FormBorderStyle = FormBorderStyle.None;
                cash.TopLevel = false;
                cash.AutoScroll = true;
                pnlForm.Controls.Add(cash);
                cash.Show();
            }
            lblTitle.Text = "Attendance";
            btnPhilHealth.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_2;
            btnSSS.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_2;
            btnPagIbig.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_2;
        }

        private void btnDeductions_Click(object sender, EventArgs e)
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
            lblTitle.Text = "PhilHealth";
            btnPhilHealth.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_1;
            btnSSS.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_2;
            btnPagIbig.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_2;
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
            lblTitle.Text = "SSS";
            btnPhilHealth.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_2;
            btnSSS.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_1;
            btnPagIbig.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_2;
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
            lblTitle.Text = "Pag-IBIG";
            btnPhilHealth.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_2;
            btnSSS.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_2;
            btnPagIbig.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_1;
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
                Payroll cash = new Payroll();
                cash.FormBorderStyle = FormBorderStyle.None;
                cash.TopLevel = false;
                cash.AutoScroll = true;
                pnlForm.Controls.Add(cash);
                cash.Show();
            }
            lblTitle.Text = "Payroll";
            btnPhilHealth.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_2;
            btnSSS.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_2;
            btnPagIbig.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_2;
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
                BIR bir = new BIR();
                bir.FormBorderStyle = FormBorderStyle.None;
                bir.TopLevel = false;
                bir.AutoScroll = true;
                pnlForm.Controls.Add(bir);
                bir.Show();
            }
            lblTitle.Text = "BIR Tax";
            btnPhilHealth.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_2;
            btnSSS.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_2;
            btnPagIbig.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_2;
        }

        private void pnlForm_Paint(object sender, PaintEventArgs e)
        {

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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Panel p = pnlForm as Panel;
            if (p != null)
            {
                while (pnlForm.Controls.Count > 0)
                {
                    pnlForm.Controls[0].Dispose();
                }
                Employee_Overtime cash = new Employee_Overtime();
                cash.FormBorderStyle = FormBorderStyle.None;
                cash.TopLevel = false;
                cash.AutoScroll = true;
                pnlForm.Controls.Add(cash);
                cash.Show();
            }
            lblTitle.Text = "Attendance";
            btnPhilHealth.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_2;
            btnSSS.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_2;
            btnPagIbig.Iconimage = Properties.Resources.icons8_unchecked_radio_button_24px_2;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
