using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace ShiftOS.Engine.WindowManager
{
    public partial class InfoboxTemplate : UserControl
    {
        Stream str;
        public int buttonChoice;
        public int buttonSelected;
        public InfoboxTemplate(buttonType type)
        {
            InitializeComponent();
            switch (type)
            {
                case buttonType.OK:
                    btnOpt1.Text = "OK";
                    btnOpt2.Hide();
                    btnOpt1.Location = new Point(122, 134);
                    buttonChoice = 1;
                    break;
                case buttonType.OKCancel:
                    btnOpt1.Text = "OK";
                    btnOpt2.Text = "Cancel";
                    buttonChoice = 2;
                    break;
                case buttonType.YesNo:
                    btnOpt1.Text = "Yes";
                    btnOpt2.Text = "No";
                    buttonChoice = 3;
                    break;
            }
        }
        public enum buttonType
        {
            YesNo,
            OKCancel,
            OK
        }

        private void btnOpt1_Click(object sender, EventArgs e)
        {
            switch (btnOpt1.Text)
            {
                case "OK":
                    buttonSelected = 1;
                    ParentForm.Close();
                    break;
                case "Yes":
                    buttonSelected = 2;
                    ParentForm.Close();
                    break;
            }
        }

        private void btnOpt2_Click(object sender, EventArgs e)
        {
            switch (btnOpt2.Text)
            {
                case "No":
                    buttonSelected = 3;
                    break;
                case "Cancel":
                    buttonSelected = 4;
                    break;
            }
        }
        public void Play()
        {
            str = Properties.Resources.infobox;
            SoundPlayer sp = new SoundPlayer(str);
            sp.Play();
            sp.Stream.Position = 0;
        }

        private void InfoboxTemplate_Load(object sender, EventArgs e)
        {
            Play();
        }
    }
}
