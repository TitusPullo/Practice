using System;
using Calc1.TwoArg;
using NUnit.Framework;

namespace Calc1.Tests.TwoArg
{
    [TestFixture]
    public class CalculatesFactoryTests
    {
        [TestCase("addition", typeof(Addition))]
        [TestCase("substraction", typeof(Substraction))]
        [TestCase("multiplication", typeof(Multiplication))]
        [TestCase("division", typeof(Division))]
        public void CalculatesFactoryTest(string buttonName, Type type)
        {
            var calculator = CalculatesFactory.CreateCalculator(buttonName);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
