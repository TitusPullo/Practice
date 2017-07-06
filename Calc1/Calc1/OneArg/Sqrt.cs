using System;

namespace Calc1.OneArg
{
    /// <summary>
    /// sqrt metod
    /// </summary>
    public class Sqrt: I2Calculator

    {
        /// <summary>
        /// calculate
        /// </summary>
        /// <param name="first">first</param>
        /// <returns>sqrt</returns>
    public double Calculate(double first)
    {
        if (first < 0)
        {
            throw new Exception("arguments < 0");
        }
            return Math.Sqrt(first);
    }
    }
}