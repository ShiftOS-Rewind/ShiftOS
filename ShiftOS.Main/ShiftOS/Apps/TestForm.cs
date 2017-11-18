using System;
using System.Windows.Forms;
using ShiftOS.Engine.Misc;
using ShiftOS.Engine.WindowManager;
using ShiftOS.Main.Properties;
using ShiftOS.Main.ShiftOS.Apps.ShifterStuff;

namespace ShiftOS.Main.ShiftOS.Apps
{
	public partial class TestForm : Form
	{
		public TestForm()
		{
			InitializeComponent();
		}

		void Button1_Click(object sender, EventArgs e)
		{
			var demo = new ShiftDemo();
			ShiftWM.Init(demo, textBox1.Text, null);
			ShiftWM.StartInfoboxSession(textBox1.Text, textBox2.Text, InfoboxTemplate.ButtonType.Ok);
		}

		void button2_Click(object sender, EventArgs e)
			=> ShiftWM.Init(new Shifter(), "Shifter", Resources.iconShifter);
	}
}