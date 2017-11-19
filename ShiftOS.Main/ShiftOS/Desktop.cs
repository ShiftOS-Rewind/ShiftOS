using System;
using System.Linq;
using System.Windows.Forms;
using ShiftOS.Engine.Misc;
using ShiftOS.Engine.WindowManager;
using ShiftOS.Main.Properties;
using ShiftOS.Main.ShiftOS.Apps;
using System.Drawing;

namespace ShiftOS.Main.ShiftOS
{
	public partial class Desktop : Form
	{
		public Desktop()
		{
			InitializeComponent();
            timer1.Start();

			Closed += (sender, args) => { Application.Exit(); };
		}
		
        private void shifterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apps.ShifterStuff.Shifter app = new Apps.ShifterStuff.Shifter();
            ShiftWM.Init(app, "Shifter", null);
        }

        private void Desktop_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void terminalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var t = new Apps.Terminal();
            ShiftWM.Init(t, "Terminal", Resources.iconTerminal, false);

        }

        private void textPadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var t = new TextPad();
            ShiftWM.Init(t, "TextPad", Resources.iconTextPad);
        }

        private void fileSkimmerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fs = new FileSkimmer();
            ShiftWM.Init(fs, "File Skimmer", Resources.iconFileSkimmer);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
