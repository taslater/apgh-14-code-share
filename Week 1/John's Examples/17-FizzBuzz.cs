using System;

namespace Session14Kata01
{
    class Program
    {
        static void Main(string[] args)
        {
            // print out each number from 1 - 100
            // if the number is divisble by 3, print out fizz instead
            // if the number is divisble by 5, print out buzz instead
            // if the number is divisble by both, print out fizzbuzz

            for (int i = 1; i < 100; i++)
            {
                
                // 5 / 3
                // 1 with a remainder of 2
                // 5 / 3 = 1 (the number of times 3 goes into 5)
                // 5 % 3 = 2 (the remainder left over)
                if (((i % 3) == 0) && ((i % 5) == 0))
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
