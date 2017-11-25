using System;
using System.Windows.Forms;
using ShiftOS.Main.ShiftOS;

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



            bool terminalMode = true;
            if (terminalMode)
            {
                Form terminalForm = new Form();
                ShiftOS.Apps.Terminal term = new ShiftOS.Apps.Terminal();
                terminalForm.Controls.Add(term);
                terminalForm.FormBorderStyle = FormBorderStyle.None;
                terminalForm.WindowState = FormWindowState.Maximized;
                term.Dock = DockStyle.Fill;
                //terminalForm.Show();
                Application.Run(terminalForm);
            }
            else
            {
                Application.Run(new Desktop());
            }
        }
	}
}