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
            this.ActiveControl = textBox3;
            textBox3.Focus();
        }
        Telepathy.Client client = new Telepathy.Client();
        Telepathy.Message msg;
        //bool isFirstJoin = true;

       
        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            client.Connect("88.245.212.22", 1337); // ip girilecek
            textBox1.ReadOnly = true;
           

            System.Threading.Thread.Sleep(1000);
            serverConnect();
            

           
        }



        public void serverConnect()
        {


            while (client.GetNextMessage(out msg))
                    {

                switch (msg.eventType)
                        {
                            case Telepathy.EventType.Connected:
                                Console.WriteLine("Connected");
                                label1.Text = "BAĞLI!";
                                label1.ForeColor = Color.Snow;
                                
                        break;
                            case Telepathy.EventType.Data: //msj alındığı yer
                            
                        string ascii = Encoding.ASCII.GetString(msg.data);
                    
                        if (!ascii.Contains("cls"))
                            textBox1.Text += ascii + "\r\n";
                        else
                            textBox1.Text = "";
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer("sounds/nya.wav");
                        player.Play();


                        break;
                            case Telepathy.EventType.Disconnected:
                                Console.WriteLine("Disconnected");
                                label1.Text = "BAĞLANTI HATASI!";
                                label1.ForeColor = Color.Snow;
                        break;
                        }


            }
                    
            

        }


        private void button1_Click(object sender, EventArgs e)
        {

        // send a message to server
        //   client.Send(new byte[] { 0xFF });

            if(textBox3.Text == "")
            {
                textBox1.Text += "Sevgili senchi üyemiz, lütfen önce isminizi giriniz :)\r\n";
                return;
            }
         
        string msg =  textBox3.Text.ToString() + ": " + textBox2.Text.ToString();
            byte[] msgc = Encoding.Default.GetBytes(msg);

            client.Send(msgc);
            textBox2.Text = "";
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

                if (textBox3.Text == "")
                {
                    textBox1.Text += "Sevgili senchi üyemiz, lütfen önce isminizi giriniz :)\r\n";
                    return;
                }

                string msg = textBox3.Text.ToString() + ": " + textBox2.Text.ToString();
                byte[] msgc = Encoding.Default.GetBytes(msg);

                client.Send(msgc);
                textBox2.Text = "";
                serverConnect();
                textBox2.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }
    }
}
