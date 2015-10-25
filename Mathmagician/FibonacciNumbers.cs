using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class FibonacciNumbers : NaturalNumbers
    {
        public FibonacciNumbers()
        {
            first = 1;
            increment = 0;
        }

        public override int GetNext(int previous_number)
        {
            int next_number = base.GetNext(previous_number);
            increment = previous_number;
            return next_number;
        }
    }
}
