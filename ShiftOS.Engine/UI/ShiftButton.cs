using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShiftOS.Engine.UI
{
    public partial class ShiftButton : Control, IButtonControl
    {
        private bool _pressing = false;
        private Color _lightBack;
        public ShiftButton()
        {
            InitializeComponent();
        }

        public DialogResult DialogResult { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void NotifyDefault(bool value)
        {

        }

        public void PerformClick()
        {
            this.OnClick(new EventArgs());
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            this.Font = new Font("Lucida Console", 9, FontStyle.Regular);
            _lightBack = Color.WhiteSmoke;
            var g = pe.Graphics;
            g.Clear(BackColor);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            var sf = new StringFormat();

            if (_pressing)
            {
                g.FillRectangle(new SolidBrush(Color.White), 0, 0, Width, Height);
                g.DrawString(Text, Font, new SolidBrush(Color.Black), ((Width / 2) + 1), (Height / 2) + 1);
            }
            else
            {
                g.FillRectangle(new SolidBrush(Color.WhiteSmoke), 0, 0, Width, Height);
            }
        }
    }
}
