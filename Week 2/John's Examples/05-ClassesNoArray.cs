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

            Message myMessage = new Message();

            bool keepLooping = true;
            while (keepLooping == true)
            {
                // show the menu
                Console.WriteLine("What would you like to do? \na) leave a message \nb) retrieve a message \nq) quit");
                string menuChoice = Console.ReadLine().ToLower();

                if(menuChoice == "a")
                {
                    // save
                    Console.WriteLine("What is your message?");
                    myMessage.Text = Console.ReadLine();
                    Console.WriteLine("What is your name?");
                    myMessage.PostedBy = Console.ReadLine();
                    myMessage.PostedOn = DateTime.Now;

                }
                else if(menuChoice == "b")
                {
                    // retrieve
                    myMessage.PrintMe();
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
