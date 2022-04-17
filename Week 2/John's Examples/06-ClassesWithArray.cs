using System;
using System.Collections.Generic;

namespace Session14Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            // message system
            // but also save a name

            Message[] myMessages = new Message[10];


            int address = 0;

            bool keepLooping = true;
            while (keepLooping == true)
            {
                // show the menu
                Console.WriteLine("What would you like to do? \na) leave a message \nb) retrieve a message \nq) quit");
                string menuChoice = Console.ReadLine().ToLower();

                if(menuChoice == "a")
                {
                    // save

                    myMessages[address] = new Message();
                    Console.WriteLine("What is your message?");
                    myMessages[address].Text = Console.ReadLine();
                    Console.WriteLine("What is your name?");
                    myMessages[address].PostedBy = Console.ReadLine();
                    myMessages[address].PostedOn = DateTime.Now;

                    Console.WriteLine("Thank you for leaving a message in box " + address);
                    address = address + 1;
                }
                else if(menuChoice == "b")
                {
                    // retrieve
                    // ask which ID to show
                    Console.WriteLine("Which message would you like to see?");
                    int messageId = Convert.ToInt32(Console.ReadLine());
                    // show it
                    myMessages[messageId].PrintMe();
                }
                else if (menuChoice == "q")
                {
                    // quit
                    keepLooping = false;
                }
                else
                {
                    // uhh typo?
                }
            }

        }
    }

    class Message
    {
        public string Text;
        public string PostedBy;
        public DateTime PostedOn;

        public void PrintMe()
        {
            Console.WriteLine("Your message from " + PostedBy + " is:");
            Console.WriteLine(Text);
            Console.WriteLine("It was posted on " + PostedOn);
        }
    }
}
