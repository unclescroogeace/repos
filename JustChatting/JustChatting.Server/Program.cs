using System;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using JustChatting.Server.Networking;

namespace JustChatting.Server
{
    class Program
    {
        static void Main()
        {
            AsynchronousSocketListener.StartListening();
        }
    }
}