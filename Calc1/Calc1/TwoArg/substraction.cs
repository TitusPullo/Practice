﻿namespace Calc1.TwoArg
{
    /// <summary>
    /// Substraction Metod
    /// </summary>
    public class Substraction : ICalculator
    {
        /// <summary>
        /// calculate
        /// </summary>
        /// <param name="first">first</param>
        /// <param name="second">second</param>
        /// <returns>first-second</returns>
        public double Calculate(double first, double second)
        {
            return first - second;
        }
    }
}
