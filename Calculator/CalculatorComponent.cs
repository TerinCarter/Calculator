using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorComponent
    {
        public int testMethod ()
        {
            return 0;
        }
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Substract(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(int a, int b)
        {
            if (b == 0)
                throw new ArgumentException("Делить на 0 нельзя!");
            return Math.Round((double)a / b, 2);
        }
    }
}
