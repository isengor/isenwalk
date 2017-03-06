
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Shapes2
{
    public partial class InternetGameForm : Form
    {

        SoundPlayer mushroomsound =
                new SoundPlayer();
        SoundPlayer shootsound =
           new SoundPlayer();
        
       

        private static int G = 31;
        private static int force=0, force2=0;

        
        
        Player player1, player2;
        
        public InternetGameForm()
        {

            InitializeComponent();
            
            player1 = new Player(player1pic,player2pic,player1_atack,progressBar2);
            player2 = new Player(player2pic,player1pic,player2_atack,progressBar1);
            player1.playerside = true;
            player1.playeratackside = true;

            label1.Text = MainData.myName;
            label2.Text = MainData.enemyName;
            mushroomsound.Stream = Shapes2.Properties.Resources.Mushroomsound;
            shootsound.Stream = Shapes2.Properties.Resources.fireball;
            
        }

       
        

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
            player1.doAttack();
            player2.doAttack();
            
            if (player1.moveLeft == true) { player1pic.Left -= 5; positionSend(3); }
            if (player1.moveRight == true) { player1pic.Left += 5; positionSend(4); }


            //side portals
            if (player1pic.Left < screen.Left - player1pic.Width) { player1pic.Left = screen.Right; }
                    else if (player1pic.Right - player1pic.Width > screen.Right) { player1pic.Left = screen.Left - player1pic.Width; }

            if (player2pic.Left < screen.Left - player2pic.Width) { player2pic.Left = screen.Right; }
                    else if (player2pic.Right - player2pic.Width > screen.Right) { player2pic.Left = screen.Left - player2pic.Width; }


           

            /////////////////////player1
            // jump
            if (player1.jump == true)
            {
                player1pic.Top -= force;
                force -= 2;
            }

            //faling till bottom
            if (player1pic.Top + player1pic.Height >= screen.Height) { player1pic.Top = screen.Height - player1pic.Height; player1.jump = false; }
            else if (!player1.blockstanding) player1.falling();

            //blocks collision


            player1.blockcollision(block1);
            player1.blockcollision(block2);
            player1.blockcollision(block3);
            player1.blockcollision(block4);
            player1.blockcollision(block5);
            player1.blockcollision(block6);
            player1.blockcollision(block7);
            player1.blockcollision(block8);
            player1.blockcollision(block9);
            

            //////////////////////////////
            //////////////////player2
            ///////////////////////////
            if (player2.jump == true)
            {
                player2pic.Top -= force2;
                force2 -= 2;
            }

            //faling till bottom
            if (player2pic.Top + player2pic.Height >= screen.Height) { player2pic.Top = screen.Height - player2pic.Height; player2.jump = false; }
            else if (!player2.blockstanding) player2.falling();

            

            //blocks collision

            player2.blockcollision(block1);
            player2.blockcollision(block2);
            player2.blockcollision(block3);
            player2.blockcollision(block4);
            player2.blockcollision(block5);
            player2.blockcollision(block6);
            player2.blockcollision(block7);
            player2.blockcollision(block8);
            player2.blockcollision(block9);
            
        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            
                if (e.KeyCode == Keys.Up)
                {
                    if (player1.jump != true)
                    {
                        positionSend(1);
                        player1.jump = true;
                        force = G;
                    }
                }

                if (e.KeyCode == Keys.Space)
                {


                    if (player1_atack.Visible == false)
                    {
                        shootsound.Play();
                        if (player1.playerside == false)
                        {
                            player1_atack.Location = new Point(player1pic.Left - player1_atack.Width, player1pic.Top + player1pic.Height / 2 - 15);
                            player1_atack.Image = Shapes2.Properties.Resources.fireball3_left;
                            positionSend(2);
                        }
                        else
                        {
                            player1_atack.Location = new Point(player1pic.Right, player1pic.Top + player1pic.Height / 2 - 15);
                            player1_atack.Image = Shapes2.Properties.Resources.fireball3;
                            positionSend(2);

                        }
                        player1_atack.Visible = true;



                    }
                
                
                }

                if (e.KeyCode == Keys.Left) { player1.playeratackside = false; if (player1_atack.Visible == false) player1.playerside = false; player1.moveLeft = true; player1pic.Image = Shapes2.Properties.Resources.mag_left; }
                if (e.KeyCode == Keys.Right) { player1.playeratackside = true; if (player1_atack.Visible == false) player1.playerside = true; player1.moveRight = true; player1pic.Image = Shapes2.Properties.Resources.mag_right; }
            

            
        }

        private void Form1_KeyUp_1(object sender, KeyEventArgs e)
        {

            
            
            if (e.KeyCode == Keys.Left) { player1.moveLeft = false;  }
            if (e.KeyCode == Keys.Right) { player1.moveRight = false;  }

        }

        public void positionSend(byte action)
        {
            
            byte[] data =BitConverter.GetBytes(action);
            MainData.senderUdp.Send(data, 1, MainData.senderEp);
            
        }
        
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
             Delegates player2moves = new Delegates(this, player2pic,player2_atack,player2);

            MainData.receiverUdp = new UdpClient(5002);
             while (true)
            {

                byte[] data = MainData.receiverUdp.Receive(ref MainData.ReceiveIpEndPoint);
                byte datrec = data[0];
                switch (datrec)
                {
                    
                    case 1: if (player2.jump != true) { player2.jump = player2moves.move_up(); force2 = G; } break; 
                    case 2: player2moves.atack(); break;
                    case 3: player2moves.move_left(); player2.playeratackside = false; if (player2_atack.Visible == false) player2.playerside = false; break;
                    case 4: player2moves.move_right(); player2.playeratackside = true; if (player2_atack.Visible == false) player2.playerside = true; break;

                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }
       
    }
}
