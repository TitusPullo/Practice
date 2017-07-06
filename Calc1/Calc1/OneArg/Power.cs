using System;

namespace Calc1.OneArg
{
    /// <summary>
    /// power metod
    /// </summary>
    public class Power : I2Calculator 
    {
        /// <summary>
        /// calculate
        /// </summary>
        /// <param name="first">first</param>
        /// <returns>power</returns>
            public double Calculate(double first)
            {
                return Math.Pow(10, first);
            }
        }
    
}