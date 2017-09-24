using System.Windows.Forms;

namespace ShiftOS.Engine.WindowManager
{
    public class ShiftWM
    {
        public static System.Drawing.Text.PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();

        public ShiftWindow Init(UserControl content, string title, bool ShowAsInfobox = false, bool resize = true)
        {
            // Setup Window
            ShiftWindow app = new ShiftWindow();
            app.Text = title;
            app.Title.Text = title;
            app.Width = content.Width + app.left.Width + app.right.Width;
            app.Height = content.Height + app.bottom.Height + app.top.Height;

            // Setup UC
            content.Parent = app.programContent;
            content.BringToFront();
            content.Dock = DockStyle.Fill;

            // Check if icon is null (NYI)
            /*
            if (icon == null)
            {
                app.programIcon.Hide();
                app.programIcon.Image = Engine.Properties.Resources.nullIcon;
                app.Title.Location = new Point(2, 1);
            }
            else app.programIcon.Image = icon;
            */
            app.Show();
            return app;
        }
    }
}
