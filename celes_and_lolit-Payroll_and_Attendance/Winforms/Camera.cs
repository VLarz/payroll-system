using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;

namespace celes_and_lolit_Payroll_and_Attendance.Winforms
{
    public partial class Camera : Form
    {
        public Camera()
        {
            InitializeComponent();
            startCam();
        }
        private FilterInfoCollection captureDevices;
        private VideoCaptureDevice videoSource;

        private void pnlBackground_Paint(object sender, PaintEventArgs e)
        {

        }
        private void startCam()
        {
            captureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoSource = new VideoCaptureDevice(captureDevices[0].MonikerString);
            //videoSource = new VideoCaptureDevice(captureDevices[cmbSelect.SelectedIndex].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
            videoSource.Start();
        }
        private void Camera_Load(object sender, EventArgs e)
        {
            //captureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //foreach(FilterInfo device in captureDevices)
            //{
            //    cmbSelect.Items.Add(device.Name);
            //}
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                pic1.Image = (Bitmap)eventArgs.Frame.Clone();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            videoSource.Stop();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            videoSource.Start();
        }
    }
}
