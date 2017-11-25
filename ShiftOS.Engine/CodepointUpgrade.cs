using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShiftOS.Engine;

namespace ShiftOS.Engine
{
    public class CodepointUpgrade
    {
        public interface ICodepointUpgrade
        {
            int codePoints { get; set; }
        }
    }
}
