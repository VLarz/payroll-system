using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;

namespace celes_and_lolit_Payroll_and_Attendance.Winforms
{
    public partial class Login : Form, DPFP.Capture.EventHandler
    {
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = celes_and_lolit-payroll");
        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;
        int GetID;
        String GetUserLevel = "";

        public Login()
        {
            InitializeComponent();
        }

        public static Form globalForm;

        void Main()
        {
            globalForm = new Form();
            globalForm.Show();
            globalForm.Hide();
            // Spawn threads here
        }

        private void InsertUserLog(int id, string userlevel, string time_in)
        {
            conn.Open();
            MySqlCommand scom = conn.CreateCommand();
            scom.CommandText = "SELECT user_id FROM userlog WHERE user_id = @id AND DATE(time_in) = @date";
            scom.Parameters.AddWithValue("@id", id);
            scom.Parameters.AddWithValue("@date", System.DateTime.Now.ToString("yyyy/MM/dd"));
            MySqlDataAdapter sda = new MySqlDataAdapter(scom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            Console.WriteLine(id);
            if (dt.Rows.Count > 0)
            {
                Console.WriteLine("if");
            }
            else
            {
                conn.Open();
                MySqlCommand scom1 = conn.CreateCommand();
                scom1.CommandText = "INSERT INTO userlog (user_id, userlevel, time_in) " +
                                   "VALUES (@id, @userlevel, @time_in)";
                scom1.Parameters.AddWithValue("@id", id);
                scom1.Parameters.AddWithValue("@userlevel", userlevel);
                scom1.Parameters.AddWithValue("@time_in", time_in);
                scom1.ExecuteNonQuery();
                conn.Close();
            }    
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT id, userlevel FROM user WHERE username = @user AND password = @pass";
                    MySqlDataAdapter sda = new MySqlDataAdapter(sql, conn);
                    sda.SelectCommand.Parameters.AddWithValue("@user", txtUsername.Text);
                    sda.SelectCommand.Parameters.AddWithValue("@pass", txtPassword.Text);
                    DataTable sdt = new DataTable();
                    sda.Fill(sdt);
                    conn.Close();
                    if (sdt.Rows.Count > 0)
                    {
                        for (int samp = 0; samp < sdt.Rows.Count; samp++)
                        {
                            string name = txtUsername.Text;
                            DataRow sdr = sdt.Rows[samp];
                            int userID = Convert.ToInt32(sdr["id"].ToString());
                            if (sdr["userlevel"].ToString() == "Admin")
                            {
                                //InsertUserLog(userID, "Admin", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                                this.Hide();
                                Admin_Mainform main = new Admin_Mainform();
                                main.Show();
                                alert.Show("Successfully Signed In.", alert.AlertType.success);
                                Stop();
                            }
                            else if (sdr["userlevel"].ToString() == "Manager")
                            {
                                //InsertUserLog(userID, "Manager", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                                this.Hide();
                                Manager_Mainform main = new Manager_Mainform();
                                main.Show();
                                alert.Show("Successfully Signed In.", alert.AlertType.success);
                                Stop();
                            }
                            else if (sdr["userlevel"].ToString() == "Accountant")
                            {
                                //InsertUserLog(userID, "Accountant", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                                this.Hide();
                                Accountant_Mainform main = new Accountant_Mainform();
                                main.Show();
                                alert.Show("Successfully Signed In.", alert.AlertType.success);
                                Stop();
                            }
                        }
                    }
                    else
                    {
                        alert.Show("Incorrect Username or Password.", alert.AlertType.warning);
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                alert.Show("Please fill up all fields.", alert.AlertType.warning);
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {

        }

        public void Verify(DPFP.Template template)
        {
            Template = template;
            ShowDialog();
        }

        private void UpdateStatus(int FAR)
        {
            // Show "False accept rate" value
            SetStatus(String.Format("False Accept Rate (FAR) = {0}", FAR));
        }

        protected virtual void Init()
        {
            try
            {
                Capturer = new DPFP.Capture.Capture();				// Create a capture operation.

                if (null != Capturer)
                    Capturer.EventHandler = this;					// Subscribe for capturing events.
                else
                    SetPrompt("Can't initiate capture operation!");
            }
            catch
            {
                MessageBox.Show("Can't initiate capture operation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Verificator = new DPFP.Verification.Verification();     // Create a fingerprint template verificator
            UpdateStatus(0);
        }

        protected void ManagerForm()
        {
            this.Invoke(new Function(delegate () {
                Manager_Mainform main = new Manager_Mainform();
                main.Show();
                this.Hide();
            }));
        }

        protected void AdminForm()
        {
            this.Invoke(new Function(delegate () {
                Admin_Mainform main = new Admin_Mainform();
                main.Show();
                this.Hide();
            }));
        }

        protected void AccountantForm()
        {
            this.Invoke(new Function(delegate () {
                Accountant_Mainform main = new Accountant_Mainform();
                main.Show();
                this.Hide();
            }));
        }
        protected virtual void Process(DPFP.Sample Sample)
        {
            //Process(Sample);

            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            // Check quality of the sample and start verification if it's good
            // TODO: move to a separate task
            if (features != null)
            {
                // Compare the feature set with our template
                DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();

                DPFP.Template template = new DPFP.Template();
                Stream stream;
                //try
                //{
                    conn.Open();
                    MySqlCommand scom = conn.CreateCommand();
                    scom.CommandText = "SELECT user.id, user.userlevel, user_fingerprint.fingerprint " +
                                       "FROM user_fingerprint " +
                                       "INNER JOIN user " +
                                       "ON user.id = user_fingerprint.user_id";
                    MySqlDataReader sdr = scom.ExecuteReader();
                    while (sdr.Read())
                    {
                        byte[] _img = (byte[])sdr["fingerprint"];
                        GetID = Convert.ToInt32(sdr["id"].ToString());
                        GetUserLevel = sdr["userlevel"].ToString();
                        stream = new MemoryStream(_img);
                        template = new DPFP.Template(stream);
                        Verificator.Verify(features, template, ref result);
                            if(result.Verified)
                            {
                                Console.WriteLine("UserLevel" + GetUserLevel);
                                Console.WriteLine("GetID" + GetID);
                                MakeReport("Fingerprint is found.");
                                conn.Close();
                                sdr.Dispose();
                                sdr.Close();
                        if (GetUserLevel == "Accountant")
                        {
                            InsertUserLog(GetID, "Accountant", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                            AccountantForm();
                            Stop();
                            break;
                        }
                        else if (GetUserLevel == "Manager")
                        {
                            InsertUserLog(GetID, "Manager", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                            ManagerForm();
                            Stop();
                            break;
                        }
                        else
                        {
                            InsertUserLog(GetID, "Admin", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                            AdminForm();
                            Stop();
                            break;
                        }
                    }
                        else
                        {
                        MakeReport("Fingerprint not found.");
                        //picFingerprint.BackColor = Color.FromArgb(255, 0, 0);
                        }
                    }
                    conn.Close();
                    sdr.Dispose();
                    sdr.Close();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
            }
            // Draw fingerprint sample image.
            DrawPicture(ConvertSampleToBitmap(Sample));
        }

        protected void Start()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StartCapture();
                    SetPrompt("Using the fingerprint reader, scan your fingerprint.");
                }
                catch
                {
                    SetPrompt("Can't initiate capture!");
                }
            }
        }
        protected void Stop()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StopCapture();
                }
                catch
                {
                    SetPrompt("Can't terminate capture!");
                }
            }
        }

        #region Form Event Handlers:

        private void CaptureForm_Load(object sender, EventArgs e)
        {
            // Start capture operation.
        }

        private void CaptureForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Stop();
        }
        #endregion

        #region EventHandler Members:

        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            MakeReport("The fingerprint sample was captured.");
            SetPrompt("Scan the same fingerprint again.");
            Process(Sample);
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The finger was removed from the fingerprint reader.");
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was touched.");
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was connected.");
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was disconnected.");
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
                MakeReport("The quality of the fingerprint sample is good.");
            else
                MakeReport("The quality of the fingerprint sample is poor.");
        }
        #endregion

