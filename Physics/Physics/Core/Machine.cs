using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics.Core
{
    public abstract class Machine
    {
        private Dictionary<string, InputNode> Inputs { get; set; }
        private Dictionary<string, OutputNode> Outputs { get; set; }
    }
}
