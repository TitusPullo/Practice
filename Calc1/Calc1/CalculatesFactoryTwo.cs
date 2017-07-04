using System;

namespace Calc1
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

                default:
                    throw new Exception("");

            }

        }
    }
}