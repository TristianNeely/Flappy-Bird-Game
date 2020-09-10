using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird_Game
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 8;
        int score = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ground_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            FlappyBird.Top += gravity;
            PipeBottom.Left -= pipeSpeed;
            PipeTop.Left -= pipeSpeed;
            ScoreText.Text = "Score: " + score;


            if (PipeBottom.Left < -150)
            {
                PipeBottom.Left = 800;
                score++;
            }
            if (PipeTop.Left < -180)
            {
                PipeTop.Left = 950;
                score++;
            }

            if (FlappyBird.Bounds.IntersectsWith(PipeBottom.Bounds) || FlappyBird.Bounds.IntersectsWith(PipeTop.Bounds) || FlappyBird.Bounds.IntersectsWith(Ground.Bounds) || FlappyBird.Top < -25)
            {
                endGame();
            }

            if (score > 5)
            {
                pipeSpeed = 15;
            } 

            if (score > 25)
            {
                pipeSpeed = 25;
            }


            if (score > 50)
            {
                pipeSpeed = 40;
            }


            if (score > 100)
            {
                pipeSpeed = 60;
            }


            if (score > 200)
            {
                pipeSpeed = 90;
            }

            if (score > 500)
            {
                pipeSpeed = 125;
            }

            if (score > 1000)
            {
                pipeSpeed = 175;
            }


            if (FlappyBird.Top < 25)
            {
                endGame();
            }




        }

        private void PipeTop_Click(object sender, EventArgs e)
        {

        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -8;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 8;
            }

        }

       private void endGame()
        {
            gameTimer.Stop();
            ScoreText.Text += " Game Over!";
        }

    }
}
