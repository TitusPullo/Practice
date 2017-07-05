using System;

namespace Calc1.TwoArg
{
    public static class CalculatesFactory
    {
        public static ICalculator CreateCalculator(string calcName)
        {
           
            switch (calcName)
            {
                case "button1":
                    return new Addition();
                    
                case "button2":
                    return new Substraction();
                    
                case "button3":
                    return new Multiplication();
                    
                case "button4":
                    return new Division();
                    
                default:
                    throw new Exception("");
               
            }
           
        }
    }
}