using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ShiftOS.Engine.Misc;
using ShiftOS.Engine.Properties;
using static ShiftOS.Engine.WindowManager.InfoboxTemplate;

namespace ShiftOS.Engine.WindowManager
{
	public static class ShiftWM
	{
		public static EventList<ShiftWindow> Windows = new EventList<ShiftWindow>();
		
		public static ShiftWindow GetShiftWindow(this UserControl control)
		{
			return Windows.First(p => (uint) control.Tag == p.Id);
		}

		/// <summary>
		///     Shows a new ShiftWindow based on a UserControl.
		/// </summary>
		/// <param name="content">The UserControl to use</param>
		/// <param name="title">The program's title</param>
		/// <param name="icon">The icon to show</param>
		/// <param name="showAsInfobox">Checks if this is an infobox</param>
		/// <param name="resize">Enables or disables resizing</param>
		/// <returns></returns>
		public static ShiftWindow Init(
			UserControl content,
			string title,
			Bitmap icon,
			bool showAsInfobox = false,
			bool resize = true)
		{
			// Setup Window
			var app = new ShiftWindow
			{
				Text = title,
				Title = { Text = title }
			};

            if (showAsInfobox)
            {
                app.btnMin.Visible = false;
                app.btnMax.Visible = false;
            }

			app.Width = content.Width + app.leftSide.Width + app.rightSide.Width;
			app.Height = content.Height + app.bottomSide.Height + app.titleBar.Height;

			if (ShiftSkinData.Colors.TitleBarColor == Color.Empty)
			{
				Color borderColor = Color.FromArgb(64, 64, 64);
                ShiftSkinData.Colors.BtnCloseColor = Color.Black;
                ShiftSkinData.Colors.BtnCloseHoverColor = Color.FromArgb(40, 40, 40);
                ShiftSkinData.Colors.BtnMaxColor = Color.Black;
                ShiftSkinData.Colors.BtnMaxHoverColor = Color.FromArgb(40, 40, 40);
                ShiftSkinData.Colors.BtnMinColor = Color.Black;
                ShiftSkinData.Colors.BtnMinHoverColor = Color.FromArgb(40, 40, 40);
                ShiftSkinData.Colors.LeftTopCornerColor = borderColor;
				ShiftSkinData.Colors.TitleBarColor = borderColor;
				ShiftSkinData.Colors.RightTopCornerColor = borderColor;
				ShiftSkinData.Colors.LeftSideColor = borderColor;
				ShiftSkinData.Colors.RightSideColor = borderColor;
				ShiftSkinData.Colors.LeftBottomCornerColor = borderColor;
				ShiftSkinData.Colors.BottomSideColor = borderColor;
				ShiftSkinData.Colors.RightBottomCornerColor = borderColor;
			}

			app.btnClose.BackColor = ShiftSkinData.Colors.BtnCloseColor;
			app.btnMax.BackColor = ShiftSkinData.Colors.BtnMaxColor;
			app.btnMin.BackColor = ShiftSkinData.Colors.BtnMinColor;
			app.leftTopCorner.BackColor = ShiftSkinData.Colors.LeftTopCornerColor;
			app.titleBar.BackColor = ShiftSkinData.Colors.TitleBarColor;
			app.rightTopCorner.BackColor = ShiftSkinData.Colors.RightTopCornerColor;
			app.leftSide.BackColor = ShiftSkinData.Colors.LeftSideColor;
			app.rightSide.BackColor = ShiftSkinData.Colors.RightSideColor;
			app.leftBottomCorner.BackColor = ShiftSkinData.Colors.LeftBottomCornerColor;
			app.bottomSide.BackColor = ShiftSkinData.Colors.BottomSideColor;
			app.rightBottomCorner.BackColor = ShiftSkinData.Colors.RightBottomCornerColor;


			// Icon Setup
			if (icon == null)
			{
				app.programIcon.Hide();
				app.Title.Location = new Point(2, 7);
			}

			else
			{
				app.programIcon.Image = icon;
				app.Icon = icon.ToIcon();
			}

			// Setup UC
			content.Parent = app.programContent;
			content.BringToFront();
			content.Dock = DockStyle.Fill;
			app.Show();

			content.Tag = app.SetId();

			Debug.WriteLine($"usercontrol: {content.Tag} window: {app.Id}");

			app.Closed += (sender, args) => { Windows.Remove((ShiftWindow) sender); };

			Windows.Add(app);

			if (content is IShiftWindowExtensions extensions)
			{
				extensions.OnLoaded(app);
			}

            app.TopMost = true;

			return app;
		}

		/// <summary>
		///     Shows a new infobox.
		/// </summary>
		/// <param name="title">The title of the infobox.</param>
		/// <param name="body">The infobox's content.</param>
		/// <param name="type">The ButtonType used for the infobox.</param>
		/// <returns></returns>
		public static InfoboxTemplate StartInfoboxSession(string title, string body, ButtonType type)
		{
			var info = new InfoboxTemplate(type)
			{
				label1 = { Text = body }
			};
			Init(info, title, Resources.iconInfoBox_fw, true, false);
			return info;
		}
	}
}