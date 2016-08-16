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
    
    public class Delegates
    {
        delegate void Enemy_move();
        delegate bool Enemy_jump();
        private Form form;
        private PictureBox player;
        private PictureBox playeratack;

        public Delegates(Form workform, PictureBox currentplayer,PictureBox attack)
        {
            form = workform;
            player = currentplayer;
            playeratack = attack;
        }


        public bool move_up()
        {
          
            if (form.InvokeRequired)
            {
                form.BeginInvoke(new Enemy_jump(move_up));
                return true;
            }
            else
            {
                return true;
            }
        }
        public void atack()
        {
            if (form.InvokeRequired)
            {
                form.BeginInvoke(new Enemy_move(atack));
                return;
            }
            else
            {
                playeratack.Visible = true;
                
            }
        }
        public void move_left()
        {
            if (form.InvokeRequired)
            {
                form.BeginInvoke(new Enemy_move(move_left));
                return;
            }
            else
            {
                player.Left -= 5;
                player.Image = Shapes2.Properties.Resources.lich_left;
            }
        }
        public void move_right()
        {
            if (form.InvokeRequired)
            {
                form.BeginInvoke(new Enemy_move(move_right));
                return;
            }
            else
            {
                player.Left += 5;
                player.Image = Shapes2.Properties.Resources.lich_right;
            }
        }


    }
}
