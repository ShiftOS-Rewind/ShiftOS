using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShiftOS.Main.Apps
{
    public partial class Pong : UserControl
    {
        bool goUp = false;
        bool goDown = false;
        int speed = 5;
        float ballX = 5;
        float ballY = 5;
        public Pong()
        {
            InitializeComponent();
            gameTimer.Start();
            ResetToRest();
        }
        void ResetToRest()
        {
            ball.Location = new Point((int)Math.Round(this.Width / 2d, 0), (int)Math.Round(this.Height / 2d, 0));
            playerPaddle.Location = new Point(playerPaddle.Location.X, (int)Math.Round(this.Height / 2d, 0));
            cpuPaddle.Location = new Point(cpuPaddle.Location.X, (int)Math.Round(this.Height / 2d, 0));
        }

        private void Pong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) goUp = true;
            if (e.KeyCode == Keys.S) goDown = true;
        }

        private void Pong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) goUp = false;
            if (e.KeyCode == Keys.S) goDown = false;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            ball.Top -= (int)ballY;
            ball.Left -= (int)ballX;

            cpuPaddle.Top += speed;

            if (cpuPaddle.Top < 0 || cpuPaddle.Top > this.Height) speed = -speed;

            if (ball.Left < 0)
            {
                ResetToRest();
                ballX = -ballX;
            }
            if (ball.Left + ball.Width > this.Height)
            {
                ResetToRest();
                ballX = -ballX;
            }
            if (ball.Top < 0 || ball.Top + ball.Height > this.Height) ballY = -ballY;
            if (ball.Bounds.IntersectsWith(playerPaddle.Bounds) || ball.Bounds.IntersectsWith(cpuPaddle.Bounds)) ballX = -ballX;

            if (goUp && playerPaddle.Top > 0) playerPaddle.Top -= 8;
            if (goDown && playerPaddle.Top < this.Height) playerPaddle.Top += 8;

        }
    }
}
