// Current working code for team 3: Yemi Truechild (she/her) Spenser Greeley andrew 

using System;

namespace Calculator01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hey, I'm a calculator! What should I do?");
            string input = Console.ReadLine();

            double firstNumber = char.GetNumericValue(input, 0);
            double secondNumber = char.GetNumericValue(input, 2);

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