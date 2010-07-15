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
        }

        private void bt_serv_off_Click(object sender, EventArgs e)
        {
            if (server != null)
            {
                lb_serv_statue.Text = "Off";
            }
            else
            {
                MessageBox.Show("서버를 실행시켜 주십시요", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_serv_on_Click(object sender, EventArgs e)
        {
            server = new Server();
            server.ServerStart();
            lb_serv_statue.Text = "On";
        }
    }
}
