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
        public override string Usage { get; } = "help <command>";
        public override bool Unlocked { get; set; } = false;
        
        public override void Run(params string[] args)
        {
            if (args.Length > 0)
            {
                if (args[0] != null && args[0] != "")
                {
                    bool solved = false;
                    foreach (var t in TerminalBackend.instances)
                    {
                        if (t.Name == args[0])
                        {
                            solved = true;
                            WriteLine($"{t.Name}: {t.Summary} \nusage: {t.Usage}");
                            break;
                        }
                    }
                    if (!solved)
                    {
                        WriteLine("The command \"" + args[0] + "\" could not be found.");
                    }
                }
            }
            else
            {
                WriteLine("List of valid commands for ShiftOS. \n To get help for a specific command, type \"help <command>\".\r\n");
                foreach (var t in TerminalBackend.instances)
                {
                    WriteLine($"{t.Name}: {t.Summary}");
                }
            }
        }
    }
}
