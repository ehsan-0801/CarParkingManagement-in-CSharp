using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using ParkingManagement;
using DemoCarParking;
using ParkingManagement.Parking_Management;
using ParkingManagement.Design;

namespace ParkingManagement.Design
{
    public partial class chat : Form
    {
        Socket sck;
        EndPoint epYou, epOther;

        public chat()
        {
            InitializeComponent();
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            IpGTextBox.Text = GetLocalIp();

        }

        private string GetLocalIp()
        {
            IPHostEntry Host;
            Host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress Ip in Host.AddressList)
            {
                if (Ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return Ip.ToString();

                }

            }
            return "127.0.0.1";
        }
        public void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = sck.EndReceiveFrom(aResult, ref epOther);
                if (size > 0)
                {
                    byte[] receivedData = new byte[1500];
                    receivedData = (byte[])aResult.AsyncState;
                    ASCIIEncoding aEncoding = new ASCIIEncoding();
                    string receivedMessage = aEncoding.GetString(receivedData);
                    MessageListBox.Items.Add("Other:" + receivedMessage);

                }
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epOther, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void chat_Load(object sender, EventArgs e)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            IpGTextBox.Text = GetLocalIp();
            IpMTextBox.Text = GetLocalIp();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            try
            {
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(MessageTextBox.Text);
                sck.Send(msg);
                MessageListBox.Items.Add("You:" + MessageTextBox.Text);
                MessageTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                epYou = new IPEndPoint(IPAddress.Parse(IpGTextBox.Text), Convert.ToInt32(PortGTextBox.Text));
                sck.Bind(epYou);
                epOther = new IPEndPoint(IPAddress.Parse(IpMTextBox.Text), Convert.ToInt32(PortMTextBox.Text));
                sck.Connect(epOther);
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epOther, new AsyncCallback(MessageCallBack), buffer);
                ConnectButton.Text = "Connected";

                ConnectButton.Enabled = false;
                SendButton.Enabled = true;
                MessageTextBox.Focus();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
