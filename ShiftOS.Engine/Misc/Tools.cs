using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ShiftOS.Engine.Misc
{
	/// <summary>
	///     Random class full of unassorted [but also uncategorizable] tools.
	/// </summary>
	public static class Tools
	{
		public static Random Rnd = new Random();

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern bool DestroyIcon(IntPtr handle);

		public static Icon ToIcon(this Bitmap bm)
		{
			var tempicon = Icon.FromHandle(bm.GetHicon());

			var newIcon = tempicon.Clone() as Icon;

			//for some reason this exists
			DestroyIcon(tempicon.Handle);

			return newIcon;
		}
	}
}