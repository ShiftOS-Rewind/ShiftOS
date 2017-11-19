using ShiftOS.Engine.ShiftFS.FileGUI;
using ShiftOS.Engine.WindowManager;
using System;
using System.IO;
using System.Windows.Forms;

namespace ShiftOS.Main.ShiftOS.Apps
{
	public partial class TextPad : UserControl
	{
		readonly string _editedText;

		public TextPad()
		{
			InitializeComponent();
			_editedText = textBox.Text;
		}

		bool IsEdited() => _editedText != textBox.Text;

		void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
			
			var sr = new StreamReader(openFileDialog1.FileName);
			textBox.Text = sr.ReadToEnd();
			sr.Close();
		}

		void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (IsEdited())
			{
				MessageBox.Show("yay it works");
			}
            var f = new FileOpener();
            ShiftWM.Init(f, "testing", null);
		}
	}
}