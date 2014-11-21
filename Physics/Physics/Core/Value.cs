using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics.Core
{
    /// <summary>
    /// Immutable, beatch!
    /// </summary>
    class Value
    {
        public Value(double value, Unit unit)
        {
            _Value = value;
            _Unit = unit;
        }

        public double Value { get { return _Value; } }
        public Unit Unit { get { return _Unit; } }

        private double _Value = 0;
        private Unit _Unit;
    }
}
