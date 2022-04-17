using System;

namespace Session14Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = GetNumber();
            int col = GetNumber();

            Console.WriteLine("You are doing something at row " + row + " and column " + col);

            Console.ReadLine();
        }

        static void SayHello()
        {
            Console.WriteLine("Hello there!");
            Console.WriteLine("This is really cool!");
        }

        static int GetNumber()
        {
            bool askForNumber = true;
            int number = 0;
            while (askForNumber)
            {
                Console.WriteLine("Give me a number from 1 - 10");
                number = Convert.ToInt32(Console.ReadLine());
                if (number >= 1 && number <= 10)
                {
                    // if it is a good number, then set askForNumber to false
                    askForNumber = false;
                }
            }
            return number;
        }

    }
}
