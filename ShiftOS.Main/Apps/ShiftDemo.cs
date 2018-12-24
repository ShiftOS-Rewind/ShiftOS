using System.Windows.Forms;
using ShiftOS.Engine.WindowManager;

namespace ShiftOS.Main.ShiftOS.Apps
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