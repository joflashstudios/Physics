using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics.Core
{
    internal class InputNode
    {
        public OutputNode Source
        {
            get { return _Source; }
            set
            {
                if (_Source != value)
                {
                    if (_Source != null)
                        _Source.OnValueChanged -= SourceNodeChanged;
                    _Source = value;
                    _Source.OnValueChanged += SourceNodeChanged;
                }
            }
        }
        private OutputNode _Source;

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
            set
            {
                if (Literal)
                {
                    if (_LiteralValue != value)
                    {
                        _LiteralValue = value;
                        if (OnValueChanged != null)
                            OnValueChanged(this, null);
                    }
                }
                else
                {
                    throw new InvalidOperationException("Cannot manually set value of a non-literal input");
                }
            }
        }

        void SourceNodeChanged(object sender, EventArgs e)
        {
            if (OnValueChanged != null)
                OnValueChanged(this, null);
        }

        /// <summary>
        /// Fires when the literal value or machine-produced output mapped to this input changes
        /// </summary>
        public event EventHandler OnValueChanged;
    }
}
