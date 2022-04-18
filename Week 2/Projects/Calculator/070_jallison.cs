// Current Working Code

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
            //string number1 = "";
            //string op = "";
            //string number2 = "";
            string[] mathparts = new string[3];
            int variablecounter = 0;
            for(int i = 0; i < math.Length; i++)
            {
                //Console.WriteLine(math[i]);
                char potato = math[i];
                //check if potato is an integer
                //check if potato is a space character
                //check if potato is an operator
                if (potato == '0' || potato == '1' || potato == '2' || potato == '3' || potato == '4' || potato == '5' || potato == '6' || potato == '7' || potato == '8' || potato == '9')
                {
                    mathparts[variablecounter] += potato;
                    Console.WriteLine("This is an integer " + potato);
                }
                else
                {
                    Console.WriteLine("This is not an integer " + potato);
                }
            }
            //int number1 = (int)Char.GetNumericValue(math[0]);
            ////Console.WriteLine(number1);
            //int number2 = (int)Char.GetNumericValue(math[4]);
            ////Console.WriteLine(number2);
            //int result = 0;
            //if (math[2] == '+')
            //{
            //    result = number1 + number2;
            //}
            //else if (math[2] == '-')
            //{
            //    result = number1 - number2;
            //}
            //else if (math[2] == '*')
            //{
            //    result = number1 * number2;
            //}
            //else if (math[2] == '/')
            //{
            //    result = number1 / number2;
            //}
            //    Console.WriteLine(result);
        }
    }
}
