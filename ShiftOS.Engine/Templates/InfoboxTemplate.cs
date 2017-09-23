using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShiftOS.Engine.Templates
{
    public partial class InfoboxTemplate : UserControl
    {
        public int buttonResult;
        public InfoboxTemplate(buttonType type)
        {
            InitializeComponent();
            switch (type)
            {
                case buttonType.OK:
                    button1.Text = "OK";
                    button2.Visible = false;
                    button1.Location = new Point(117, 122);

            }
        }
        public enum buttonType
        {
            YesNo,
            OK,
            OKCancel,
        }
    }
}
