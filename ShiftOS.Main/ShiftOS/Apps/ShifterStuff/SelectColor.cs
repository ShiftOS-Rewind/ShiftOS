using System;
using System.Drawing;
using System.Windows.Forms;
using ShiftOS.Engine.WindowManager;

namespace ShiftOS.Main.ShiftOS.Apps
{
    public partial class SelectColor : UserControl
    {
        Color _finalColor;
        int _colorType1;
        int _colorType2;
        int _colorType3;
        public SelectColor()
        {
            InitializeComponent();
            
        }

        private void btnSetColor_Click(object sender, EventArgs e)
        {
            try
            {
                _colorType1 = Convert.ToInt32(textBox1.Text);
                _colorType2 = Convert.ToInt32(textBox2.Text);
                _colorType3 = Convert.ToInt32(textBox3.Text);
            }
            catch(FormatException ex)
            {
                ShiftWM.StartInfoboxSession("Error!", "Failed to parse integer. Error:\n" + ex, InfoboxTemplate.ButtonType.Ok);
            }
            
            if (_colorType1 > 255 || _colorType2 > 255 || _colorType3 > 255)
            {
                ShiftWM.StartInfoboxSession("Error!", "A value cannot be greater than 255!", InfoboxTemplate.ButtonType.Ok);
            }
            else
            {
                try
                {
                    ShiftWindow sw = new ShiftWindow();
                    _finalColor = Color.FromArgb(_colorType1, _colorType2, _colorType3);
                    BackColor = _finalColor;
                    ShiftWM.StartInfoboxSession("Success!", "Changed color to:\n" + _colorType1.ToString() + ", " + _colorType2.ToString() + ", " + _colorType3.ToString() + ".", InfoboxTemplate.ButtonType.Ok);
                }
                catch (Exception)
                {
                    ShiftWM.StartInfoboxSession("Error!", "An error occured while setting the color.", InfoboxTemplate.ButtonType.Ok);
                }
            }
        }
    }
}
