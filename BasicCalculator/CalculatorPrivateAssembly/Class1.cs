using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorPrivateAssembly;

namespace CalculatorPrivateAssembly
{
    public class Calculator
    {
        public static float Addition(float a, float b)
        {
            return a + b;
        }

        public static float Subtraction(float a, float b)
        {
            return a - b;
        }

        public static float Multiplication(float a, float b)
        {
            return a * b;
        }

        public static float Division(float a, float b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot be divided by zero.");
            }
            return a / b;
        }
    }
}
