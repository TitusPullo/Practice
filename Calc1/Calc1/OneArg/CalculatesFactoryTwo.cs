using System;

namespace Calc1.OneArg
{
    public static class CalculatesFactoryTwo
    {
        public static I2Calculator CreateCalculator(string calcName)
        {

            switch (calcName)
            {
                case "button5":
                    return new Power();

                case "button6":
                    return new Sqrt();
                case "button7":
                    return new Sin();
                case "button8":
                    return new Cos();

                default:
                    throw new Exception("");

            }

        }
    }
}