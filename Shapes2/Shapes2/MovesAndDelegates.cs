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
    public class MovesAndDelegates
    {
        delegate void Enemy_move();

        private Form form;
        private PictureBox player;


        public MovesAndDelegates(Form workform, PictureBox currentplayer)
        {
            form = workform;
            player = currentplayer;

        }


        public void move_up()
        {
            if (form.InvokeRequired)
            {
                form.BeginInvoke(new Enemy_move(move_up));
                return;
            }
            else
            {
                player.Top -= 5;
            }
        }
        public void move_down()
        {
            if (form.InvokeRequired)
            {
                form.BeginInvoke(new Enemy_move(move_down));
                return;
            }
            else
            {
                player.Top += 5;
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
            }
        }


    }
}
