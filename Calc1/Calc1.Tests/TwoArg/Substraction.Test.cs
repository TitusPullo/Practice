using System;
using Calc1.OneArg;
using Calc1.TwoArg;
using NUnit.Framework;

namespace Calc1.Tests.TwoArg
{
    [TestFixture]
    public class SubstractionTests
    {
        [TestCase(5, 45, -40)]
        [TestCase(5, 50, -45)]
        [TestCase(5, 60, -55)]

        public void SubstractionTest(double firstArgument, double secondArgument, double expected)
        {
            Substraction calc = new Substraction();
            double result = calc.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}
