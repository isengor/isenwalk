using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes2
{
    public class Collision
    {
        private System.Windows.Forms.Control player;
        public bool blockstanding;
        public bool jump;
        public string actualblock;
        public bool moveLeft, moveRight;
        public bool playerside, playeratackside;

        public Collision(System.Windows.Forms.Control pl)
        {
            player = pl;
            
            jump = false;

            blockstanding = false;
            actualblock = null;
            
            moveLeft = false;
            moveRight = false;
            playerside = false;
            playeratackside = false;
        }


        public void blockcollision(System.Windows.Forms.Control block)
        {
            //if (player.Right >= block.Left && player.Bottom-player.Height/2 > block.Top && player.Top < block.Bottom && player.Left < block.Left ) { moveRight = false;  }
            //if (player.Left <= block.Right && player.Bottom > block.Top && player.Top < block.Bottom && player.Right > block.Right ) { moveLeft = false; }
             
            if (player.Right - 1 > block.Left && player.Left + player.Width < block.Left + block.Width + player.Width && player.Top + player.Height >= block.Top && player.Top < block.Top)
                {

                    player.Top = block.Location.Y - player.Height;
                    jump = false;
                    blockstanding = true;
                    actualblock = block.Name;

                }
                else if (block.Name==actualblock) blockstanding = false;
            

            
            if (player.Left + player.Width - 1 > block.Left && player.Left + player.Width < block.Left + block.Width + player.Width && player.Top - block.Bottom <= 10 && player.Top - block.Top > -10)
            {

                jump = false;

            }
            

        }

        

        public void falling()
        {
            if (!blockstanding)
            {
                player.Top += 8;
            }
        }
    }
}
