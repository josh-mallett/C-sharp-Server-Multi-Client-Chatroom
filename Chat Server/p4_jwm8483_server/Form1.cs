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
using System.Threading;

namespace p4_jwm8483_server
{
    public partial class Form1 : Form
    {
        TcpListener listener = new TcpListener(IPAddress.Any, 51111);
        private StreamWriter writer;
        private StreamReader reader;
        private List<TcpClient> Clients = new List<TcpClient>();
        private List<String> usernames = new List<String>();
        private bool run_server;


        public Form1()
        {
            InitializeComponent();
        }

        private void ServerStart_Click(object sender, EventArgs e)
        {
            
            ListenerThread.RunWorkerAsync();
        }

        private void ListenerThread_DoWork(object sender, DoWorkEventArgs e)
        {
            this.run_server = true;
            String testName;
            bool isUnique = true;
            while (run_server)
            {
                listener.Start();
                TcpClient client = listener.AcceptTcpClient();
                reader = new StreamReader(client.GetStream());
                writer = new StreamWriter(client.GetStream());
                writer.AutoFlush = true;

                testName = reader.ReadLine();

                foreach (String name in usernames)
                {
                    if (testName.CompareTo(name) == 0)
                    {
                        isUnique = false;
                    }
                }

                if (isUnique)
                {
                    Clients.Add(client);
                    usernames.Add(testName);
                    Thread ClientThread = new Thread(new ParameterizedThreadStart(ClientHandler));
                    ClientThread.Start(client);
                    listener.Stop();
                }
                else
                {
                    client.Close();
                    listener.Stop();
                    writer.Close();
                    reader.Close();
                }
  
            }
            
        }

        private void ClientHandler(object client)
        {
            TcpClient Client = (TcpClient)client;
            while (Client.Connected)
            {
                try
                {
                    String textRecieved = reader.ReadLine();
                    textBox1.Invoke(new MethodInvoker(delegate ()
                    {
                        textBox1.AppendText(textRecieved);
                        MessageAllClients(textRecieved);
                    }));
                    textRecieved = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            Client.Close();
            Clients.Remove(Client);
        }

        private void MessageAllClients(String message)
        {
            foreach (TcpClient user in Clients)
            {
                StreamWriter writer = new StreamWriter(user.GetStream());
                writer.WriteLine(message);
                writer.AutoFlush = true;
            }
        }
    }
}
