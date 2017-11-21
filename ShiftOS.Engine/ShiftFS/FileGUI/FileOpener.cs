using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShiftOS.Engine.WindowManager;

namespace ShiftOS.Engine.ShiftFS.FileGUI
{
    public partial class FileOpener : UserControl
    {
        public FileOpener()
        {
            InitializeComponent();
        }

        private void shiftButton1_Click(object sender, EventArgs e)
        {
            ShiftWM.StartInfoboxSession("Test", "lol", InfoboxTemplate.ButtonType.Ok);
        }
    }
}
