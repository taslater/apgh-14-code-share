using System;

namespace Session14Kata01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            if (name == "red")
            {
                Console.WriteLine("red");
            }
            else if(name == "blue")
            {
                Console.WriteLine("blue");
            }
            else if (name == "green")
            {
                Console.WriteLine("green");
            }
            else
            {
                Console.WriteLine("I don't know that color, so I'll default to 100 sq ft per bucket");
            }

            switch(name)
            {
                case "green":
                case "red":
                    Console.WriteLine("red or maybe green");
                    break;
                case "blue":
                    Console.WriteLine("blue");
                    break;
                default:
                    Console.WriteLine("None of the above");
                    break;
            }


        }
    }
}
