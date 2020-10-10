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
using AForge.Video;
using AForge.Video.DirectShow;

namespace Client
{
    public partial class TcpClient : Form
    {

        private FilterInfoCollection VideoCaptureDevices;
        private VideoCaptureDevice FinalVideo;
        private Bitmap video;
        byte[] bmpBytes;

        private static ClientSocket clientSocket;
        public TcpClient()
        {
            InitializeComponent();

            VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in VideoCaptureDevices)
            {
                comboBoxCameras.Items.Add(VideoCaptureDevice.Name);
            }
            comboBoxCameras.SelectedIndex = 0;

            clientSocket = new ClientSocket();
            toolStripStatusLabel1.Text = "Program is running";
        }

        void FinalVideo_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            video = (Bitmap)eventArgs.Frame.Clone();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            FinalVideo = new VideoCaptureDevice(VideoCaptureDevices[comboBoxCameras.SelectedIndex].MonikerString);
            FinalVideo.NewFrame += new NewFrameEventHandler(FinalVideo_NewFrame);
            FinalVideo.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            FinalVideo.Stop();
        }

        private void buttonTakePicture_Click(object sender, EventArgs e)
        {
            pictureBoxVideo1.Image = video;
            Bitmap bmp = new Bitmap(video);
            MemoryStream ms = new MemoryStream();
            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            bmpBytes = ms.GetBuffer();
            ms.Close();
            clientSocket.Send(bmpBytes);
        }

        private void tcpCLientStart_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Waiting for connection...";
            clientSocket.Connect("127.0.0.1", 6556);
            toolStripStatusLabel1.Text = "Connected to the server!";
        }
    }
}
