using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // FIZZBUZZ
            // Print the numbers 1-100
            // If the number is a multiple of 3, instead of the number, print "fizz"
            // If the number is a multiple of 5, instead of the number, print "buzz"
            // If the number is a multiple of both, print "fizzbuzz"

            for (int i = 1; i <= 100; i++)
            {
                string output = "";

                int mod3 = i % 3;
                int mod5 = i % 5;

                if (mod3 == 0)
                {
                    output += "fizz";
                }
                if (mod5 == 0)
                {
                    output += "buzz";
                }
                if (output == "")
                {
                    output += i;
                }
                Console.WriteLine(output);
            }
        }
    }
}
