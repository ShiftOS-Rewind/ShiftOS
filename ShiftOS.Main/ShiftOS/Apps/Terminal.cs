using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShiftOS.Engine;
using ShiftOS.Engine.Terminal;

namespace ShiftOS.Main.ShiftOS.Apps
{
    public partial class Terminal : UserControl
    {
        public string defaulttextBefore = "user> ";
        public string defaulttextResult = "user@shiftos> "; // NOT YET IMPLEMENTED!!!
        public bool doClear = false;

        // The below variables makes the terminal... a terminal!
        public string OldText = "";   
        public int TrackingPosition = 0;

        public Terminal()
        {
            InitializeComponent();

            termmain.ContextMenuStrip = new ContextMenuStrip(); // Disables the right click of a richtextbox!
        }

        public void Print(string text)
        {
            termmain.AppendText($"\n {text} \n {defaulttextResult}");
            TrackingPosition = termmain.Text.Length;
        }

        private void termmain_KeyDown(object sender, KeyEventArgs e)
        {
            // The below code disables the ability to paste anything other then text...

            if (e.Control && e.KeyCode == Keys.V)
            {
                //if (Clipboard.ContainsText())
                //    termmain.Paste(DataFormats.GetFormat(DataFormats.Text));
                e.Handled = true;
            } else if (e.KeyCode == Keys.Enter) {
                Print(TerminalBackend.RunCommand(termmain.Text.Substring(TrackingPosition, termmain.Text.Length - TrackingPosition))); // The most horrific line in the entire application!
                e.Handled = true;
            }
        }

        private void termmain_TextChanged(object sender, EventArgs e)
        {
            if (termmain.SelectionStart < TrackingPosition)
            {
                if (doClear == false) // If it's not clearing the terminal
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

        private void termmain_SelectionChanged(object sender, EventArgs e)
        {
            if (termmain.SelectionStart < TrackingPosition)
            {
                termmain.Text = OldText;
                termmain.Select(termmain.Text.Length, 0);
            }
        }

        private void Terminal_Load(object sender, EventArgs e)
        {
            Print("\n");
        }

        public string RunCommand(string command)
        {
            string ToReturn = "";

            if (command == "hi")
            {
                ToReturn = $"{ToReturn} \n Hi!";
                MessageBox.Show("HI!");
            }
            return ToReturn;
        }
    }
}
