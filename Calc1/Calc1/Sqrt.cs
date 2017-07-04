using System;

namespace Calc1
{
    public class Sqrt: I2Calculator

    {
    public double Calculate(double first)
    {
        return Math.Sqrt(first);
    }
    }
}