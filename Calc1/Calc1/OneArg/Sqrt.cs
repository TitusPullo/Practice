using System;

namespace Calc1.OneArg
{
    /// <summary>
    /// sqrt metod
    /// </summary>
    public class Sqrt: I2Calculator

    {
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