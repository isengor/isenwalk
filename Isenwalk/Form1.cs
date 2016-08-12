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

namespace Isenwalk
{
    public partial class Form1 : Form
    {
        public String player1left_img = "mariomove_left.gif", player1right_img = "mariomove_right.gif";
        public String player2left_img = "snakemove_left.gif", player2right_img = "snakemove_right.gif";
        bool player1side = true, player2side = false;
        bool player1atackside = true, player2atackside = false;

        int G = 31;
        
        bool right, left;
        bool jump;
        int force;

        bool right2, left2;
        bool jump2;
        int force2;
        Wonform wonform = new Wonform();
        Random rnd = new Random();
        int mushroom_left;
        
            SoundPlayer mushroomsound =
                new SoundPlayer();
            SoundPlayer shootsound =
               new SoundPlayer();
            SoundPlayer explosionsound =
              new SoundPlayer();
        


        public Form1()
        {

            

            InitializeComponent();
            mushroomsound.SoundLocation = "Mushroomsound.wav";
            mushroomsound.Load();
            shootsound.SoundLocation = "Shootsound.wav";
            shootsound.Load();
            explosionsound.SoundLocation = "Explosion8sound.wav";
            explosionsound.Load();

            mushroom_left = rnd.Next(screen.Width - mushroom.Width);
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            ///// MUSHROOM_PICKER
            if (mushroom.Visible == true && player1.Right > mushroom.Left && player1.Bottom == mushroom.Bottom && player1.Left < mushroom.Right) { mushroomsound.Play(); mushroom.Visible = false; if(progressBar1.Value!=100) progressBar1.Value += 10; }
            if (mushroom.Visible == true && player1.Left < mushroom.Right && player1.Bottom == mushroom.Bottom && player1.Right > mushroom.Left) { mushroomsound.Play(); mushroom.Visible = false; if (progressBar1.Value != 100) progressBar1.Value += 10; }
            if (mushroom.Visible == true && Collision2.top_collision(player1, mushroom)) { mushroomsound.Play(); mushroom.Visible = false; if (progressBar1.Value != 100) progressBar1.Value += 10; }

            if (mushroom.Visible == true && player2.Right > mushroom.Left && player2.Bottom == mushroom.Bottom && player2.Left < mushroom.Right) { mushroomsound.Play(); mushroom.Visible = false; if (progressBar2.Value != 100)progressBar2.Value += 10; }
            if (mushroom.Visible == true && player2.Left < mushroom.Right && player2.Bottom == mushroom.Bottom && player2.Right > mushroom.Left) { mushroomsound.Play(); mushroom.Visible = false; if (progressBar2.Value != 100) progressBar2.Value += 10; }
            if (mushroom.Visible == true && Collision2.top_collision(player2, mushroom)) { mushroomsound.Play(); mushroom.Visible = false; if (progressBar2.Value != 100) progressBar2.Value += 10; }

            /////

            
            
            if (DateTime.Now.Second % 20 == 0) { mushroom.Top = screen.Height - mushroom.Height; mushroom.Left = mushroom_left; mushroom.Visible = true;  }
            if (DateTime.Now.Second % 30 == 0) { mushroom.Visible = false; }
            
            
            //ATTACK!!!
            if (player1_atack.Visible == true && player1side == false) {
                player1_atack.Left -= 25;
                if (player1_atack.Left + player1_atack.Width < 0) { player1_atack.Visible = false; player1side = player1atackside; }
                else if (player1_atack.Left < player2.Right && player1_atack.Right > player2.Left + player1_atack.Width / 2 && player1_atack.Bottom <= player2.Bottom+player1_atack.Height && player1_atack.Bottom > player2.Top) { player1_atack.Visible = false; progressBar2.Value -= 10; explosionsound.Play(); player2.Image = Image.FromFile("explosion2.gif"); }
            }
            else if (player1_atack.Visible == true && player1side == true) {
                player1_atack.Left += 25;
                if (player1_atack.Left > screen.Width) { player1_atack.Visible = false; player1side = player1atackside; }
                else if (player1_atack.Right > player2.Left && player1_atack.Left < player2.Right - player1_atack.Width / 2 && player1_atack.Bottom  <= player2.Bottom+player1_atack.Height && player1_atack.Bottom > player2.Top) { player1_atack.Visible = false; progressBar2.Value -= 10; explosionsound.Play(); player2.Image = Image.FromFile("explosion2.gif"); }
            }

            //for both players, won event
            if (progressBar1.Value == 0) { player1.Image = Image.FromFile("rip3.png"); timer1.Dispose(); wonform.pictureBox1.Image = Image.FromFile(player2left_img); wonform.label1.Text = label2.Text + "! You won!"; wonform.ShowDialog(); ; this.Dispose(); }
            if (progressBar2.Value == 0) { player2.Image = Image.FromFile("rip3.png"); timer1.Dispose(); wonform.pictureBox1.Image = Image.FromFile(player1right_img); wonform.label1.Text = label1.Text + "! You won!"; wonform.ShowDialog(); this.Dispose(); } 

            //move right/left
            if (right == true) { player1.Left += 5; }
            if (left == true) { player1.Left -= 5; }
            
            // jump
            if (jump == true) {
                player1.Top -= force;
                    force -= 2;
            }
            
            //faling till bottom
            if (player1.Top + player1.Height >= screen.Height) { player1.Top = screen.Height - player1.Height; force = 0; jump = false; }
            else player1.Top += 8;
            
            //////blocks
            if (Collision2.top_collision(player1, block2)) { player1.Top = block2.Location.Y - player1.Height; force = 0; jump = false; }
            if (Collision2.head_collision(player1, block2)) { force = -1; }

            if (Collision2.top_collision(player1, block1)) { player1.Top = block1.Location.Y - player1.Height; force = 0; jump = false; }
            if (Collision2.head_collision(player1, block1)) { force = -1; }

            if (Collision2.top_collision(player1, block3)) { player1.Top = block3.Location.Y - player1.Height; force = 0; jump = false; }
            if (Collision2.head_collision(player1, block3)) { force = -1; }

            if (Collision2.top_collision(player1, block4)) { player1.Top = block4.Location.Y - player1.Height; force = 0; jump = false; }
            if (Collision2.head_collision(player1, block4)) { force = -1; }

            if (Collision2.top_collision(player1, block5)) { player1.Top = block5.Location.Y - player1.Height; force = 0; jump = false; }
            if (Collision2.head_collision(player1, block5)) { force = -1; }

            if (Collision2.top_collision(player1, block6)) { player1.Top = block6.Location.Y - player1.Height; force = 0; jump = false; }
            if (Collision2.head_collision(player1, block6)) { force = -1; }

            if (Collision2.top_collision(player1, block7)) { player1.Top = block7.Location.Y - player1.Height; force = 0; jump = false; }
            if (Collision2.head_collision(player1, block7)) { force = -1; }

            if (Collision2.top_collision(player1, block8)) { player1.Top = block8.Location.Y - player1.Height; force = 0; jump = false; }
            if (Collision2.head_collision(player1, block8)) { force = -1; }

            //player vs player collision
            if (Collision2.top_collision(player1, player2)) { player1.Top = player2.Location.Y - player1.Height; force = 0; jump = false; }
            
            
            //side portals
            if (player1.Left < screen.Left - player1.Width) { player1.Left = screen.Right; }
            if (player1.Right - player1.Width > screen.Right) { player1.Left = screen.Left - player1.Width; }



            //player2
           /////////////
            /////////////////////////


            //ATTACK!!!
            if (player2_atack.Visible == true && player2side == false)
            {
                player2_atack.Left -= 25;
                if (player2_atack.Left + player2_atack.Width < 0) { player2_atack.Visible = false; player2side = player2atackside; }
                else if (player2_atack.Left < player1.Right && player2_atack.Right > player1.Left + player2_atack.Width / 2 && player2_atack.Bottom <= player1.Bottom + player2_atack.Height && player2_atack.Bottom > player1.Top) { player2_atack.Visible = false; progressBar1.Value -= 10; explosionsound.Play(); player1.Image = Image.FromFile("explosion2.gif"); }
            }
            else if (player2_atack.Visible == true && player2side == true)
            {
                player2_atack.Left += 25;
                if (player2_atack.Left > screen.Width) { player2_atack.Visible = false; player2side = player2atackside; }
                else if (player2_atack.Right > player1.Left && player2_atack.Left < player1.Right - player2_atack.Width / 2 && player2_atack.Bottom <= player1.Bottom+player2_atack.Height && player2_atack.Bottom > player1.Top) { player2_atack.Visible = false; progressBar1.Value -= 10; explosionsound.Play(); player1.Image = Image.FromFile("explosion2.gif"); }
            }



            //move right/left
            if (right2 == true) { player2.Left += 5; }
            if (left2 == true) { player2.Left -= 5; }

            // jump
            if (jump2 == true)
            {
                player2.Top -= force2;
                force2 -= 2;
            }

            //faling till bottom
            if (player2.Top + player2.Height >= screen.Height) { player2.Top = screen.Height - player2.Height; force2 = 0; jump2 = false; }
            else player2.Top += 8;

            //////blocks
            if (Collision2.top_collision(player2, block1)) { force2 = 0; jump2 = false; player2.Top = block1.Location.Y - player2.Height; }
            if (Collision2.head_collision(player2, block1)) { force2 = -1; }

            if (Collision2.top_collision(player2, block2)) { force2 = 0; jump2 = false; player2.Top = block2.Location.Y - player2.Height; }
            if (Collision2.head_collision(player2, block2)) { force2 = -1; }

            if (Collision2.top_collision(player2, block3)) { force2 = 0; jump2 = false; player2.Top = block3.Location.Y - player2.Height; }
            if (Collision2.head_collision(player2, block3)) { force2 = -1; }

            if (Collision2.top_collision(player2, block4)) { force2 = 0; jump2 = false; player2.Top = block4.Location.Y - player2.Height; }
            if (Collision2.head_collision(player2, block4)) { force2 = -1; }

            if (Collision2.top_collision(player2, block5)) { force2 = 0; jump2 = false; player2.Top = block5.Location.Y - player2.Height; }
            if (Collision2.head_collision(player2, block5)) { force2 = -1; }

            if (Collision2.top_collision(player2, block6)) { force2 = 0; jump2 = false; player2.Top = block6.Location.Y - player2.Height; }
            if (Collision2.head_collision(player2, block6)) { force2 = -1; }

            if (Collision2.top_collision(player2, block7)) { force2 = 0; jump2 = false; player2.Top = block7.Location.Y - player2.Height; }
            if (Collision2.head_collision(player2, block7)) { force2 = -1; }

            if (Collision2.top_collision(player2, block8)) { force2 = 0; jump2 = false; player2.Top = block8.Location.Y - player2.Height; }
            if (Collision2.head_collision(player2, block8)) { force2 = -1; }


            //player vs player collision
            if (Collision2.top_collision(player2, player1)) { player2.Top = player1.Location.Y - player2.Height; force2 = 0; jump2 = false; }


            //side portals
            if (player2.Left < screen.Left - player2.Width) { player2.Left = screen.Right; }
            if (player2.Right - player2.Width > screen.Right) { player2.Left = screen.Left - player2.Width; }

        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) { player1atackside = false; if(player1_atack.Visible==false) player1side = false; left = true; player1.Image = Image.FromFile(player1left_img); }
            if (e.KeyCode == Keys.D) { player1atackside = true; if (player1_atack.Visible == false) player1side = true; right = true; player1.Image = Image.FromFile(player1right_img); }
            if (e.KeyCode == Keys.Space)
            {
                mushroom_left = rnd.Next(screen.Width - mushroom.Width);

                if (player1_atack.Visible == false)
                {
                    shootsound.Play();
                    if (player1side == false)
                    {
                        player1_atack.Location = new Point(player1.Left - player1_atack.Width, player1.Top + player1.Height / 2 - 15);
                        player1_atack.Image = Image.FromFile("fireball3_left.gif");
                    }
                    else
                    {
                        player1_atack.Location = new Point(player1.Right, player1.Top + player1.Height / 2 - 15);
                        player1_atack.Image = Image.FromFile("fireball3.gif");

                    }
                    player1_atack.Visible = true;



                }
                               
            }
                                      
                         
            if (e.KeyCode == Keys.W){                 
                     if (jump!=true)
                     {
                         jump = true;
                         force = G;
                     }
                
            }

