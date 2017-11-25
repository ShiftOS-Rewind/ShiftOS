using System.Drawing;

namespace ShiftOS.Engine.WindowManager
{
    public abstract class ShiftSkinData
    {
        // ColorData
        public static skinColors Colors = new skinColors();
        public static skinTextures Images = new skinTextures();
    }

    public class skinTextures
    {
        public skinTextures()
        {

        }
    }
}

namespace ShiftOS.Engine.WindowManager
{
    public class skinColors
    {
        public Color LeftTopCornerColor;
        public Color TitleBarColor;
        public Color RightTopCornerColor;
        public Color BtnCloseColor;
        public Color BtnMaxColor;
        public Color BtnMinColor;
        public Color BtnCloseHoverColor;
        public Color BtnMaxHoverColor;
        public Color BtnMinHoverColor;
        public Color LeftSideColor;
        public Color RightSideColor;
        public Color LeftBottomCornerColor;
        public Color BottomSideColor;
        public Color RightBottomCornerColor;
    }
}