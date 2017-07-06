using System;
using Calc1.OneArg;
using NUnit.Framework;

namespace Calc1.Tests.OneArg
{
    [TestFixture]
    public class SqrtTests

    {
        [TestCase(5, 25)]
        [TestCase(6, 36)]
        [TestCase(7, 49)]

        public void SqrtTest(double expected, double real)
        {
            Sqrt calc = new Sqrt();
            double result = calc.Calculate(real);
            Assert.AreEqual(expected, result, 0.0001);
        }

        [Test]
        public void SqrtLessThenZeroTest()
        {
            Sqrt calc = new Sqrt();
            Assert.Throws<Exception>(() => calc.Calculate(-1));

        }
    }
}
