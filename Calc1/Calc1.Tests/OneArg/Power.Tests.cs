using System;
using Calc1.OneArg;
using NUnit.Framework;

namespace Calc1.Tests.OneArg
{
    [TestFixture]
    public class PowerTests
    {
        [TestCase(100, 2)]
        [TestCase(1000, 3)]
        [TestCase(10000, 4)]


        public void PowerTest(double expected, double real)
        {
            Power calc = new Power();
            double result = calc.Calculate(real);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}
