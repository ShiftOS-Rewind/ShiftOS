
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftOS.Main.Terminal.Commands
{
    public class Clear : TerminalCommand
    {
        public override string Name { get; } = "clear";
        public override string Summary { get; } = "Clears all text from the terminal.";
        public override string Usage { get; } = "clear";
        public override bool Unlocked { get; set; } = false;

        public override void Run(params string[] parameters)
        {
            Clear();
        }
    }
}
