using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Mathmagician
{
    public class NaturalNumbers
    {
        protected int first;

        public NaturalNumbers()
        {
            first = 1;
        }

        public int GetFirst()
        {
            return first;
        }

        public virtual int GetNext(int x)
        {
            return x + 1;
        }

        public int[] GetSequence()
        {
            return GetSequence(10);
        }

        public int[] GetSequence(int length)
        {
            List<int> output = new List<int>();
            output.Add(GetFirst());
            while (output.Count() < length)
            {
                output.Add(GetNext(output.Last()));
            }
            return output.ToArray();
        }

        public string ToString(int[] array)
        {
            string output = String.Join(" ", array);
            return output;
        }
    }
}
