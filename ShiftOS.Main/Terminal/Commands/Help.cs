using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftOS.Main.Terminal.Commands
{
    public class Help : TerminalCommand
    {
        public override string Name { get; } = "help";
        public override string Summary { get; } = "Shows the list of valid commands.";
        public override string Usage { get; } = "n/a";
        public override bool Unlocked { get; set; } = false;
        
        public override void Run(params string[] args)
        {
            WriteLine("List of valid commands for ShiftOS.\r\n");
            foreach (var t in TerminalBackend.instances)
            {
                WriteLine($"{t.Name}: {t.Summary}");
            }
        }
    }
}
