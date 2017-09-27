using System;
using System.Windows.Forms;
using ShiftOS.Engine;
using ShiftOS.Engine.WindowManager;

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
    }
}
