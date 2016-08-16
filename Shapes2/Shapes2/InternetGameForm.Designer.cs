namespace Shapes2
{
    partial class InternetGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InternetGameForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.screen = new System.Windows.Forms.Panel();
            this.block8 = new System.Windows.Forms.Panel();
            this.block9 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.block7 = new System.Windows.Forms.Panel();
            this.block1 = new System.Windows.Forms.Panel();
            this.block6 = new System.Windows.Forms.Panel();
            this.block3 = new System.Windows.Forms.Panel();
            this.block4 = new System.Windows.Forms.Panel();
            this.block2 = new System.Windows.Forms.Panel();
            this.block5 = new System.Windows.Forms.Panel();
            this.player1_atack = new System.Windows.Forms.PictureBox();
            this.player2_atack = new System.Windows.Forms.PictureBox();
            this.player2pic = new System.Windows.Forms.PictureBox();
            this.player1pic = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bottom = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player1_atack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2_atack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1pic)).BeginInit();
            this.bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.screen.Controls.Add(this.block8);
            this.screen.Controls.Add(this.block9);
            this.screen.Controls.Add(this.panel2);
            this.screen.Controls.Add(this.block7);
            this.screen.Controls.Add(this.block1);
            this.screen.Controls.Add(this.block6);
            this.screen.Controls.Add(this.block3);
            this.screen.Controls.Add(this.block4);
            this.screen.Controls.Add(this.block2);
            this.screen.Controls.Add(this.block5);
            this.screen.Controls.Add(this.player1_atack);
            this.screen.Controls.Add(this.player2_atack);
            this.screen.Controls.Add(this.player2pic);
            this.screen.Controls.Add(this.player1pic);
            this.screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen.Location = new System.Drawing.Point(0, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(1362, 651);
            this.screen.TabIndex = 1;
            // 
            // block8
            // 
            this.block8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("block8.BackgroundImage")));
            this.block8.Location = new System.Drawing.Point(950, 246);
            this.block8.Name = "block8";
            this.block8.Size = new System.Drawing.Size(223, 37);
            this.block8.TabIndex = 23;
            // 
            // block9
            // 
            this.block9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("block9.BackgroundImage")));
            this.block9.Location = new System.Drawing.Point(573, 365);
            this.block9.Name = "block9";
            this.block9.Size = new System.Drawing.Size(223, 37);
            this.block9.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Shapes2.Properties.Resources.stars;
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 46);
            this.panel2.TabIndex = 26;
            // 
            // block7
            // 
            this.block7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("block7.BackgroundImage")));
            this.block7.Location = new System.Drawing.Point(1139, 514);
            this.block7.Name = "block7";
            this.block7.Size = new System.Drawing.Size(223, 37);
            this.block7.TabIndex = 20;
            // 
            // block1
            // 
            this.block1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("block1.BackgroundImage")));
            this.block1.Location = new System.Drawing.Point(757, 500);
            this.block1.Name = "block1";
            this.block1.Size = new System.Drawing.Size(223, 37);
            this.block1.TabIndex = 19;
            // 
            // block6
            // 
            this.block6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("block6.BackgroundImage")));
            this.block6.Location = new System.Drawing.Point(6, 514);
            this.block6.Name = "block6";
            this.block6.Size = new System.Drawing.Size(223, 37);
            this.block6.TabIndex = 24;
            // 
            // block3
            // 
            this.block3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("block3.BackgroundImage")));
            this.block3.Location = new System.Drawing.Point(378, 500);
            this.block3.Name = "block3";
            this.block3.Size = new System.Drawing.Size(236, 37);
            this.block3.TabIndex = 21;
            // 
            // block4
            // 
            this.block4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("block4.BackgroundImage")));
            this.block4.Location = new System.Drawing.Point(83, 375);
            this.block4.Name = "block4";
            this.block4.Size = new System.Drawing.Size(258, 37);
            this.block4.TabIndex = 22;
            // 
            // block2
            // 
            this.block2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("block2.BackgroundImage")));
            this.block2.Location = new System.Drawing.Point(1023, 375);
            this.block2.Name = "block2";
            this.block2.Size = new System.Drawing.Size(254, 37);
            this.block2.TabIndex = 18;
            // 
            // block5
            // 
            this.block5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("block5.BackgroundImage")));
            this.block5.Location = new System.Drawing.Point(185, 246);
            this.block5.Name = "block5";
            this.block5.Size = new System.Drawing.Size(223, 37);
            this.block5.TabIndex = 25;
            // 
            // player1_atack
            // 
            this.player1_atack.Image = global::Shapes2.Properties.Resources.fireball3_left;
            this.player1_atack.Location = new System.Drawing.Point(645, 472);
            this.player1_atack.Name = "player1_atack";
            this.player1_atack.Size = new System.Drawing.Size(57, 24);
            this.player1_atack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1_atack.TabIndex = 16;
            this.player1_atack.TabStop = false;
            this.player1_atack.Visible = false;
            // 
            // player2_atack
            // 
            this.player2_atack.Image = global::Shapes2.Properties.Resources.blue_fireball_right;
            this.player2_atack.Location = new System.Drawing.Point(645, 408);
            this.player2_atack.Name = "player2_atack";
            this.player2_atack.Size = new System.Drawing.Size(57, 24);
            this.player2_atack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2_atack.TabIndex = 17;
            this.player2_atack.TabStop = false;
            this.player2_atack.Visible = false;
            // 
            // player2pic
            // 
            this.player2pic.BackColor = System.Drawing.SystemColors.Desktop;
            this.player2pic.Image = global::Shapes2.Properties.Resources.lich_left;
            this.player2pic.Location = new System.Drawing.Point(1073, 599);
            this.player2pic.Name = "player2pic";
            this.player2pic.Size = new System.Drawing.Size(48, 46);
            this.player2pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2pic.TabIndex = 3;
            this.player2pic.TabStop = false;
            // 
            // player1pic
            // 
            this.player1pic.BackColor = System.Drawing.SystemColors.Desktop;
            this.player1pic.Image = global::Shapes2.Properties.Resources.mag_right;
            this.player1pic.Location = new System.Drawing.Point(252, 599);
            this.player1pic.Name = "player1pic";
            this.player1pic.Size = new System.Drawing.Size(48, 46);
            this.player1pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1pic.TabIndex = 2;
            this.player1pic.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // bottom
            // 
            this.bottom.BackgroundImage = global::Shapes2.Properties.Resources.ground2;
            this.bottom.Controls.Add(this.label2);
            this.bottom.Controls.Add(this.label1);
            this.bottom.Controls.Add(this.progressBar2);
            this.bottom.Controls.Add(this.progressBar1);
            this.bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom.Location = new System.Drawing.Point(0, 651);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(1362, 65);
            this.bottom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(1161, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(200, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(1020, 30);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(254, 23);
            this.progressBar2.TabIndex = 19;
            this.progressBar2.Value = 100;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.Location = new System.Drawing.Point(106, 30);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(254, 23);
            this.progressBar1.TabIndex = 18;
            this.progressBar1.Value = 100;
            // 
            // InternetGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1362, 716);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.bottom);
            this.Name = "InternetGameForm";
            this.Text = "Isenwalk";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp_1);
            this.screen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player1_atack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2_atack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1pic)).EndInit();
            this.bottom.ResumeLayout(false);
            this.bottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel screen;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel bottom;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox player2pic;
        public System.Windows.Forms.PictureBox player1pic;
        private System.Windows.Forms.PictureBox player1_atack;
        private System.Windows.Forms.PictureBox player2_atack;
        private System.Windows.Forms.Panel block7;
        private System.Windows.Forms.Panel block1;
        private System.Windows.Forms.Panel block6;
        private System.Windows.Forms.Panel block3;
        private System.Windows.Forms.Panel block4;
        private System.Windows.Forms.Panel block8;
        private System.Windows.Forms.Panel block2;
        private System.Windows.Forms.Panel block5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel block9;
        public System.Windows.Forms.ProgressBar progressBar2;
        public System.Windows.Forms.ProgressBar progressBar1;
    }
}

