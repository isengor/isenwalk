using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Reflection;
				
namespace Shapes2
{
    public partial class LocalGameForm : Form
    {
       
        bool player1side = true, player2side = false;
        bool player1atackside = true, player2atackside = false;

        int G = 31;
        
        
        int force;                
        int force2;

        Wonform wonform = new Wonform();
        Random rnd = new Random();

        Player player1, player2;

        int mushroom_left;
        
            SoundPlayer mushroomsound =
                new SoundPlayer();
            SoundPlayer shootsound =
               new SoundPlayer();
            SoundPlayer explosionsound =
              new SoundPlayer();
        


        public LocalGameForm()
        {
           
            

            InitializeComponent();
          
            player1 = new Player(player1pic);
            player2 = new Player(player2pic);
            mushroomsound.Stream = Shapes2.Properties.Resources.Mushroomsound;
            shootsound.Stream = Shapes2.Properties.Resources.Shootsound;
            explosionsound.Stream = Shapes2.Properties.Resources.Explosion8sound;
           

            

            mushroom_left = rnd.Next(screen.Width - mushroom.Width);
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {

            
            ///// MUSHROOM_PICKER
            if (mushroom.Visible == true && player1pic.Right > mushroom.Left && player1pic.Bottom == mushroom.Bottom && player1pic.Left < mushroom.Right) { mushroomsound.Play(); mushroom.Visible = false; if (progressBar1.Value != 100) progressBar1.Value += 10; }
            if (mushroom.Visible == true && player1pic.Left < mushroom.Right && player1pic.Bottom == mushroom.Bottom && player1pic.Right > mushroom.Left) { mushroomsound.Play(); mushroom.Visible = false; if (progressBar1.Value != 100) progressBar1.Value += 10; }
            

            if (mushroom.Visible == true && player2pic.Right > mushroom.Left && player2pic.Bottom == mushroom.Bottom && player2pic.Left < mushroom.Right) { mushroomsound.Play(); mushroom.Visible = false; if (progressBar2.Value != 100)progressBar2.Value += 10; }
            if (mushroom.Visible == true && player2pic.Left < mushroom.Right && player2pic.Bottom == mushroom.Bottom && player2pic.Right > mushroom.Left) { mushroomsound.Play(); mushroom.Visible = false; if (progressBar2.Value != 100) progressBar2.Value += 10; }
            

            /////

            
            
            if (DateTime.Now.Second % 20 == 0) { mushroom.Top = screen.Height - mushroom.Height; mushroom.Left = mushroom_left; mushroom.Visible = true;  }
            if (DateTime.Now.Second % 30 == 0) { mushroom.Visible = false; }
            
            
            //player1 ATTACK!!!
            if (player1_atack.Visible == true && player1side == false) {
                player1_atack.Left -= 25;
                if (player1_atack.Left + player1_atack.Width < 0) { player1_atack.Visible = false; player1side = player1atackside; }
                else if (player1_atack.Left < player2pic.Right && player1_atack.Right > player2pic.Left + player1_atack.Width / 2 && player1_atack.Bottom <= player2pic.Bottom + player1_atack.Height && player1_atack.Bottom > player2pic.Top) { player1_atack.Visible = false; progressBar2.Value -= 10; explosionsound.Play(); player2pic.Image = Shapes2.Properties.Resources.explosion2; }
            }
            else if (player1_atack.Visible == true && player1side == true) {
                player1_atack.Left += 25;
                if (player1_atack.Left > screen.Width) { player1_atack.Visible = false; player1side = player1atackside; }
                else if (player1_atack.Right > player2pic.Left && player1_atack.Left < player2pic.Right - player1_atack.Width / 2 && player1_atack.Bottom <= player2pic.Bottom + player1_atack.Height && player1_atack.Bottom > player2pic.Top) { player1_atack.Visible = false; progressBar2.Value -= 10; explosionsound.Play(); player2pic.Image = Shapes2.Properties.Resources.explosion2; }
            }

            //for both players, won event
            if (progressBar1.Value == 0) { player1pic.Image = Shapes2.Properties.Resources.rip3; ; timer1.Dispose(); wonform.pictureBox1.Image = Shapes2.Properties.Resources.lich_left; wonform.label1.Text = label2.Text + "! You won!"; wonform.ShowDialog(); ; this.Dispose(); }
            if (progressBar2.Value == 0) { player2pic.Image = Shapes2.Properties.Resources.rip3; timer1.Dispose(); wonform.pictureBox1.Image = Shapes2.Properties.Resources.mag_right; wonform.label1.Text = label1.Text + "! You won!"; wonform.ShowDialog(); this.Dispose(); } 

            


            


            //player2 ATTACK!!!
            if (player2_atack.Visible == true && player2side == false)
            {
                player2_atack.Left -= 25;
                if (player2_atack.Left + player2_atack.Width < 0) { player2_atack.Visible = false; player2side = player2atackside; }
                else if (player2_atack.Left < player1pic.Right && player2_atack.Right > player1pic.Left + player2_atack.Width / 2 && player2_atack.Bottom <= player1pic.Bottom + player2_atack.Height && player2_atack.Bottom > player1pic.Top) { player2_atack.Visible = false; progressBar1.Value -= 10; explosionsound.Play(); player1pic.Image = Shapes2.Properties.Resources.explosion2; }
            }
            else if (player2_atack.Visible == true && player2side == true)
            {
                player2_atack.Left += 25;
                if (player2_atack.Left > screen.Width) { player2_atack.Visible = false; player2side = player2atackside; }
                else if (player2_atack.Right > player1pic.Left && player2_atack.Left < player1pic.Right - player2_atack.Width / 2 && player2_atack.Bottom <= player1pic.Bottom + player2_atack.Height && player2_atack.Bottom > player1pic.Top) { player2_atack.Visible = false; progressBar1.Value -= 10; explosionsound.Play(); player1pic.Image = Shapes2.Properties.Resources.explosion2; }
            }



           



            //side portals
            if (player1pic.Left < screen.Left - player1pic.Width) { player1pic.Left = screen.Right; }
                    else if (player1pic.Right - player1pic.Width > screen.Right) { player1pic.Left = screen.Left - player1pic.Width; }

            if (player2pic.Left < screen.Left - player2pic.Width) { player2pic.Left = screen.Right; }
                    else if (player2pic.Right - player2pic.Width > screen.Right) { player2pic.Left = screen.Left - player2pic.Width; }


           

            /////////////////////player1


            //moves

            if (player1.moveDown == true) { player1pic.Top += 5; }
            if (player1.moveLeft == true) { player1pic.Left -= 5; }
            if (player1.moveRight == true) { player1pic.Left += 5; }
            
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
               
            

            //////////////////////////////
            //////////////////player2
            ///////////////////////////

            //moves
                if (player2.moveDown == true) { player2pic.Top += 5; }
                if (player2.moveLeft == true) { player2pic.Left -= 5; }
                if (player2.moveRight == true) { player2pic.Left += 5; }
            
            //jump
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
           
        }

        


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) { player1atackside = false; if (player1_atack.Visible == false) player1side = false; player1.moveLeft = true; player1pic.Image = Shapes2.Properties.Resources.mag_left; }
            if (e.KeyCode == Keys.D) { player1atackside = true; if (player1_atack.Visible == false) player1side = true; player1.moveRight = true; player1pic.Image = Shapes2.Properties.Resources.mag_right; }
            if (e.KeyCode == Keys.Space)
            {
                mushroom_left = rnd.Next(screen.Width - mushroom.Width);

                if (player1_atack.Visible == false)
                {
                    shootsound.Play();
                    if (player1side == false)
                    {
                        player1_atack.Location = new Point(player1pic.Left - player1_atack.Width, player1pic.Top + player1pic.Height / 2 - 15);
                        player1_atack.Image = Shapes2.Properties.Resources.fireball3_left;
                    }
                    else
                    {
                        player1_atack.Location = new Point(player1pic.Right, player1pic.Top + player1pic.Height / 2 - 15);
                        player1_atack.Image = Shapes2.Properties.Resources.fireball3;


                    }
                    player1_atack.Visible = true;



                }
                               
            }
                                      
                         
            if (e.KeyCode == Keys.W){                 
                     if (player1.jump!=true)
                     {
                         player1.jump = true;
                         force = G;
                     }
                
            }

