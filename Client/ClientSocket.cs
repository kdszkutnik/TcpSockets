using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class ClientSocket
    {
        private Socket _socket;
        private byte[] _buffer;

        public ClientSocket()
        {
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Connect(String ipAddress, int port)
        {
            _socket.BeginConnect(new IPEndPoint(IPAddress.Parse(ipAddress), port), ConnectCallback, null);
        }

        private void ConnectCallback(IAsyncResult result)
        {
            _buffer = new byte[1024];
            _socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, ReceivedCallback, null);

            _socket.Send(Encoding.ASCII.GetBytes("I'm a client and I am connected to you!"));
        }

        private void ReceivedCallback(IAsyncResult result)
        {
            int bufLength = _socket.EndReceive(result);
            byte[] packet = new byte[bufLength];
            Array.Copy(_buffer, packet, packet.Length);

            //Handle packet

            _buffer = new byte[1024];
            _socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, ReceivedCallback, null);
        }
    }
}
