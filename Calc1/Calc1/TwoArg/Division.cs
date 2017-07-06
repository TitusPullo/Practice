using System;

namespace Calc1.TwoArg
{
    /// <summary>
    /// division metod and zero test 
    /// </summary>
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
