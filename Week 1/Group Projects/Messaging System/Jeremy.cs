using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a system that allows you to either a) save a message or b) retrieve a message​


            Console.WriteLine("Please choose A, B, or C:");
            Console.WriteLine("A: Save a message");
            Console.WriteLine("B: Retrieve a message");
            Console.WriteLine("C: Exit system");
            string response = Console.ReadLine().ToLower();
            string[] messages = { };
            if (response == "a")
            {
                Console.WriteLine("Type your message");
                string savemessage = Console.ReadLine();
            }
            if (response == "b")
            {
                Console.WriteLine("Enter code to retrieve message");
                string code = Console.ReadLine();
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
