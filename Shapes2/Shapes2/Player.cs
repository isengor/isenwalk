using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes2
{
    public class Player:Collision
    {

        private PictureBox player1, player2, attack;
        private ProgressBar enemylifes;
        SoundPlayer explosionsound =
          new SoundPlayer();


        public Player(PictureBox pl1, PictureBox pl2, PictureBox atk, ProgressBar enemybar)
            : base(pl1)
        {
            player1 = pl1;
            player2 = pl2;
            attack = atk;
            explosionsound.Stream = Shapes2.Properties.Resources.Explosion8sound;
            enemylifes = enemybar;
        }

        public void doAttack()
        {
            if (attack.Visible == true && playerside == false)
            {
                attack.Left -= 25;
                if (attack.Left + attack.Width < 0) { attack.Visible = false; playerside = playeratackside; }
                else if (attack.Left < player2.Right && attack.Right > player2.Left + attack.Width / 2 && attack.Bottom <= player2.Bottom + attack.Height && attack.Bottom > player2.Top) { attack.Visible = false; enemylifes.Value -= 10; explosionsound.Play(); player2.Image = Shapes2.Properties.Resources.explosion2; }
            }
            else if (attack.Visible == true && playerside == true)
            {
                attack.Left += 25;
                if (attack.Left > 1378) { attack.Visible = false; playerside = playeratackside; }
                else if (attack.Right > player2.Left && attack.Left < player2.Right - attack.Width / 2 && attack.Bottom <= player2.Bottom + attack.Height && attack.Bottom > player2.Top) { attack.Visible = false; enemylifes.Value -= 10; explosionsound.Play(); player2.Image = Shapes2.Properties.Resources.explosion2; }
            }

        }
        
    }
}