        protected Bitmap ConvertSampleToBitmap(DPFP.Sample Sample)
        {
            DPFP.Capture.SampleConversion Convertor = new DPFP.Capture.SampleConversion();  // Create a sample convertor.
            Bitmap bitmap = null;                                                           // TODO: the size doesn't matter
            Convertor.ConvertToPicture(Sample, ref bitmap);                                 // TODO: return bitmap as a result
            return bitmap;
        }

        protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();  // Create a feature extractor
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);            // TODO: return features as a result?
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return features;
            else
                return null;
        }

        protected void SetStatus(string status)
        {
            this.Invoke(new Function(delegate () {
                StatusLine.Text = status;
            }));
        }

        protected void SetPrompt(string prompt)
        {
            this.Invoke(new Function(delegate () {
                Prompt.Text = prompt;
            }));
        }
        protected void MakeReport(string message)
        {
            this.Invoke(new Function(delegate () {
                StatusText.Text = message;
            }));
        }

        private void DrawPicture(Bitmap bitmap)
        {
            this.Invoke(new Function(delegate () {
                Picture.Image = new Bitmap(bitmap, Picture.Size);   // fit the image into the picture box
            }));
        }

        private DPFP.Capture.Capture Capturer;

        private void Login_Load(object sender, EventArgs e)
        {
            Init();
            Start();
        }

        private void txtUsername_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            if(chkShowPassword.Checked == true)
            {
                txtPassword.isPassword = false;
            }
            else
            {
                txtPassword.isPassword = true;
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSignIn_Click(sender, e);
            }
        }

        private void chkShowPassword_OnChange(object sender, EventArgs e)
        {
            if(chkShowPassword.Checked == true)
            {
                txtPassword.isPassword = false;
            }
            else
            {
                txtPassword.isPassword = true;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
