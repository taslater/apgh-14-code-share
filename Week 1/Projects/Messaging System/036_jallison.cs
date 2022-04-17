using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a system that allows you to either a) save a message or b) retrieve a message​


            string[] messages = new string[10];
            Console.WriteLine("Please choose A, B, or C:");
            Console.WriteLine("A: Save a message");
            Console.WriteLine("B: Retrieve a message");
            Console.WriteLine("C: Exit system");
            string response = Console.ReadLine().ToLower();
            if (response == "a")
            {
                Console.WriteLine("Type your message");
                int counter = 0;
                while (counter < 10)
                messages[counter] = Console.ReadLine();
                counter = counter + 1;
                {
                    Console.WriteLine("Your message is number " + counter);
                }
            }
            if (response == "b")
            {
                Console.WriteLine("Enter number to retrieve message");
                int code = Convert.ToInt32(Console.ReadLine());
                code = counter;
                Console.WriteLine(messages[counter]);
                
            }
            if (response == "c")
            {
                Console.WriteLine("Goodbye");
            }


            //When saving, return a # that the user can use to retrieve a message​

            //When retrieving, allow a user to put in a # to see the message saved
        }
    }
}