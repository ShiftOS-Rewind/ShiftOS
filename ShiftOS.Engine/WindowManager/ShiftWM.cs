using System.Drawing;
using System.Windows.Forms;
using static ShiftOS.Engine.WindowManager.InfoboxTemplate;

namespace ShiftOS.Engine.WindowManager
{
    public class ShiftWM
    {
        public ShiftWindow Init(UserControl content, string title, Image icon, bool ShowAsInfobox = false, bool resize = true)
        {
            // Setup Window
            ShiftWindow app = new ShiftWindow();
            app.Text = title;
            app.Title.Text = title;
            app.Width = content.Width + app.left.Width + app.right.Width;
            app.Height = content.Height + app.bottom.Height + app.top.Height;

            // Icon Setup
            if (icon == null)
            {
                app.programIcon.Hide();
                app.programIcon.Image = Properties.Resources.nullIcon;
                app.Title.Location = new Point(2, 7);
            }
            else app.programIcon.Image = icon;

            // Setup UC
            content.Parent = app.programContent;
            content.BringToFront();
            content.Dock = DockStyle.Fill;
            app.Show();
            return app;
        }
        public InfoboxTemplate StartInfoboxSession(string title, string body, buttonType type)
        {
            InfoboxTemplate info = new InfoboxTemplate(type);
            info.label1.Text = body;
            Init(info, title, Properties.Resources.iconInfoBox_fw, true, false);
            return info;
        }
    }
}
