using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Project1
{
    public partial class TcpServer : Form
    {
        private FilterInfoCollection VideoCaptureDevices;
        private VideoCaptureDevice FinalVideo;
        private Bitmap video;
        byte[] bmpBytes;

        public static ServerSocket ServerSocket = new ServerSocket();

        public TcpServer()
        {
            InitializeComponent();
            VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in VideoCaptureDevices)
            {
                comboBoxCameras.Items.Add(VideoCaptureDevice.Name);
            }
            comboBoxCameras.SelectedIndex = 0;
            toolStripStatusLabel1.Text = "Prigram is running";
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
        }

        private void buttonReceiveImage_Click(object sender, EventArgs e)
        {
            ImageConverter convertData = new ImageConverter();
            Image image = (Image)convertData.ConvertFrom(bmpBytes);
            pictureBoxVideo2.Image = image;
        }

        private void buttonServerTcp_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Creating server...";
            ServerSocket.Bind(6556);
            ServerSocket.Listen(500);
            ServerSocket.Accept();
            toolStripStatusLabel1.Text = "Server is running";
        }
    }
}
