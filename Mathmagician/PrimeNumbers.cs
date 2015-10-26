using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
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

        public bool isPrime(BigInteger a)
        {
            if (a == 1)
            {
                return false;
            }
            if (a == 2 || a == 3)
            {
                return true;
            }
            if (!((a & 1) == 1))
            {
                return false;
            }
            if (!((a + 1) % 6 == 0 || (a - 1) % 6 == 0))
            {
                return false;
            }
            BigInteger q = (BigInteger)Math.Sqrt((double)a) +1;
            for (BigInteger v = 3; v < q; v += 2)
            {
                if (a % v == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public override BigInteger GetNext(BigInteger x)
        {
            BigInteger number = base.GetNext(x);
            while (!isPrime(number))
            {
                number = base.GetNext(number);
            }
            return number;
        }
    }
}
