﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShiftOS.Main.Terminal
{
    public static class TerminalBackend
    {
        // The line below gets all the terminal commands in... well... the entire ShiftOS.Engine
        public static IEnumerable<TerminalCommand> instances = Assembly.GetExecutingAssembly().GetTypes()
                        .Where(t => t.IsSubclassOf(typeof(TerminalCommand)) && t.GetConstructor(Type.EmptyTypes) != null)
                        .Select(t => Activator.CreateInstance(t) as TerminalCommand);

        public static List<ShiftOS.Apps.Terminal> trm = new List<ShiftOS.Apps.Terminal>();
        public static int trmTopID = 0;
        public static Stack<string> commandBuffer = new Stack<string>();
        /// <summary>
        /// Runs a terminal command.
        /// </summary>
        /// <param name="command"></param>
        /// <param name="rtb"><summary>The rich text box that the text will be written to.</summary></param>
        public static void RunCommand(string command, int TermID)
        {
            string name;
            try { name = command.Split(' ')[0]; } catch { name = command; }

            var theParams = new string[command.Split(' ').Length - 1];
            Array.Copy(command.Split(' '), 1, theParams, 0, command.Split(' ').Length - 1);

            bool complete = false;
            foreach (TerminalCommand instance in instances)
            {
                if (instance.Name.ToLower() == name.ToLower())
                {
                    instance.TermID = TermID;
                    // Add a new line!
                    Array.Find(trm.ToArray(), w => w.TerminalID == TermID).termmain.AppendText("\n");
                    instance.Run(theParams);
                    complete = true;
                    commandBuffer.Push(command);
                    return;
                }
                if (instance.Name.ToLower() == name.ToLower() && instance.Unlocked == false)
                {
                    Array.Find(trm.ToArray(), w => w.TerminalID == TermID).termmain.AppendText($"\n sbash: invalid command: {command.Split(' ').First()}");
                    return;
                }
            }
            if (command.Length == 0) return;
            if (!complete)
            {
                  Array.Find(trm.ToArray(), w => w.TerminalID == TermID).termmain.AppendText($"\n sbash: invalid command: {command.Split(' ').First()}");
                  return;
            }
        }
    }
}
