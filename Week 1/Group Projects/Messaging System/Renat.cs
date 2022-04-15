using System;

namespace Day3or4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] messages = new string[100];
            int on = 1;
            int index = 0;
            while (on == 1)
            {
                Console.WriteLine("Please make a choice ");
                Console.WriteLine("A. Save a message ");
                Console.WriteLine("B. Retrieve a message ");
                Console.WriteLine("C. Exit ");
                string reply = Console.ReadLine().ToLower();

                if (reply == "a")
                {
                    Console.WriteLine("Please leave a message ");
                    messages[index] = Console.ReadLine();
                    Console.WriteLine("Your message number is: " + index);
                    index = index + 1;
                }
                else if (reply == "b")

                {
                    Console.WriteLine("Please give a message number ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(messages[id]);
                }

                else if (reply == "c")
                {
                    on = 0;
                }

            }

        }
    }
}
