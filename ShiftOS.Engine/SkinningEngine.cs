using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShiftOS.Engine.WindowManager;
using System.Drawing;

namespace ShiftOS.Engine
{
    public static class SkinningEngine
    {
        static ShiftWindow shiftWindow = new ShiftWindow();
        public static void SetTitleBarColor(Color selectedColor)
        {
            shiftWindow.top.BackColor = selectedColor;
        }
        public static void SetBackColor(Color selectedColor)
        {
            shiftWindow.programContent.BackColor = selectedColor;
        }
    }
}
