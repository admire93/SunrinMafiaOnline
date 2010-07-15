using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    class Server
    {
        private int port = 10521;
        Socket listen_sock,client_sock;        
        IPEndPoint listen_ip,client_ip;
        Thread th_client;
        
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
        public void ServerStart()
        {
            th_client = new Thread(new ThreadStart(AcceptListen));
            th_client.IsBackground = true;
            th_client.Start();
        }
        public void ServerStop()
        {
        }

        public void AcceptListen()
        {
            bind(); listen();
            Client client;
            while (true)
            {
                try
                {
                    client_sock = listen_sock.Accept();
                    client_ip = (IPEndPoint)client_sock.RemoteEndPoint;
                    client = new Client(client_sock,client_ip);
                    th_client = new Thread(new ThreadStart(client.Receive));
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    break;
                }
            }
        }
       
    }
}
