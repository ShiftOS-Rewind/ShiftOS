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

namespace ShiftOS.Main.ShiftOS.Apps
{
    public partial class SelectColor : UserControl
    {
        ShiftWM shiftWM = new ShiftWM();
        Color finalColor;
        int colorType1;
        int colorType2;
        int colorType3;
        public SelectColor()
        {
            InitializeComponent();
            
        }

        private void btnSetColor_Click(object sender, EventArgs e)
        {
            try
            {
                colorType1 = Convert.ToInt32(textBox1.Text);
                colorType2 = Convert.ToInt32(textBox2.Text);
                colorType3 = Convert.ToInt32(textBox3.Text);
            }
            catch
            {
                shiftWM.StartInfoboxSession("Error!", "Cannot parse a string.", InfoboxTemplate.buttonType.OK);
            }
            
            if (colorType1 > 255 || colorType2 > 255 || colorType3 > 255)
            {
                shiftWM.StartInfoboxSession("Error!", "A value cannot be greater than 255!", InfoboxTemplate.buttonType.OK);
            }
            else
            {
                try
                {
                    ShiftWindow sw = new ShiftWindow();
                    finalColor = Color.FromArgb(colorType1, colorType2, colorType3);
                    this.BackColor = finalColor;
                    shiftWM.StartInfoboxSession("Success!", "Changed color to:\n" + colorType1.ToString() + ", " + colorType2.ToString() + ", " + colorType3.ToString() + ".", InfoboxTemplate.buttonType.OK);
                }
                catch (Exception ex)
                {
                    shiftWM.StartInfoboxSession("Error!", "An exception occured while setting the color! Exception: \n" + ex, InfoboxTemplate.buttonType.OK);
                }
            }
        }
    }
}
