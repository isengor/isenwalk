using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;

namespace Shapes2
{
    public partial class Conectionwindow : Form
    {
        public Conectionwindow()
        {
            InitializeComponent();
        }

        
        delegate void Delegatename(String enemyData);
        
      
        
        public void getEnemyData(String enemyData)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Delegatename(getEnemyData), enemyData); 
            }
            else
            {
                string[] enemydatarec = enemyData.Split(' ');
                label1.Text = "Соединение установлено!";
                label2.Text = "Ваш противник " + enemydatarec[0];
                MainData.enemyName = enemydatarec[0];
                MainData.senderEp = new IPEndPoint(IPAddress.Parse(enemydatarec[1]), 5002);
                pictureBox1.Image = Shapes2.Properties.Resources.Swords;

               
                startButton.Enabled = true;
                
            }
        }

        

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {


            MainData.receiverUdp = new UdpClient(5002);

            byte[] data = MainData.receiverUdp.Receive(ref MainData.ReceiveIpEndPoint);
            string name = Encoding.ASCII.GetString(data);


            getEnemyData(name);

            MainData.receiverUdp.Close();

            


        }

        private void Conectionwindow_Activated(object sender, EventArgs e)
        {
            
            backgroundWorker1.RunWorkerAsync();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
            
           
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] name = Encoding.ASCII.GetBytes(MainData.myName);
            MainData.senderUdp.Send(name, name.Length, MainData.senderEp);

            this.Hide();
            InternetGameForm gameform = new InternetGameForm();
            gameform.Show();
            backgroundWorker1.CancelAsync();
            
           
        }

        private void Conectionwindow_Load(object sender, EventArgs e)
        {
            
        }
        
    }
}
