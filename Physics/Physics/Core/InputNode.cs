using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics.Core
{
    class InputNode
    {
        public OutputNode Source { get; set; }
        public bool Literal { get; set; }
        private Value _LiteralValue { get; set; }

        public Value Value
        {
            get
            {
                if (Literal)
                    return _LiteralValue;
                else
                    return Source.Value;
            }
            set {
                if (Literal)
                    _LiteralValue = value;
                else
                    throw new InvalidOperationException("Cannot manually set value of a non-literal input");
            }
        }

        public 
    }
}
