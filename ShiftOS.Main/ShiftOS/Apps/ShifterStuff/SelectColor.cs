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
            _colorType1 = Int32.Parse(redUpDown.Value.ToString());
            _colorType2 = Int32.Parse(greenUpDown.Value.ToString());
            _colorType3 = Int32.Parse(blueUpDown.Value.ToString());
            try
            {
                _finalColor = Color.FromArgb(_colorType1, _colorType2, _colorType3);
                //BackColor = _finalColor;
                
                foreach (var window in ShiftWM.Windows)
{
                    window.Invoke(new Action(() => window.top.BackColor = _finalColor));
                }
                
                ShiftWM.StartInfoboxSession("Success!", $"Changed color to:\r\n{_colorType1}, {_colorType2}, {_colorType3}.", InfoboxTemplate.ButtonType.Ok);
            }
            catch (Exception)
            {
                ShiftWM.StartInfoboxSession("Error!", "An error occured while setting the color.", InfoboxTemplate.ButtonType.Ok);
            }
            //return _finalColor;
        }
    }
    }
