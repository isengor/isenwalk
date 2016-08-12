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
    public partial class Mainmenu : Form
    {
        public Mainmenu()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 gameform = new Form1();
            gameform.label1.Text = textBox1.Text;
            gameform.label2.Text = textBox2.Text;
            if (radioButton1.Checked) {  gameform.player1left_img = "snakemove_left.gif"; gameform.player1right_img = "snakemove_right.gif"; }
            if (radioButton2.Checked) { gameform.player2left_img = "batman_left.gif"; gameform.player2right_img = "batman_right.gif"; }
            if (radioButton6.Checked) { gameform.player2left_img = "mariomove_left.gif"; gameform.player2right_img = "mariomove_right.gif"; }
            if (radioButton5.Checked) { gameform.player1left_img = "soldier_left.gif"; gameform.player1right_img = "soldier_right.gif"; }

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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { pictureBox1.Image = Image.FromFile("snakemove_right.gif"); }
            if (radioButton2.Checked) { pictureBox2.Image = Image.FromFile("batman_left.gif"); }
            if (radioButton6.Checked) { pictureBox2.Image = Image.FromFile("mariomove_left.gif"); }
            if (radioButton5.Checked) { pictureBox1.Image = Image.FromFile("soldier_right.gif"); }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { pictureBox1.Image = Image.FromFile("snakemove_right.gif"); }
            if (radioButton2.Checked) { pictureBox2.Image = Image.FromFile("batman_left.gif"); }
            if (radioButton6.Checked) { pictureBox2.Image = Image.FromFile("mariomove_left.gif"); }
            if (radioButton5.Checked) { pictureBox1.Image = Image.FromFile("soldier_right.gif"); }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { pictureBox1.Image = Image.FromFile("snakemove_right.gif"); }
            if (radioButton2.Checked) { pictureBox2.Image = Image.FromFile("batman_left.gif"); }
            if (radioButton6.Checked) { pictureBox2.Image = Image.FromFile("mariomove_left.gif"); }
            if (radioButton5.Checked) { pictureBox1.Image = Image.FromFile("soldier_right.gif"); }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { pictureBox1.Image = Image.FromFile("snakemove_right.gif"); }
            if (radioButton2.Checked) { pictureBox2.Image = Image.FromFile("batman_left.gif"); }
            if (radioButton6.Checked) { pictureBox2.Image = Image.FromFile("mariomove_left.gif"); }
            if (radioButton5.Checked) { pictureBox1.Image = Image.FromFile("soldier_right.gif"); }
        }

        
    }
}
