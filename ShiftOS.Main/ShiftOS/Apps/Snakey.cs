using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using ShiftOS.Engine;
using ShiftOS.Main.Properties;

namespace ShiftOS.Main.ShiftOS.Apps
{
    public partial class Snakey : UserControl
    {
        public Snakey()
        {
            InitializeComponent();
        }
        private struct structSnake
        {
            public Rectangle rect;
            public int x;
            public int y;
        }
        private enum directions
        {
            Rightward,
            Downward,
            Leftward,
            Upward
        }
        #region Various-Objects
        private const int INTIAL_SNAKE_RECT_COUNT = 5;
        private const int COLUMN_COUNT = 65;
        private const int ROW_COUNT = 47;
        private int curRecCount;
        private Rectangle[,] Rects;


        private bool [,] isSnakePart;
        private List<structSnake> snake;
        private Brush snakeBrush = new SolidBrush(Color.FromArgb(255, 255, 255));
        private Brush backBrush = new SolidBrush(Color.FromArgb(1, 1, 1));
        private Brush tokenBrush = new SolidBrush(Color.FromArgb(255, 255, 255));
        private directions curDirection;
        private Bitmap buffer;
        private int columnCount;
        private int rowCount;
        private int snakePoints;
        private double snakeSpeed;
        private int snakeLength;
        private Rectangle token;
        #endregion
        private int xyIndexToRect(int X, int Y)
        {
            return (Y * (columnCount)) + X;
        }
        private void rectToIndexXY(double index, double X, double Y)
        {
            X = index % (columnCount);
            Y = Math.Round(index / columnCount);
        }
        private void initSnake()
        {
            int x;
            int y;
            int index;
            snake = new List<structSnake>();
            structSnake sSnake = new structSnake();
            x = ((columnCount) - 10 / 2);
            y = ((rowCount) - 6) / 2;
            Point snakePosition = new Point(x, y);
            index = xyIndexToRect(x, y);
            for (int i = 0; i < INTIAL_SNAKE_RECT_COUNT; i++)
            {
                rectToIndexXY(index + (i - 1), x, y);
                sSnake.rect = Rects[x, y];
                sSnake.x = x;
                sSnake.y = y;
                snake.Add(sSnake);
            }
            snakeLength = INTIAL_SNAKE_RECT_COUNT;
            snakeSpeed = 1;
            length.Text = "Length: " + snakeLength.ToString();
            speed.Text = "Speed: " + snakeSpeed.ToString();
        }
        private void selectRectangles()
        {
            Graphics g = Graphics.FromImage(Resources.snakeyback);
            int i;
            structSnake sSnake = new structSnake();
            for (i = 0; i < INTIAL_SNAKE_RECT_COUNT; i++)
            {
                sSnake = snake[i];
                g.FillRectangle(snakeBrush, sSnake.rect);
                isSnakePart[sSnake.x, sSnake.y] = true;
            }
            buffer = new Bitmap(Resources.snakeyback);
            g.Dispose();
            Refresh();
        }
        private void initRectangles()
        {
            int i;
            int j;
            columnCount = COLUMN_COUNT;
            rowCount = ROW_COUNT;
            Rects = new Rectangle[columnCount, rowCount];
            isSnakePart = new bool[columnCount, rowCount];
            for (j = 0; j < rowCount; j++)
            {
                for (i = 0; i < columnCount; i++)
                {
                    //TO-DO: I can't really port this over right now. Commiting soon. -FDD
                }
            }
        }
    }
}

