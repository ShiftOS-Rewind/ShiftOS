using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShiftOS.Engine.WindowManager;

namespace ShiftOS.Main.ShiftOS
{
	public partial class Desktop : Form
	{
		public Desktop()
		{
			InitializeComponent();

			timer1.Start();

			this.Closed += (sender, args) =>
			{
				Application.Exit();
			};

			#region Disgusting taskbar code

			ShiftWM.Windows.CollectionChanged += (sender, args) =>
			{
				args.NewItems?.OfType<ShiftWindow>().ToList().ForEach(window =>
				{
					taskbar.Invoke(new Action(() =>
					{
						taskbar.Items.Add(new ToolStripButton
						{
							Text = window.Title.Text,
							Image = window.Icon.ToBitmap(),
							Tag = window.Id
						});
					}));
				});
				
				args.OldItems?.OfType<ShiftWindow>().ToList().ForEach(window =>
				{
					taskbar.Invoke(new Action(() =>
					{
						var tbRemovalList = taskbar.Items.OfType<ToolStripItem>().Where(i => (uint) i.Tag == window.Id);

						tbRemovalList.ToList().ForEach(p => taskbar.Items.Remove(p));
					}));
				});
			};

			#endregion
		}

		private void timer1_Tick(object sender, EventArgs e) => 
			taskbarClock.Text = $"{DateTime.Now:t}";
	}
}
