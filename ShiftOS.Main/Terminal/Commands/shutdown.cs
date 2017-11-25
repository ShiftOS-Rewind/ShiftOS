using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShiftOS.Main.Terminal.Commands
{
    class shutdown:TerminalCommand
    {
        public override string Name { get; } = "shutdown";
        public override string Summary { get; } = "Shuts down and saves ShiftOS.";
        public override string Usage { get; } = "shutdown";
        public override bool Unlocked { get; set; } = true;

        public override void Run(params string[] parameters)
        {
            Application.Exit();
        }
    }
}
