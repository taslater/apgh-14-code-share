// Initial working code:

using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for a math problem
            //Break math problem into three parts--first number, plus/minus, second number
            //Do the math
            Console.WriteLine("Please input problem:");
            string math = Console.ReadLine();
            int number1 = (int)Char.GetNumericValue(math[0]);
            //Console.WriteLine(number1);
            int number2 = (int)Char.GetNumericValue(math[2]);
            //Console.WriteLine(number2);
            int result = 0;
            if (math[1] == '+')
            {
                result = number1 + number2;
            }
            else if (math[1] == '-')
            {
                result = number1 - number2;
            }
            else if (math[1] == '*')
            {
                result = number1 * number2;
            }
            else if (math[1] == '/')
            {
                result = number1 / number2;
            }
            Console.WriteLine(result);
        }
    }
}