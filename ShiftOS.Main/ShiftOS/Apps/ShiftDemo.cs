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

namespace ShiftOS.Main
{
    public partial class ShiftDemo : UserControl, IShiftWindowExtensions
    {
        public ShiftDemo()
        {
            InitializeComponent();
        }

	    public void OnLoaded(ShiftWindow window)
	    {
		    icon.Image = this.GetShiftWindow().Icon.ToBitmap();
	    }
	}
}
