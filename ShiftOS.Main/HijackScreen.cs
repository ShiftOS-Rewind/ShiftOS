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
using System.Text.RegularExpressions;

namespace ShiftOS.Main
{
    public partial class HijackScreen : Form
    {
        public string actualshiftversion = "0.0.1.1";
        string rtext;
        string gtexttotype;
        int charcount;
        int currentletter;
        int slashcount;
        int conversationcount = 0;
        Label textgeninput;
        bool needtoclose = false;
        string oldversion;
        public bool upgraded = false;
        SoundPlayer player = new SoundPlayer();

        FileStream fs;
        int hackeffect;
        int percentcount;

        static DriveInfo[] cdrives = DriveInfo.GetDrives();
        DriveInfo cdrive = Array.Find(cdrives, c => "C:\\" == "C:\\");
        public HijackScreen()
        {
            InitializeComponent();
        }
        private void PlaySound(Stream path)
        {
            player.Stream = path;
            player.Play();
            player.Stream.Position = 0;
        }
        private void HijackScreen_Load(object sender, EventArgs e)
        {
            //extractdlls();
            Control.CheckForIllegalCrossThreadCalls = false;

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            if (Directory.Exists("C:\\ShiftOS-Rewind"))
            {
                if (File.ReadAllText("C:/ShiftOS-Rewind/Shiftum42/HDAccess.sft") == actualshiftversion)
                {
                    //ShiftOSDesktop.Show();
                    conversationtimer.Start();
                    needtoclose = true;
                }
                else
                {
                    if (MessageBox.Show("Your save file is not currently compatible with this version of ShiftOS. Would you like to upgrade your save file so you can continue to play the latest version of ShiftOS without losing your progress? If so click yes below. If you would like to start a new game and wipe all your progress please click no", "Warning: Update your save file", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        this.Hide();
                        //ShiftOS_Save_File_Converter.Show();
                        // ShiftOS_Save_File_Converter.BringToFront();
                    }
                    else
                    {
                        oldversion = System.IO.File.ReadAllText("C:/ShiftOS-Rewind/Shiftum42/HDAccess.sft");
                        upgraded = true;
                        System.IO.Directory.Delete("C:/ShiftOS-Rewind/", true);
                        backgroundWorker1.RunWorkerAsync();
                        conversationtimer.Start();
                        hackeffecttimer.Start();
                    }
                }
            }
            else
            {
                backgroundWorker1.RunWorkerAsync();
                conversationtimer.Start();
                hackeffecttimer.Start();
            }
        }

        private void TextType(string texttotype)
        {
            conversationtimer.Stop();
            charcount = texttotype.Length;
            gtexttotype = texttotype;
            currentletter = 0;
            slashcount = 1;
            textgen.Start();
        }


        private void textgen_Tick(object sender, EventArgs e)
        {
            switch (slashcount)
            {
                case 1:
                    if (currentletter < gtexttotype.Length)
                    {
                        textgeninput.Text = rtext + "\\";
                    }

                    break;
                case 2:
                    if (currentletter < gtexttotype.Length)
                    {
                        textgeninput.Text = rtext + "|";
                    }

                    break;
                case 3:
                    if (currentletter < gtexttotype.Length)
                    {
                        textgeninput.Text = rtext + "/";
                    }

                    break;
                case 4:
                    if (currentletter < gtexttotype.Length)
                    {
                        rtext = rtext + Regex.Split(gtexttotype, string.Empty)[currentletter];
                        currentletter = currentletter + 1;
                        textgeninput.Text = rtext;

                    }
                    break;
            }

            slashcount = slashcount + 1;

            if (slashcount == 5)
                slashcount = 1;
            if (currentletter == gtexttotype.Length)
            {
                gtexttotype = "";
                PlaySound(Properties.Resources.typesound);
                conversationtimer.Start();
                textgen.Stop();
            }


        }

        private void conversationtimer_Tick(object sender, EventArgs e)
        {
            switch (conversationcount)
            {
                case 0:
                    if (needtoclose == true)
                        this.Close();
                    break;
                case 1:

                    textgeninput = lblHijack;
                    TextType("Your computer is now being Hijacked ");
                    conversationtimer.Interval = 1000;

                    break;
                case 3:
                    textgeninput = lblhackwords;
                    textgen.Interval = 10;
                    rtext = "";
                    TextType("Congratulations, you have been involuntarily selected to be an Alpha Tester for ShiftOS." + Environment.NewLine + Environment.NewLine);
                    break;
                case 4:
                    TextType("At this current point in time I do not wish to reveal my identity or future intentions. You can call me DevX" + Environment.NewLine + Environment.NewLine);
                    break;
                case 5:
                    TextType("I just need to use you and your computer as an external test bed to evolve my experimental operating system." + Environment.NewLine + Environment.NewLine);
                    break;
                case 6:
                    TextType("Right now ShiftOS is practically non-existent but I’ll work on coding it remotely as you use it." + Environment.NewLine + Environment.NewLine);
                    break;
                case 7:
                    TextType("Your hard drive will now be formatted in preparation for the installation of ShiftOS" + Environment.NewLine + Environment.NewLine);
                    break;
                case 8:
                    TextType("Starting Format.");
                    conversationtimer.Interval = 500;
                    break;
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                    TextType(".");
                    break;
                case 19:
                    rtext = "";
                    break;
                case 20:
                    TextType("Scanning Drive C:/");
                    break;
                case 21:

                    TextType(Environment.NewLine + Environment.NewLine + "Drive Label: " + cdrive.VolumeLabel);
                    break;
                case 22:
                    TextType(Environment.NewLine + "Total Drive Size: " + String.Format((cdrive.TotalSize / 1024 / 1024 / 1024).ToString(), "0.00") + " GigaBytes ");
                    break;
                case 23:
                    TextType(Environment.NewLine + "Old File System: " + cdrive.DriveFormat + " ");
                    break;
                case 24:
                    TextType(Environment.NewLine + "New File System: ShiftFS ");
                    break;
                case 25:
                    TextType(Environment.NewLine + Environment.NewLine + "Formatting C:/ - ");
                    conversationtimer.Interval = 100;
                    break;
                case 26: // TODO: to 126
                    textgeninput.Text = rtext + percentcount + "%";
                    if (percentcount < 101)
                    {
                        percentcount = percentcount + 1;
                        PlaySound(Main.Properties.Resources.writesound);
                    }
                    break;
                case 127:
                    rtext = rtext + "100%";
                    conversationtimer.Interval = 1000; 
                    break;
                case 128:
                    TextType(Environment.NewLine + "Format Complete");
                    break;
                case 129:
                    rtext = "";
                    percentcount = 0;
                    TextType("Installing ShiftOS Beta 0.0.1 - ");
                    conversationtimer.Interval = 200;
                    break;
                case 130: // TODO: to 230
                    textgeninput.Text = rtext + percentcount + "%" + Environment.NewLine + Environment.NewLine;
                    if (percentcount < 101)
                    {
                        percentcount = percentcount + 1;
                        PlaySound(Properties.Resources.writesound);
                    }
                    switch (percentcount)
                    {
                        case 1:
                        case 2:
                            textgeninput.Text = textgeninput.Text + "C:/Home";
                            if ((!System.IO.Directory.Exists("C:/ShiftOS-Rewind/Home")))
                                System.IO.Directory.CreateDirectory("C:/ShiftOS-Rewind/Home");
                            break;
                        case 3:
                        case 4:
                            textgeninput.Text = textgeninput.Text + "C:/Home/Documents";
                            if ((!System.IO.Directory.Exists("C:/ShiftOS-Rewind/Home/Documents")))
                                System.IO.Directory.CreateDirectory("C:/ShiftOS-Rewind/Home/Documents");
                            break;
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                            textgeninput.Text = textgeninput.Text + "C:/Home/Documents/ShiftOSInfo.txt";
                            fs = File.Create("C:/ShiftOS-Rewind/Home/Documents/ShiftOSInfo.txt");
                            fs.Close();
                            break;
                        case 10:
                        case 11:
                        case 12:
                            textgeninput.Text = textgeninput.Text + "C:/Home/Music";
                            if ((!System.IO.Directory.Exists("C:/ShiftOS-Rewind/Home/Music")))
                                System.IO.Directory.CreateDirectory("C:/ShiftOS-Rewind/Home/Music");
                            break;
                        case 13:
                        case 14:
                        case 15:
                            textgeninput.Text = textgeninput.Text + "C:/Home/Pictures";
                            if ((!System.IO.Directory.Exists("C:/ShiftOS-Rewind/Home/Pictures")))
                                System.IO.Directory.CreateDirectory("C:/ShiftOS-Rewind/Home/Pictures");
                            break;
                        case 16:
                        case 17:
                        case 18:
                            textgeninput.Text = textgeninput.Text + "C:/Shiftum42";
                            if ((!System.IO.Directory.Exists("C:/ShiftOS-Rewind/Shiftum42")))
                                System.IO.Directory.CreateDirectory("C:/ShiftOS-Rewind/Shiftum42");
                            break;
                        case 19:
                        case 20:
                            textgeninput.Text = textgeninput.Text + "C:/Shiftum42/Drivers";
                            if ((!System.IO.Directory.Exists("C:/ShiftOS-Rewind/Shiftum42/Drivers")))
                                System.IO.Directory.CreateDirectory("C:/ShiftOS-Rewind/Shiftum42/Drivers");
                            break;
                        case 21:
                        case 22:
                        case 23:
                        case 24:
                        case 25:
                        case 26:
                        case 27:
                            textgeninput.Text = textgeninput.Text + "C:/Shiftum42/Drivers/HDD.dri";
                            fs = File.Create("C:/ShiftOS-Rewind/Shiftum42/Drivers/HDD.dri");
                            fs.Close();
                            break;
                        case 28:
                        case 29:
                        case 30:
                        case 31:
                        case 32:
                        case 33:
                        case 34:
                        case 35:
                            textgeninput.Text = textgeninput.Text + "C:/Shiftum42/Drivers/Keyboard.dri";
                            fs = File.Create("C:/ShiftOS-Rewind/Shiftum42/Drivers/Keyboard.dri");
                            fs.Close();
                            break;
                        case 36:
                        case 37:
                        case 38:
                        case 39:
                        case 40:
                        case 41:
                        case 42:
                        case 43:
                        case 44:
                            textgeninput.Text = textgeninput.Text + "C:/Shiftum42/Drivers/Monitor.dri";
                            fs = File.Create("C:/ShiftOS-Rewind/Shiftum42/Drivers/Monitor.dri");
                            fs.Close();
                            break;
                        case 45:
                        case 46:
                        case 47:
                        case 48:
                        case 49:
                        case 50:
                        case 51:
                        case 52:
                            textgeninput.Text = textgeninput.Text + "C:/Shiftum42/Drivers/Mouse.dri";
                            fs = File.Create("C:/ShiftOS-Rewind/Shiftum42/Drivers/Mouse.dri");
                            fs.Close();
                            break;
                        case 53:
                        case 54:
                        case 55:
                        case 56:
                        case 57:
                        case 58:
                        case 59:
                        case 60:
                            textgeninput.Text = textgeninput.Text + "C:/Shiftum42/Drivers/Printer.dri";
                            fs = File.Create("C:/ShiftOS-Rewind/Shiftum42/Drivers/Printer.dri");
                            fs.Close();
                            break;
                        case 61:
                        case 62:
                        case 63:
                        case 64:
                        case 65:
                        case 66:
                        case 67:
                        case 68:
                            textgeninput.Text = textgeninput.Text + "C:/Shiftum42/Languages/";
                            if ((!System.IO.Directory.Exists("C:/ShiftOS-Rewind/Shiftum42/Languages/")))
                                System.IO.Directory.CreateDirectory("C:/ShiftOS-Rewind/Shiftum42/Languages/");
                            break;
                        case 69:
                        case 70:
                        case 71:
                        case 72:
                        case 73:
                        case 74:
                        case 75:
                        case 76:
                            textgeninput.Text = textgeninput.Text + "C:/Shiftum42/Languages/English.lang";
                            fs = File.Create("C:/ShiftOS-Rewind/Shiftum42/Languages/English.lang");
                            fs.Close();
                            break;
                        case 77:
                        case 78:
                        case 79:
                        case 80:
                        case 81:
                        case 82:
                        case 83:
                        case 84:
                            textgeninput.Text = textgeninput.Text + "C:/Shiftum42/HDAccess.sft";
                            fs = File.Create("C:/ShiftOS-Rewind/Shiftum42/HDAccess.sft");
                            fs.Close();
                            System.IO.StreamWriter objWriter = new System.IO.StreamWriter("C:/ShiftOS-Rewind/Shiftum42/HDAccess.sft", false);
                            objWriter.Write(actualshiftversion);
                            objWriter.Close();
                            break;
                        case 85:
                        case 86:
                        case 87:
                        case 88:
                        case 89:
                            textgeninput.Text = textgeninput.Text + "C:/Shiftum42/ShiftGUI.sft";
                            fs = File.Create("C:/ShiftOS-Rewind/Shiftum42/ShiftGUI.sft");
                            fs.Close();
                            break;
                        case 90:
                        case 91:
                        case 92:
                        case 93:
                            textgeninput.Text = textgeninput.Text + "C:/Shiftum42/SKernal.sft";
                            fs = File.Create("C:/ShiftOS-Rewind/Shiftum42/SKernal.sft");
                            fs.Close();
                            break;
                        case 94:
                        case 95:
                        case 96:
                        case 97:
                            textgeninput.Text = textgeninput.Text + "C:/Shiftum42/SRead.sft";
                            fs = File.Create("C:/ShiftOS-Rewind/Shiftum42/SRead.sft");
                            fs.Close();
                            break;
                        case 98:
                        case 99:
                        case 100:
                        case 101:
                            textgeninput.Text = textgeninput.Text + "C:/Shiftum42/SWrite.sft";
                            fs = File.Create("C:/ShiftOS-Rewind/Shiftum42/SWrite.sft");
                            fs.Close();
                            break;
                    }

                    break;

                case 231:
                    textgeninput.Text = rtext + "100%" + Environment.NewLine + Environment.NewLine + "C:/Shiftum42/SWrite.sft";
                    conversationtimer.Interval = 1000;
                    PlaySound(Properties.Resources.writesound);
                    break;
                case 232:
                    textgeninput.Text = rtext + "100%" + Environment.NewLine + Environment.NewLine + "ShiftOS Installation Complete!";
                    PlaySound(Properties.Resources.typesound);
                    if ((!System.IO.Directory.Exists("C:/ShiftOS-Rewind/SoftwareData/")))
                        System.IO.Directory.CreateDirectory("C:/ShiftOS-Rewind/SoftwareData/");
                    if ((!System.IO.Directory.Exists("C:/ShiftOS-Rewind/SoftwareData/KnowledgeInput")))
                        System.IO.Directory.CreateDirectory("C:/ShiftOS-Rewind/SoftwareData/KnowledgeInput");
                    fs = File.Create("C:/ShiftOS-Rewind/SoftwareData/KnowledgeInput/Animals.lst");
                    fs.Close();
                    fs = File.Create("C:/ShiftOS-Rewind/SoftwareData/KnowledgeInput/Fruits.lst");
                    fs.Close();
                    fs = File.Create("C:/ShiftOS-Rewind/SoftwareData/KnowledgeInput/Countries.lst");
                    fs.Close();
                    break;
                case 234:
                    //ShiftOSDesktop.newgame = true;
                    //ShiftOSDesktop.Show();
                    //Terminal.Show();
                    //Terminal.tmrfirstrun.Start();
                    //this.Close();

                    break;
            }
            conversationcount = conversationcount + 1;
        }

        private void hackeffecttimer_Tick(object sender, EventArgs e)
        {
            if (hackeffect < 101)
            {
                switch (hackeffect)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 9:
                    case 11:
                    case 13:
                    case 15:
                    case 17:
                    case 19:
                    case 21:
                    case 23:
                    case 25:
                    case 27:
                    case 29:
                    case 31:
                    case 33:
                    case 35:
                    case 37:
                    case 39:
                    case 41:
                    case 43:
                    case 45:
                    case 47:
                    case 49:
                    case 51:
                    case 53:
                    case 55:
                    case 57:
                    case 59:
                    case 61:
                    case 63:
                    case 65:
                    case 67:
                    case 69:
                    case 71:
                    case 73:
                    case 75:
                    case 77:
                    case 79:
                    case 81:
                    case 83:
                    case 85:
                    case 87:
                    case 89:
                    case 91:
                    case 93:
                    case 95:
                        this.BackColor = Color.Black;
                        PlaySound(Properties.Resources.writesound);
                        break;
                    case 2:
                    case 4:
                    case 6:
                    case 8:
                    case 10:
                    case 12:
                    case 14:
                    case 16:
                    case 18:
                    case 20:
                    case 22:
                    case 24:
                    case 26:
                    case 28:
                        this.BackColor = Color.White;
                        PlaySound(Properties.Resources.typesound);
                        break;
                    case 30:
                    case 32:
                    case 34:
                    case 36:
                    case 38:
                    case 40:
                    case 42:
                    case 44:
                    case 46:
                    case 48:
                    case 50:
                        this.BackColor = Color.Gainsboro;
                        PlaySound(Properties.Resources.typesound);
                        break;
                    case 52:
                    case 54:
                    case 56:
                    case 58:
                    case 60:
                    case 62:
                    case 64:
                    case 66:
                    case 68:
                    case 70:
                    case 72:
                    case 74:
                    case 76:
                        this.BackColor = Color.Silver;
                        PlaySound(Properties.Resources.typesound);
                        break;
                    case 78:
                    case 80:
                    case 82:
                    case 84:
                    case 86:
                    case 88:
                    case 90:
                    case 92:
                    case 94:
                        this.BackColor = Color.DimGray;
                        PlaySound(Properties.Resources.typesound);
                        break;
                    case 96:
                        lblHijack.BackColor = Color.LightGray;
                        break;
                    case 97:
                        lblHijack.BackColor = Color.DarkGray;
                        break;
                    case 98:
                        lblHijack.BackColor = Color.DimGray;
                        break;
                    case 99:
                        lblHijack.BackColor = Color.Black;
                        lblHijack.ForeColor = Color.DimGray;
                        break;
                    case 100:
                        lblHijack.Hide();
                        break;
                }
            }
            else
            {
                hackeffecttimer.Stop();
            }
            hackeffect = hackeffect + 1;
        }

    }
}


