using System;

namespace allo
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalmessages = 0;
            bool keepgoing = true;
            while (keepgoing)
            {


                Console.WriteLine("Welcome to the messaging system");

                Console.WriteLine("select from the following:");
                Console.WriteLine("a) input a message");
                Console.WriteLine("b) retrieve a message");
                Console.WriteLine("c) exit");
                string option = Console.ReadLine();


                MessageIndex[] messages = new MessageIndex[10];
                messages[totalmessages] = new MessageIndex();
                if (option == "a")
                {
                    Console.WriteLine("May I ask who's calling? ");
                    messages[totalmessages].name = Console.ReadLine();

                    Console.WriteLine("What is your message?");
                    messages[totalmessages].message = Console.ReadLine();
                    Console.WriteLine("Thank you; Your message ID is: " + totalmessages);
                    totalmessages++;
                }
                if (option == "b")
                {
                    Console.WriteLine("What is your message ID?");
                    int request = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(messages[0].name);
                    Console.WriteLine(messages[0].message);
                }
                if (option == "c")
                {
                    keepgoing = false;
                }



            }

        }

    }
    class MessageIndex

    {
        public string name;
        public string message;
    }
}
