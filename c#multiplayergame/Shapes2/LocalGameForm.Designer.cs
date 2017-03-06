namespace Shapes2
{
    partial class LocalGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalGameForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.screen = new System.Windows.Forms.Panel();
            this.player1pic = new System.Windows.Forms.PictureBox();
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
            this.player2pic = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mushroom = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player1pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1_atack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2_atack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2pic)).BeginInit();
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
            this.screen.Controls.Add(this.player1pic);
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
            this.screen.Controls.Add(this.player2pic);
            this.screen.Controls.Add(this.panel2);
            this.screen.Controls.Add(this.mushroom);
            this.screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen.Location = new System.Drawing.Point(0, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(1350, 627);
            this.screen.TabIndex = 1;
            // 
            // player1pic
            // 
            this.player1pic.Image = global::Shapes2.Properties.Resources.mag_right;
            this.player1pic.Location = new System.Drawing.Point(330, 174);
            this.player1pic.Name = "player1pic";
            this.player1pic.Size = new System.Drawing.Size(46, 46);
            this.player1pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1pic.TabIndex = 3;
            this.player1pic.TabStop = false;
            // 
            // player1_atack
            // 
            this.player1_atack.Image = global::Shapes2.Properties.Resources.fireball3_left;
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
            this.player2_atack.Image = global::Shapes2.Properties.Resources.blue_fireball_right;
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
            this.block7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("block7.BackgroundImage")));
            this.block7.Location = new System.Drawing.Point(1147, 505);
            this.block7.Name = "block7";
            this.block7.Size = new System.Drawing.Size(223, 37);
            this.block7.TabIndex = 8;
            // 
            // block1
            // 
            this.block1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("block1.BackgroundImage")));
            this.block1.Location = new System.Drawing.Point(968, 393);
            this.block1.Name = "block1";
            this.block1.Size = new System.Drawing.Size(223, 37);
            this.block1.TabIndex = 7;
            // 
            // block8
            // 
            this.block8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("block8.BackgroundImage")));
            this.block8.Location = new System.Drawing.Point(0, 505);
            this.block8.Name = "block8";
            this.block8.Size = new System.Drawing.Size(223, 37);
            this.block8.TabIndex = 11;
            // 
            // block3
            // 
            this.block3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("block3.BackgroundImage")));
            this.block3.Location = new System.Drawing.Point(368, 434);
            this.block3.Name = "block3";
            this.block3.Size = new System.Drawing.Size(236, 37);
            this.block3.TabIndex = 8;
            // 
            // block4
            // 
            this.block4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("block4.BackgroundImage")));
            this.block4.Location = new System.Drawing.Point(77, 366);
            this.block4.Name = "block4";
            this.block4.Size = new System.Drawing.Size(258, 37);
            this.block4.TabIndex = 9;
            // 
            // block6
            // 
            this.block6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("block6.BackgroundImage")));
            this.block6.Location = new System.Drawing.Point(886, 195);
            this.block6.Name = "block6";
            this.block6.Size = new System.Drawing.Size(258, 37);
            this.block6.TabIndex = 10;
            // 
            // block2
            // 
            this.block2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("block2.BackgroundImage")));
            this.block2.Location = new System.Drawing.Point(646, 326);
            this.block2.Name = "block2";
            this.block2.Size = new System.Drawing.Size(226, 37);
            this.block2.TabIndex = 6;
            // 
            // block5
            // 
            this.block5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("block5.BackgroundImage")));
            this.block5.Location = new System.Drawing.Point(298, 237);
            this.block5.Name = "block5";
            this.block5.Size = new System.Drawing.Size(223, 37);
            this.block5.TabIndex = 12;
            // 
            // player2pic
            // 
            this.player2pic.BackColor = System.Drawing.SystemColors.Desktop;
            this.player2pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.player2pic.Image = global::Shapes2.Properties.Resources.lich_left;
            this.player2pic.Location = new System.Drawing.Point(886, 143);
            this.player2pic.Name = "player2pic";
            this.player2pic.Size = new System.Drawing.Size(46, 46);
            this.player2pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2pic.TabIndex = 0;
            this.player2pic.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Shapes2.Properties.Resources.stars;
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 46);
            this.panel2.TabIndex = 15;
            // 
            // mushroom
            // 
            this.mushroom.Image = global::Shapes2.Properties.Resources.mushroom;
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
            this.panel1.BackgroundImage = global::Shapes2.Properties.Resources.ground2;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.progressBar2);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 627);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 64);
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
            // LocalGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 691);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LocalGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "IsenWalks";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.screen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player1pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1_atack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2_atack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mushroom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox player2pic;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox player1pic;
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
        
    }
}

