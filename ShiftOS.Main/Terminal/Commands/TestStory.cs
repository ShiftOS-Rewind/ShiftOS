using System;
using System.Collections.Generic;
using System.Drawing;
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
        public override string Usage { get; } = "teststory";
        public override bool Unlocked { get; set; } = false;

        public override void Run(params string[] parameters)
        {
            var r = new Random();
            WriteLine($"Incoming connection from {r.Next(0, 256)}.{r.Next(0, 256)}.{r.Next(0, 256)}.{r.Next(0, 256)}...");
            WriteLine(); //The various Task.Delay functions are to make the Thread.Sleep function work.
            Thread.Sleep(r.Next(2000, 4500));
            WriteLine("User set alias as \"DevX\".");
            Task.Delay(1);
            Thread.Sleep(4000);
            WriteLine("User <DevX> has connected successfully!");
            Task.Delay(1);
            Thread.Sleep(3400);
            StoryWriteLine("Well, it seems ShiftOS has installed. Congrats.... err... whatever your name is.");
        }
        private void StoryWriteLine(string value)
        {
            WriteLine($"[devx@master ~]$ {value}");
        }
    }
}
