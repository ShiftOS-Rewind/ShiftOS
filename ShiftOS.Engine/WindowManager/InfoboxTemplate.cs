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
        public bool isOK = false;
        public bool isNo = false;
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
            isOK = true;
            MessageBox.Show("button was clicked");
            ParentForm?.Close();
		}

		void btnOpt2_Click(object sender, EventArgs e)
		{
			switch (btnOpt2.Text)
			{
				case "No":
                    isNo = true;
                    ParentForm?.Close();
                    break;
				case "Cancel":
                    isNo = true;
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