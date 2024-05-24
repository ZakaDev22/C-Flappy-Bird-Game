using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Flappy_Bird_Game
{
    public partial class Form1 : Form
    {

        int Gravity = 9;
        int PipeSpeed = 8;
        int Score = 0;

        bool GameEnd;

        Random Rnumber = new Random();

        public Form1()
        {
            InitializeComponent();

            pcPipeDown.Left = Rnumber.Next(1000, 1500);
            pcPipeUp.Left = Rnumber.Next(1000, 1500);

            pcGameOver.Visible = false;
            lbGameOver.Visible = false;
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            pcBird.Top += Gravity;

            pcPipeDown.Left -= PipeSpeed;
            pcPipeUp.Left -= PipeSpeed;

            lbScore.Text = "Score: " + Score.ToString();

            GameOver();

            if (pcPipeDown.Left < -80)
            {
                pcPipeDown.Height = Rnumber.Next(80, 160);
                pcPipeDown.Left = Rnumber.Next(1000, 1500);
                Score++;
            }

            if (pcPipeUp.Left < -80)
            {
                pcPipeUp .Height = Rnumber.Next(80, 160);
                pcPipeUp.Left = Rnumber.Next(1000, 1500);
                Score++;
            }

            if(Score == 10)
            {
                PipeSpeed = 10;
            }

            if (Score == 20)
            {
                PipeSpeed = 15;
            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                Gravity = 9;
            }

            if(e.KeyCode == Keys.Enter && GameEnd)
            {
                RestartGame();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Gravity = -9;
            }
        }

        private void GameOver()
        {
            if(pcBird.Bounds.IntersectsWith(pcPipeUp.Bounds) || pcBird.Bounds.IntersectsWith(pcPipeDown.Bounds) || pcBird.Bounds.IntersectsWith(pcGround.Bounds))
            {
                GameTimer.Stop();
                GameEnd = true;

                pcGameOver.Visible = true;
                lbGameOver.Visible = true;

                // MessageBox.Show("Game Over You Dead , \n Click  Rastart To Play Again");
            }

            if (pcBird.Top < -25)
            {
                GameTimer.Stop();
                GameEnd = true;

                pcGameOver.Visible = true;
                lbGameOver.Visible = true;
            }
        }

        private void RestartGame()
        {
            this.Hide();

            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void pcPipeUp_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
