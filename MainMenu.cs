using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Shapes2
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            
        }
        Shapes2.Form1 gameform = new Form1();
        
        private void MainMenu_Activated(object sender, EventArgs e)
        {
            IPHostEntry host;
            textBox1.Text = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)                              ////// находим  ip 
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    textBox1.Text = ip.ToString();
                }
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != String.Empty)
            {
              
                button2.Enabled = true;
            }
            else { button2.Enabled = false; button1.Enabled = false; }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
          //  gameform.enemyIp = textBox2.Text; // устанавливаем ip оппонента 
            button1.Enabled = true;
        }
    }
}
