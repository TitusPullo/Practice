namespace Calc1.TwoArg
{
    /// <summary>
    /// multiplication Metod
    /// </summary>
    public class Multiplication : ICalculator
    {
        public double Calculate(double first, double second)
        {
            return first * second;
        }
    }
}
