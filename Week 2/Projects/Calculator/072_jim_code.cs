// Yemi Truechild (she/her): Spenser Greeley andrew 

// Current working bonus code for team 3:


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

            //LeftNumber = input.Substring(0, 3);

            //Console.WriteLine("Hey, I'm a calculator! What should I do?");
            //string input = Console.ReadLine();

            //double firstNumber = char.GetNumericValue(input, 0);
            //double secondNumber = char.GetNumericValue(input, 2);

            //if (input.Contains("+"))
            //{
            //    Console.WriteLine(firstNumber + secondNumber);
            //}
            //if (input.Contains("-"))
            //{
            //    Console.WriteLine(firstNumber - secondNumber);
            //}

            Console.WriteLine("Hey! I'm a calculator, what's up?");
            string input = Console.ReadLine();
            //Console.WriteLine(input);
            //Console.WriteLine(input.Substring(0, 4));
            int place = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '+' || input[i] == '-')
                {
                    place = i;
                }
            }
            string firstNumber = input.Substring(0, place);
            string secondNumber = input.Substring(place + 1);
            //Console.WriteLine(firstNumber);
            //Console.WriteLine(secondNumber);

            int num1 = Convert.ToInt32(firstNumber);
            int num2 = Convert.ToInt32(secondNumber);
            //Console.WriteLine(num1 + num2);

            if (input.Contains("+"))
            {
                Console.WriteLine(num1 + num2);
            }
            if (input.Contains("-"))
            {
                Console.WriteLine(num1 - num2);
            }
        }
    }
}
