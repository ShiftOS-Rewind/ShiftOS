using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ShiftOS.Engine.SaveSystem;
using System.IO;

namespace ShiftOS.Main.Terminal.Commands
{
   public class codepoints : TerminalCommand
    {
        public override string Name { get; } = "codepoints";
        public override string Summary { get; } = "Shows your current amount of codepoints.";
        public override string Usage { get; } = "codepoints";
        public override bool Unlocked { get; set; } = true;

        public override void Run(params string[] parameters)
        {
            if (parameters.Length > 0)
            {
                WriteLine($"sbash: unexpected token: {parameters.First()}");
            }

            using (var fs = File.OpenRead(dataDir + "\\userCodePoints.whoa"))
            {
                int codepoints = Whoa.Whoa.DeserialiseObject<int>(fs, Whoa.SerialisationOptions.None);
                WriteLine($"You currently have {codepoints} codepoints.");
            }
        }
    }
}

