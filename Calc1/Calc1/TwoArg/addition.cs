namespace Calc1.TwoArg
{
    public class Addition: ICalculator
    {
        /// <summary>
        /// addition metod
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
    
        
        public double Calculate(double first, double second)
        {
            return first + second;
        }
    }
}
