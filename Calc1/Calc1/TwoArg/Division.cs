using System;

namespace Calc1.TwoArg
{
    /// <summary>
    /// division metod and zero test 
    /// </summary>
    public class Division: ICalculator
    {
        /// <summary>
        /// calculate
        /// </summary>
        /// <param name="first">first</param>
        /// <param name="second">second</param>
        /// <returns>first/second</returns>
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
