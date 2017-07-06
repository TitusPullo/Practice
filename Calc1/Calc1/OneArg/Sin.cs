using System;

namespace Calc1.OneArg
{
    /// <summary>
    /// sin metod
    /// </summary>
    public class Sin : I2Calculator

    {
        public double Calculate(double first)
        {
            return Math.Sin(first) ;
        }

    }
}