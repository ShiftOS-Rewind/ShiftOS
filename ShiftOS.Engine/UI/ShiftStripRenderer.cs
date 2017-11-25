using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShiftOS.Engine.UI
{
    public class ShiftStripRenderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderLabelBackground(ToolStripItemRenderEventArgs e)
        {
            using (var b = new SolidBrush(e.Item.BackColor))
            {
                e.Graphics.FillRectangle(b, new Rectangle(Point.Empty, e.Item.Size));
            }
        }
    }
}
