using System;

namespace Session14Kata01
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask the person for what month they were born
            // tell them what season it was when they were born


            int counter = 1;
            while (counter < 3)
            {
                Console.WriteLine("What month were you born? Please type the whole month name");
                string month;
                month = Console.ReadLine().ToLower();


                string summerAnswerKey = "july august september";
                if (month == "january" || month == "february" || month == "march")
                {
                    Console.WriteLine("You were born in lemon pepper.");
                }
                else if (month == "april" || month == "may" || month == "june")
                {
                    Console.WriteLine("You were born in cajun jerk");
                }
                else if (summerAnswerKey.Contains(month))
                {
                    Console.WriteLine("You were born in curry");
                }
                else if (month.Contains("oct") || month.Contains("nov") || month.Contains("dec"))
                {
                    Console.WriteLine("You were born in szechuan");
                }

                Console.WriteLine("Do you want to go again? (yes/no)");
                string answer = Console.ReadLine().ToLower();
                // if their answer is no
                // I want to end the loop
                if (answer == "no")
                {
                    counter = 100;
                }
            }

            Console.WriteLine("This is the end.");
        }
    }
}