            ////////////////////////
            //player2
            /////////////////////////
            if (e.KeyCode == Keys.Left) { player2atackside = false; if (player2_atack.Visible == false) player2side = false; player2.moveLeft = true; player2pic.Image = Shapes2.Properties.Resources.lich_left; }
            if (e.KeyCode == Keys.Right) { player2atackside = true; if (player2_atack.Visible == false) player2side = true; player2.moveRight = true; player2pic.Image = Shapes2.Properties.Resources.lich_right; }
             if (e.KeyCode == Keys.Enter)
             {

                 mushroom_left = rnd.Next(screen.Width - mushroom.Width);
                 if (player2_atack.Visible == false) 
                 {
                     shootsound.Play();
                     if (player2side == false)
                     {
                         player2_atack.Location = new Point(player2pic.Left - player2_atack.Width, player2pic.Top + player2pic.Height / 2 - 15);
                         player2_atack.Image = Shapes2.Properties.Resources.blue_fireball_left;
                     }
                     else
                     {
                         player2_atack.Location = new Point(player2pic.Right, player2pic.Top + player2pic.Height / 2 - 15);
                         player2_atack.Image = Shapes2.Properties.Resources.blue_fireball_right;
                         
                     }
                     player2_atack.Visible = true;

                 }



             }

             if (e.KeyCode == Keys.Up)
             {

                 if (player2.jump != true)
                 {
                     player2.jump = true;
                     force2 = G;
                     
                 }

             }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) { player1.moveLeft = false; }
            if (e.KeyCode == Keys.D) { player1.moveRight = false; }
            
            
            //////////
            //player2
            ////////
            if (e.KeyCode == Keys.Left) { player2.moveLeft = false; }
            if (e.KeyCode == Keys.Right) { player2.moveRight = false; }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            
            
        }
    }
}
