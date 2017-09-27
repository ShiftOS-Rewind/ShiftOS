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

namespace ShiftOS.Main.ShiftOS.Apps
{
    public partial class Shifter : UserControl
    {
        public int colorType; //This is a check to see what option was chosen.
        ShiftWM wm = new ShiftWM();
        public Shifter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorType = 1;
            wm.Init(new SelectColor(), "Select a color", Properties.Resources.iconColourPicker_fw);
        }
    }
}
