using System;
using System.Collections.Generic;
using System.Drawing;
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
        public override bool Unlocked { get; set; } = true;
        
        public override void Run(params string[] args)
        {
            if (args.Length > 0)
            {
                if (args[0] != null && args[0] != "")
                {
                    bool solved = false;
                    foreach (var t in TerminalBackend.instances)
                    {
                        if (t.Name.ToLower() == args[0].ToLower())
                        {
                            solved = true;
                            WriteLine($"{t.Name}: {t.Summary} \n usage: {t.Usage}");
                            break;
                        }
                        if (t.Name.ToLower() == args[0].ToLower() && t.Unlocked == false) return;
                    }
                    if (!solved)
                    {
                        Write($"sbash: unexpected token: {args[0]}", Color.White);
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
