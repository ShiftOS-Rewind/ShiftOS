using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShiftOS.Engine.UI;
using ShiftOS.Engine.WindowManager;

namespace ShiftOS.Main
{
    public partial class Desktop : Form
    {
        public Desktop()
        {
            InitializeComponent();
            foreach (var menuItem in applicationsToolStripMenuItem.DropDownItems.OfType<ToolStripMenuItem>())
            {
                menuItem.BackColor = Color.FromArgb(64,64,64);
                menuItem.ForeColor = Color.White;
            }
            menuStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            ToolStripManager.Renderer = new ShiftToolStrip();
            this.FormClosed += (o, a) => Application.Exit();
        }

        private void terminalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShiftWM.Init(new Apps.Terminal(), "Terminal", Properties.Resources.iconTerminal);
        }

        private void fileSkimmerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShiftWM.Init(new Apps.FileSkimmer(), "FileSkimmer", Properties.Resources.iconFileSkimmer);
        }

        private void textPadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShiftWM.Init(new Apps.TextPad(), "TextPad", Properties.Resources.iconTextPad);
        }

        private void pongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShiftWM.Init(new Apps.Pong(), "Pong", null);
        }

    }
}
