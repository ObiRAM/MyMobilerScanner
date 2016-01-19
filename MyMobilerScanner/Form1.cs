using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Diagnostics;


namespace MyMobilerScanner
{
    public partial class FormMyMobilerScanner : Form
    {
        public FormMyMobilerScanner()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = int.Parse(textBoxIPLow.Text);
            int j = int.Parse(textBoxIPHigh.Text);
            progressBar1.Minimum = k;
            progressBar1.Maximum = j;
            listBoxIP.Items.Clear();
            listBoxLog.Items.Clear();
            for (int i=k;i<=j;i++)
            {
                //TcpClient tcpClient = new TcpClient();
                string cliente = textBoxIP.Text + "." + i;
                int porto = int.Parse(TextboxPort.Text);

                try
                {
                    TcpClient connection = new TcpClientWithTimeout(cliente, porto, 1000).Connect();
                    //tcpClient.Connect(cliente, porto);
                    listBoxLog.Items.Add("Porto aberto " + cliente + " " + porto);
                    //Console.WriteLine("Porto aberto " + cliente + " " + porto);
                    listBoxIP.Items.Add(cliente);
                    connection.Close();
                    //tcpClient.Close();
                }
                catch (Exception ex)
                {
                    listBoxLog.Items.Add("Porto fechado " + cliente + " " + porto);
                    //Console.WriteLine("Porto fechado " + cliente + " " + porto);
                    Console.WriteLine("An error occurred: '{0}'", ex);
                }
                progressBar1.Value = i;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonScan.Enabled = true;
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                foreach (UnicastIPAddressInformation ip in nic.GetIPProperties().UnicastAddresses)
                {
                    if (nic.Description == comboBoxInterfaces.SelectedItem.ToString())
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            string [] ipaddressArray = ip.Address.ToString().Split('.');
                            textBoxIP.Text = ipaddressArray[0] + "." + ipaddressArray[1] + "." + ipaddressArray[2];
                        }
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            buttonScan.Enabled = false;
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if ((nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet) || (nic.NetworkInterfaceType == NetworkInterfaceType.Wireless80211) || (nic.NetworkInterfaceType == NetworkInterfaceType.Ppp ) && (nic.OperationalStatus == OperationalStatus.Up))
                {
                    comboBoxInterfaces.Items.Add(nic.Description);
                }
            }
        }

        private void listBoxIP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBoxIP_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxIP.SelectedItem != null)
            {
                //MessageBox.Show(listBoxIP.SelectedItem.ToString());
                Process MyMobiler = new Process();
                MyMobiler.StartInfo.FileName = "MyMobiler.exe";
                MyMobiler.StartInfo.Arguments = " -connect " + listBoxIP.SelectedItem.ToString();
                MyMobiler.StartInfo.WorkingDirectory = Environment.CurrentDirectory;
                //MessageBox.Show("  -connect " + listBoxIP.SelectedItem.ToString());
                try {
                    MyMobiler.Start();
                } catch
                {
                    MessageBox.Show("Failed to Launch.");
                }
            }
        }
    }
}
