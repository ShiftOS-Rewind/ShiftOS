using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static ShiftOS.Engine.WindowManager.InfoboxTemplate;

namespace ShiftOS.Engine.WindowManager
{
    public static class ShiftWM
    {
		public static ObservableCollection<ShiftWindow> Windows { get; } = new ObservableCollection<ShiftWindow>();

	    public static ShiftWindow GetShiftWindow(this UserControl control)
	    {
		    return Windows.First(p => (uint) control.Tag == p.Id);
	    }

        /// <summary>
        /// Shows a new Window based on a UserControl.
        /// </summary>
        /// <param name="content">The UserControl to use</param>
        /// <param name="title">The program's title</param>
        /// <param name="icon">The icon to show</param>
        /// <param name="showAsInfobox">Checks if this is an infobox</param>
        /// <param name="resize">Enables or disables resizing</param>
        /// <returns></returns>
        public static ShiftWindow Init(UserControl content, string title, Icon icon, bool showAsInfobox = false, bool resize = true)
        {
            // Setup Window
	        ShiftWindow app = new ShiftWindow
	        {
		        Text = title,
		        Title = {Text = title}
	        };

	        app.Width = content.Width + app.left.Width + app.right.Width;
            app.Height = content.Height + app.bottom.Height + app.top.Height;

            // Icon Setup
	        if (icon == null)
	        {
		        app.programIcon.Hide();
		        app.programIcon.Image = Properties.Resources.nullIcon;
		        app.Title.Location = new Point(2, 7);
	        }

	        else
	        {
		        app.programIcon.Image = icon.ToBitmap();
		        app.Icon = icon;
	        }

			// Setup UC
			content.Parent = app.programContent;
            content.BringToFront();
            content.Dock = DockStyle.Fill;
            app.Show();

	        content.Tag = app.SetId();

			Debug.WriteLine($"usercontrol: {content.Tag} window: {app.Id}");

	        app.Closed += (sender, args) =>
	        {
		        Windows.Remove((ShiftWindow) sender);
	        };

			Windows.Add(app);

	        if (content is IShiftWindowExtensions extensions)
	        {
		        extensions.OnLoaded(app);
	        }

            return app;
        }

        /// <summary>
        /// Shows a new infobox.
        /// </summary>
        /// <param name="title">The title of the infobox.</param>
        /// <param name="body">The infobox's content.</param>
        /// <param name="type">The ButtonType used for the infobox.</param>
        /// <returns></returns>
        public static InfoboxTemplate StartInfoboxSession(string title, string body, ButtonType type)
        {
            InfoboxTemplate info = new InfoboxTemplate(type)
            {
                label1 = { Text = body }
            };
	        Init(info, title, Properties.Resources.iconInfoBox_fw.ToIcon(), true, false);
            return info;
        }
    }
}
