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
        public static string dataDir
        {
            get
            {
                return gameDir + "\\Data";
            }
        }
        public static string fontDir
        {
            get
            {
                return gameDir + "\\Fonts";
            }
        }
        public static string baseGameDir
        {
            get
            {
                return gameDir + "\\GameData";
            }
        }
        public static string homeDir
        {
            get
            {
                return baseGameDir + "\\Home";
            }
        }
        public static string desktopDir
        {
            get
            {
                return homeDir + "\\Desktop";
            }
        }
        public static string docDir
        {
            get
            {
                return homeDir + "\\Documents";
            }
        }
        public static string downloadsDir
        {
            get
            {
                return homeDir + "\\Downloads";
            }
        }
        public static string musicDir
        {
            get
            {
                return homeDir + "\\Music";
            }
        }
        public static string picDir
        {
            get { return homeDir + "\\Pictures"; }
        }
        public static class User
        {
            public static int codePoints
            {
                get
                {
                    return 0;
                }
                set
                {

                }
            }
            public static void AddToCodePoints(int amountToAdd)
            {
                codePoints += amountToAdd;
                using (var fs = File.OpenWrite(dataDir + "\\userCodePoints.whoa"))
                {
                    Whoa.Whoa.SerialiseObject(fs, codePoints);
                }
            }
        }
    }
}
