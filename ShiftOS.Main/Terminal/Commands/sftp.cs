using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftOS.Main.Terminal.Commands
{
    class sftp:TerminalCommand
    {
        public override string Name { get; } = "sftp";
        public override string Summary { get; } = "The Shift File Transfer Protocol (SFTP) Client.";
        public override string Usage { get; } = "sftp <host> <username> <password> <port (Default - 22)>";
        public override bool Unlocked { get; set; } = false;

        public override void Run(params string[] args)
        {
            WriteLine(args[0]);
        }
    }
}
