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

			app.Width = content.Width + app.leftSide.Width + app.rightSide.Width;
			app.Height = content.Height + app.bottomSide.Height + app.titleBar.Height;

			if (ShiftSkinData.TitleBarColor == Color.Empty)
			{
				var borderColor = Color.FromArgb(64, 64, 64);
				ShiftSkinData.BtnCloseColor = Color.Black;
				ShiftSkinData.BtnMaxColor = Color.Black;
				ShiftSkinData.BtnMinColor = Color.Black;
				ShiftSkinData.LeftTopCornerColor = borderColor;
				ShiftSkinData.TitleBarColor = borderColor;
				ShiftSkinData.RightTopCornerColor = borderColor;
				ShiftSkinData.LeftSideColor = borderColor;
				ShiftSkinData.RightSideColor = borderColor;
				ShiftSkinData.LeftBottomCornerColor = borderColor;
				ShiftSkinData.BottomSideColor = borderColor;
				ShiftSkinData.RightBottomCornerColor = borderColor;
			}

			app.btnClose.BackColor = ShiftSkinData.BtnCloseColor;
			app.btnMax.BackColor = ShiftSkinData.BtnMaxColor;
			app.btnMin.BackColor = ShiftSkinData.BtnMinColor;
			app.leftTopCorner.BackColor = ShiftSkinData.LeftTopCornerColor;
			app.titleBar.BackColor = ShiftSkinData.TitleBarColor;
			app.rightTopCorner.BackColor = ShiftSkinData.RightTopCornerColor;
			app.leftSide.BackColor = ShiftSkinData.LeftSideColor;
			app.rightSide.BackColor = ShiftSkinData.RightSideColor;
			app.leftBottomCorner.BackColor = ShiftSkinData.LeftBottomCornerColor;
			app.bottomSide.BackColor = ShiftSkinData.BottomSideColor;
			app.rightBottomCorner.BackColor = ShiftSkinData.RightBottomCornerColor;


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