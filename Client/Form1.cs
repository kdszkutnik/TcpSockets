using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class TcpClient : Form
    {
        private static ClientSocket clientSocket;
        public TcpClient()
        {
            InitializeComponent();
            clientSocket = new ClientSocket();
            toolStripStatusLabel1.Text = "Program is running";
        }

        private void tcpCLientStart_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Waiting for connection...";
            clientSocket.Connect("127.0.0.1", 6556);
            toolStripStatusLabel1.Text = "Connected to the server!";
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
