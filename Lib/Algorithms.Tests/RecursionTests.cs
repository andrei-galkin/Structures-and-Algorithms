using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Recursion;

namespace Algorithms.Tests
{
    [TestClass]
    public class RecursionTests
    {
        [TestMethod]
        public void WhenFibonacciOf3_ThenTheNumberIs2()
        {
            var resutl = Fibonacci.Value(3);
            Assert.AreEqual(2, resutl, "Incorrect Fibonacci number");
        }

        [TestMethod]
        public void WhenFibonacciOf7_ThenTheNumberIs13()
        {
            var resutl = Fibonacci.Value(7);
            Assert.AreEqual(13, resutl, "Incorrect Fibonacci number");
        }

        [TestMethod]
        public void WhenTailRecursionFibonacciOf3_ThenTheNumberIs2()
        {
            var resutl = TailRecursionFibonacci.Value(3);
            Assert.AreEqual(2, resutl, "Incorrect Fibonacci number");
        }

        [TestMethod]
        public void WhenTailRecursionFibonacciOf7_ThenTheNumberIs13()
        {
            var resutl = TailRecursionFibonacci.Value(7);
            Assert.AreEqual(13, resutl, "Incorrect Fibonacci number");
        }
    }
}
