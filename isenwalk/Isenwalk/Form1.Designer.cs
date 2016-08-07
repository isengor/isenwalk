namespace Isenwalk
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.screen = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.player1_atack = new System.Windows.Forms.PictureBox();
            this.player2_atack = new System.Windows.Forms.PictureBox();
            this.block7 = new System.Windows.Forms.Panel();
            this.block1 = new System.Windows.Forms.Panel();
            this.block8 = new System.Windows.Forms.Panel();
            this.block3 = new System.Windows.Forms.Panel();
            this.block4 = new System.Windows.Forms.Panel();
            this.block6 = new System.Windows.Forms.Panel();
            this.block2 = new System.Windows.Forms.Panel();
            this.block5 = new System.Windows.Forms.Panel();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mushroom = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1_atack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2_atack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mushroom)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.screen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.screen.Controls.Add(this.pictureBox1);
            this.screen.Controls.Add(this.player1_atack);
            this.screen.Controls.Add(this.player2_atack);
            this.screen.Controls.Add(this.block7);
            this.screen.Controls.Add(this.block1);
            this.screen.Controls.Add(this.block8);
            this.screen.Controls.Add(this.block3);
            this.screen.Controls.Add(this.block4);
            this.screen.Controls.Add(this.block6);
            this.screen.Controls.Add(this.block2);
            this.screen.Controls.Add(this.block5);
            this.screen.Controls.Add(this.player2);
            this.screen.Controls.Add(this.player1);
            this.screen.Controls.Add(this.panel2);
            this.screen.Controls.Add(this.mushroom);
            this.screen.Controls.Add(this.pictureBox2);
            this.screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen.Location = new System.Drawing.Point(0, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(1286, 575);
            this.screen.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Image = global::Isenwalk.Properties.Resources.Flame;
            this.pictureBox2.Location = new System.Drawing.Point(0, 548);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1286, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Isenwalk.Properties.Resources.mushroom;
            this.pictureBox1.Location = new System.Drawing.Point(692, 293);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // player1_atack
            // 
            this.player1_atack.Image = global::Isenwalk.Properties.Resources.fireball3_left;
            this.player1_atack.Location = new System.Drawing.Point(535, 119);
            this.player1_atack.Name = "player1_atack";
            this.player1_atack.Size = new System.Drawing.Size(57, 24);
            this.player1_atack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1_atack.TabIndex = 13;
            this.player1_atack.TabStop = false;
            this.player1_atack.Visible = false;
            // 
            // player2_atack
            // 
            this.player2_atack.Image = global::Isenwalk.Properties.Resources.blue_fireball_right;
            this.player2_atack.Location = new System.Drawing.Point(535, 55);
            this.player2_atack.Name = "player2_atack";
            this.player2_atack.Size = new System.Drawing.Size(57, 24);
            this.player2_atack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2_atack.TabIndex = 14;
            this.player2_atack.TabStop = false;
            this.player2_atack.Visible = false;
            // 
            // block7
            // 
            this.block7.BackgroundImage = global::Isenwalk.Properties.Resources.mario_ground;
            this.block7.Location = new System.Drawing.Point(1134, 505);
            this.block7.Name = "block7";
            this.block7.Size = new System.Drawing.Size(223, 37);
            this.block7.TabIndex = 8;
            // 
            // block1
            // 
            this.block1.BackgroundImage = global::Isenwalk.Properties.Resources.mario_ground;
            this.block1.Location = new System.Drawing.Point(968, 393);
            this.block1.Name = "block1";
            this.block1.Size = new System.Drawing.Size(223, 37);
            this.block1.TabIndex = 7;
            // 
            // block8
            // 
            this.block8.BackgroundImage = global::Isenwalk.Properties.Resources.mario_ground;
            this.block8.Location = new System.Drawing.Point(0, 505);
            this.block8.Name = "block8";
            this.block8.Size = new System.Drawing.Size(223, 37);
            this.block8.TabIndex = 11;
            // 
            // block3
            // 
            this.block3.BackgroundImage = global::Isenwalk.Properties.Resources.mario_ground;
            this.block3.Location = new System.Drawing.Point(356, 435);
            this.block3.Name = "block3";
            this.block3.Size = new System.Drawing.Size(236, 37);
            this.block3.TabIndex = 8;
            // 
            // block4
            // 
            this.block4.BackgroundImage = global::Isenwalk.Properties.Resources.mario_ground;
            this.block4.Location = new System.Drawing.Point(77, 366);
            this.block4.Name = "block4";
            this.block4.Size = new System.Drawing.Size(258, 37);
            this.block4.TabIndex = 9;
            // 
            // block6
            // 
            this.block6.BackgroundImage = global::Isenwalk.Properties.Resources.mario_ground;
            this.block6.Location = new System.Drawing.Point(886, 195);
            this.block6.Name = "block6";
            this.block6.Size = new System.Drawing.Size(258, 37);
            this.block6.TabIndex = 10;
            // 
            // block2
            // 
            this.block2.BackgroundImage = global::Isenwalk.Properties.Resources.mario_ground;
            this.block2.Location = new System.Drawing.Point(646, 326);
            this.block2.Name = "block2";
            this.block2.Size = new System.Drawing.Size(226, 37);
            this.block2.TabIndex = 6;
            // 
            // block5
            // 
            this.block5.BackgroundImage = global::Isenwalk.Properties.Resources.mario_ground;
            this.block5.Location = new System.Drawing.Point(298, 237);
            this.block5.Name = "block5";
            this.block5.Size = new System.Drawing.Size(223, 37);
            this.block5.TabIndex = 12;
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.SystemColors.Desktop;
            this.player2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.player2.Image = global::Isenwalk.Properties.Resources.mariomove_left;
            this.player2.Location = new System.Drawing.Point(886, 143);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(46, 46);
            this.player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2.TabIndex = 0;
            this.player2.TabStop = false;
            // 
            // player1
            // 
            this.player1.Image = global::Isenwalk.Properties.Resources.snakemove_right;
            this.player1.Location = new System.Drawing.Point(298, 185);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(46, 46);
            this.player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1.TabIndex = 3;
            this.player1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Isenwalk.Properties.Resources.stars;
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 46);
            this.panel2.TabIndex = 15;
            // 
            // mushroom
            // 
            this.mushroom.Image = global::Isenwalk.Properties.Resources.mushroom;
            this.mushroom.Location = new System.Drawing.Point(33, 98);
            this.mushroom.Name = "mushroom";
            this.mushroom.Size = new System.Drawing.Size(49, 29);
            this.mushroom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mushroom.TabIndex = 17;
            this.mushroom.TabStop = false;
            this.mushroom.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Isenwalk.Properties.Resources.ground2;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.progressBar2);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 575);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1286, 64);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SaddleBrown;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1100, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 35);
            this.label2.TabIndex = 17;
            this.label2.Text = "Player2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SaddleBrown;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 35);
            this.label1.TabIndex = 18;
            this.label1.Text = "Player1";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(982, 38);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(254, 23);
            this.progressBar2.TabIndex = 15;
            this.progressBar2.Value = 100;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.Location = new System.Drawing.Point(122, 38);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(254, 23);
            this.progressBar1.TabIndex = 14;
            this.progressBar1.Value = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 639);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.screen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1_atack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2_atack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mushroom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.Panel block2;
        private System.Windows.Forms.Panel block1;
        private System.Windows.Forms.Panel block3;
        private System.Windows.Forms.Panel block4;
        private System.Windows.Forms.Panel block7;
        private System.Windows.Forms.Panel block6;
        private System.Windows.Forms.Panel block8;
        private System.Windows.Forms.Panel block5;
        private System.Windows.Forms.PictureBox player1_atack;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.PictureBox player2_atack;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox mushroom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

