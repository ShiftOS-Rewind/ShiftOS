using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;
using ShiftOS.Engine.Properties;
using ShiftOS.Engine.UI;

namespace ShiftOS.Engine.WindowManager
{
	public partial class InfoboxTemplate : UserControl
	{
		public enum ButtonType
		{
			YesNo,
			OkCancel,
			Ok
		}

		public enum DialogResult
		{
			Yes,
			No,
			Cancel,
			Ok
		}

		int _buttonChoice;
		int _buttonSelected;
		Stream _str;

		public InfoboxTemplate(ButtonType type)
		{
			InitializeComponent();
 
			switch (type)
			{
				case ButtonType.Ok:
					btnOpt1.Text = "OK";
					btnOpt2.Hide();
					btnOpt1.Location = new Point(109, 134);
					_buttonChoice = 1;
					break;
				case ButtonType.OkCancel:
					btnOpt1.Text = "OK";
					btnOpt2.Text = "Cancel";
					_buttonChoice = 2;
					break;
				case ButtonType.YesNo:
					btnOpt1.Text = "Yes";
					btnOpt2.Text = "No";
					_buttonChoice = 3;
					break;
			}
		}

		void btnOpt1_Click(object sender, EventArgs e)
		{
			switch (btnOpt1.Text)
			{
				case "OK":
					ParentForm?.Close();
					break;
				case "Yes":
					_buttonSelected = 2;
					ParentForm?.Close();
					break;
			}
		}

		void btnOpt2_Click(object sender, EventArgs e)
		{
			switch (btnOpt2.Text)
			{
				case "No":
					_buttonSelected = 3;
					break;
				case "Cancel":
					_buttonSelected = 4;
					break;
			}
		}

		public void Play()
		{
			_str = Resources.infobox;
			var sp = new SoundPlayer(_str);
			sp.Play();
			sp.Stream.Position = 0;
		}

		void InfoboxTemplate_Load(object sender, EventArgs e)
			=> Play();
	}
}