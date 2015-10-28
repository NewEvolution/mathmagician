using System;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Mathmagician
{
    public class FibonacciNumbers : NaturalNumbers
    {
        public FibonacciNumbers()
        {
            increment = 0;
        }

        public override BigInteger GetNext(BigInteger previous_number)
        {
            BigInteger next_number = base.GetNext(previous_number);
            increment = previous_number;
            return next_number;
        }
    }
}
