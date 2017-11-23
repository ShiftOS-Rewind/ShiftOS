using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShiftOS.Main;

namespace ShiftOS.Main.Terminal.Commands
{
    public class tcpip : TerminalCommand
    {
        public override string Name { get; } = "tcpip";
        public override string Summary { get; } = "Shows a list of incoming or outgoing connections.";
        public override string Usage { get; } = "tcpip <incoming/outgoing>";
        public override bool Unlocked { get; set; } = false;

        public override void Run(params string[] args)
        {
            var r = new Random();
            string gen = Generate(13);
            if (args.Length == 0)
            {
                WriteLine("tcpip: syntax error");
                return;
            }
            switch (args[0].ToLower())
            {
                default:
                    WriteLine("tcpip: syntax error");
                    break;
                case "incoming":
                    WriteLine("Incoming connections from localhost:");
                    WriteLine($"IP ADDRESS v4                                COMPUTER NAME");
                    WriteLine($"{r.Next(0, 255)}.{r.Next(0, 255)}.{r.Next(0, 255)}.{r.Next(255)}                               {gen}");
                    break;
                case "outgoing":
                    WriteLine("Outgoing connections from localhost:");
                    WriteLine($"IP ADDRESS v4                                COMPUTER NAME");
                    WriteLine($"{r.Next(0, 255)}.{r.Next(0, 255)}.{r.Next(0, 255)}.{r.Next(255)}                               {gen}");
                    WriteLine($"[1] outgoing connection(s) is using {r.Next(0, 16)} MiBs of bandwith.");
                    break;
            }
        }
        public string Generate(int amountToGenerate)
        {
            var r = new Random();

            string symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghjklmnopqrstuvwxyz0123456789!@#$%^&*()";
            char[] array = new char[amountToGenerate];
            for (int i = 0; i < amountToGenerate; i++)
            {
                array[i] = symbols[r.Next(0, symbols.Length)];
            }
            return new string(array);
        }
    }
}
