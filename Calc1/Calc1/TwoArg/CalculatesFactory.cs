using System;

namespace Calc1.TwoArg
{
    public static class CalculatesFactory
    {
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