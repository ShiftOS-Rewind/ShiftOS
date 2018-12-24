using ShiftOS.Main.ShiftOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShiftOS.Engine;
using static ShiftOS.Engine.CodepointUpgrade;
using static ShiftOS.Engine.SaveSystem;
using ShiftOS.Main;
using System.Windows.Forms;

namespace ShiftOS.Main.Terminal.Commands
{
    public class startx : TerminalCommand, ICodepointUpgrade
    {
        private bool hasGUI = false;
        private bool autostart = false;
        private Timer timer = new Timer();
        public override string Name { get; } = "startx";
        public override string Summary { get; } = "Starts the ShiftX driver.";
        public override string Usage { get; } = "startx";
        public override bool Unlocked { get; set; } = false;
        public int codePoints { get; set; } = 150;
        public override void Run(params string[] args)
        {
            if (args.Length > 0)
            {
                if (args[0] == "autostart")
                {
                    if (!autostart)
                    {
                        WriteLine("startx: Toggled autostart ON.");
                        return;
                    }
                    else
                    {
                        WriteLine("startx: Toggled autostart OFF.");
                        return;
                    }
                }
                WriteLine($"sbash: unexpected token: {args[0]}");
                return;
            }
            if (!hasGUI)
            {
                WriteLine("[startx] starting driver...");
                new System.Threading.ManualResetEvent(false).WaitOne(1500);

                new Desktop().Show();
                hasGUI = true;
                return;
            }
            if (hasGUI)
            {
                WriteLine("startx: the ShiftX driver has already been intialized.");
                return;
            } 
        }
    }
}
