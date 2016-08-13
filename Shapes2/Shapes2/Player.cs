using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes2
{
    class Player:Collision
    {
        
        private System.Windows.Forms.Control player;
        

        public Player(System.Windows.Forms.Control pl):base(pl)
        {
            player = pl;
            
        }
    }
}
