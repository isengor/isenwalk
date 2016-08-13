﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes2
{
    class Collision
    {
        private System.Windows.Forms.Control player;
        public bool blockstanding;
        public bool jump;
        public string actualblock;
        public bool moveDown, moveLeft, moveRight;

        public Collision(System.Windows.Forms.Control pl)
        {
            player = pl;
            
            jump = false;

            blockstanding = false;
            actualblock = null;
            moveDown = false;
            moveLeft = false;
            moveRight = false;
        }


        public void blockcollision(System.Windows.Forms.Control block)
        {
            
             
            if (player.Left + player.Width - 1 > block.Left && player.Left + player.Width < block.Left + block.Width + player.Width && player.Top + player.Height >= block.Top && player.Top < block.Top)
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