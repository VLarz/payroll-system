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
    public partial class Add_Employee : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = celes_and_lolit-payroll");
        private DPFP.Template RightThumb;
        private DPFP.Template LeftThumb;
        public int RightThumbValid = 0;
        public int LeftThumbValid = 0;
        public string position = "";
        public string salary = "";
        string getID;
        string EmployeeID = "";
        public Add_Employee()
        {
            InitializeComponent();
            EmployeeID = Employees.EmployeeID;
            if (EmployeeID != "")
            {
                btnUpdate.Visible = true;
                getEmployeeInformation();
                lblTitle.Text = "Update Employee";
                getPosition();
                cmbPosition.Text = position;
                cmbSalary.Text = salary;
            }
            else
            {
                getPosition();
            }
        }

        private void getEmployeeInformation()
        {        
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT employee.firstname, employee.middlename, employee.lastname, employee.address, employee.birthdate, employee.date_hired, employee.contact_number, position.description, salary.rate, employee.philhealth_number, employee.sss_number, employee.pagibig_number, employee.picture " +
                               "FROM employee " +
                               "INNER JOIN position " +
                               "ON employee.position_id = position.id " +
                               "INNER JOIN salary " +
                               "ON employee.salary_id = salary.id " +
                               "WHERE employee.id = @id";
            scom.Parameters.AddWithValue("@id", EmployeeID);
            MySqlDataReader sdr = scom.ExecuteReader();
            while (sdr.Read())
            {
                txtFirstName.Text = sdr["firstname"].ToString();
                txtMiddleName.Text = sdr["middlename"].ToString();
                txtLastName.Text = sdr["lastname"].ToString();
                txtAddress.Text = sdr["address"].ToString();
                txtAddress.Text = sdr["address"].ToString();
                dtpBirthDate.Text = sdr["birthdate"].ToString();
                dtpDateHired.Text = sdr["date_hired"].ToString();
                txtContactNumber.Text = sdr["contact_number"].ToString();
                position = sdr["description"].ToString();
                salary = sdr["rate"].ToString();
                txtPhilHealth.Text = sdr["philhealth_number"].ToString();
                txtSSS.Text = sdr["sss_number"].ToString();
                txtPagIbig.Text = sdr["pagibig_number"].ToString();

                if (sdr["picture"] != DBNull.Value)
                {
                    byte[] pic = (byte[])sdr["picture"];
                    MemoryStream ms = new MemoryStream(pic);
                    picProfilePicture.Image = Image.FromStream(ms);
                }
            }
            conn.Close();
            sdr.Close();
        }

        private void InsertFingerPrint()
        {
            byte[] LeftThumb1 = LeftThumb.Bytes;
            byte[] RightThumb1 = RightThumb.Bytes;

            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "INSERT INTO fingerprint (employee_id, fingerprint, finger) " +
                                "VALUES (@id, @right, @finger)";
            scom.Parameters.AddWithValue("@id", getID);
            scom.Parameters.AddWithValue("@right", RightThumb1);
            scom.Parameters.AddWithValue("@finger", "Right");
            scom.ExecuteNonQuery();
            conn.Close();


            conn.Open();
            MySqlCommand scom1 = conn.CreateCommand();
            scom1.CommandText = "INSERT INTO fingerprint (employee_id, fingerprint, finger) " +
                                "VALUES (@id, @left, @finger)";
            scom1.Parameters.AddWithValue("@id", getID);
            scom1.Parameters.AddWithValue("@left", LeftThumb1);
            scom1.Parameters.AddWithValue("@finger", "Left");
            scom1.ExecuteNonQuery();
            conn.Close();
            RightThumbValid = 0;
            LeftThumbValid = 0;
            picRightThumb.BackColor = Color.Transparent;
            picLeftThumb.BackColor = Color.Transparent;
        }

        private void Right_Thumb(DPFP.Template Right)
        {
            this.Invoke(new Function(delegate ()
            {
                RightThumb = Right;
                //btnAgregar.Enabled = (Template != null);
                if (RightThumb != null)
                {
                    alert.Show("Fingerprint successfully verified", alert.AlertType.success); ;
                    picRightThumb.BackColor = Color.FromArgb(33, 150, 243);
                    RightThumbValid = 1;
                }
                else
                {
                    alert.Show("Fingerprint not Verified", alert.AlertType.success);
                    picRightThumb.BackColor = Color.FromArgb(255,0,0);
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
                    alert.Show("Fingerprint successfully verified", alert.AlertType.success);
                    picLeftThumb.BackColor = Color.FromArgb(33, 150, 243);
                    LeftThumbValid = 1;
                }
                else
                {
                    alert.Show("Fingerprint not verified", alert.AlertType.success);
                    picLeftThumb.BackColor = Color.FromArgb(255,0 ,0);
                    LeftThumbValid = 0;
                }
            }));
        }

        private void generateRandomNumbers()
        {
            var randomNumbers = new List<int>();
            var randomGenerator = new Random();
            int initialCount = 1;
            string num1 = "";
            string num2 = "";

            for (int i = 0; i <= 5; i++)
            {
                while (initialCount <= 5)
                {
                    int num = randomGenerator.Next(1000,99999);
                    if (!randomNumbers.Contains(num))
                    {
                        randomNumbers.Add(num);
                        initialCount++;
                    }
                }
            }
            randomNumbers.Sort();
            randomNumbers.ForEach(x => num1 = x.ToString());

            var randomNumbers1 = new List<int>();
            var randomGenerator1 = new Random();
            int initialCount1 = 1;
            for (int i = 0; i <= 5; i++)
            {
                while (initialCount1 <= 5)
                {
                    int num5 = randomGenerator1.Next(100, 999);
                    if (!randomNumbers.Contains(num5))
                    {
                        randomNumbers1.Add(num5);
                        initialCount1++;
                    }
                }
            }
            randomNumbers1.Sort();
            randomNumbers1.ForEach(x => num2 = x.ToString());

            string[] combine = new String[] { num1, num2 };
            string combine1 = String.Join("", combine);
            getID = combine1 + txtLastName.Text;
        }

        private void clearFields()
        {
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = ""; 
            dtpBirthDate.Text = System.DateTime.Now.ToString();
            dtpDateHired.Text = System.DateTime.Now.ToString();
            //cmbSchedule.SelectedIndex = 0;
            //cmbPosition.SelectedIndex = 0;
            txtContactNumber.Text = "";
            txtPhilHealth.Text = "";
            txtSSS.Text = "";
            txtPagIbig.Text = "";
            picProfilePicture.Image = Properties.Resources.blankimg;
            lblImagePath.Text = "";
        }

        private void getPosition()
        {
            try
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT id, description FROM position";
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataSet ds = new DataSet();
                sda.Fill(ds, "position");
                cmbPosition.DisplayMember = "description";
                cmbPosition.ValueMember = "id";
                cmbPosition.DataSource = ds.Tables["position"];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getSalary()
        {
            try
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "SELECT id, rate FROM salary WHERE position_id = (SELECT id FROM position WHERE description = @description)";
                scom.Parameters.AddWithValue("@description", lblPosition.Text);
                MySqlDataAdapter sda = new MySqlDataAdapter(scom);
                DataSet ds = new DataSet();
                sda.Fill(ds, "salary");
                cmbSalary.DisplayMember = "rate";
                cmbSalary.ValueMember = "id";
                cmbSalary.DataSource = ds.Tables["salary"];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" && txtMiddleName.Text != "" && txtLastName.Text != "" && txtAddress.Text != "" && cmbPosition.Text != "- Select -" &&  txtContactNumber.Text != "" && txtPhilHealth.Text != "" && txtPagIbig.Text != "" && txtSSS.Text != "")
            {
                if(RightThumbValid != 0 && LeftThumbValid != 0)
                {
                    //try
                    //{
                        generateRandomNumbers();
                        if (lblImagePath.Text != "")
                        {
                            string FileName = lblImagePath.Text;
                            byte[] ImageData;
                            FileStream fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                            BinaryReader br = new BinaryReader(fs);
                            ImageData = br.ReadBytes((int)fs.Length);
                            br.Close();
                            fs.Close();
                            String cmdString = "INSERT INTO employee (id, firstname, middlename, lastname, address, birthdate, date_hired, contact_number, position_id, salary_id,  philhealth_number, sss_number, pagibig_number, picture) " +
                            "                       VALUES (@id, @fname, @mname, @lname, @address, @birthdate, @date_hired, @contact, @position_id, @salary_id, @phil, @sss, @pagibig, @picture)";
                            MySqlCommand cmd = new MySqlCommand(cmdString, conn);

                            cmd.Parameters.Add("@id", MySqlDbType.VarChar, 255);
                            cmd.Parameters.Add("@fname", MySqlDbType.VarChar, 255);
                            cmd.Parameters.Add("@mname", MySqlDbType.VarChar, 255);
                            cmd.Parameters.Add("@lname", MySqlDbType.VarChar, 255);
                            cmd.Parameters.Add("@address", MySqlDbType.VarChar, 255);
                            cmd.Parameters.Add("@birthdate", MySqlDbType.Date);
                            cmd.Parameters.Add("@date_hired", MySqlDbType.Date);
                            cmd.Parameters.Add("@contact", MySqlDbType.VarChar, 255);
                            cmd.Parameters.Add("@position_id", MySqlDbType.Int32, 11);
                            cmd.Parameters.Add("@salary_id", MySqlDbType.Int32, 11);
                            cmd.Parameters.Add("@phil", MySqlDbType.VarChar, 255);
                            cmd.Parameters.Add("@sss", MySqlDbType.VarChar, 255);
                            cmd.Parameters.Add("@pagibig", MySqlDbType.VarChar, 255);
                            cmd.Parameters.Add("@picture", MySqlDbType.LongBlob);

                            cmd.Parameters["@id"].Value = getID;
                            cmd.Parameters["@fname"].Value = txtFirstName.Text;
                            cmd.Parameters["@mname"].Value = txtMiddleName.Text;
                            cmd.Parameters["@lname"].Value = txtLastName.Text;
                            cmd.Parameters["@address"].Value = txtAddress.Text;
                            cmd.Parameters["@birthdate"].Value = dtpBirthDate.Text;
                            cmd.Parameters["@date_hired"].Value = dtpDateHired.Text;
                            cmd.Parameters["@contact"].Value = txtContactNumber.Text;
                            cmd.Parameters["@position_id"].Value = cmbPosition.SelectedValue.ToString();
                            cmd.Parameters["@salary_id"].Value = cmbSalary.SelectedValue.ToString();
                            cmd.Parameters["@phil"].Value = txtPhilHealth.Text;
                            cmd.Parameters["@sss"].Value = txtSSS.Text;
                            cmd.Parameters["@pagibig"].Value = txtPagIbig.Text;
                            cmd.Parameters["@picture"].Value = ImageData;

                            conn.Open();
                            int RowsAffected = cmd.ExecuteNonQuery();
                            if (RowsAffected > 0)
                            {
                                alert.Show("Successfully Saved.", alert.AlertType.success);
                            }
                            clearFields();
                            conn.Close();
                            InsertFingerPrint();

                        }
                        else
                        {
                            String cmdString = "INSERT INTO employee (id, firstname, middlename, lastname, address, birthdate, date_hired, contact_number, position_id, salary_id,  philhealth_number, sss_number, pagibig_number) " +
                        "                       VALUES (@id, @fname, @mname, @lname, @address, @birthdate, @date_hired, @contact, @position_id, @salary_id, @phil, @sss, @pagibig)";
                            MySqlCommand cmd1 = new MySqlCommand(cmdString, conn);

                            cmd1.Parameters.Add("@id", MySqlDbType.VarChar, 255);
                            cmd1.Parameters.Add("@fname", MySqlDbType.VarChar, 255);
                            cmd1.Parameters.Add("@mname", MySqlDbType.VarChar, 255);
                            cmd1.Parameters.Add("@lname", MySqlDbType.VarChar, 255);
                            cmd1.Parameters.Add("@address", MySqlDbType.VarChar, 255);
                            cmd1.Parameters.Add("@birthdate", MySqlDbType.Date);
                            cmd1.Parameters.Add("@date_hired", MySqlDbType.Date);
                            cmd1.Parameters.Add("@contact", MySqlDbType.VarChar, 255);
                            cmd1.Parameters.Add("@position_id", MySqlDbType.Int32, 11);
                            cmd1.Parameters.Add("@salary_id", MySqlDbType.Int32, 11);
                            cmd1.Parameters.Add("@phil", MySqlDbType.VarChar, 255);
                            cmd1.Parameters.Add("@sss", MySqlDbType.VarChar, 255);
                            cmd1.Parameters.Add("@pagibig", MySqlDbType.VarChar, 255);

                            cmd1.Parameters["@id"].Value = getID;
                            cmd1.Parameters["@fname"].Value = txtFirstName.Text;
                            cmd1.Parameters["@mname"].Value = txtMiddleName.Text;
                            cmd1.Parameters["@lname"].Value = txtLastName.Text;
                            cmd1.Parameters["@address"].Value = txtAddress.Text;
                            cmd1.Parameters["@birthdate"].Value = dtpBirthDate.Text;
                            cmd1.Parameters["@date_hired"].Value = dtpDateHired.Text;
                            cmd1.Parameters["@contact"].Value = txtContactNumber.Text;
                            cmd1.Parameters["@position_id"].Value = cmbPosition.SelectedValue.ToString();
                            cmd1.Parameters["@salary_id"].Value = cmbSalary.SelectedValue.ToString();
                            cmd1.Parameters["@phil"].Value = txtPhilHealth.Text;
                            cmd1.Parameters["@sss"].Value = txtSSS.Text;
                            cmd1.Parameters["@pagibig"].Value = txtPagIbig.Text;

                            conn.Open();
                            int RowsAffected = cmd1.ExecuteNonQuery();
                            if (RowsAffected > 0)
                            {
                                alert.Show("Successfully Added.", alert.AlertType.success);
                            }
                            clearFields();
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

        private void btnTakePicture_Click(object sender, EventArgs e)
        {
            Camera cam = new Camera();
            cam.ShowDialog();
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

        private void das_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void cmbSchedule_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = true;
        }

        private void cmbPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = true;
        }

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPosition.SelectedItem != null)
            {
                DataRowView drv = cmbPosition.SelectedItem as DataRowView;
                if (drv.Row["description"].ToString() != "- Select -")
                {
                    lblPosition.Text = drv.Row["description"].ToString();
                    cmbSalary.Enabled = true;
                    getSalary();
                }
                else
                {
                    cmbSalary.Enabled = false;
                    lblPosition.Text = "";
                    cmbSalary.DataSource = null;

                }
            }
        }

        private void txtContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void picRightThumb_Click(object sender, EventArgs e)
        {
            Fingerprint_Registration fingerprint = new Fingerprint_Registration();
            fingerprint.OnTemplate += this.Right_Thumb;
            fingerprint.ShowDialog();

        }

        private void picLeftThumb_Click(object sender, EventArgs e)
        {
            Fingerprint_Registration fingerprint = new Fingerprint_Registration();
            fingerprint.OnTemplate += this.Left_Thumb;
            fingerprint.ShowDialog();
        }

        private void btnAddFinger_Click(object sender, EventArgs e)
        {
            byte[] LeftThumb1 = LeftThumb.Bytes;
            byte[] RightThumb1 = RightThumb.Bytes;

            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "INSERT INTO fingerprint (employee_id, fingerprint, finger) " +
                                "VALUES (@id, @right, @finger)";
            scom.Parameters.AddWithValue("@id", "86931880Dela Cuesta");
            scom.Parameters.AddWithValue("@right", RightThumb1);
            scom.Parameters.AddWithValue("@finger", "Right");
            scom.ExecuteNonQuery();
            conn.Close();


            conn.Open();
            MySqlCommand scom1 = conn.CreateCommand();
            scom1.CommandText = "INSERT INTO fingerprint (employee_id, fingerprint, finger) " +
                                "VALUES (@id, @left, @finger)";
            scom1.Parameters.AddWithValue("@id", "86931880Dela Cuesta");
            scom1.Parameters.AddWithValue("@left+", LeftThumb1);
            scom1.Parameters.AddWithValue("@finger", "Left");
            scom1.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully insert");

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picExit_Click_1(object sender, EventArgs e)
        {
            
        }

        private void cmbPosition_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
                if (txtFirstName.Text != "" && txtMiddleName.Text != "" && txtLastName.Text != "" && txtAddress.Text != "" && cmbPosition.Text != "- Select -" && txtContactNumber.Text != "" && txtPhilHealth.Text != "" && txtPagIbig.Text != "" && txtSSS.Text != "")
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
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "UPDATE employee SET firstname = @fname, middlename = @mname, lastname = @lname, address = @address, birthdate = @birthdate, date_hired = @date_hired, contact_number = @contact, position_id = @position_id, salary_id = @salary_id,  philhealth_number = @phil, sss_number = @sss, pagibig_number = @pagibig, picture = @picture WHERE id = @id";
                    scom.Parameters.AddWithValue("@fname", txtFirstName.Text);
                    scom.Parameters.AddWithValue("@mname", txtMiddleName.Text);
                    scom.Parameters.AddWithValue("@lname", txtLastName.Text);
                    scom.Parameters.AddWithValue("@address", txtAddress.Text);
                    scom.Parameters.AddWithValue("@birthdate", dtpBirthDate.Text);
                    scom.Parameters.AddWithValue("@date_hired", dtpDateHired.Text);
                    scom.Parameters.AddWithValue("@contact", txtContactNumber.Text);
                    scom.Parameters.AddWithValue("@position_id", cmbPosition.SelectedValue.ToString());
                    scom.Parameters.AddWithValue("@salary_id", cmbSalary.SelectedValue.ToString());
                    scom.Parameters.AddWithValue("@phil", txtPhilHealth.Text);
                    scom.Parameters.AddWithValue("@sss", txtSSS.Text);
                    scom.Parameters.AddWithValue("@pagibig", txtPagIbig.Text);
                    scom.Parameters.AddWithValue("@picture", ImageData);
                    scom.Parameters.AddWithValue("@id", EmployeeID);
                    scom.ExecuteNonQuery();
                    conn.Close();

                    alert.Show("Successfully Updated.", alert.AlertType.success);
                    conn.Close();
                }
                else
                {
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "UPDATE employee SET firstname = @fname, middlename = @mname, lastname = @lname, address = @address, birthdate = @birthdate, date_hired = @date_hired, contact_number = @contact, position_id = @position_id, salary_id = @salary_id,  philhealth_number = @phil, sss_number = @sss, pagibig_number = @pagibig WHERE id = @id";
                    scom.Parameters.AddWithValue("@fname", txtFirstName.Text);
                    scom.Parameters.AddWithValue("@mname", txtMiddleName.Text);
                    scom.Parameters.AddWithValue("@lname", txtLastName.Text);
                    scom.Parameters.AddWithValue("@address", txtAddress.Text);
                    scom.Parameters.AddWithValue("@birthdate", dtpBirthDate.Text);
                    scom.Parameters.AddWithValue("@date_hired", dtpDateHired.Text);
                    scom.Parameters.AddWithValue("@contact", txtContactNumber.Text);
                    scom.Parameters.AddWithValue("@position_id", cmbPosition.SelectedValue.ToString());
                    scom.Parameters.AddWithValue("@salary_id", cmbSalary.SelectedValue.ToString());
                    scom.Parameters.AddWithValue("@phil", txtPhilHealth.Text);
                    scom.Parameters.AddWithValue("@sss", txtSSS.Text);
                    scom.Parameters.AddWithValue("@pagibig", txtPagIbig.Text);
                    scom.Parameters.AddWithValue("@id", EmployeeID);
                    scom.ExecuteNonQuery();
                    conn.Close();

                    alert.Show("Successfully Updated.", alert.AlertType.success);
                    conn.Close();
                }
                //}
                //catch (Exception a)
                //{
                //    MessageBox.Show(a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //}
            }
            else
            {
                alert.Show("Please fill in required fields.", alert.AlertType.warning);
            }
        }
    }
}
