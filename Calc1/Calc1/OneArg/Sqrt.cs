using System;

namespace Calc1.OneArg
{
    public class Sqrt: I2Calculator

    {
    public double Calculate(double first)
    {
        return Math.Sqrt(first);
    }
    }
}