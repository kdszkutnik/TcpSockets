using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class ServerSocket
    {
        private Socket _socket;
        private byte[] _buffer = new byte[30000];

        public delegate void ServerSocketReceiveEventHandler(object source, ServerSocketEventArgs args);
        public event ServerSocketReceiveEventHandler ServerSocketReceive;

        public class ServerSocketEventArgs : EventArgs
        {
            public Byte[] Data { get; set; }
        }

        public ServerSocket()
        {
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Bind(int port)
        {
            _socket.Bind(new IPEndPoint(IPAddress.Any, port));
        }

        public void Listen(int backlog)
        {
            _socket.Listen(500);
        }

        public void Accept()
        {
            _socket.BeginAccept(AcceptedCallback, null);
        }

        public void Send(String text)
        {
            _socket.Send(Encoding.ASCII.GetBytes(text));
        }

        private void AcceptedCallback(IAsyncResult result)
        {
            Socket clientSocket = _socket.EndAccept(result);
            _buffer = new byte[30000];
            Accept();
            clientSocket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, ReceivedCallback, clientSocket);
        }

        private void ReceivedCallback(IAsyncResult result)
        {
            Socket clientSocket = result.AsyncState as Socket;
            int bufferSize = clientSocket.EndReceive(result);
            byte[] packet = new byte[bufferSize];
            Array.Copy(_buffer, packet, packet.Length);

            // Handle the packet
            String _text = PacketHandler.Handle(packet, clientSocket);
            OnServerSocketReceive(_buffer);

            _buffer = new byte[30000];
            clientSocket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, ReceivedCallback, clientSocket);
        }

        protected virtual void OnServerSocketReceive(Byte[] data)
        {
            if(ServerSocketReceive != null)
                ServerSocketReceive(this, new ServerSocketEventArgs { Data = data });
        }
    }
}
