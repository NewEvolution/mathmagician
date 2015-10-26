using System;
using Mathmagician;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathmagicianTest
{
    [TestClass]
    public class NaturalNumbersTests
    {
        [TestMethod]
        public void EnsureICanCreateClassInstance()
        {
            NaturalNumbers nats = new NaturalNumbers();
            Assert.IsNotNull(nats);
        }
        /*
        [TestMethod]
        [ExpectedException(typeof(AccessViolationException))]
        public void NoOneCanAccessPrivateDatamember()
        {
            NaturalNumbers nats = new NaturalNumbers();
            //nats.first; won't compile
        }
        */
        [TestMethod]
        public void ShouldPrintFirstNumber()
        {
            NaturalNumbers nats = new NaturalNumbers();
            BigInteger expected = 1;
            BigInteger actual = nats.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldPrintNextNumber()
        {
            NaturalNumbers nats = new NaturalNumbers();
            BigInteger input = nats.GetFirst();
            BigInteger expected = 2;
            BigInteger actual = nats.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldPrintNextNumberInput3()
        {
            NaturalNumbers nats = new NaturalNumbers();
            BigInteger input = 3;
            BigInteger expected = 4;
            BigInteger actual = nats.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldPrintSequenceOfNumbers()
        {
            NaturalNumbers nats = new NaturalNumbers();
            BigInteger[] expected = new BigInteger[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            BigInteger[] actual = nats.GetSequence();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldPrintVariableSequenceOfNumbers()
        {
            NaturalNumbers nats = new NaturalNumbers();
            BigInteger input = 8;
            BigInteger[] expected = new BigInteger[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            BigInteger[] actual = nats.GetSequence(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldProvideSameSequences()
        {
            NaturalNumbers nats = new NaturalNumbers();
            BigInteger input = 10;
            BigInteger[] sequencenolength = nats.GetSequence();
            BigInteger[] sequencewithlength = nats.GetSequence(input);
            CollectionAssert.AreEqual(sequencenolength, sequencewithlength);
        }

        [TestMethod]
        public void PrintSequenceOfNumbers()
        {
            NaturalNumbers nats = new NaturalNumbers();
            BigInteger length = 7;
            string expected = "1 2 3 4 5 6 7";
            string actual = nats.ToString(nats.GetSequence(length));
            Assert.AreEqual(expected, actual);
        }
    }
}
