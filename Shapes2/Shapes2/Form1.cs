
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


namespace Shapes2
{
    public partial class Form1 : Form
    {
        private static bool jump = false, moveDown = false, moveLeft = false, moveRight = false;

        public string enemyIp { get; set; }
        private static IPEndPoint senderEp = null;
        private static UdpClient senderUdp = new UdpClient();
        int G = 31;
        int force;
        
        private static IPEndPoint ReceiveIpEndPoint = null;
        private static UdpClient receiverUdp = new UdpClient(5001);
        
        public Form1()
        {

            InitializeComponent();
            
        }

       
        

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (jump == true) { player1.Top -= 5; positionSend(1); }
            if (moveDown == true) { player1.Top += 5; positionSend(2); }
            if (moveLeft == true) { player1.Left -= 5; positionSend(3); }
            if (moveRight == true) { player1.Left += 5; positionSend(4); }


            //side portals
            if (player1.Left < screen.Left - player1.Width) { player1.Left = screen.Right; }
                    else if (player1.Right - player1.Width > screen.Right) { player1.Left = screen.Left - player1.Width; }

            if (player2.Left < screen.Left - player2.Width) { player2.Left = screen.Right; }
                    else if (player2.Right - player2.Width > screen.Right) { player2.Left = screen.Left - player2.Width; }




            /////////////////////player1
            // jump
            if (jump == true)
            {
                player1.Top -= force;
                force -= 2;
            }

            //faling till bottom
            if (player1.Top + player1.Height >= screen.Height) { player1.Top = screen.Height - player1.Height; force = 0; jump = false; }
            else player1.Top += 8;


            ////////////////////player2
            if (player2.Top + player2.Height >= screen.Height) { player2.Top = screen.Height - player2.Height;   }
            else player2.Top += 8;
        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
            {
                if (jump != true)
                {
                    jump = true;
                    force = G;
                }
            }

            if (e.KeyCode == Keys.Down) { moveDown = true;  }
            if (e.KeyCode == Keys.Left) { moveLeft = true;  }
            if (e.KeyCode == Keys.Right) { moveRight = true;  }
            

            
        }

        private void Form1_KeyUp_1(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up) { jump = false; }
            if (e.KeyCode == Keys.Down) { moveDown = false; }
            if (e.KeyCode == Keys.Left) { moveLeft = false;  }
            if (e.KeyCode == Keys.Right) { moveRight = false;  }

        }

        public void positionSend(byte posX)
        {
            
            byte[] data =BitConverter.GetBytes(posX);
            senderUdp.Send(data, 1, senderEp);
            
        }
        
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
             MovesAndDelegates player2moves = new MovesAndDelegates(this, player2);
            
            while (true)
            {
                
                byte[] data = receiverUdp.Receive(ref ReceiveIpEndPoint);
                byte datrec = data[0];
                switch (datrec)
                {
                    case 1: player2moves.move_up(); break;
                    case 2: player2moves.move_down(); break;
                    case 3: player2moves.move_left(); break;
                    case 4: player2moves.move_right(); break;

                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            senderEp = new IPEndPoint(IPAddress.Parse("192.168.1.35"), 5001);
        }
       
    }
}
