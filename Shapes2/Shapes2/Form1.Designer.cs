namespace Shapes2
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
            this.player2 = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bottom = new System.Windows.Forms.Panel();
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
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
            this.screen.Controls.Add(this.player2);
            this.screen.Controls.Add(this.player1);
            this.screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen.Location = new System.Drawing.Point(0, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(784, 258);
            this.screen.TabIndex = 1;
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.Red;
            this.player2.Location = new System.Drawing.Point(590, 70);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(30, 30);
            this.player2.TabIndex = 3;
            this.player2.TabStop = false;
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.player1.Location = new System.Drawing.Point(100, 70);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(30, 30);
            this.player1.TabIndex = 2;
            this.player1.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // bottom
            // 
            this.bottom.BackgroundImage = global::Shapes2.Properties.Resources.ground2;
            this.bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom.Location = new System.Drawing.Point(0, 258);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(784, 54);
            this.bottom.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 312);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.bottom);
            this.Name = "Form1";
            this.Text = "Isenwalk";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp_1);
            this.screen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.PictureBox player1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel bottom;
    }
}

