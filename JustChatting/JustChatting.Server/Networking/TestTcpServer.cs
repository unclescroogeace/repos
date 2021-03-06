using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;
using JustChatting.Server.Models;
using JustChatting.Data;

namespace JustChatting.Server.Networking
{
    public class StateObject
    {
        // Size of receive buffer.  
        public const int BufferSize = 1024;

        // Receive buffer.  
        public byte[] buffer = new byte[BufferSize];

        // Received data string.
        public StringBuilder sb = new();

        // Client socket.
        public Socket workSocket = null;
    }

    public class AsynchronousSocketListener
    {
        private static UserService userService = new();
        // Thread signal.  
        public static ManualResetEvent allDone = new(false);

        public AsynchronousSocketListener()
        {
        }

        public static void StartListening()
        {
            // Establish the local endpoint for the socket.  
            // The DNS name of the computer  
            // running the listener is "host.contoso.com".  
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint localEndPoint = new(ipAddress, 13300);

            // Create a TCP/IP socket.  
            Socket listener = new(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);

            // Bind the socket to the local endpoint and listen for incoming connections.  
            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(100);

                while (true)
                {
                    // Set the event to nonsignaled state.  
                    allDone.Reset();

                    // Start an asynchronous socket to listen for connections.  
                    Console.WriteLine("Waiting for a connection...");
                    listener.BeginAccept(
                        new AsyncCallback(AcceptCallback),
                        listener);

                    // Wait until a connection is made before continuing.  
                    allDone.WaitOne();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nPress ENTER to continue...");
            Console.Read();

        }

        public static void AcceptCallback(IAsyncResult ar)
        {
            // Signal the main thread to continue.  
            allDone.Set();

            // Get the socket that handles the client request.  
            Socket listener = (Socket)ar.AsyncState;
            Socket handler = listener.EndAccept(ar);

            // Create the state object.  
            StateObject state = new();
            state.workSocket = handler;
            handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                new AsyncCallback(ReadCallback), state);
        }

        public static void ReadCallback(IAsyncResult ar)
        {
            String content = String.Empty;

            // Retrieve the state object and the handler socket  
            // from the asynchronous state object.  
            StateObject state = (StateObject)ar.AsyncState;
            Socket handler = state.workSocket;

            // Read data from the client socket.
            int bytesRead = handler.EndReceive(ar);

            if (bytesRead > 0)
            {
                // There  might be more data, so store the data received so far.  
                state.sb.Append(Encoding.ASCII.GetString(
                    state.buffer, 0, bytesRead));

                // Check for end-of-file tag. If it is not there, read
                // more data.  
                content = state.sb.ToString();
                if (content.IndexOf("<EOF>") > -1)
                {
                    // All the data has been read from the
                    // client. Display it on the console.  
                    int index = content.IndexOf("<EOF>");
                    string temp = content.Substring(0, index);

                    
                    Console.WriteLine("Read {0} bytes from socket.",
                        content.Length);

                    int indexEndType = temp.IndexOf(">") + 1;
                    string type = temp.Substring(0, indexEndType);
                    string contentWithoutType = temp.Substring(indexEndType, temp.Length - indexEndType);

                    if (type == "<LogIn>")
                    {
                        LogIn login = LogInDeserialize(contentWithoutType);

                        if (userService.AuthenticateUser(login.Username, login.Password))
                        {
                            content = "1";
                        }
                        else
                        {
                            content = "0";
                        }
                    }
                    else if (type == "<User>")
                    {
                        User user = UserDeserialize(contentWithoutType);

                        if (userService.CreateUser(user))
                        {
                            content = "1";
                        }
                        else
                        {
                            content = "0";
                        }
                    }

                    // Echo the data back to the client.  

                    Send(handler, content);
                }
                else
                {
                    // Not all data received. Get more.  
                    handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                    new AsyncCallback(ReadCallback), state);
                }
            }
        }

        private static void Send(Socket handler, String data)
        {
            // Convert the string data to byte data using ASCII encoding.  
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            // Begin sending the data to the remote device.  
            handler.BeginSend(byteData, 0, byteData.Length, 0,
                new AsyncCallback(SendCallback), handler);
        }

        private static void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.  
                Socket handler = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.  
                int bytesSent = handler.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to client.", bytesSent);

                handler.Shutdown(SocketShutdown.Both);
                handler.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static LogIn LogInDeserialize(string obj)
        {
            try
            {
                XmlSerializer xmlSerializer = new(typeof(LogIn));
                using StringReader textReader = new(obj);
                return (LogIn)xmlSerializer.Deserialize(textReader);
            }
            catch
            {
                throw;
            }
        }
        private static User UserDeserialize(string obj)
        {
            try
            {
                XmlSerializer xmlSerializer = new(typeof(User));
                using StringReader textReader = new(obj);
                return (User)xmlSerializer.Deserialize(textReader);
            }
            catch
            {
                throw;
            }
        }
    }
}