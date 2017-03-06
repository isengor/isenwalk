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
        private PictureBox playerpic;
        private PictureBox playerattackpic;
        private Player player;
        public Delegates(Form workform, PictureBox currentplayer,PictureBox attack, Player playerAtributs)
        {
            form = workform;
            playerpic = currentplayer;
            playerattackpic = attack;
            player=playerAtributs;
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
                if (playerattackpic.Visible == false)
                {

                    if (player.playerside == false)
                    {
                        playerattackpic.Location = new Point(playerpic.Left - playerattackpic.Width, playerpic.Top + playerpic.Height / 2 - 15);
                        playerattackpic.Image = Shapes2.Properties.Resources.blue_fireball_left;

                    }
                    else
                    {
                        playerattackpic.Location = new Point(playerpic.Right, playerpic.Top + playerpic.Height / 2 - 15);
                        playerattackpic.Image = Shapes2.Properties.Resources.blue_fireball_right;


                    }
                    playerattackpic.Visible = true;
                }
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
                playerpic.Left -= 5;
                playerpic.Image = Shapes2.Properties.Resources.lich_left;
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
                playerpic.Left += 5;
                playerpic.Image = Shapes2.Properties.Resources.lich_right;
            }
        }


    }
}
