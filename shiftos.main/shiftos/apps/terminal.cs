using System;
using System.Windows.Forms;
using ShiftOS.Engine;
using ShiftOS.Main.Terminal;
using System.Linq;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using ShiftOS.Main.Properties;

namespace ShiftOS.Main.ShiftOS.Apps
{
    public partial class Terminal : UserControl
    {
        public int TerminalID = TerminalBackend.trmTopID++; // Used so that we can have multiple instances of the terminal whilst the command begin run knowing what terminal to send the text to - very complicated ;)
        public string defaulttextBefore = "user> ";
        public string defaulttextResult = "[user@shiftos ~]$ "; // NOT YET IMPLEMENTED!!!
        public bool DoClear = false;
        public bool RunningCommand = false;
        public bool WaitingResponse = false;
        public string InputReturnText = "";
        public Stack<string> c = TerminalBackend.commandBuffer;
        private PrivateFontCollection fontCollection = new PrivateFontCollection();
        
		// The below variables makes the terminal... a terminal!
		string OldText = "";

		int TrackingPosition;

		public Terminal()
		{
			InitializeComponent();

			termmain.ContextMenuStrip = new ContextMenuStrip(); // Disables the right click of a richtextbox!

            TerminalBackend.trm.Add(this);


            Setup();
        }

        void Print()
        {
            termmain.AppendText($"\n {defaulttextResult}");
            TrackingPosition = termmain.Text.Length;
        }

        void Print(string text)
		{
			termmain.AppendText($"\n {text} \n {defaulttextResult}");
			TrackingPosition = termmain.Text.Length;
        }

        //if (e.Control && e.KeyCode == Keys.V)
        //    {
        //        //if (Clipboard.ContainsText())
        //        //    termmain.Paste(DataFormats.GetFormat(DataFormats.Text));
        //        e.Handled = true;
        //    } else if (e.KeyCode == Keys.Enter) {
        //        RunningCommand = true;
        //        TerminalBackend.RunCommand(termmain.Text.Substring(TrackingPosition, termmain.Text.Length - TrackingPosition), TerminalID); // The most horrific line in the entire application!
        //        RunningCommand = false;
        //        termmain.AppendText($"\n {defaulttextResult}");
        //        TrackingPosition = termmain.Text.Length;
        //        e.Handled = true;
        //    }
        //}

        private void termmain_TextChanged(object sender, EventArgs e)
        {
            if (!RunningCommand)
            {
                if (termmain.SelectionStart < TrackingPosition)
                {
                    if (!DoClear) // If it's not clearing the terminal
                    {
                        termmain.Text = OldText;
                        termmain.Select(termmain.Text.Length, 0);
                    }
                }
                else
                {
                    OldText = termmain.Text;
                }
            }
        }

        private void termmain_SelectionChanged(object sender, EventArgs e)
        {
            if (!RunningCommand)
            {
                if (termmain.SelectionStart < TrackingPosition)
                {
                    termmain.Text = OldText;
                    termmain.Select(termmain.Text.Length, 0);
                }
            }
        }

        private void Terminal_Load(object sender, EventArgs e)
        {
            termmain.Text = $"\n {defaulttextResult}";
            TrackingPosition = termmain.Text.Length;
            termmain.Select(termmain.TextLength, 1);
        }

        public void Input(string request)
        {
            InputReturnText = "";
            RunningCommand = false;

            termmain.AppendText($"\n {request} ");
            TrackingPosition = termmain.Text.Length;
        }

        public void Clear()
        {
            DoClear = true;
            OldText = "";
            termmain.Text = "";
            TrackingPosition = termmain.Text.Length;
            DoClear = false;
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
				TerminalBackend.RunCommand(termmain.Text.Substring(TrackingPosition, termmain.Text.Length - TrackingPosition), TerminalID); // The most horrific line in the entire application!
                Print();
				e.Handled = true;
			}
            else if (e.KeyCode == Keys.Up)
            {
                if (c.Count == 0) return;
                termmain.AppendText(c.Pop());
            }
        }
        public void Setup()
        {
            if (!Directory.Exists(SaveSystem.gameDir)) Directory.CreateDirectory(SaveSystem.gameDir);
            if (!Directory.Exists(SaveSystem.fontDir)) Directory.CreateDirectory(SaveSystem.fontDir);
            if (!Directory.Exists(SaveSystem.dataDir)) Directory.CreateDirectory(SaveSystem.dataDir);
            if (!File.Exists(SaveSystem.fontDir + "\\termFont.ttf")) File.WriteAllBytes(SaveSystem.fontDir + "\\termFont.ttf", Resources.UbuntuMono_R);
            if (!File.Exists(SaveSystem.dataDir + "\\userCodePoints.whoa"))
            {
                using (var fobj = File.OpenWrite(SaveSystem.dataDir + "\\userCodePoints.whoa"))
                {
                    Whoa.Whoa.SerialiseObject(fobj, SaveSystem.User.codePoints);
                }
            }
            if (!Directory.Exists(SaveSystem.baseGameDir)) Directory.CreateDirectory(SaveSystem.baseGameDir);
            if (!Directory.Exists(SaveSystem.desktopDir)) Directory.CreateDirectory(SaveSystem.desktopDir);
            if (!Directory.Exists(SaveSystem.docDir)) Directory.CreateDirectory(SaveSystem.docDir);
            if (!Directory.Exists(SaveSystem.downloadsDir)) Directory.CreateDirectory(SaveSystem.downloadsDir);
            if (!Directory.Exists(SaveSystem.musicDir)) Directory.CreateDirectory(SaveSystem.musicDir);
            if (!Directory.Exists(SaveSystem.picDir)) Directory.CreateDirectory(SaveSystem.picDir);
            fontCollection.AddFontFile(SaveSystem.fontDir + "\\termFont.ttf");
            termmain.Font = new System.Drawing.Font(fontCollection.Families[0], 12F, System.Drawing.FontStyle.Regular);
        }
    }
}
