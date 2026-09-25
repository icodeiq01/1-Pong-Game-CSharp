namespace Pong_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pPlayer = new System.Windows.Forms.PictureBox();
            this.pComputer = new System.Windows.Forms.PictureBox();
            this.pball = new System.Windows.Forms.PictureBox();
            this.gtimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblComputerScore = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pball)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pPlayer
            // 
            this.pPlayer.Image = ((System.Drawing.Image)(resources.GetObject("pPlayer.Image")));
            this.pPlayer.Location = new System.Drawing.Point(2, 83);
            this.pPlayer.Name = "pPlayer";
            this.pPlayer.Size = new System.Drawing.Size(25, 140);
            this.pPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pPlayer.TabIndex = 0;
            this.pPlayer.TabStop = false;
            // 
            // pComputer
            // 
            this.pComputer.Image = ((System.Drawing.Image)(resources.GetObject("pComputer.Image")));
            this.pComputer.Location = new System.Drawing.Point(499, 83);
            this.pComputer.Name = "pComputer";
            this.pComputer.Size = new System.Drawing.Size(25, 140);
            this.pComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pComputer.TabIndex = 1;
            this.pComputer.TabStop = false;
            // 
            // pball
            // 
            this.pball.Image = ((System.Drawing.Image)(resources.GetObject("pball.Image")));
            this.pball.Location = new System.Drawing.Point(253, 134);
            this.pball.Name = "pball";
            this.pball.Size = new System.Drawing.Size(18, 18);
            this.pball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pball.TabIndex = 2;
            this.pball.TabStop = false;
            // 
            // gtimer
            // 
            this.gtimer.Enabled = true;
            this.gtimer.Interval = 20;
            this.gtimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 34);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Edwardian Script ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(201, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pong Game";
            // 
            // lblComputerScore
            // 
            this.lblComputerScore.AutoSize = true;
            this.lblComputerScore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblComputerScore.Font = new System.Drawing.Font("Felix Titling", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerScore.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblComputerScore.Location = new System.Drawing.Point(382, 51);
            this.lblComputerScore.Name = "lblComputerScore";
            this.lblComputerScore.Size = new System.Drawing.Size(31, 32);
            this.lblComputerScore.TabIndex = 4;
            this.lblComputerScore.Text = "0";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPlayerScore.Font = new System.Drawing.Font("Felix Titling", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore.ForeColor = System.Drawing.Color.Red;
            this.lblPlayerScore.Location = new System.Drawing.Point(90, 51);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(31, 32);
            this.lblPlayerScore.TabIndex = 5;
            this.lblPlayerScore.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(536, 309);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblComputerScore);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pball);
            this.Controls.Add(this.pComputer);
            this.Controls.Add(this.pPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Pong Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pball)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pPlayer;
        private System.Windows.Forms.PictureBox pComputer;
        private System.Windows.Forms.PictureBox pball;
        private System.Windows.Forms.Timer gtimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblComputerScore;
        private System.Windows.Forms.Label lblPlayerScore;
    }
}

