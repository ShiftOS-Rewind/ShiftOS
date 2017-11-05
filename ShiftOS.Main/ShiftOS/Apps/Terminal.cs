using System;
using System.Windows.Forms;
using ShiftOS.Engine.Terminal;

namespace ShiftOS.Main.ShiftOS.Apps
{
	public partial class Terminal : UserControl
	{
		public string DefaulttextBefore = "user> ";
		string DefaulttextResult = "user@shiftos> "; // NOT YET IMPLEMENTED!!!
		bool DoClear = false;

		// The below variables makes the terminal... a terminal!
		string OldText = "";

		int TrackingPosition;

		public Terminal()
		{
			InitializeComponent();

			termmain.ContextMenuStrip = new ContextMenuStrip(); // Disables the right click of a richtextbox!
		}

		void Print(string text)
		{
			termmain.AppendText($"\n {text} \n {DefaulttextResult}");
			TrackingPosition = termmain.Text.Length;
		}

		void termmain_KeyDown(object sender, KeyEventArgs e)
		{
			// The below code disables the ability to paste anything other then text...

			if (e.Control && e.KeyCode == Keys.V)
			{
				//if (Clipboard.ContainsText())
				//    termmain.Paste(DataFormats.GetFormat(DataFormats.Text));
				e.Handled = true;
			}
			else if (e.KeyCode == Keys.Enter)
			{
				Print(
					TerminalBackend.RunCommand(
						termmain.Text.Substring(
							TrackingPosition,
							termmain.Text.Length - TrackingPosition))); // The most horrific line in the entire application!
				e.Handled = true;
			}
		}

		void termmain_TextChanged(object sender, EventArgs e)
		{
			if (termmain.SelectionStart < TrackingPosition)
			{
				if (DoClear) return;
				
				termmain.Text = OldText;
				termmain.Select(termmain.Text.Length, 0);
			}
			else
			{
				OldText = termmain.Text;
			}
		}

		void termmain_SelectionChanged(object sender, EventArgs e)
		{
			if (termmain.SelectionStart >= TrackingPosition) return;
			
			termmain.Text = OldText;
			termmain.Select(termmain.Text.Length, 0);
		}

		void Terminal_Load(object sender, EventArgs e)
		{
			Print("\n");
		}
	}
}