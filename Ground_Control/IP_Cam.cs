using AForge.Video;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ground_Control
{
    public partial class IP_Cam : Form
    {

        MJPEGStream video_stream;
        bool isVideoConnected = false;

        public IP_Cam()
        {
            InitializeComponent();
            txtbox_cam_address.Text = "http://192.168.1.10:5000/video_feed";
        }

        private void GetNewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                Bitmap bmap = (Bitmap)eventArgs.Frame.Clone();
                video_panel.Image = bmap;
            }
            catch (Exception e)
            {
                Console.WriteLine("VIDEO ERROR: " + e.Message);
            }

        }

        private void ShowStreamVideo(string CAM_URL = "http://192.168.1.10:5000/video_feed")
        {
            try
            {
                video_stream = new MJPEGStream(CAM_URL);
                video_stream.NewFrame += GetNewFrame;
            }
            catch (Exception e)
            {
                Console.WriteLine("VIDEO ERROR: " + e.Message);
            }

        }

        private void btn_connectVideo_Click_1(object sender, EventArgs e)
        {
            if (!isVideoConnected)
            {
                try
                {
                    string cam_address = txtbox_cam_address.Text.ToString();
                    ShowStreamVideo(cam_address);

                    video_stream.Start();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message.ToString(), "Link Error");
                }
                
                isVideoConnected = true;
                btn_connectVideo.Text = "Disconnect";
                btn_connectVideo.BackColor = Color.Coral;
            }
            else if (isVideoConnected)
            {
                video_stream.Stop();

                isVideoConnected = false;
                btn_connectVideo.Text = "Connect";
                btn_connectVideo.BackColor = Color.DodgerBlue;
            }
        }
    }
}
