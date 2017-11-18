using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using ShiftOS.Engine.Misc;
using ShiftOS.Engine.WindowManager;
using ShiftOS.Main.Properties;

namespace ShiftOS.Main.ShiftOS.Apps.ShifterStuff
{
	public partial class Shifter : UserControl
	{
		public int ColorType; //This is a check to see what option was chosen.

		public Shifter()
		{
			InitializeComponent();
		}

		void button1_Click(object sender, EventArgs e)
		{
			ColorType = 1;
			ShiftWM.Init(new SelectColor(), "Select a color", Resources.iconColourPicker_fw);
		}

		void SetDefaultSkin(object sender, EventArgs e)
		{
			SetBorderColor(Color.FromArgb(64, 64, 64));
			ShiftSkinData.BtnCloseColor = Color.Black;
			ShiftSkinData.BtnMaxColor = Color.Black;
			ShiftSkinData.BtnMinColor = Color.Black;
			button5_Click(sender, e);
		}

		void SetColorSkin(object sender, EventArgs e)
		{
			SetBorderColor(Color.Blue);
			ShiftSkinData.BtnCloseColor = Color.Red;
			ShiftSkinData.BtnMaxColor = Color.Yellow;
			ShiftSkinData.BtnMinColor = Color.Green;
			ShiftSkinData.BtnCloseHoverColor = Color.FromArgb(255, 102, 102);
			ShiftSkinData.BtnMaxHoverColor = Color.FromArgb(255, 255, 153);
			ShiftSkinData.BtnMinColor = Color.FromArgb(102, 255, 102);
			button5_Click(sender, e);
		}

		void SetRandomSkin(object sender, EventArgs e)
		{
			var rnd = new Random();
			SetBorderColor(Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255)));
			ShiftSkinData.BtnCloseColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
			ShiftSkinData.BtnMaxColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
			ShiftSkinData.BtnMinColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
			ShiftSkinData.BtnCloseHoverColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
			ShiftSkinData.BtnMaxHoverColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
			ShiftSkinData.BtnMinHoverColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
			button5_Click(sender, e);
		}

		// SetBorderColor
		public void SetBorderColor(Color borderColor)
		{
			ShiftSkinData.LeftTopCornerColor = borderColor;
			ShiftSkinData.TitleBarColor = borderColor;
			ShiftSkinData.RightTopCornerColor = borderColor;
			ShiftSkinData.LeftSideColor = borderColor;
			ShiftSkinData.RightSideColor = borderColor;
			ShiftSkinData.LeftBottomCornerColor = borderColor;
			ShiftSkinData.BottomSideColor = borderColor;
			ShiftSkinData.RightBottomCornerColor = borderColor;
		}

		void button5_Click(object sender, EventArgs e)
		{
			foreach (var window in ShiftWM.Windows)
			{
				window.Invoke(new Action(() => window.titleBar.BackColor = ShiftSkinData.TitleBarColor));
				window.Invoke(new Action(() => window.leftTopCorner.BackColor = ShiftSkinData.LeftTopCornerColor));
				window.Invoke(new Action(() => window.rightTopCorner.BackColor = ShiftSkinData.RightTopCornerColor));
				window.Invoke(new Action(() => window.leftSide.BackColor = ShiftSkinData.LeftSideColor));
				window.Invoke(new Action(() => window.rightSide.BackColor = ShiftSkinData.RightSideColor));
				window.Invoke(new Action(() => window.leftBottomCorner.BackColor = ShiftSkinData.LeftBottomCornerColor));
				window.Invoke(new Action(() => window.bottomSide.BackColor = ShiftSkinData.BottomSideColor));
				window.Invoke(new Action(() => window.rightBottomCorner.BackColor = ShiftSkinData.RightBottomCornerColor));
				window.Invoke(new Action(() => window.btnClose.BackColor = ShiftSkinData.BtnCloseColor));
				window.Invoke(new Action(() => window.btnMax.BackColor = ShiftSkinData.BtnMaxColor));
				window.Invoke(new Action(() => window.btnMin.BackColor = ShiftSkinData.BtnMinColor));
			}
		}

		void btnSave_Click(object sender, EventArgs e)
		{
			var shiftColors = new Color[14];
			shiftColors[0] = ShiftSkinData.LeftTopCornerColor;
			shiftColors[1] = ShiftSkinData.TitleBarColor;
			shiftColors[2] = ShiftSkinData.RightTopCornerColor;
			shiftColors[3] = ShiftSkinData.LeftSideColor;
			shiftColors[4] = ShiftSkinData.RightSideColor;
			shiftColors[5] = ShiftSkinData.LeftBottomCornerColor;
			shiftColors[6] = ShiftSkinData.BottomSideColor;
			shiftColors[7] = ShiftSkinData.RightBottomCornerColor;
			shiftColors[8] = ShiftSkinData.BtnCloseColor;
			shiftColors[9] = ShiftSkinData.BtnMaxColor;
			shiftColors[10] = ShiftSkinData.BtnMinColor;
			shiftColors[11] = ShiftSkinData.BtnCloseHoverColor;
			shiftColors[12] = ShiftSkinData.BtnMaxHoverColor;
			shiftColors[13] = ShiftSkinData.BtnMinHoverColor;
			File.WriteAllText(@"C:\Users\Public\Documents\Skin.json", JsonConvert.SerializeObject(shiftColors));
			ShiftWM.StartInfoboxSession(
				"Saved Skin",
				"Saved Skin to C:\\Users\\Public\\Documents\\Skin.json",
				InfoboxTemplate.ButtonType.Ok);
		}
	}
}