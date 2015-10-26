using System;
using Mathmagician;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathmagicianTest
{
    [TestClass]
    public class FibonacciNumbersTests
    {
        [TestMethod]
        public void FibonacciEnsureICanCreateClassInstance()
        {
            FibonacciNumbers fibonacci = new FibonacciNumbers();
            Assert.IsNotNull(fibonacci);
        }

        [TestMethod]
        public void FibonacciShouldPrintFirstNumber()
        {
            FibonacciNumbers fibonacci = new FibonacciNumbers();
            BigInteger expected = 1;
            BigInteger actual = fibonacci.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibonacciShouldPrintNextNumber()
        {
            FibonacciNumbers fibonacci = new FibonacciNumbers();
            BigInteger input = fibonacci.GetFirst();
            BigInteger expected = 1;
            BigInteger actual = fibonacci.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibonacciShouldPrintVariableSequenceOfNumbers()
        {
            FibonacciNumbers fibonacci = new FibonacciNumbers();
            BigInteger input = 8;
            BigInteger[] expected = new BigInteger[] { 1, 1, 2, 3, 5, 8, 13, 21 };
            BigInteger[] actual = fibonacci.GetSequence(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibonacciPrintSequenceOfNumbers()
        {
            FibonacciNumbers fibonacci = new FibonacciNumbers();
            BigInteger length = 7;
            string expected = "1 1 2 3 5 8 13";
            string actual = fibonacci.ToString(fibonacci.GetSequence(length));
            Assert.AreEqual(expected, actual);
        }
    }
}
