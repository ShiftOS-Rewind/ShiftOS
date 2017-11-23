using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftOS.Engine
{
    public class SaveSystem
    {
        public static string gameDir
        {
            get
            {
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ShiftOS-Rewind");
            }
        }
        public static string fontDir
        {
            get
            {
                return gameDir + "\\Fonts";
            }
        }
    }
}
