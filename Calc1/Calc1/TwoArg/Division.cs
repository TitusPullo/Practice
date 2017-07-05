using System;

namespace Calc1.TwoArg
{
    public class Division: ICalculator
    {
        public double Calculate(double first, double second)
        {
            if (first == 0 && second == 0)
            {
                throw new Exception("arguments = 0");
            }
                return first / second;
        }
    }
}
