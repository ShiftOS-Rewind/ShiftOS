using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShiftOS.Main.ShiftOS;
using ShiftOS.Main.ShiftOS.Apps;

namespace ShiftOS.Main
{
	static class Program
	{
		/// <summary>
		///     The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Parallel.Invoke(
				() => Application.Run(new TestForm()),
				() => Application.Run(new Desktop()));
		}
	}
}