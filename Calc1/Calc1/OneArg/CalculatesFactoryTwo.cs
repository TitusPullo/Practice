using System;

namespace Calc1.OneArg
{
    public static class CalculatesFactoryTwo
    {
        public static I2Calculator CreateCalculator(string calcName)
        {

            switch (calcName)
            {
                case "power":
                    return new Power();

                case "sqrt":
                    return new Sqrt();
                case "sin":
                    return new Sin();
                case "cos":
                    return new Cos();

                default:
                    throw new Exception("");

            }

        }
    }
}