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
        ShiftSkinData skinConfig = new ShiftSkinData();
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
            skinConfig.setBorderColor(Color.FromArgb(64, 64, 64));
            skinConfig.btnCloseColor = Color.Black;
            skinConfig.btnMaxColor = Color.Black;
            skinConfig.btnMinColor = Color.Black;
        }

        private void setColorSkin(object sender, EventArgs e)
        {
            skinConfig.setBorderColor(Color.Blue);
            skinConfig.btnCloseColor = Color.Red;
            skinConfig.btnMaxColor = Color.Yellow;
            skinConfig.btnMinColor = Color.Green;
        }

        private void setRandomSkin(object sender, EventArgs e)
        {
            Random rnd = new Random();
            skinConfig.setBorderColor(Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255)));
            skinConfig.btnCloseColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            skinConfig.btnMaxColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            skinConfig.btnMinColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
        }

        private void button5_Click(object sender, EventArgs e)
        {

            foreach (var window in ShiftWM.Windows)
            {
                window.Invoke(new Action(() => window.top.BackColor = skinConfig.titleBarColor));
                window.Invoke(new Action(() => window.topleftcorner.BackColor = skinConfig.leftTopCornerColor));
                window.Invoke(new Action(() => window.toprightcorner.BackColor = skinConfig.rightTopCornerColor));
                window.Invoke(new Action(() => window.left.BackColor = skinConfig.leftSideColor));
                window.Invoke(new Action(() => window.right.BackColor = skinConfig.rightSideColor));
                window.Invoke(new Action(() => window.bottomleftcorner.BackColor = skinConfig.leftBottomCornerColor));
                window.Invoke(new Action(() => window.bottom.BackColor = skinConfig.bottomSideColor));
                window.Invoke(new Action(() => window.bottomrightcorner.BackColor = skinConfig.rightBottomCornerColor));
                window.Invoke(new Action(() => window.closebutton.BackColor = skinConfig.btnCloseColor));
                window.Invoke(new Action(() => window.maximizebutton.BackColor = skinConfig.btnMaxColor));
                window.Invoke(new Action(() => window.minimizebutton.BackColor = skinConfig.btnMinColor));
            }
        }
    }
}
