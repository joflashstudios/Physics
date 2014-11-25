using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using Numerics;

namespace Physics.Core
{
    class AdditionMachine : Machine
    {
        public AdditionMachine()
        {
            Inputs.Add("A", new InputNode());
            Inputs.Add("B", new InputNode());
            Outputs.Add("C", new OutputNode());

            A = Inputs["A"];
            B = Inputs["B"];
            C = Outputs["C"];
        }

        public InputNode A;
        public InputNode B;
        public OutputNode C;

        public override void Compute()
        {
            BigRational c = A.Value.Number + B.Value.Number;
            C.Value = new Value(c, null);
        }
    }
}
