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

namespace Chat_room
{
    public partial class Form1 : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        public Form1()
        {
            InitializeComponent();

            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp );
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            Ip1.Text = GetLocalIp();
            textBox5.Text= GetLocalIp();

        }
        private void MessageCallBack(IAsyncResult aResult) {
            try {
                int size = sck.EndReceiveFrom(aResult,ref epLocal);
                if (size>0) {
                    byte[] recievedData=new byte[1464];
                    recievedData = (byte[])aResult.AsyncState;
                    ASCIIEncoding eENCODING = new ASCIIEncoding();
                    string recievedMessage = eENCODING.GetString(recievedData);
                    listMessages.Items.Add("Friend: " + recievedMessage);


                }
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote,
                    new AsyncCallback(MessageCallBack), buffer);
            }
            catch(Exception exp) {
                MessageBox.Show(exp.ToString());
            }
        }
        private string GetLocalIp() {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList) {
                if (ip.AddressFamily == AddressFamily.InterNetwork) {
                    return ip.ToString();
                }
            }
            return "192.168.1.112";
        }//get Ip address

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                epLocal = new IPEndPoint(IPAddress.Parse(Ip1.Text), Convert.ToInt32(textBox2.Text
                    ));
                sck.Bind(epLocal);   
                
                epRemote=new IPEndPoint(IPAddress.Parse(textBox5.Text), Convert.ToInt32(textBox4.Text
                    ));
                sck.Bind(epRemote);

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack),buffer
                    );
                start.Text = "Connected";
                start.Enabled = false;
                send.Enabled = true;
                message.Focus();

            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void send_Click(object sender, EventArgs e)
        {
        try {
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(message.Text);
                sck.Send(msg);
                listMessages.Items.Add("Me: "+ message.Text);
                message.Clear();
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
}

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
