using System;
using Calc1.OneArg;
using NUnit.Framework;

namespace Calc1.Tests.OneArg
{
    [TestFixture]
    public class CosTests
    {
        [TestCase(0.5253, 45)]

        public void CosTest(double expected, double real)
        {
            Cos calc = new Cos();
            double result = calc.Calculate(real);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}
