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

namespace Shapes2
{
    

    public partial class InternetModMenu : Form
    {
        public InternetModMenu()
        {
            InitializeComponent();
            
        }
        
        

              

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            if (enemyIpBox.Text != String.Empty)
            {
              
                connectionButton.Enabled = true;
            }
            else { connectionButton.Enabled = false; serverButton.Enabled = false; }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            Conectionwindow conectwin = new Conectionwindow();
            conectwin.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            MainData.enemyIp = enemyIpBox.Text; // устанавливаем ip оппонента 
            MainData.senderEp = new IPEndPoint(IPAddress.Parse(MainData.enemyIp), 5002);
           

            byte[] data = Encoding.ASCII.GetBytes(MainData.myName+" "+MainData.myIp);
            MainData.senderUdp.Send(data, data.Length, MainData.senderEp);
            MainData.receiverUdp = new UdpClient(5002);
            MainData.enemyName=Encoding.ASCII.GetString(MainData.receiverUdp.Receive(ref MainData.ReceiveIpEndPoint));
            MainData.receiverUdp.Close();
            InternetGameForm game = new InternetGameForm();
            game.player2pic.Location = new Point(126, 624);
            game.player2pic.Image = Shapes2.Properties.Resources.lich_right;
            game.player1pic.Location = new Point(1226, 624);
            game.player1pic.Image = Shapes2.Properties.Resources.mag_left;

            game.ShowDialog();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            IPHostEntry host;
            
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)                              ////// находим локальный ip 
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    hostIpBox.Text  = ip.ToString();
                    MainData.myIp = ip.ToString();

                    MainData.ReceiveIpEndPoint = new IPEndPoint(ip, 5002);
                }
            }

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            MainData.myName = nameBox.Text;
            if (nameBox.Text != String.Empty)
            {
                
                serverButton.Enabled = true;
            }
            else { connectionButton.Enabled = false; serverButton.Enabled = false; }
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
    
}
