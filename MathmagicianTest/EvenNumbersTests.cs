using System;
using Mathmagician;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathmagicianTest
{
    [TestClass]
    public class EvenNumbersTests
    {
        [TestMethod]
        public void EvenEnsureICanCreateClassInstance()
        {
            EvenNumbers even = new EvenNumbers();
            Assert.IsNotNull(even);
        }

        [TestMethod]
        public void EvenShouldPrintFirstNumber()
        {
            EvenNumbers even = new EvenNumbers();
            BigInteger expected = 2;
            BigInteger actual = even.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EvenShouldPrintNextNumber()
        {
            EvenNumbers even = new EvenNumbers();
            BigInteger input = even.GetFirst();
            BigInteger expected = 4;
            BigInteger actual = even.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EvenShouldPrintVariableSequenceOfNumbers()
        {
            EvenNumbers even = new EvenNumbers();
            BigInteger input = 8;
            BigInteger[] expected = new BigInteger[] { 2, 4, 6, 8, 10, 12, 14, 16 };
            BigInteger[] actual = even.GetSequence(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EvenPrintSequenceOfNumbers()
        {
            EvenNumbers even = new EvenNumbers();
            BigInteger length = 7;
            string expected = "2 4 6 8 10 12 14";
            string actual = even.ToString(even.GetSequence(length));
            Assert.AreEqual(expected, actual);
        }
    }
}
