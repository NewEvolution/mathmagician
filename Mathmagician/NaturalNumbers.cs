using System;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Mathmagician
{
    public class NaturalNumbers
    {
        protected BigInteger first;
        protected BigInteger increment;

        public NaturalNumbers()
        {
            first = 1;
            increment = 1;
        }

        public BigInteger GetFirst()
        {
            return first;
        }
        
        public virtual BigInteger GetNext(BigInteger x)
        {
            return x + increment;
        }

        public BigInteger[] GetSequence()
        {
            return GetSequence(10);
        }

        public BigInteger[] GetSequence(BigInteger length)
        {
            List<BigInteger> output = new List<BigInteger>();
            output.Add(GetFirst());
            while (output.Count() < length)
            {
                output.Add(GetNext(output.Last()));
            }
            return output.ToArray();
        }

        public string ToString(BigInteger[] array)
        {
            string output = String.Join(" ", array);
            return output;
        }
    }
}
