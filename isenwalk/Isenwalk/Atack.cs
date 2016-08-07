using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Isenwalk
{
    public class Atack
    {
        public static System.Windows.Forms.Control do_atack(System.Windows.Forms.Control player)
        {
            PictureBox atack = new PictureBox();
            

            atack.Visible = true;
            atack.Size = new Size(24, 16);
            atack.Location = new Point(player.Location.X - atack.Width, player.Location.Y + player.Height / 2);
            atack.Image = Image.FromFile("fireball3.gif");
            atack.BackColor = SystemColors.ActiveCaptionText;


            
           //this.Controls.Add(atack);
            atack.BringToFront();
            return atack;
        }
    }
}
