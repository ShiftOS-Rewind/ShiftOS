using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ShiftOS.Engine.Properties;
using ShiftOS.Engine.ShiftFS;
using ShiftOS.Engine.WindowManager;

namespace ShiftOS.Engine.Misc
{
	/// <summary>
	/// Random class full of unassorted [but also uncategorizable] tools.
	/// </summary>
	public static class Tools
	{
		public static Random Rnd = new Random();

		//I wanna DESTROY this method
		[DllImport("user32.dll")]
		static extern bool DestroyIcon(IntPtr handle);

		public static Icon ToIcon(this Bitmap bm)
		{
			var tempicon = Icon.FromHandle(bm.GetHicon());

			var newIcon = tempicon.Clone() as Icon;

			//for some reason this exists
			DestroyIcon(tempicon.Handle);
			tempicon.Dispose();
			
			return newIcon;
		}

		public static void DisplayShiftFolder(this ListView list, ShiftDirectory dir)
		{
					            var dirs = dir.OfType<ShiftDirectory>().ToArray();
			for (var i = 0; i < dirs.Length; i++)
			{
				list.Items.Add(
					new ListViewItem
					{
						Text = dirs[i].Name,
						ImageIndex = i,
						StateImageIndex = i,
						ImageKey = dirs[i].Guid.ToString(),
						Tag = dirs[i]
					});

				list.StateImageList.Images.Add(dirs[i].Guid.ToString(), Resources.iconFileOpener_fw);
			}

			var items = dir.OfType<ShiftFile>().ToArray();
			for (var i = 0; i < items.Length; i++)
			{
				list.Items.Add(
					new ListViewItem
					{
						Text = items[i].Name,
						ImageIndex = i,
						StateImageIndex = i,
						ImageKey = items[i].Guid.ToString(),
						Tag = items[i],
					});

				list.StateImageList.Images.Add(items[i].Guid.ToString(), items[i].Icon ?? Resources.iconFileOpener_fw);
			}
		}

		public static void ShowDrivesList(this ListView list, ShiftWindow window = null)
		{
			var imageList = new ImageList();
			list.SmallImageList = imageList;
			list.LargeImageList = imageList;
			list.StateImageList = imageList;
			
			for (var i = 0; i < ShiftFS.ShiftFS.Drives.Count; i++)
			{
				list.Items.Add(
					new ListViewItem
					{
						Text = $"{ShiftFS.ShiftFS.Drives[i].Name} ({ShiftFS.ShiftFS.Drives[i].Letter})",
						ImageIndex = i,
						StateImageIndex = i,
						ImageKey= ShiftFS.ShiftFS.Drives[i].Guid.ToString(),
						Tag = ShiftFS.ShiftFS.Drives[i]
					});

				list.StateImageList.Images.Add(ShiftFS.ShiftFS.Drives[i].Guid.ToString(), window?.Icon.ToBitmap() ?? Resources.ArtPadsave);
			}
		}

	}
}