using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ShiftOS.Engine.Misc;
using ShiftOS.Engine.WindowManager;
using ShiftOS.Main.Properties;
using Whoa;

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

        /// <summary>
        /// Modifies the values in ShiftShiftSkinData.Colors.
        /// </summary>
        /// <param name="borderColor">The border color of the window.</param>
        /// <param name="btnClose">The close button color of the window.</param>
        /// <param name="btnCloseHover">The close button color of the window while hovering.</param>
        /// <param name="btnMax">The maximize button color of the window.</param>
        /// <param name="btnMaxHover">The maximize button color of the window while hovering.</param>
        /// <param name="btnMin">The minimize button color of the window.</param>
        /// <param name="btnMinHover">The minimize button color of the window while hovering.</param>
        void ModifyData(Color borderColor, Color btnClose, Color btnCloseHover, Color btnMax, Color btnMaxHover, Color btnMin, Color btnMinHover)
        {
            SetBorderColor(borderColor);
            ShiftSkinData.Colors.BtnCloseColor = btnClose;
            ShiftSkinData.Colors.BtnCloseHoverColor = btnCloseHover;
            ShiftSkinData.Colors.BtnMaxColor = btnMax;
            ShiftSkinData.Colors.BtnMaxHoverColor = btnMaxHover;
            ShiftSkinData.Colors.BtnMinColor = btnMin;
            ShiftSkinData.Colors.BtnMinHoverColor = btnMinHover;
        }

        // SetBorderColor
        public void SetBorderColor(Color borderColor)
        {
            ShiftSkinData.Colors.LeftTopCornerColor = borderColor;
            ShiftSkinData.Colors.TitleBarColor = borderColor;
            ShiftSkinData.Colors.RightTopCornerColor = borderColor;
            ShiftSkinData.Colors.LeftSideColor = borderColor;
            ShiftSkinData.Colors.RightSideColor = borderColor;
            ShiftSkinData.Colors.LeftBottomCornerColor = borderColor;
            ShiftSkinData.Colors.BottomSideColor = borderColor;
            ShiftSkinData.Colors.RightBottomCornerColor = borderColor;
        }

        void SetDefaultSkin(object sender, EventArgs e)
		{
            ModifyData(Color.FromArgb(64, 64, 64), Color.Black, Color.FromArgb(40, 40, 40), Color.Black, Color.FromArgb(40, 40, 40), Color.Black, Color.FromArgb(40, 40, 40));
            ApplySkin();
		}

		void SetColorSkin(object sender, EventArgs e)
		{
            ModifyData(Color.Blue, Color.Red, Color.FromArgb(255, 102, 102), Color.Yellow, Color.FromArgb(255, 255, 153), Color.Green, Color.FromArgb(102, 255, 102));
			ApplySkin();
		}

		void SetRandomSkin(object sender, EventArgs e)
		{
			var rnd = new Random();
            ModifyData(
                Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255)), // Border Color
                Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255)), // Close Button Color
                Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255)), // Close Hover Color
                Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255)), // Maximize Button Color
                Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255)), // Maximize Hover Color
                Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255)), // Minimize Button Color
                Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255))); // Minimize Hover Color
			ApplySkin();
		}

		void ApplySkin()
		{
			foreach (var window in ShiftWM.Windows)
			{
				window.Invoke(new Action(() => window.titleBar.BackColor = ShiftSkinData.Colors.TitleBarColor));
				window.Invoke(new Action(() => window.leftTopCorner.BackColor = ShiftSkinData.Colors.LeftTopCornerColor));
				window.Invoke(new Action(() => window.rightTopCorner.BackColor = ShiftSkinData.Colors.RightTopCornerColor));
				window.Invoke(new Action(() => window.leftSide.BackColor = ShiftSkinData.Colors.LeftSideColor));
				window.Invoke(new Action(() => window.rightSide.BackColor = ShiftSkinData.Colors.RightSideColor));
				window.Invoke(new Action(() => window.leftBottomCorner.BackColor = ShiftSkinData.Colors.LeftBottomCornerColor));
				window.Invoke(new Action(() => window.bottomSide.BackColor = ShiftSkinData.Colors.BottomSideColor));
				window.Invoke(new Action(() => window.rightBottomCorner.BackColor = ShiftSkinData.Colors.RightBottomCornerColor));
				window.Invoke(new Action(() => window.btnClose.BackColor = ShiftSkinData.Colors.BtnCloseColor));
				window.Invoke(new Action(() => window.btnMax.BackColor = ShiftSkinData.Colors.BtnMaxColor));
				window.Invoke(new Action(() => window.btnMin.BackColor = ShiftSkinData.Colors.BtnMinColor));
			}
		}

		void btnSave_Click(object sender, EventArgs e)
		{
            Color[] shiftSkinColors = new Color[14];
            int i = 0;
            
            shiftSkinColors[0] = ShiftSkinData.Colors.LeftTopCornerColor;
            shiftSkinColors[1] = ShiftSkinData.Colors.TitleBarColor;
            shiftSkinColors[2] = ShiftSkinData.Colors.RightTopCornerColor;
            shiftSkinColors[3] = ShiftSkinData.Colors.LeftSideColor;
            shiftSkinColors[4] = ShiftSkinData.Colors.RightSideColor;
            shiftSkinColors[5] = ShiftSkinData.Colors.LeftBottomCornerColor;
            shiftSkinColors[6] = ShiftSkinData.Colors.BottomSideColor;
            shiftSkinColors[7] = ShiftSkinData.Colors.RightBottomCornerColor;
            shiftSkinColors[8] = ShiftSkinData.Colors.BtnCloseColor;
            shiftSkinColors[9] = ShiftSkinData.Colors.BtnCloseHoverColor;
            shiftSkinColors[10] = ShiftSkinData.Colors.BtnMaxColor;
            shiftSkinColors[11] = ShiftSkinData.Colors.BtnMaxHoverColor;
            shiftSkinColors[12] = ShiftSkinData.Colors.BtnMinColor;
            shiftSkinColors[13] = ShiftSkinData.Colors.BtnMinHoverColor;

            using (var fobj = File.OpenWrite(@"C:\Users\Public\Documents\Skin.whoa"))
                Whoa.Whoa.SerialiseObject(fobj, shiftSkinColors);

            ShiftWM.StartInfoboxSession(
				"Saved Skin",
				"Saved Skin to C:\\Users\\Public\\Documents\\Skin.whoa",
				InfoboxTemplate.ButtonType.Ok);
		}

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Color[] shiftSkinColors = new Color[14];
            using (var fobj = File.OpenRead(@"C:\Users\Public\Documents\Skin.whoa"))
              shiftSkinColors  = Whoa.Whoa.DeserialiseObject<Color[]>(fobj);

            ShiftSkinData.Colors.LeftTopCornerColor = shiftSkinColors[0];
            ShiftSkinData.Colors.TitleBarColor = shiftSkinColors[1];
            ShiftSkinData.Colors.RightTopCornerColor = shiftSkinColors[2];
            ShiftSkinData.Colors.LeftSideColor = shiftSkinColors[3];
            ShiftSkinData.Colors.RightSideColor = shiftSkinColors[4];
            ShiftSkinData.Colors.LeftBottomCornerColor = shiftSkinColors[5];
            ShiftSkinData.Colors.BottomSideColor = shiftSkinColors[6];
            ShiftSkinData.Colors.RightBottomCornerColor = shiftSkinColors[7];
            ShiftSkinData.Colors.BtnCloseColor = shiftSkinColors[8];
            ShiftSkinData.Colors.BtnCloseHoverColor = shiftSkinColors[9];
            ShiftSkinData.Colors.BtnMaxColor = shiftSkinColors[10];
            ShiftSkinData.Colors.BtnMaxHoverColor = shiftSkinColors[11];
            ShiftSkinData.Colors.BtnMinColor = shiftSkinColors[12];
            ShiftSkinData.Colors.BtnMinHoverColor = shiftSkinColors[13];

            ApplySkin();
            ShiftWM.StartInfoboxSession(
    "Loaded Skin",
    "Loaded Skin from C:\\Users\\Public\\Documents\\Skin.whoa",
    InfoboxTemplate.ButtonType.Ok);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ModifyData(
                Color.FromArgb(15, 29, 45),
                Color.FromArgb(15, 29, 78),
                Color.FromArgb(15, 29, 100),
                Color.FromArgb(15, 29, 130),
                Color.FromArgb(15, 29, 108),
                Color.FromArgb(15, 29, 130),
                Color.FromArgb(15, 29, 160));
            ApplySkin();
        }
    }
}