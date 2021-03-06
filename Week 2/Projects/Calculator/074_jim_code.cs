// Yemi Truechild (she/her): Spenser Greeley andrew 

// 2nd version for bonus code using "Splits", team 3:

using System;

namespace Calculator01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Take in a math problem
            // like, 2 + 2
            // or, 5 - 1

            // give the person the right answer to that problem

            // Bonus:
            // Make it work with multi-digit numbers
            // 71 + 238

            // Extra Bonus:
            // Consider how you might do 3 numbers instead of two


            //1. Ask for a mathematical problem
            //2. ReadLine for input
            //3. Determine user's operation
            //4. Create variables that will store values


            Console.WriteLine("Hey, I'm a calculator! What should I do?");
            string input = Console.ReadLine();
            string[] splits = input.Split(' ', '+', '-');
            long firstNumber = Convert.ToInt64(splits[0]);
            long secondNumber = Convert.ToInt64(splits[1]);

            //double firstNumber = char.GetNumericValue(input, 0);
            //double secondNumber = char.GetNumericValue(input, 2);

            if (input.Contains("+"))
            {
                Console.WriteLine(firstNumber + secondNumber);
            }
            if (input.Contains("-"))
            {
                Console.WriteLine(firstNumber - secondNumber);
            }

        }
    }
}