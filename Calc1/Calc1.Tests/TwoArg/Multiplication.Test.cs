using System;
using Calc1.OneArg;
using Calc1.TwoArg;
using NUnit.Framework;

namespace Calc1.Tests.TwoArg
{
    [TestFixture]
    public class MultiplicationTests
    {
        [TestCase(5, 40, 200)]
        [TestCase(5, 20, 100)]
        [TestCase(5, 400, 2000)]

        public void MultiplicationTest(double firstArgument, double secondArgument, double expected)
        {
            Multiplication calc = new Multiplication();
            double result = calc.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}
