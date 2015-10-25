using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class PrimeNumbers : NaturalNumbers
    {
        public PrimeNumbers()
        {
            first = 2;
            increment = 1;
        }

        public override int GetNext(int x)
        {
            return base.GetNext(x);
        }
    }
}
