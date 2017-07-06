using System;

namespace Calc1.OneArg
{
    /// <summary>
    /// static  one argument operation 
    /// </summary>
    public static class CalculatesFactoryTwo
    {
        /// <summary>
        /// public static metod buttonClick
        /// </summary>
        /// <param name="calcName">choose param</param>
        /// <returns>calculator</returns>
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