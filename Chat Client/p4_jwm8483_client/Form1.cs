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
using System.IO;


namespace p4_jwm8483_client
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private StreamReader reader;
        private StreamWriter writer;
        private String textReceived;
        private String textToSend;
        private String UN;
        private String IP;
        private String Port;
    
        public Form1()
        {
            InitializeComponent();
        }

        private void StartClient_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IP = IPBox.Text;
            Port = portBox.Text;
            IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 51111);

            if (username.Text != "")
            {
                UN = username.Text;

                try
                {
                    client.Connect(IpEnd);
                    if (client.Connected)
                    {
                        textBox1.AppendText("Connected! \n");
                        this.writer = new StreamWriter(client.GetStream());
                        this.reader = new StreamReader(client.GetStream());
                        writer.AutoFlush = true;
                        TestUsername();
                        recieveMessages.RunWorkerAsync();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void TestUsername()
        {
            writer.WriteLine(UN);
        }

        private void Send_Click(object sender, EventArgs e)
        {
            if (message.Text != "")
            {
                dataSender(message.Text);
            }
            message.Text = "";
        }

        private async void dataSender(String toSend)
        {
            await writer.WriteLineAsync(UN + ": " + toSend);
        }

        private void recieveMessages_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    textReceived = this.reader.ReadLine();

                    textBox1.Invoke(new MethodInvoker(delegate ()
                    {
                        textBox1.AppendText(textReceived + "\n");
                    }));
                    textReceived = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
