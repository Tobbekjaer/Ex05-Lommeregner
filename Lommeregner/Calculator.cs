using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lommeregner
{
    public class Calculator
    {
        public int Add(int num1, int num2)
        {
            Console.WriteLine("Du tastede 1: ");
            int add = num1 + num2;
            Console.WriteLine("The addition of " + num1 + num2 + " is: " + add);
            return add;
        }

        public int Subtract(int num1, int num2)
        {
            Console.WriteLine("Du tastede 2: ");
            int subtract = num1 - num2;
            Console.WriteLine("The subtraction of " + num1 + num2 + " is: " + subtract);
            return subtract;
        }

        public double Divide(double num1, double num2)
        {
            Console.WriteLine("Du tastede 3: ");
            double divide = num1 / num2;
            Console.WriteLine("The division of " + num1 + num2 + " is: " + divide);
            return divide;
        }

        public int Multiply(int num1, int num2)
        {
            Console.WriteLine("Du tastede 4: ");
            int multiply = num1 * num2;
            Console.WriteLine("The multiplication of " + num1 + num2 + " is: " + multiply);
            return multiply;
        }
    }
}
