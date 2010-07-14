using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Server
{
    class Server
    {
        private int port = 10521;
        Socket listen_sock;
        
        IPEndPoint listen_ip;
        public Server()
        {
            listen_sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            listen_ip = new IPEndPoint(IPAddress.Any, port);
        }
        public Server(int user_port)
        {
            listen_sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            listen_ip = new IPEndPoint(IPAddress.Any, user_port);
        }

        public void bind()
        {
            try
            {
                listen_sock.Bind(listen_ip);
            }
            catch (SocketException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void listen()
        {
            try
            {
                listen_sock.Listen(1024);
            }
            catch (SocketException e)
            {
                MessageBox.Show(e.Message);
            }
        }


    }
}
