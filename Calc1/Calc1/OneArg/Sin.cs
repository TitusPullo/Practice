using System;

namespace Calc1.OneArg
{
    /// <summary>
    /// sin metod
    /// </summary>
    public class Sin : I2Calculator
    {
        /// <summary>
        /// calculate
        /// </summary>
        /// <param name="first">first</param>
        /// <returns>sin</returns>
        public double Calculate(double first)
        {
            return Math.Sin(first) ;
        }

    }
}