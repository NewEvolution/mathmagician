using System;
using Mathmagician;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathmagicianTest
{
    [TestClass]
    public class PrimeNumbersTests
    {
        [TestMethod]
        public void PrimeEnsureICanCreateClassInstance()
        {
            PrimeNumbers prime = new PrimeNumbers();
            Assert.IsNotNull(prime);
        }

        [TestMethod]
        public void PrimeShouldPrintFirstNumber()
        {
            PrimeNumbers prime = new PrimeNumbers();
            BigInteger expected = 2;
            BigInteger actual = prime.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimeShouldPrintNextNumber()
        {
            PrimeNumbers prime = new PrimeNumbers();
            BigInteger input = prime.GetFirst();
            BigInteger expected = 3;
            BigInteger actual = prime.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimeShouldPrintVariableSequenceOfNumbers()
        {
            PrimeNumbers prime = new PrimeNumbers();
            BigInteger input = 8;
            BigInteger[] expected = new BigInteger[] { 2, 3, 5, 7, 11, 13, 17, 19 };
            BigInteger[] actual = prime.GetSequence(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimePrintSequenceOfNumbers()
        {
            PrimeNumbers prime = new PrimeNumbers();
            BigInteger length = 7;
            string expected = "2 3 5 7 11 13 17";
            string actual = prime.ToString(prime.GetSequence(length));
            Assert.AreEqual(expected, actual);
        }
    }
}
