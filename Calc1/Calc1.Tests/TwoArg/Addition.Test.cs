using System;
using Calc1.OneArg;
using Calc1.TwoArg;
using NUnit.Framework;

namespace Calc1.Tests.TwoArg
{
    [TestFixture]
    public class AdditionTests
    {
        [TestCase(5, 45,50)]
        [TestCase(5, 40, 45)]
        [TestCase(5, 65, 70)]

        public void AdditionTest(double firstArgument, double secondArgument, double expected)
        {
            Addition calc = new Addition();
            double result = calc.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}