            ////////////////////////
            //player2
            /////////////////////////
            if (e.KeyCode == Keys.Left) { player2atackside = false; if (player2_atack.Visible == false) player2side = false; left2 = true; player2.Image = Image.FromFile(player2left_img); }
            if (e.KeyCode == Keys.Right) { player2atackside = true; if (player2_atack.Visible == false) player2side = true; right2 = true; player2.Image = Image.FromFile(player2right_img); }
             if (e.KeyCode == Keys.Enter)
             {

                 mushroom_left = rnd.Next(screen.Width - mushroom.Width);
                 if (player2_atack.Visible == false) 
                 {
                     shootsound.Play();
                     if (player2side == false)
                     {
                         player2_atack.Location = new Point(player2.Left - player2_atack.Width, player2.Top + player2.Height / 2 - 15);
                         player2_atack.Image = Image.FromFile("blue_fireball_left.gif");
                     }
                     else
                     {
                         player2_atack.Location = new Point(player2.Right, player2.Top + player2.Height / 2 - 15);
                         player2_atack.Image = Image.FromFile("blue_fireball_right.gif");
                         
                     }
                     player2_atack.Visible = true;

                 }



             }

             if (e.KeyCode == Keys.Up)
             {

                 if (jump2 != true)
                 {
                     jump2 = true;
                     force2 = G;
                     
                 }

             }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) { left = false; }
            if (e.KeyCode == Keys.D) { right = false; }
            if (e.KeyCode == Keys.W) { jump = false; }
            
            //////////
            //player2
            ////////
            if (e.KeyCode == Keys.Left) { left2 = false; }
            if (e.KeyCode == Keys.Right) { right2 = false; }
            if (e.KeyCode == Keys.Up) { jump2 = false; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            player1.Image = Image.FromFile(player1right_img);
            player2.Image = Image.FromFile(player2left_img);
            
        }
    }
}
