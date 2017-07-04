namespace Calc1
{
    public static class CalculatesFactory
    {
        static ICalculate createCalculator(string calcName)
        {
            ICalculate calculate;
            switch (calcName)
            {
                case "button1":
                    calculate = new Addition();
                    break;
                case "button2":
                    calculate = new Substraction();
                    break;
                case "button3":
                    calculate = new Multiplication();
                    break;
                case "button4":
                    calculate = new Division();
                    break;
                default:
                    calculate = null;
                    break;
            }
            return calculate;
        }
    }
}