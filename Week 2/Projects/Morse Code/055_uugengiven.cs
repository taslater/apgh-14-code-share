// Morse Code with switch

using System;

namespace Session14Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask a user for a message
            // convert that into morse code
            // spit the message back out

            Console.WriteLine("What message would you like to translate?");
            string message = Console.ReadLine();
            message = message.ToUpper();
            string output = "";

            for (int i = 0; i < message.Length; i++)
            {
                // if(message[i] == 'a')

                switch (message[i])
                {
                    case 'A':
                        output = output + ".- ";
                        break;
                    case 'B':
                        output = output + "-... ";
                        break;
                    case 'C':
                        output = output + "-.-. ";
                        break;
                    case 'D':
                        output = output + "-.. ";
                        break;

                }
            }

            Console.WriteLine("Your translated message is " + output);

            Console.ReadLine();
        }
    }
}
