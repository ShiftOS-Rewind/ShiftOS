using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;
using ShiftOS.Engine.Properties;

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
		Stream _str;

		public InfoboxTemplate(ButtonType type)
		{
			InitializeComponent();
			switch (type)
			{
				case ButtonType.Ok:
					btnOpt1.Text = "OK";
					btnOpt2.Hide();
					btnOpt1.Location = new Point(156, 163);
					break;
				case ButtonType.OkCancel:
					btnOpt1.Text = "OK";
					btnOpt2.Text = "Cancel";
					break;
				case ButtonType.YesNo:
					btnOpt1.Text = "Yes";
					btnOpt2.Text = "No";
					break;
			}
		}

		void btnOpt1_Click(object sender, EventArgs e)
		{
			switch (btnOpt1.Text)
			{
				case "OK":
                    btnOpt1.DialogResult = System.Windows.Forms.DialogResult.OK;
                    ParentForm?.Close();
					break;
				case "Yes":
                    btnOpt1.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    ParentForm?.Close();
					break;
			}
		}

		void btnOpt2_Click(object sender, EventArgs e)
		{
			switch (btnOpt2.Text)
			{
				case "No":
                    btnOpt2.DialogResult = System.Windows.Forms.DialogResult.No;
                    ParentForm?.Close();
                    break;
				case "Cancel":
                    btnOpt2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
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
        {
            Play();
            SizeAndLoad(label1.Size.Width, label1.Size.Width);
        }
        private Size SizeAndLoad(int x, int y)
        {
            this.Size = new Size(x, y);
            Left = (Screen.PrimaryScreen.Bounds.Width - Width) / 2;
            Top = (Screen.PrimaryScreen.Bounds.Top - Height) / 2;
            return Size;
        }
    }
}