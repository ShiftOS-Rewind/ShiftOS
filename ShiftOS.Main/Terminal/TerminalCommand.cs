using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShiftOS.Main.Terminal
{
    public class TerminalCommand
    {
        public int TermID { get; set; }

        public virtual string Name { get; }
        public virtual string Summary { get; }
        public virtual string Usage { get; }
        public virtual bool Unlocked { get; set; }

        public virtual void Run(params string[] parameters) { }

        /// <summary>
        /// Writes a blank line in the terminal.
        /// </summary>
        public virtual void WriteLine()
        {
            WriteLine("");
        }

        /// <summary>
        /// Writes specified text in the terminal and starts a new line.
        /// </summary>
        /// <param name="value"><summary>The text to write before the new line is made.</summary></param>
        public virtual void WriteLine(string value)
        {
            Array.Find(TerminalBackend.trm.ToArray(), w => w.TerminalID == TermID).termmain.AppendText($"{value} \n");
        }

        /// <summary>
        /// Writes specified text in the terminal in the specified color and starts a new line.
        /// </summary>
        /// <param name="value"><summary>The text to write before the new line is made.</summary></param>
        /// <param name="textClr"><summary>The color the text is written in.</summary></param>
        public virtual void WriteLine(string value, Color textClr)
        {
            ShiftOS.Apps.Terminal trm = Array.Find(TerminalBackend.trm.ToArray(), w => w.TerminalID == TermID);

            int startPoint = trm.termmain.Text.Length;
            trm.termmain.AppendText($"{value} \n");
            trm.termmain.Select(startPoint, $"{value} \n".Length);
            trm.termmain.SelectionColor = textClr;
        }

        /// <summary>
        /// Writes specified text in the terminal.
        /// </summary>
        /// <param name="value"><summary>The text to write.</summary></param>
        /// <param name="textClr"><summary>The color the text is written in.</summary></param>
        public virtual void Write(string value, Color textClr)
        {

            ShiftOS.Apps.Terminal trm = Array.Find(TerminalBackend.trm.ToArray(), w => w.TerminalID == TermID);

            int startPoint = trm.termmain.Text.Length;
            trm.termmain.AppendText($"{value}");
            trm.termmain.Select(startPoint, $"{value}".Length);
            trm.termmain.SelectionColor = textClr;
        }

        /// <summary>
        /// Writes specified text in the terminal.
        /// </summary>
        /// <param name="value"><summary>The text to say before requesting text. </summary></param>
        //public virtual Task<string> Input(string value = "")
        //{
        //    ShiftOS.Apps.Terminal trm = Array.Find(TerminalBackend.trm.ToArray(), w => w.TerminalID == TermID);
        //    trm.Input(value);

        //    Task<string> Input = new Task<string>(() =>
        //    {              
        //        while (true)
        //            if (trm.InputReturnText != "") break;

        //        // The terminal has finally decided!

        //        return trm.InputReturnText;
        //    });
        //    Input.Start();
        //    return Input;
        //}
    }
}
