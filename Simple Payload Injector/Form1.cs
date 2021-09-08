using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Payload_Injector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void send_pay_load(string IP, string payloadPath, int port)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            socket.Connect(new IPEndPoint(IPAddress.Parse(IP), port));
            socket.SendFile(payloadPath);
            socket.Close();
        }

        private void BrowseBT_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "bin files (*.bin)|*.bin";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PathText.Text = openFileDialog.FileName;
            }
        }

        private void PayloadBT_Click(object sender, EventArgs e)
        {
            if (IPText.Text == "" && PortText.Text == "")
            {
                MessageBox.Show("IP Address and Port is not specificate!", "Error", MessageBoxButtons.OK);
            }

            else if (PathText.Text == "")
            {
                MessageBox.Show("Payload is not specificate!", "Error", MessageBoxButtons.OK);
            }

            else
            {
                try
                {
                    this.send_pay_load(IPText.Text, PathText.Text, Convert.ToInt32(PortText.Text));
                    Thread.Sleep(1000);
                    MessageBox.Show("The payload as been send", "Success", MessageBoxButtons.OK);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }
    }
}
