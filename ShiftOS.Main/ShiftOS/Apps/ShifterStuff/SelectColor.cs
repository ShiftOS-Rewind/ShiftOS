using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using ShiftOS.Engine.WindowManager;

namespace ShiftOS.Main.ShiftOS.Apps.ShifterStuff
{
	public partial class SelectColor : UserControl
	{
		int _colorType1;
		int _colorType2;
		int _colorType3;
		Color _finalColor;

		public SelectColor()
		{
			InitializeComponent();
		}

		Color SetColor()
		{
			_colorType1 = int.Parse(redUpDown.Value.ToString(CultureInfo.InvariantCulture));
			_colorType2 = int.Parse(greenUpDown.Value.ToString(CultureInfo.InvariantCulture));
			_colorType3 = int.Parse(blueUpDown.Value.ToString(CultureInfo.InvariantCulture));
			try
			{
				_finalColor = Color.FromArgb(_colorType1, _colorType2, _colorType3);


				foreach (var window in ShiftWm.Windows)
				{
					window.Invoke(new Action(() => window.titleBar.BackColor = _finalColor));
				}


				ShiftWm.StartInfoboxSession(
					"Success!",
					$"Changed color to:\r\n{_colorType1}, {_colorType2}, {_colorType3}.",
					InfoboxTemplate.ButtonType.Ok);
			}
			catch (Exception)
			{
				ShiftWm.StartInfoboxSession("Error!", "An error occured while setting the color.", InfoboxTemplate.ButtonType.Ok);
			}
			return _finalColor;
		}

		void btnSetColor_Click(object sender, EventArgs e)
		{
			SetColor();
		}
	}
}