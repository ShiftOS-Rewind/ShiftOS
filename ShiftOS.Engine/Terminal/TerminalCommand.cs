using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftOS.Engine.Terminal
{
    public abstract class TerminalCommand
    {
        public abstract string GetName();

        public abstract string Run(params string[] parameters);
    }
}
