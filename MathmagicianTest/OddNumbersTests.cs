using System;
using Mathmagician;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathmagicianTest
{
    [TestClass]
    public class OddNumbersTests
    {
        [TestMethod]
        public void OddEnsureICanCreateClassInstance()
        {
            OddNumbers odd = new OddNumbers();
            Assert.IsNotNull(odd);
        }

        [TestMethod]
        public void OddShouldPrintFirstNumber()
        {
            OddNumbers odd = new OddNumbers();
            BigInteger expected = 1;
            BigInteger actual = odd.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OddShouldPrintNextNumber()
        {
            OddNumbers odd = new OddNumbers();
            BigInteger input = odd.GetFirst();
            BigInteger expected = 3;
            BigInteger actual = odd.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OddShouldPrintVariableSequenceOfNumbers()
        {
            OddNumbers odd = new OddNumbers();
            BigInteger input = 8;
            BigInteger[] expected = new BigInteger[] { 1, 3, 5, 7, 9, 11, 13, 15 };
            BigInteger[] actual = odd.GetSequence(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OddPrintSequenceOfNumbers()
        {
            OddNumbers odd = new OddNumbers();
            BigInteger length = 7;
            string expected = "1 3 5 7 9 11 13";
            string actual = odd.ToString(odd.GetSequence(length));
            Assert.AreEqual(expected, actual);
        }
    }
}
