using System.Drawing;

namespace ShiftOS.Engine.WindowManager
{
    public class ShiftSkinData
    {
        // ColorData
        public Color leftTopCornerColor { get; set; }
        public Color titleBarColor { get; set; }
        public Color rightTopCornerColor { get; set; }
        public Color btnCloseColor { get; set; }
        public Color btnMaxColor { get; set; }
        public Color btnMinColor { get; set; }
        public Color leftSideColor { get; set; }
        public Color rightSideColor { get; set; }
        public Color leftBottomCornerColor { get; set; }
        public Color bottomSideColor { get; set; }
        public Color rightBottomCornerColor { get; set; }
        public Color borderColorColor { get; set; }

        // SetBorderColor
        public void setBorderColor(Color borderColor)
        {
            leftTopCornerColor = borderColor;
            titleBarColor = borderColor;
            rightTopCornerColor = borderColor;
            leftSideColor = borderColor;
            rightSideColor = borderColor;
            leftBottomCornerColor = borderColor;
            bottomSideColor = borderColor;
            rightBottomCornerColor = borderColor;
        }
    }
}
