using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Chat_Messenger_Client
{
    class ConnectionHandler
    {
        readonly static String IP_ADDRESS = "127.0.0.1";
        readonly static int PORT = 6330;
        static Socket _socket;

        public static Socket socket { get => _socket; set => _socket = value; }

        public static bool connect()
        { // attempt to establish connection to a TCP/IP based server
            bool connectedToServer = true; // prove false

            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream,ProtocolType.Tcp);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(IP_ADDRESS), PORT);

            try
            {
                socket.Connect(endPoint);
            }
            catch(Exception e)
            {
                connectedToServer = false;
                Console.WriteLine(e.ToString());
            }

            return connectedToServer;
        }
    }
}
