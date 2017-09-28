using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

namespace ShiftOS.Engine
{
	/// <summary>
	/// Random class full of unassorted [but also uncategorizable] tools.
	/// </summary>
	public static class Tools
	{
		public static Random Rnd = new Random();

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public extern static bool DestroyIcon(IntPtr handle);

		public static Icon ToIcon(this Bitmap bm)
		{
			Icon tempicon = Icon.FromHandle(bm.GetHicon());

			Icon newIcon = tempicon.Clone() as Icon;

			//for some reason this exists
			DestroyIcon(tempicon.Handle);

			return newIcon;
		}
	}
}
