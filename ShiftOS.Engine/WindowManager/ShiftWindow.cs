using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ShiftOS.Engine.Misc;

namespace ShiftOS.Engine.WindowManager
{
	public partial class ShiftWindow : Form
	{
		const int WmNclbuttondown = 0xA1;
		const int HtCaption = 0x2;

		public ShiftWindow()
		{
			InitializeComponent();
		}

		public uint Id { get; private set; }

		public UserControl ChildControl { get; set; }

		public uint SetId()
		{
			do
			{
				Id = (uint) Tools.Rnd.Next(100000, 999999);
			} while (ShiftWm.Windows.FirstOrDefault(w => w.Id == Id) != null);

			return Id;
		}

		[DllImport("user32.dll")]
		static extern int SendMessage(
			IntPtr hWnd,
			int msg,
			int wParam,
			int lParam);

		[DllImport("user32.dll")]
		static extern bool ReleaseCapture();

		void Programtopbar_drag(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left) return;

			ReleaseCapture();
			SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
		}

		void closebutton_Click(object sender, EventArgs e)
			=> Close();

		void closebutton_MouseEnter(object sender, EventArgs e)
			=> btnClose.BackColor = ShiftSkinData.BtnCloseHoverColor;

		void closebutton_MouseLeave(object sender, EventArgs e)
			=> btnClose.BackColor = ShiftSkinData.BtnCloseColor;

		void maximizebutton_MouseEnter(object sender, EventArgs e)
			=> btnMax.BackColor = ShiftSkinData.BtnMaxHoverColor;

		void maximizebutton_MouseLeave(object sender, EventArgs e)
			=> btnMax.BackColor = ShiftSkinData.BtnMaxColor;

		void minimizebutton_MouseEnter(object sender, EventArgs e)
			=> btnMin.BackColor = ShiftSkinData.BtnMinHoverColor;


		void minimizebutton_MouseLeave(object sender, EventArgs e)
			=> btnMin.BackColor = ShiftSkinData.BtnMinColor;

		/*
		private void closebutton_MouseDown(object sender, MouseEventArgs e) 
			=> btnClose.BackColor = Color.Black;

		private void maximizebutton_MouseDown(object sender, MouseEventArgs e) 
			=> btnMax.BackColor = Color.Black;

		private void minimizebutton_MouseDown(object sender, MouseEventArgs e) 
			=> btnMin.BackColor = Color.Black;
	        */
	}

	public interface IShiftWindowExtensions
	{
		void OnLoaded(ShiftWindow window);
	}
}