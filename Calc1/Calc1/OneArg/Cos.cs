using System;

namespace Calc1.OneArg
{
    /// <summary>
    /// cos metod
    /// </summary>
    public class Cos : I2Calculator
    {/// <summary>
    /// calculate
    /// </summary>
    /// <param name="first">first</param>
    /// <returns>cos</returns>
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}