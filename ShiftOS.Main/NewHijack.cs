using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;


namespace HijackScreen
{
    public partial class Form1 : Form
    {
#region Setting Up Stuff
        string shiftVersion = "0.1.0 Beta 1";
        bool newGame = true;
        int textCount = 0;
        string rText;
        int charCount;
        string textToTypeGen;
        int currentLetter;
        int slashCount;
        int convoCount = 0;
        object textGenInput;
        DirectoryInfo di;
        bool needToClose = false;
        string oldVersion;
        public bool upgraded = false;
        FileStream fs;
        StreamReader sr;
        int hackEffect;
        int percentChanged;
        DriveInfo cDrive;
        DialogResult dialogResult;
        //Holy jesus that was a lot of objects... Really Phil?
#endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            cDrive = new DriveInfo("C:\\");
            if (Directory.Exists("C:\\ShiftOS-Rewind\\"))
            {
                if (File.ReadAllText("C:\\ShiftOS-Rewind\\Shiftum64\\HDAccess.sft") != shiftVersion)
                {
                    dialogResult = MessageBox.Show("It appears that the version you are running is not compatible with this version of ShiftOS-Rewind\nWould you like to convert the save file?", "Oh dear!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (dialogResult == DialogResult.Yes)
                    {
                        ConvertSaveFile();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
            else
            {
                tmrHackFX.Start();
                BackgroundWorker1.RunWorkerAsync();
                conversationTimer.Start();
                textGen.Start();
            }
        }
        /// <summary>
        /// The text to type during the intro sequence.
        /// </summary>
        /// <param name="textToType"> The string it uses to type. </param>
        private void TextType(string textToType)
        {
            textToTypeGen = textToType;
            conversationTimer.Stop();
            charCount = textToTypeGen.Length;
            currentLetter = 0;
            slashCount = 1;
            textGen.Start();
        }

        /// <summary>
        /// Attempts to convert the save file into the correct version.
        /// </summary>
        private void ConvertSaveFile()
        {
            try
            {
                File.AppendAllText("C:\\ShiftOS-Rewind\\Shiftum64\\HDAccess.sft", shiftVersion);
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occured (big surprise). Here's the error: " + ex);
            }
        }

        private void textGen_Tick(object sender, EventArgs e)
        {
            switch (slashCount)
            {
                case 1:
                    if (currentLetter < textToTypeGen.Length)
                    {
                        textGenInput = rText + @"\";
                    }
                    break;
                case 2:
                    if (currentLetter < textToTypeGen.Length)
                    {
                        textGenInput = rText + @"|";
                    }
                    break;
                case 3:
                    if (currentLetter < textToTypeGen.Length)
                    {
                        textGenInput = rText + @"/";
                    }
                    break;
                case 4:
                    if (currentLetter < textToTypeGen.Length)
                    {
                        rText += textToTypeGen.ToCharArray(currentLetter, 1);
                        textGenInput = rText;
                        Stream str = ShiftOS.Main.Properties.Resources.typesound;
                        SoundPlayer sp = new SoundPlayer(str);
                        sp.Play();
                        sp.Stream.Position = 0;
                    }
                    break;

            }
            slashCount += 1;
            if (slashCount == 5)
            {
                slashCount = 1;
            }
            
            if (currentLetter == textToTypeGen.Length)
            {
                textToTypeGen = "";
                conversationTimer.Start();
                textGen.Stop();
            }
        }

        private void conversationTimer_Tick(object sender, EventArgs e)
        {
            switch (convoCount)
            {
                case 0:
                    if (needToClose == true) this.Close();
                    break;
                case 1:
                    textGenInput = lblhackwords;
                    TextType("Your computer is now being Hijacked");
                    conversationTimer.Interval = 1000;
                    break;
                case 2:
                    textGenInput = lblhackwords;
                    textGen.Interval = 10;
                    rText = "";
                    TextType("Congrats, " + Environment.UserName + "! You've been involunatarily selected to test out my new experimental operating system called ShiftOS!");
                    break;
            }
            convoCount = convoCount + 1;

        }
    }
}
