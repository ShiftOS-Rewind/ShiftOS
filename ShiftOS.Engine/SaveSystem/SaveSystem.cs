using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ShiftOS.Engine.SaveSystem
{
    public static class SaveSystem
    {
        public static string dataDir
        {
            get
            {
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ShiftOS-Rewind");
            }
        }
    }
}
