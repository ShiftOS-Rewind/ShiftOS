using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShiftOS.Engine.UI
{
    public class ShiftStripRenderer : ToolStripRenderer
    {
        SolidBrush sb;

        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            if (!e.Item.Selected)
            {
                base.OnRenderButtonBackground(e);
            }
            else
            {
                sb = new SolidBrush(Color.FromArgb(64, 64, 64));
                Rectangle rectangle = new Rectangle(0, 0, e.Item.Size.Width - 1, e.Item.Size.Height - 1);
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(64,64,64)), rectangle);
                e.Graphics.DrawRectangle(new Pen(sb, 1F), rectangle);
            }
        }
    }
}