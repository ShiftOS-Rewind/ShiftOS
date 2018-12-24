using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using ShiftOS.Engine.Misc;
using ShiftOS.Engine.ShiftFS;
using ShiftOS.Engine.WindowManager;
using System.Linq;
using ShiftOS.Engine.UI;

namespace ShiftOS.Main.Apps
{
	public partial class FileSkimmer : UserControl, IShiftWindowExtensions
	{
		ShiftDirectory _currentDirectory;
		
		public FileSkimmer()
		{
			InitializeComponent();
            
		}

		public void OnLoaded(ShiftWindow window)
		{
			Debug.WriteLine(ShiftFS.Drives.Count);
			listView1.ShowDrivesList(window);
		}

		void toolStripDropDownButton1_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			switch (e.ClickedItem.Text)
			{
				case "Small Icons":
					listView1.View = View.SmallIcon;
					break;
				case "Details":
					listView1.View = View.Details;
					break;
				case "List":
					listView1.View = View.List;
					break;
				case "Tiles":
					listView1.View = View.Tile;
					break;
				default:
					listView1.View = View.LargeIcon;
					break;
			}
		}

		void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
		{	
			var hit = listView1.HitTest(e.Location);

			if (!(hit.Item.Tag is ShiftDirectory dir)) return;
			
			listView1.Items.Clear();
			listView1.DisplayShiftFolder(dir);
			_currentDirectory = dir;
			breadcrumbsBar.Items.Add(new ToolStripButton(dir.Name) { Tag = dir });
		}

		void toolStripButton1_Click(object sender, EventArgs e)
		{
			listView1.Items.Clear();
			if (breadcrumbsBar.Items.Count > 1)
			{
				breadcrumbsBar.Items.Remove(breadcrumbsBar.Items.OfType<ToolStripItem>().Last());
				var dir = breadcrumbsBar.Items.OfType<ToolStripItem>().Last().Tag as ShiftDirectory;
				_currentDirectory = dir;
				listView1.DisplayShiftFolder(dir);
			}
			else
			{
				breadcrumbsBar.Items.Clear();
				listView1.ShowDrivesList();
			}
		}

		void breadcrumbsBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			var items = new List<ToolStripItem>(breadcrumbsBar.Items.OfType<ToolStripItem>()
			                          .Where((_, y) => y > breadcrumbsBar.Items.IndexOf(e.ClickedItem)));

			foreach (var item in items)
			{
				breadcrumbsBar.Items.Remove(item);
			}

			toolStripButton1_Click(null, EventArgs.Empty);
		}

		void textFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_currentDirectory.Add(new ShiftFile<string>("Text file"));
		}

		void listView1_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{	
				contextMenuStrip1.Show(MousePosition);
			}
		}
	}
}
