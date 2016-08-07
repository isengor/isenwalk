using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isenwalk
{
    public static class Collision2
    {
        public static bool top_collision(System.Windows.Forms.Control player, System.Windows.Forms.Control block)
        {
            if (player.Left + player.Width - 1 > block.Left && player.Left + player.Width < block.Left + block.Width + player.Width && player.Top + player.Height >= block.Top && player.Top < block.Top) return true;
            else return false;

        }

        public static bool head_collision(System.Windows.Forms.Control player, System.Windows.Forms.Control block)
        {
            if (player.Left + player.Width - 1 > block.Left && player.Left + player.Width < block.Left + block.Width + player.Width && player.Top - block.Bottom <= 10 && player.Top - block.Top > -10) return true;
            else return false;

        }
    }
   
}
