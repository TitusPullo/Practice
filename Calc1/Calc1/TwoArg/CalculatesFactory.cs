using System;

namespace Calc1.TwoArg
{
    /// <summary>
    /// factory of two arguments
    /// </summary>
    public static class CalculatesFactory
    {
        /// <summary>
        /// interface
        /// </summary>
        /// <param name="calcName">calcName</param>
        /// <returns>another function or metod </returns>
        public static ICalculator CreateCalculator(string calcName)
        {
           
            switch (calcName)
            {
                case "addition":
                    return new Addition();
                    
                case "substraction":
                    return new Substraction();
                    
                case "multiplication":
                    return new Multiplication();
                    
                case "division":
                    return new Division();
                    
                default:
                    throw new Exception("");
               
            }
           
        }
    }
}