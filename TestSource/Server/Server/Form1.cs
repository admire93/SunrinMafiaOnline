using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    public partial class Main : Form
    {
        Server server;
        public Main()
        {
            InitializeComponent();
            server = new Server();          
                      
        }
    }
}
