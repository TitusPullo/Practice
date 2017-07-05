using System;
using Calc1.OneArg;
using NUnit.Framework;

namespace Calc1.Tests.OneArg
{
    [TestFixture]
    public class CalculatesFactoryTwoTests
    {
        [TestCase("power", typeof(Power))]
        [TestCase("sqrt", typeof(Sqrt))]
        [TestCase("sin", typeof(Sin))]
        [TestCase("cos", typeof(Cos))]
        public void CalculatesFactoryTwoTest(string buttonName, Type type)
        {
            var calculator = CalculatesFactoryTwo.CreateCalculator(buttonName);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}