using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Numerics;

namespace Physics.Core
{
    /// <summary>
    /// Immutable, beatch!
    /// </summary>
    class Value
    {
        public Value(BigRational value, Unit unit)
        {
            _Number = value;
            _Unit = unit;
        }
        
        public BigRational Number { get { return _Number; } }
        public Unit Unit { get { return _Unit; } }

        private BigRational _Number = new BigRational(0d);
        private Unit _Unit = Unit.Dimensionless;

        public override string ToString()
        {
            return Number.ToString() + " " + Unit.ToString();
        }
    }
}
