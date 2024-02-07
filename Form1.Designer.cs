namespace Battleship_Fight
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
            this.EnemyAI = new System.Windows.Forms.PictureBox();
            this.Bullet = new System.Windows.Forms.PictureBox();
            this.MainShip = new System.Windows.Forms.PictureBox();
            this.EnemyAI2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyAI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyAI2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EnemyAI
            // 
            this.EnemyAI.BackColor = System.Drawing.Color.IndianRed;
            this.EnemyAI.ImageLocation = "C:\\Users\\Sebi\\source\\repos\\Battleship Fight\\Resources\\enemey1.png";
            this.EnemyAI.Location = new System.Drawing.Point(864, 526);
            this.EnemyAI.Name = "EnemyAI";
            this.EnemyAI.Size = new System.Drawing.Size(200, 228);
            this.EnemyAI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyAI.TabIndex = 2;
            this.EnemyAI.TabStop = false;
            // 
            // Bullet
            // 
            this.Bullet.ImageLocation = "C:\\Users\\Sebi\\source\\repos\\Battleship Fight\\Resources\\bullet.png";
            this.Bullet.Location = new System.Drawing.Point(1133, 12);
            this.Bullet.Name = "Bullet";
            this.Bullet.Size = new System.Drawing.Size(24, 12);
            this.Bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bullet.TabIndex = 1;
            this.Bullet.TabStop = false;
            // 
            // MainShip
            // 
            this.MainShip.BackColor = System.Drawing.Color.Transparent;
            this.MainShip.ImageLocation = "C:\\Users\\Sebi\\source\\repos\\Battleship Fight\\Resources\\MainSHturn.png";
            this.MainShip.Location = new System.Drawing.Point(108, 526);
            this.MainShip.Name = "MainShip";
            this.MainShip.Size = new System.Drawing.Size(189, 228);
            this.MainShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainShip.TabIndex = 0;
            this.MainShip.TabStop = false;
            this.MainShip.Click += new System.EventHandler(this.b1click);
            // 
            // EnemyAI2
            // 
            this.EnemyAI2.BackColor = System.Drawing.Color.IndianRed;
            this.EnemyAI2.ImageLocation = "C:\\Users\\Sebi\\source\\repos\\Battleship Fight\\Resources\\enemey1.png";
            this.EnemyAI2.Location = new System.Drawing.Point(551, 526);
            this.EnemyAI2.Name = "EnemyAI2";
            this.EnemyAI2.Size = new System.Drawing.Size(200, 228);
            this.EnemyAI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyAI2.TabIndex = 3;
            this.EnemyAI2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1180, 754);
            this.Controls.Add(this.EnemyAI2);
            this.Controls.Add(this.EnemyAI);
            this.Controls.Add(this.Bullet);
            this.Controls.Add(this.MainShip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyup);
            ((System.ComponentModel.ISupportInitialize)(this.EnemyAI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyAI2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MainShip;
        private System.Windows.Forms.PictureBox Bullet;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox EnemyAI;
        private System.Windows.Forms.PictureBox EnemyAI2;
    }
}

