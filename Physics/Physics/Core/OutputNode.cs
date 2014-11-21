using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics.Core
{
    class OutputNode
    {
        public Value Value
        {
            get { return _Value; }
            set
            {
                if (value != _Value)
                {
                    _Value = value;
                    if (OnValueChanged != null)
                        OnValueChanged(this, null);

                }
            }
        }
        private Value _Value;
        public event EventHandler OnValueChanged;
    }
}
