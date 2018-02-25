using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftOS.Main.Terminal.Commands
{
    public class upgrade : TerminalCommand
    {
        public override string Name { get; } = "upgrade";
        public override string Summary { get; } = "Allows you to install upgrades for ShiftOS.";
        public override string Usage { get; } = "upgrade <install/list/info> <upgrade>";
        public override bool Unlocked { get; set; } = true;

        public override void Run(params string[] args)
        {
            if (args.Length == 0)
            {
                WriteLine("sbash: ");
            }
        }
    }
}
