using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics.Core
{
    public abstract class Machine
    {
        internal Dictionary<string, InputNode> Inputs { get { return _Inputs; } }
        internal Dictionary<string, OutputNode> Outputs { get { return _Outputs; } }

        private Dictionary<string, InputNode> _Inputs = new Dictionary<string, InputNode>();
        private Dictionary<string, OutputNode> _Outputs = new Dictionary<string, OutputNode>();

        public abstract void Compute();
    }
}
