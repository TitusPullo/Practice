using System;

namespace Calc1.OneArg
{
    /// <summary>
    /// power metod
    /// </summary>
    public class Power : I2Calculator 
    {
            public double Calculate(double first)
            {
                return Math.Pow(10, first);
            }
        }
    
}