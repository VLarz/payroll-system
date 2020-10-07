using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace celes_and_lolit_Payroll_and_Attendance.Winforms
{
    public partial class Add_User : Form
    {
        private DPFP.Template RightThumb;
        private DPFP.Template LeftThumb;
        public int RightThumbValid = 0;
        public int LeftThumbValid = 0;
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = celes_and_lolit-payroll");
        public Add_User()
        {
            InitializeComponent();
        }

        private void Right_Thumb(DPFP.Template Right)
        {
            this.Invoke(new Function(delegate ()
            {
                RightThumb = Right;
                //btnAgregar.Enabled = (Template != null);
                if (RightThumb != null)
                {
                    alert.Show("Fingerprint Successfully Verified", alert.AlertType.success);
                    picRightThumb.BackColor = Color.FromArgb(33, 150, 243);
                    RightThumbValid = 1;
                }
                else
                {
                    alert.Show("Fingerprint not Verified", alert.AlertType.warning);
                    picRightThumb.BackColor = Color.FromArgb(255, 0, 0);
                    RightThumbValid = 0;
                }
            }));
        }

        private void Left_Thumb(DPFP.Template Left)
        {
            this.Invoke(new Function(delegate ()
            {
                LeftThumb = Left;
                //btnAgregar.Enabled = (Template != null);
                if (LeftThumb != null)
                {
                    alert.Show("Fingerprint Successfully Verified", alert.AlertType.success);
                    picLeftThumb.BackColor = Color.FromArgb(33, 150, 243);
                    LeftThumbValid = 1;
                }
                else
                {
                    alert.Show("Fingerprint not Verified", alert.AlertType.warning);
                    picLeftThumb.BackColor = Color.FromArgb(255, 0, 0);
                    LeftThumbValid = 0;
                }
            }));
        }

        private void txtConfirm_OnValueChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                if (txtPassword.Text != txtConfirm.Text)
                {
                    lblMatch.Text = "Passwords do not match.";
                    lblMatch.ForeColor = Color.Red;
                }
                else
                {
                    lblMatch.Text = "Passwords match.";
                    lblMatch.ForeColor = Color.Green;
                }
            }
        }

        private void ClearFields()
        {
            
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            dtpBirthDate.Text = System.DateTime.Now.ToString();
            txtContactNumber.Text = "";
            cmbUserLevel.SelectedIndex = -1;
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirm.Text = "";
            picProfilePicture.Image = Properties.Resources.blankimg;
            lblImagePath.Text = "";
            lblMatch.Text = "";
            chkShow.Checked = false;
            txtFirstName.Focus();
        }
        private void InsertFingerPrint()
        {
            byte[] LeftThumb1 = LeftThumb.Bytes;
            byte[] RightThumb1 = RightThumb.Bytes;

            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "INSERT INTO user_fingerprint (user_id, fingerprint, finger) " +
                                "VALUES ((SELECT MAX(id) FROM user), @right, @finger)";
            scom.Parameters.AddWithValue("@right", RightThumb1);
            scom.Parameters.AddWithValue("@finger", "Right");
            scom.ExecuteNonQuery();
            conn.Close();


            conn.Open();
            MySqlCommand scom1 = conn.CreateCommand();
            scom1.CommandText = "INSERT INTO user_fingerprint (user_id, fingerprint, finger) " +
                                "VALUES ((SELECT MAX(id) FROM user), @left, @finger)";
            scom1.Parameters.AddWithValue("@left", LeftThumb1);
            scom1.Parameters.AddWithValue("@finger", "Left");
            scom1.ExecuteNonQuery();
            conn.Close();

            RightThumbValid = 0;
            LeftThumbValid = 0;
            picRightThumb.BackColor = Color.Transparent;
            picLeftThumb.BackColor = Color.Transparent;
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if(chkShow.Checked == true)
            {
                txtPassword.isPassword = false;
                txtConfirm.isPassword = false;
            }
            else
            {
                txtPassword.isPassword = true;
                txtConfirm.isPassword = true;
            }
        }

        private void picLeftThumb_Click(object sender, EventArgs e)
        {
            Fingerprint_Registration fingerprint = new Fingerprint_Registration();
            fingerprint.OnTemplate += this.Left_Thumb;
            fingerprint.ShowDialog();
        }

        private void txtRightThumb_Click(object sender, EventArgs e)
        {
            Fingerprint_Registration fingerprint = new Fingerprint_Registration();
            fingerprint.OnTemplate += this.Right_Thumb;
            fingerprint.ShowDialog();
        }

        private void das_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" && txtMiddleName.Text != "" && txtLastName.Text != "" && txtAddress.Text != "" && cmbUserLevel.Text != "" && txtContactNumber.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && txtConfirm.Text != "" && txtPassword.Text == txtConfirm.Text)
            {
                if (RightThumbValid != 0 && LeftThumbValid != 0)
                {
                    //try
                    //{
                    if (lblImagePath.Text != "")
                    {
                        string FileName = lblImagePath.Text;
                        byte[] ImageData;
                        FileStream fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        ImageData = br.ReadBytes((int)fs.Length);
                        br.Close();
                        fs.Close();
                        String cmdString = "INSERT INTO user (firstname, middlename, lastname, address, birthdate, contact_number, username, password, userlevel, picture) " +
                        "                       VALUES (@fname, @mname, @lname, @address, @birthdate, @contact, @user, @pass, @userlevel, @picture)";
                        MySqlCommand cmd = new MySqlCommand(cmdString, conn);

                        cmd.Parameters.Add("@fname", MySqlDbType.VarChar, 255);
                        cmd.Parameters.Add("@mname", MySqlDbType.VarChar, 255);
                        cmd.Parameters.Add("@lname", MySqlDbType.VarChar, 255);
                        cmd.Parameters.Add("@address", MySqlDbType.VarChar, 255);
                        cmd.Parameters.Add("@birthdate", MySqlDbType.Date);
                        cmd.Parameters.Add("@contact", MySqlDbType.VarChar, 255);
                        cmd.Parameters.Add("@user", MySqlDbType.VarChar, 255);
                        cmd.Parameters.Add("@pass", MySqlDbType.VarChar, 255);
                        cmd.Parameters.Add("@userlevel", MySqlDbType.VarChar, 255);
                        cmd.Parameters.Add("@picture", MySqlDbType.LongBlob);

                        cmd.Parameters["@fname"].Value = txtFirstName.Text;
                        cmd.Parameters["@mname"].Value = txtMiddleName.Text;
                        cmd.Parameters["@lname"].Value = txtLastName.Text;
                        cmd.Parameters["@address"].Value = txtAddress.Text;
                        cmd.Parameters["@birthdate"].Value = dtpBirthDate.Text;
                        cmd.Parameters["@contact"].Value = txtContactNumber.Text;
                        cmd.Parameters["@user"].Value = txtUsername.Text;
                        cmd.Parameters["@pass"].Value = txtPassword.Text;
                        cmd.Parameters["@userlevel"].Value = cmbUserLevel.Text;
                        cmd.Parameters["@picture"].Value = ImageData;

                        conn.Open();
                        int RowsAffected = cmd.ExecuteNonQuery();
                        if (RowsAffected > 0)
                        {
                            alert.Show("Successfully Saved.", alert.AlertType.success);
                        }
                        ClearFields();
                        conn.Close();
                        InsertFingerPrint();

                    }
                    else
                    {
                        String cmdString = "INSERT INTO user (firstname, middlename, lastname, address, birthdate, contact_number, username,  password, userlevel) " +
                        "                       VALUES (@fname, @mname, @lname, @address, @birthdate, @contact, @user, @pass, @userlevel)";
                        MySqlCommand cmd = new MySqlCommand(cmdString, conn);

                        cmd.Parameters.Add("@fname", MySqlDbType.VarChar, 255);
                        cmd.Parameters.Add("@mname", MySqlDbType.VarChar, 255);
                        cmd.Parameters.Add("@lname", MySqlDbType.VarChar, 255);
                        cmd.Parameters.Add("@address", MySqlDbType.VarChar, 255);
                        cmd.Parameters.Add("@birthdate", MySqlDbType.Date);
                        cmd.Parameters.Add("@contact", MySqlDbType.VarChar, 255);
                        cmd.Parameters.Add("@user", MySqlDbType.VarChar, 255);
                        cmd.Parameters.Add("@pass", MySqlDbType.VarChar, 255);
                        cmd.Parameters.Add("@userlevel", MySqlDbType.VarChar, 255);

                        cmd.Parameters["@fname"].Value = txtFirstName.Text;
                        cmd.Parameters["@mname"].Value = txtMiddleName.Text;
                        cmd.Parameters["@lname"].Value = txtLastName.Text;
                        cmd.Parameters["@address"].Value = txtAddress.Text;
                        cmd.Parameters["@birthdate"].Value = dtpBirthDate.Text;
                        cmd.Parameters["@contact"].Value = txtContactNumber.Text;
                        cmd.Parameters["@user"].Value = txtUsername.Text;
                        cmd.Parameters["@pass"].Value = txtPassword.Text;
                        cmd.Parameters["@userlevel"].Value = cmbUserLevel.Text;

                        conn.Open();
                        int RowsAffected = cmd.ExecuteNonQuery();
                        if (RowsAffected > 0)
                        {
                            alert.Show("Successfully Saved.", alert.AlertType.success);
                        }
                        ClearFields();
                        conn.Close();
                        InsertFingerPrint();
                    }
                    //}
                    //catch (Exception a)
                    //{
                    //    MessageBox.Show(a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //}
                }
                else
                {
                    alert.Show("Please input required fingerprint.", alert.AlertType.warning);
                }
            }
            else
            {
                alert.Show("Please fill in required fields.", alert.AlertType.warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void txtBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png| All files(*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filesize = new FileInfo(ofd.FileName);
                    var validFileSize = filesize.Length <= 1024 * 2000;
                    var validDimension = false;

                    using (Image image = Image.FromFile(ofd.FileName))
                    {
                        validDimension = (image.Width >= 200) && (image.Height >= 200);
                    }
                    if (!validDimension || !validFileSize)
                    {
                        alert.Show("Size is invalid.", alert.AlertType.warning);
                    }
                    else
                    {
                        lblImagePath.Text = ofd.FileName;
                        picProfilePicture.Image = Image.FromFile(ofd.FileName);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
