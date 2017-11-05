using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace ShiftOS.Engine.WindowManager
{
    public partial class InfoboxTemplate : UserControl
    {
        Stream _str;
        private int _buttonChoice;
	    private int _buttonSelected;
        public InfoboxTemplate(ButtonType type)
        {
            InitializeComponent();
            
            switch (type)
            {
                case ButtonType.Ok:
                    btnOpt1.Text = "OK";
                    btnOpt2.Hide();
                    btnOpt1.Location = new Point(109, 134);
                    _buttonChoice = 1;
                    break;
                case ButtonType.OkCancel:
                    btnOpt1.Text = "OK";
                    btnOpt2.Text = "Cancel";
                    _buttonChoice = 2;
                    break;
                case ButtonType.YesNo:
                    btnOpt1.Text = "Yes";
                    btnOpt2.Text = "No";
                    _buttonChoice = 3;
                    break;
            }
        }

        public enum ButtonType
        {
            YesNo,
            OkCancel,
            Ok
        }

        public enum DialogResult
        {
            Yes,
            No,
            Cancel,
            Ok
        }

        private void btnOpt1_Click(object sender, EventArgs e)
        {
            switch (btnOpt1.Text)
            {
                case "OK":
                    ParentForm?.Close();
                    break;
                case "Yes":
                    _buttonSelected = 2;
                    ParentForm?.Close();
                    break;
            }
        }

        private void btnOpt2_Click(object sender, EventArgs e)
        {
            switch (btnOpt2.Text)
            {
                case "No":
                    _buttonSelected = 3;
                    break;
                case "Cancel":
                    _buttonSelected = 4;
                    break;
            }
        }

        public void Play()
        {
            _str = Properties.Resources.infobox;
            SoundPlayer sp = new SoundPlayer(_str);
            sp.Play();
            sp.Stream.Position = 0;
        }

        private void InfoboxTemplate_Load(object sender, EventArgs e) 
			=> Play();

	    
    }
}
