using System;
using Calc1.OneArg;
using Calc1.TwoArg;
using NUnit.Framework;

namespace Calc1.Tests.TwoArg
{
    [TestFixture]
    public class DivisionTests
    {
        [TestCase(40, 5, 8)]

        public void DivisionTest(double firstArgument, double secondArgument, double expected)
        {
            Division calc = new Division();
            double result = calc.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(expected, result, 0.0001);
        }

        [Test]
        public void DivisionZerobyZeroTest()
        {
            Division calc = new Division();
            Assert.Throws<Exception>(() => calc.Calculate(0, 0));

        }
    }
}
