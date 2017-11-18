using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShiftOS.Main.Terminal.Commands
{
    public class TestStory : TerminalCommand
    {
        public override string Name { get; } = "teststory";
        public override string Summary { get; } = "Debug Command - Test the intro";
        public override string Usage { get; } = "n/a";
        public override bool Unlocked { get; set; } = false;

        public override void Run(params string[] parameters)
        {
            WriteLine("Incoming connection...");
            Thread.Sleep(2000);
            WriteLine("User set alias as \"DevX\".");
            Thread.Sleep(2000);
            WriteLine("User <DevX> has connected successfully!");
        }
    }
}
