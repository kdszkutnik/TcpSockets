using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public static class PacketHandler
    {
        public static String Handle(byte[] packet, Socket clientSocket)
        {
            return System.Text.Encoding.ASCII.GetString(packet);
        }
    }
}
