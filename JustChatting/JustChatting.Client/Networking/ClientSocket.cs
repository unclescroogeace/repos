using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace JustChatting.Client.Networking
{
    public class ClientSocket
    {
        private Socket _socket;
        private byte[] _buffer;

        public ClientSocket()
        {
            _socket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Connect(string ipAdress, int port)
        {
            _socket.BeginConnect(new IPEndPoint(IPAddress.Parse(ipAdress), port), ConnectCallback, null);
        }

        private void ConnectCallback(IAsyncResult result)
        {
            _buffer = new byte[1024];
            _socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, ReceivedCallback, null);
        }

        private void ReceivedCallback(IAsyncResult result)
        {
            int bufferLength = _socket.EndReceive(result);
            byte[] packet = new byte[bufferLength];
            Array.Copy(_buffer, packet, packet.Length);

            //handle packet
            _buffer = new byte[1024];
            _socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, ReceivedCallback, null);
        }
    }
}
