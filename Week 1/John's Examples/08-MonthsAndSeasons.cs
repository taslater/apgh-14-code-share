using System;

namespace Session14Kata01
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask the person for what month they were born
            // tell them what season it was when they were born

            Console.WriteLine("What month were you born? Please type a number from 1-12");
            int month;
            month = Convert.ToInt32(Console.ReadLine());

            if(month <= 3)
            {
                Console.WriteLine("You were born in lemon pepper.");
            }
            else if (month <= 6)
            {
                Console.WriteLine("You were born in cajun jerk");
            }
            else if (month <= 9)
            {
                Console.WriteLine("You were born in curry");
            }
            else
            {
                Console.WriteLine("You were born in szechuan");
            }

        }
    }
}
