using System;
using Calc1.OneArg;
using NUnit.Framework;

namespace Calc1.Tests.OneArg
{
    [TestFixture]
    public class SinTests
    {
        [TestCase(0.8509, 45)]

        public void SinTest(double expected, double real)
        {
            Sin calc = new Sin();
            double result = calc.Calculate(real);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}
