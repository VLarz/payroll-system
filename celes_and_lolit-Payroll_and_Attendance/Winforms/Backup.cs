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
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();
        }

        private void picBackupPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBackupPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void BackupDatabase()
        {
            string cn = "SERVER = LOCALHOST; USERNAME = root; PASSWORD =; DATABASE = celes_and_lolit-payroll";
            string file = txtBackupPath.Text + "\\BackupDatabase " + DateTime.Now.ToString("MM-dd-yyyy--HH.mm.ss") + ".sql";
            lblStatus.ForeColor = Color.Green;
            lblStatus.Text = "Backing up Database...";
            using (MySqlConnection conn = new MySqlConnection(cn))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        try
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ExportToFile(file);
                            conn.Close();
                            lblStatus.ForeColor = Color.Green;
                            lblStatus.Text = "Success Backup";
                        }
                        catch (Exception)
                        {
                            lblStatus.ForeColor = Color.Red;
                            lblStatus.Text = "Please select path";
                        }
                    }
                }
            }
        }

        private void RestoreDatabase()
        {
            string cn = "SERVER = LOCALHOST; USERNAME = root; PASSWORD =; DATABASE = celes_and_lolit-payroll";
            string file = txtRestorePath.Text;
            lblStatus.ForeColor = Color.Green;
            lblStatus.Text = "Restoring Database...";
            using (MySqlConnection conn = new MySqlConnection(cn))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        try
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ImportFromFile(file);
                            conn.Close();
                            bunifuCustomLabel4.ForeColor = Color.Green;
                            bunifuCustomLabel4.Text = "Success Restoring";
                        }
                        catch (Exception)
                        {
                            bunifuCustomLabel4.ForeColor = Color.Red;
                            bunifuCustomLabel4.Text = "Please check the .sql file";
                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBackupPath.Text == "Select Path Click The Button >")
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Please Select Path";
            }
            else
            {
                BackupDatabase();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (txtRestorePath.Text == "Select .sql File To Restore >")
            {
                bunifuCustomLabel4.ForeColor = Color.Red;
                bunifuCustomLabel4.Text = "Please select .sql file to restore";
            }
            else
            {
                RestoreDatabase();
            }
        }

        private void picRestorePath_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRestorePath.Text = openFileDialog1.FileName;
            }
        }
    }
}
