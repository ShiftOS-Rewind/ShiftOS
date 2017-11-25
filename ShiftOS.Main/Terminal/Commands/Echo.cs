using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftOS.Main.Terminal.Commands
{
    public class Echo : TerminalCommand
    {
        public override string Name { get; } = "echo";
        public override string Summary { get; } = "Return a string.";
        public override string Usage { get; } = "echo <PHRASE>";
        public override bool Unlocked { get; set; } = true;

        public override void Run(params string[] args)
        {
           if (args.Length == 0)
            {
                WriteLine("echo: syntax error");
                return;
            }
            switch (args[0])
            {
                default:
                    WriteLine(string.Join(" ", args));
                    break;
                case "off":
                    Array.Find(TerminalBackend.trm.ToArray(), w => w.TerminalID == TermID).defaulttextResult = "";
                    break;
                case "on":
                    Array.Find(TerminalBackend.trm.ToArray(), w => w.TerminalID == TermID).defaulttextResult = "[user@shiftos ~]$ ";
                    break;
             }
        }
    }
}
