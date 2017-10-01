using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ShiftOS.Engine.WindowManager
{
    public partial class ShiftWindow : Form
    {
		public uint Id { get; private set; }

	    public UserControl ChildControl { get; set; }

	    public ShiftWindow()
        {
            InitializeComponent();
        }

	    public uint SetId()
	    {
			do
			{
				Id = (uint)Tools.Rnd.Next(100000, 999999);
			}
			while (ShiftWM.Windows.FirstOrDefault(w => w.Id == Id) != null);

		    return Id;
	    }

		private const int WM_NCLBUTTONDOWN = 0xA1;
	    private const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd,
                        int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        private void Programtopbar_drag(object sender, MouseEventArgs e)
        {
	        if (e.Button != MouseButtons.Left) return;

	        ReleaseCapture();
	        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void closebutton_Click(object sender, EventArgs e) 
			=> this.Close();

	    private void closebutton_MouseEnter(object sender, EventArgs e) 
			=> closebutton.BackColor = Color.Gray;

		private void closebutton_MouseLeave(object sender, EventArgs e) 
			=> closebutton.BackColor = Color.Black;

		private void maximizebutton_MouseEnter(object sender, EventArgs e) 
			=> maximizebutton.BackColor = Color.Gray;

		private void maximizebutton_MouseLeave(object sender, EventArgs e) 
			=> maximizebutton.BackColor = Color.Black;

		private void minimizebutton_MouseEnter(object sender, EventArgs e) 
			=> minimizebutton.BackColor = Color.Gray;

		private void minimizebutton_MouseLeave(object sender, EventArgs e) 
			=> minimizebutton.BackColor = Color.Black;

		private void closebutton_MouseDown(object sender, MouseEventArgs e) 
			=> closebutton.BackColor = Color.Black;

		private void maximizebutton_MouseDown(object sender, MouseEventArgs e) 
			=> maximizebutton.BackColor = Color.Black;

		private void minimizebutton_MouseDown(object sender, MouseEventArgs e) 
			=> minimizebutton.BackColor = Color.Black;

		private void minimizebutton_MouseUp(object sender, MouseEventArgs e) 
			=> minimizebutton.BackColor = Color.Gray;

		private void maximizebutton_MouseUp(object sender, MouseEventArgs e) 
			=> maximizebutton.BackColor = Color.Gray;

		private void closebutton_MouseUp(object sender, MouseEventArgs e) 
			=> closebutton.BackColor = Color.Gray;
	}

	public interface IShiftWindowExtensions
	{
		void OnLoaded(ShiftWindow window);
	}
}
