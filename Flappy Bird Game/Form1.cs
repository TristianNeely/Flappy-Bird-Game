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
        int gravity = 5;
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

        }

        private void PipeTop_Click(object sender, EventArgs e)
        {

        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }

        }
    }
}
