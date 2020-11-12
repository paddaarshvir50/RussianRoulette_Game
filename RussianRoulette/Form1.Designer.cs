namespace RussianRoulette
{
    partial class RussianRoulette
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            this.btnShoot = new System.Windows.Forms.Button();
            this.btnSpin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRandom = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBulletsFired = new System.Windows.Forms.Label();
            this.lblAway = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKill = new System.Windows.Forms.Label();
            this.btnPointAway2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 266);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wins";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 266);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Losses";
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Location = new System.Drawing.Point(17, 308);
            this.lblWins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(16, 17);
            this.lblWins.TabIndex = 2;
            this.lblWins.Text = "0";
            // 
            // lblLosses
            // 
            this.lblLosses.AutoSize = true;
            this.lblLosses.Location = new System.Drawing.Point(76, 308);
            this.lblLosses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(16, 17);
            this.lblLosses.TabIndex = 3;
            this.lblLosses.Text = "0";
            // 
            // btnShoot
            // 
            this.btnShoot.Enabled = false;
            this.btnShoot.Location = new System.Drawing.Point(17, 68);
            this.btnShoot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(100, 28);
            this.btnShoot.TabIndex = 4;
            this.btnShoot.Text = "Shoot";
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // btnSpin
            // 
            this.btnSpin.Location = new System.Drawing.Point(17, 103);
            this.btnSpin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(100, 28);
            this.btnSpin.TabIndex = 6;
            this.btnSpin.Text = "Spin Chamber";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 266);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Random Number";
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Location = new System.Drawing.Point(433, 308);
            this.lblRandom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(0, 17);
            this.lblRandom.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bullets Fired";
            // 
            // lblBulletsFired
            // 
            this.lblBulletsFired.AutoSize = true;
            this.lblBulletsFired.Location = new System.Drawing.Point(288, 306);
            this.lblBulletsFired.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBulletsFired.Name = "lblBulletsFired";
            this.lblBulletsFired.Size = new System.Drawing.Size(16, 17);
            this.lblBulletsFired.TabIndex = 10;
            this.lblBulletsFired.Text = "0";
            // 
            // lblAway
            // 
            this.lblAway.AutoSize = true;
            this.lblAway.Location = new System.Drawing.Point(225, 306);
            this.lblAway.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAway.Name = "lblAway";
            this.lblAway.Size = new System.Drawing.Size(16, 17);
            this.lblAway.TabIndex = 11;
            this.lblAway.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 266);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Point Away";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RussianRoulette.Resource1.Revolver;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(184, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 199);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 266);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(131, 308);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(16, 17);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblKill);
            this.panel1.Controls.Add(this.btnPointAway2);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblAway);
            this.panel1.Controls.Add(this.lblBulletsFired);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblRandom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSpin);
            this.panel1.Controls.Add(this.btnShoot);
            this.panel1.Controls.Add(this.lblLosses);
            this.panel1.Controls.Add(this.lblWins);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 334);
            this.panel1.TabIndex = 16;
            // 
            // lblKill
            // 
            this.lblKill.AutoSize = true;
            this.lblKill.Location = new System.Drawing.Point(385, 235);
            this.lblKill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKill.Name = "lblKill";
            this.lblKill.Size = new System.Drawing.Size(12, 17);
            this.lblKill.TabIndex = 17;
            this.lblKill.Text = " ";
            this.lblKill.Visible = false;
            // 
            // btnPointAway2
            // 
            this.btnPointAway2.Enabled = false;
            this.btnPointAway2.Location = new System.Drawing.Point(17, 139);
            this.btnPointAway2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPointAway2.Name = "btnPointAway2";
            this.btnPointAway2.Size = new System.Drawing.Size(100, 28);
            this.btnPointAway2.TabIndex = 16;
            this.btnPointAway2.Text = "Point Away";
            this.btnPointAway2.UseVisualStyleBackColor = true;
            this.btnPointAway2.Click += new System.EventHandler(this.btnPointAway2_Click);
            // 
            // RussianRoulette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(517, 350);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RussianRoulette";
            this.Text = "Russian Roulette";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblLosses;
        private System.Windows.Forms.Button btnShoot;
        //private System.Windows.Forms.Button btnPointAway;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBulletsFired;
        private System.Windows.Forms.Label lblAway;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPointAway2;
        private System.Windows.Forms.Label lblKill;
    }
}

