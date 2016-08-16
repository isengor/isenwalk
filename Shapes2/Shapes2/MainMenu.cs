using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes2
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LocalModMenu localgamemenu = new LocalModMenu();
            
            localgamemenu.ShowDialog();
            
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InternetModMenu ipmenu = new InternetModMenu();
            ipmenu.ShowDialog();
        }
    }
}
