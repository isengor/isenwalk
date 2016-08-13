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
    public partial class LocalModMenu : Form
    {
        public LocalModMenu()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            LocalGameForm gameform = new LocalGameForm();
            gameform.label1.Text = textBox1.Text;
            gameform.label2.Text = textBox2.Text;
            

            gameform.ShowDialog(this);

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty && textBox2.Text !=String.Empty)  // поле логин не может быть пустым
                button1.Enabled = true;
            else button1.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty && textBox2.Text != String.Empty)  // поле логин не может быть пустым
                button1.Enabled = true;
            else button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

       

        
    }
}
