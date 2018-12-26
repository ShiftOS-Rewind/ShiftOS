using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShiftOS.Engine.WindowManager;

namespace ShiftOS.Main.Apps
{
    public partial class Breakout : UserControl
    {
        bool goLeft = false;
        bool goRight = false;
        int speed = 5;
        float ballX = 5;
        float ballY = 5;
        int rows = 5;
        int col = 8;
        public PictureBox[,] blocks;
        public Breakout()
        {
            InitializeComponent();
            DrawBlocks();
            gameTimer.Start();
            ResetToRest();
        }
        void ResetToRest()
        {
            ball.Location = new Point((int)Math.Round(this.Width / 2d, 0), (int)Math.Round(this.Height / 2d, 0));
            playerPaddle.Location = new Point((int)Math.Round(ClientSize.Width / 2d, 0), playerPaddle.Location.Y);
        }

        private void Pong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && playerPaddle.Left > 0) goLeft = true;
            if (e.KeyCode == Keys.D && playerPaddle.Left + playerPaddle.Width < this.Width) goRight = true;
        }

        private void Pong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) goLeft = false;
            if (e.KeyCode == Keys.D) goRight = false;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            ball.Top += (int)ballY;
            ball.Left += (int)ballX;

            if (ball.Bottom > ClientSize.Height || ball.Top < 0) ballY = -ballY;
            if (ball.Right > ClientSize.Width || ball.Left < 0) ballX = -ballX;
            if (ball.Bounds.IntersectsWith(playerPaddle.Bounds)) ballY = -ballY;
            if (goRight) playerPaddle.Left += 8;
            if (goLeft) playerPaddle.Left -= 8;
            if (playerPaddle.Left < 1) goLeft = false;
            if (playerPaddle.Left + playerPaddle.Width > this.Width) goRight = false;

            for (int j = 0; j < rows; j++)
            {
                for (int i = 0; i < col; i++)
                {
                    if (ball.Bounds.IntersectsWith(blocks[j,i].Bounds) && blocks[j,i].Visible)
                    {
                        ballY = -ballY;
                        blocks[j,i].Visible = false;
                    }
                }
            }
            if (ball.Top + ball.Height > ClientSize.Height)
            {
                gameTimer.Stop();
                var infoBox = ShiftWM.StartInfoboxSession("Breakout - You Lose! ", "It appears that you have lost the game, meaning\nall codepoints won were lost. Would you\nlike to try again?", InfoboxTemplate.ButtonType.YesNo);
                ShiftWM.StartInfoboxSession(null, infoBox.isOK.ToString(), InfoboxTemplate.ButtonType.Ok);
                infoBox.btnOpt1.Click += InfoboxYes;
                infoBox.btnOpt2.Click += InfoboxYes;
            }
        }

        private void InfoboxYes(object sender, EventArgs e)
        {
            DrawBlocks();
            ResetToRest();
            gameTimer.Start();
        }
        private void InfoboxNo(object sender, EventArgs e)
        {
            // When user clicks No
        }

        private void DrawBlocks()
        {
            int h = 20;
            int w = 75;
            blocks = new PictureBox[rows, col];
            for (int j = 0; j < rows; j++)
            {
                for (int i = 0; i < col; i++)
                {
                    blocks[j, i] = new PictureBox();
                    blocks[j, i].Height = h;
                    blocks[j, i].Width = w;
                    blocks[j, i].Top = h * j;
                    blocks[j, i].Left = w * i;
                    blocks[j, i].Paint += (o, a) =>
                      {
                          Rectangle rect = new Rectangle(blocks[j,i].Location.X, blocks[j,i].Location.Y, blocks[j,i].ClientSize.Width, blocks[j,i].ClientSize.Height);

                          rect.Inflate(1,1); // border thickness
                          ControlPaint.DrawBorder(a.Graphics, rect, Color.Black, ButtonBorderStyle.Solid);
                      };
                    this.Controls.Add(blocks[j, i]);
                }
            }
        }
    }
}
