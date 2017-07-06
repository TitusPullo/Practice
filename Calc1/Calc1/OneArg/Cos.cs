using System;

namespace Calc1.OneArg
{
    /// <summary>
    /// cos metod
    /// </summary>
    public class Cos : I2Calculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}