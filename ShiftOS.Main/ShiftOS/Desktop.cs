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

			ShiftWm.Windows.CollectionChanged += (sender, args) =>
			{
				args.NewItems?.OfType<ShiftWindow>()
				    .ToList()
				    .ForEach(
					    window =>
					    {
						    taskbar.Invoke(
							    new Action(
								    () =>
								    {
									    taskbar.Items.Add(
										    new ToolStripButton
										    {
											    Text = window.Title.Text,
											    Image = window.Icon.ToBitmap(),
											    Tag = window.Id
										    });
								    }));
					    });

				args.OldItems?.OfType<ShiftWindow>()
				    .ToList()
				    .ForEach(
					    window =>
					    {
						    taskbar.Invoke(
							    new Action(
								    () =>
								    {
									    var tbRemovalList = taskbar.Items.OfType<ToolStripItem>().Where(i => (uint) i.Tag == window.Id);

									    tbRemovalList.ToList().ForEach(p => taskbar.Items.Remove(p));
								    }));
					    });
			};

			#endregion
		}

		void timer1_Tick(object sender, EventArgs e) =>
			taskbarClock.Text = $"{DateTime.Now:t}";

		void terminalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var trm = new Terminal();

			ShiftWm.Init(trm, "Terminal", null);
		}

		void textPadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var tp = new TextPad();
			ShiftWm.Init(tp, "TextPad", Resources.iconTextPad.ToIcon());
		}
	}
}