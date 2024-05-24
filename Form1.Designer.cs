namespace C__Flappy_Bird_Game
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
            this.pcPipeDown = new System.Windows.Forms.PictureBox();
            this.pcPipeUp = new System.Windows.Forms.PictureBox();
            this.pcBird = new System.Windows.Forms.PictureBox();
            this.pcGround = new System.Windows.Forms.PictureBox();
            this.lbScore = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.pcGameOver = new System.Windows.Forms.PictureBox();
            this.lbGameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcPipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcPipeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcGameOver)).BeginInit();
            this.SuspendLayout();
            // 
            // pcPipeDown
            // 
            this.pcPipeDown.BackColor = System.Drawing.Color.Transparent;
            this.pcPipeDown.Image = global::C__Flappy_Bird_Game.Properties.Resources.pipedown;
            this.pcPipeDown.Location = new System.Drawing.Point(347, -3);
            this.pcPipeDown.Name = "pcPipeDown";
            this.pcPipeDown.Size = new System.Drawing.Size(100, 143);
            this.pcPipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcPipeDown.TabIndex = 0;
            this.pcPipeDown.TabStop = false;
            this.pcPipeDown.Tag = "Pipe";
            // 
            // pcPipeUp
            // 
            this.pcPipeUp.BackColor = System.Drawing.Color.Transparent;
            this.pcPipeUp.Image = global::C__Flappy_Bird_Game.Properties.Resources.pipe;
            this.pcPipeUp.Location = new System.Drawing.Point(347, 285);
            this.pcPipeUp.Name = "pcPipeUp";
            this.pcPipeUp.Size = new System.Drawing.Size(100, 146);
            this.pcPipeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcPipeUp.TabIndex = 1;
            this.pcPipeUp.TabStop = false;
            this.pcPipeUp.Tag = "Pipe";
            this.pcPipeUp.Click += new System.EventHandler(this.pcPipeUp_Click);
            // 
            // pcBird
            // 
            this.pcBird.BackColor = System.Drawing.Color.Transparent;
            this.pcBird.Image = global::C__Flappy_Bird_Game.Properties.Resources.bird;
            this.pcBird.Location = new System.Drawing.Point(68, 112);
            this.pcBird.Name = "pcBird";
            this.pcBird.Size = new System.Drawing.Size(65, 42);
            this.pcBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBird.TabIndex = 2;
            this.pcBird.TabStop = false;
            // 
            // pcGround
            // 
            this.pcGround.Image = global::C__Flappy_Bird_Game.Properties.Resources.ground;
            this.pcGround.Location = new System.Drawing.Point(-5, 423);
            this.pcGround.Name = "pcGround";
            this.pcGround.Size = new System.Drawing.Size(528, 89);
            this.pcGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcGround.TabIndex = 3;
            this.pcGround.TabStop = false;
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.Transparent;
            this.lbScore.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(12, 24);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(96, 28);
            this.lbScore.TabIndex = 4;
            this.lbScore.Text = "Score: 0";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // pcGameOver
            // 
            this.pcGameOver.Image = global::C__Flappy_Bird_Game.Properties.Resources.GameOver;
            this.pcGameOver.Location = new System.Drawing.Point(120, 180);
            this.pcGameOver.Name = "pcGameOver";
            this.pcGameOver.Size = new System.Drawing.Size(221, 153);
            this.pcGameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcGameOver.TabIndex = 5;
            this.pcGameOver.TabStop = false;
            // 
            // lbGameOver
            // 
            this.lbGameOver.AutoSize = true;
            this.lbGameOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbGameOver.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGameOver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbGameOver.Location = new System.Drawing.Point(64, 461);
            this.lbGameOver.Name = "lbGameOver";
            this.lbGameOver.Size = new System.Drawing.Size(346, 21);
            this.lbGameOver.TabIndex = 6;
            this.lbGameOver.Text = "Prees (Enter) To Play Again.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::C__Flappy_Bird_Game.Properties.Resources.Backround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(512, 513);
            this.Controls.Add(this.lbGameOver);
            this.Controls.Add(this.pcGameOver);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.pcGround);
            this.Controls.Add(this.pcBird);
            this.Controls.Add(this.pcPipeUp);
            this.Controls.Add(this.pcPipeDown);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pcPipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcPipeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcGameOver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcPipeDown;
        private System.Windows.Forms.PictureBox pcPipeUp;
        private System.Windows.Forms.PictureBox pcBird;
        private System.Windows.Forms.PictureBox pcGround;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox pcGameOver;
        private System.Windows.Forms.Label lbGameOver;
    }
}

