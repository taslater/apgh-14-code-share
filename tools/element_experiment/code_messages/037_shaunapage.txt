using System;

namespace messaging_system
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] messages = new string[5];
            int counter = 0;
            while (counter < 5)
            {
                Console.WriteLine("Would you like to create or retrieve a message? (C/R)");
                string input = Console.ReadLine();
                if (input == "C")
                {
                    Console.WriteLine("Let's create a message!");
                    messages[counter] = Console.ReadLine();
                    Console.WriteLine("Your message number is " + counter);
                    counter++;
                    //Array.ForEach(messages, Console.WriteLine);
                }
                else
                {
                    Console.WriteLine("Let's retrieve your message!");
                    string userinput = Console.ReadLine();
                    int userint = Convert.ToInt32(userinput); 
                    //Console.WriteLine(userint);

                    string usermessage = messages[userint];
                    Console.WriteLine(usermessage);
                   
                }
               
                //counter++;
            }



        }
    }
}
