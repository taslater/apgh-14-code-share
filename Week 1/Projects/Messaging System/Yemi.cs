using System;

namespace First_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Messaging System​

            //Make a system that allows you to either a) save a message or b) retrieve a message​

            //When saving, return a # that the user can use to retrieve a message​

            //When retrieving, allow a user to put in a # to see the message saved

            // ask for input
            // assign message ID
            // create a menu; options:
            // a) input a message
            // b) retrieve a message
            // c) exit

            string[] usermessage = new string[50];
            int currentmessage = 0;
            while (true)
            {
                Console.WriteLine("Welcome to your messaging system, HeLlO");
                Console.WriteLine("Pls pls select from the following:");
                Console.WriteLine("a) input a message");
                Console.WriteLine("b) retrieve a message");
                Console.WriteLine("c) exit");

                string option = Console.ReadLine();
                //Console.WriteLine(option);

                //usermessage[0] = "test";
                // receive message
                if (option == "a")
                {

                    Console.WriteLine("Please enter your message or whatever");
                    usermessage[currentmessage] = Console.ReadLine();
                    //Console.WriteLine(usermessage[currentmessage]);
                    Console.WriteLine("Your message is message number " + currentmessage);
                    currentmessage++;
                }
                else if (option == "b")
                {
                    Console.WriteLine("Please enter message ID number");
                    int requestmessage = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(usermessage[requestmessage]);
                }


                else
                {
                    Console.WriteLine("butt");
                }



                // store message
                // specify size of array or
                // string [] = newstring [maximum number of elements in this array]
            }
           }
    }
}

