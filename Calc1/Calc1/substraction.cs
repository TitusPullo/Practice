using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc1
{
    public class Substraction : ICalculator
    {
        public double Calculate(double first, double second)
        {
            return first - second;
        }
    }
}
