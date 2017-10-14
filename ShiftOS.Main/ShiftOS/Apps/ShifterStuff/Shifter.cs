using System;
using System.Windows.Forms;
using ShiftOS.Engine;
using ShiftOS.Engine.WindowManager;
using System.Drawing;

namespace ShiftOS.Main.ShiftOS.Apps
{
    public partial class Shifter : UserControl
    {
        public int colorType; //This is a check to see what option was chosen.
        public Shifter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorType = 1;
            ShiftWM.Init(new SelectColor(), "Select a color", Properties.Resources.iconColourPicker_fw.ToIcon());
        }

        private void setDefaultSkin(object sender, EventArgs e)
        {
            setBorderColor(Color.FromArgb(64, 64, 64));
            ShiftSkinData.btnCloseColor = Color.Black;
            ShiftSkinData.btnMaxColor = Color.Black;
            ShiftSkinData.btnMinColor = Color.Black;
            button5_Click(sender, e);
        }

        private void setColorSkin(object sender, EventArgs e)
        {
            setBorderColor(Color.Blue);
            ShiftSkinData.btnCloseColor = Color.Red;
            ShiftSkinData.btnMaxColor = Color.Yellow;
            ShiftSkinData.btnMinColor = Color.Green;
            button5_Click(sender, e);
        }

        private void setRandomSkin(object sender, EventArgs e)
        {
            Random rnd = new Random();
            setBorderColor(Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255)));
            ShiftSkinData.btnCloseColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            ShiftSkinData.btnMaxColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            ShiftSkinData.btnMinColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            button5_Click(sender, e);
        }

        // SetBorderColor
        public void setBorderColor(Color borderColor)
        {
            ShiftSkinData.leftTopCornerColor = borderColor;
            ShiftSkinData.titleBarColor = borderColor;
            ShiftSkinData.rightTopCornerColor = borderColor;
            ShiftSkinData.leftSideColor = borderColor;
            ShiftSkinData.rightSideColor = borderColor;
            ShiftSkinData.leftBottomCornerColor = borderColor;
            ShiftSkinData.bottomSideColor = borderColor;
            ShiftSkinData.rightBottomCornerColor = borderColor;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            foreach (var window in ShiftWM.Windows)
            {
                window.Invoke(new Action(() => window.titleBar.BackColor = ShiftSkinData.titleBarColor));
                window.Invoke(new Action(() => window.leftTopCorner.BackColor = ShiftSkinData.leftTopCornerColor));
                window.Invoke(new Action(() => window.rightTopCorner.BackColor = ShiftSkinData.rightTopCornerColor));
                window.Invoke(new Action(() => window.leftSide.BackColor = ShiftSkinData.leftSideColor));
                window.Invoke(new Action(() => window.rightSide.BackColor = ShiftSkinData.rightSideColor));
                window.Invoke(new Action(() => window.leftBottomCorner.BackColor = ShiftSkinData.leftBottomCornerColor));
                window.Invoke(new Action(() => window.bottomSide.BackColor = ShiftSkinData.bottomSideColor));
                window.Invoke(new Action(() => window.rightBottomCorner.BackColor = ShiftSkinData.rightBottomCornerColor));
                window.Invoke(new Action(() => window.btnClose.BackColor = ShiftSkinData.btnCloseColor));
                window.Invoke(new Action(() => window.btnMax.BackColor = ShiftSkinData.btnMaxColor));
                window.Invoke(new Action(() => window.btnMin.BackColor = ShiftSkinData.btnMinColor));
                
            }
        }
    }
}
