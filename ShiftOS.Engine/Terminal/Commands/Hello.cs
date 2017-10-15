using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftOS.Engine.Terminal.Commands
{
    public class Hello : TerminalCommand
    {
        public override string GetName()
        {
            return "Hello";
        }

        public override string Run(params string[] parameters)
        {
            return "Oh, HELLO, " + String.Join(" ", parameters);
        }
    }
}
