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
using static Project1.ServerSocket;

namespace Project1
{
    public partial class TcpServer : Form
    {
        public static ServerSocket ServerSocket = new ServerSocket();

        public TcpServer()
        {
            InitializeComponent();
            
            toolStripStatusLabel1.Text = "Program is running";

            ServerSocket.ServerSocketReceive += this.ServerSocketDataReceive;
        }

        private void buttonServerTcp_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Creating server...";
            ServerSocket.Bind(6556);
            ServerSocket.Listen(500);
            ServerSocket.Accept();
            toolStripStatusLabel1.Text = "Server is running";
        }

        public void ServerSocketDataReceive(Object source, ServerSocketEventArgs args)
        {
            var ms = new MemoryStream(args.Data);
            pictureBoxVideo1.Image = Image.FromStream(ms);
        }
    }
}
