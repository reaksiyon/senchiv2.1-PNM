using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Telepathy;

namespace MRClient
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = NickTB;
            NickTB.Focus();
        }

        Telepathy.Client client = new Telepathy.Client();
        Telepathy.Message msg;
        //bool isFirstJoin = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            TextPanel.ReadOnly = true;
        }


        public void serverConnect()
        {

            while (client.GetNextMessage(out msg))
            {

                switch (msg.eventType)
                {
                    case Telepathy.EventType.Connected:
                        Console.WriteLine("Connected");
                        ConnectCheck.Text = "CONNECTED!";
                        ConnectCheck.ForeColor = Color.Snow;

                        break;
                    case Telepathy.EventType.Data: //msg taken

                        string ascii = Encoding.ASCII.GetString(msg.data);

                        if (!ascii.Contains("cls"))
                            TextPanel.Text += ascii + "\r\n";
                        else
                            TextPanel.Text = "";
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer("sounds/nya.wav");
                        player.Play();


                        break;
                    case Telepathy.EventType.Disconnected:
                        Console.WriteLine("Disconnected");
                        ConnectCheck.Text = "CONNECTION ERROR!";
                        ConnectCheck.ForeColor = Color.Snow;
                        break;
                }


            }



        }


        private void button1_Click(object sender, EventArgs e)
        {

            // send a message to server
            //   client.Send(new byte[] { 0xFF });

            if (NickTB.Text == "")
            {
                TextPanel.Text += "Dear Senchi member, please enter your nickname :)\r\n";
                return;
            }

            string msg = NickTB.Text.ToString() + ": " + msgTB.Text.ToString();
            byte[] msgc = Encoding.Default.GetBytes(msg);

            client.Send(msgc);
            msgTB.Text = "";
            serverConnect();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            serverConnect();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (NickTB.Text == "")
                {
                    TextPanel.Text += "Dear Senchi member, please enter your nickname :)\r\n";
                    return;
                }

                string msg = NickTB.Text.ToString() + ": " + msgTB.Text.ToString();
                byte[] msgc = Encoding.Default.GetBytes(msg);

                client.Send(msgc);
                msgTB.Text = "";
                serverConnect();
                msgTB.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void connect_Click(object sender, EventArgs e)
        {
            client.Connect(ipTB.Text, 1337); // ip address

            serverConnect();
            System.Threading.Thread.Sleep(1000);
        }

        private void ConnectCheck_Click(object sender, EventArgs e)
        {

        }

        private void TextPanel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
