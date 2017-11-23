using System;
using System.Windows.Forms;
using ShiftOS.Engine.WindowManager;
using ShiftOS.Main.Properties;
using ShiftOS.Main.ShiftOS.Apps;
using System.IO;
using ShiftOS.Engine;

namespace ShiftOS.Main.ShiftOS
{
    // testing github because git hates me
    public partial class Desktop : Form
	{
		public Desktop()
		{
			InitializeComponent();
            timer1.Start();
            Setup();
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
        public void Setup()
        {
            if (!Directory.Exists(SaveSystem.gameDir)) Directory.CreateDirectory(SaveSystem.gameDir);
            if (!Directory.Exists(SaveSystem.fontDir)) Directory.CreateDirectory(SaveSystem.fontDir);
            if (!File.Exists(SaveSystem.fontDir + "\\termFont.ttf")) File.WriteAllBytes(SaveSystem.fontDir + "\\termFont.ttf", Resources.UbuntuMono_R);
        }
    }
}
