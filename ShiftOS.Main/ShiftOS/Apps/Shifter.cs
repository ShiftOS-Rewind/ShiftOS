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
        public Shifter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog cD = new ColorDialog();
            if (cD.ShowDialog() == DialogResult.OK)
            {
                ShiftWindow sw = new ShiftWindow();
                sw.top.BackColor = cD.Color;
            }
        }
    }
}
