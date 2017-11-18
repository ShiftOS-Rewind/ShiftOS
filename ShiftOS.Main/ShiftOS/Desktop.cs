using System;
using System.Linq;
using System.Windows.Forms;
using ShiftOS.Engine.Misc;
using ShiftOS.Engine.WindowManager;
using ShiftOS.Main.Properties;
using ShiftOS.Main.ShiftOS.Apps;

namespace ShiftOS.Main.ShiftOS
{
	public partial class Desktop : Form
	{
		public Desktop()
		{
			InitializeComponent();

			timer1.Start();

			Closed += (sender, args) => { Application.Exit(); };

			#region Disgusting taskbar code

			ShiftWM.Windows.ItemAdded += (sender, e) =>
			{
				taskbar.Invoke(
					new Action(
						() =>
						{
							taskbar.Items.Add(
								new ToolStripButton
								{
									Text = e.Item.Title.Text,
									Image = e.Item.Icon.ToBitmap(),
									Tag = e.Item.Id
								});
						}));
			};

			ShiftWM.Windows.ItemRemoved += (sender, e) =>
			{
				taskbar.Invoke(
					new Action(
						() =>
						{
							var tbRemovalList = taskbar.Items.OfType<ToolStripItem>().Where(i => (uint) i.Tag == e.Item.Id);

							tbRemovalList.ToList().ForEach(p => taskbar.Items.Remove(p));
						}));
			};

			#endregion
		}

		void timer1_Tick(object sender, EventArgs e) =>
			taskbarClock.Text = $"{DateTime.Now:t}";

        private void terminalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apps.Terminal trm = new Apps.Terminal();
            
            ShiftWM.Init(trm, "Terminal", null, false, true);
        }

		void textPadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var tp = new TextPad();
			ShiftWM.Init(tp, "TextPad", Resources.iconTextPad);
		}

		void fileSkimmerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var fs = new FileSkimmer();
			ShiftWM.Init(fs, "File Skimmer", Resources.iconFileSkimmer);
		}

        private void shifterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apps.ShifterStuff.Shifter app = new Apps.ShifterStuff.Shifter();
            ShiftWM.Init(app, "Shifter", null);
        }
    }
}
