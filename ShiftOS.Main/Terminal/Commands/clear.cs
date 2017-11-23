
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftOS.Main.Terminal.Commands
{
    public class clear : TerminalCommand
    {
        public override string Name { get; } = "clear";
        public override string Summary { get; } = "Clears all text from the terminal.";
        public override string Usage { get; } = "clear";
        public override bool Unlocked { get; set; } = false;
        public static List<ShiftOS.Apps.Terminal> trm = TerminalBackend.trm;
        public override void Run(params string[] parameters)
        {
            ShiftOS.Apps.Terminal trm = Array.Find(TerminalBackend.trm.ToArray(), w => w.TerminalID == TermID);

            trm.Clear();
        }
    }
}
