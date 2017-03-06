namespace Shapes2
{
    partial class Conectionwindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cxlButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ожидаем соединение клиента";
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(25, 171);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(83, 22);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Начать";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // cxlButton
            // 
            this.cxlButton.Location = new System.Drawing.Point(155, 170);
            this.cxlButton.Name = "cxlButton";
            this.cxlButton.Size = new System.Drawing.Size(83, 23);
            this.cxlButton.TabIndex = 4;
            this.cxlButton.Text = "Отмена";
            this.cxlButton.UseVisualStyleBackColor = true;
            this.cxlButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Shapes2.Properties.Resources.loading;
            this.pictureBox1.Location = new System.Drawing.Point(89, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Conectionwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 219);
            this.ControlBox = false;
            this.Controls.Add(this.cxlButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Conectionwindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Соединение";
            this.Activated += new System.EventHandler(this.Conectionwindow_Activated);
            this.Load += new System.EventHandler(this.Conectionwindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cxlButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}