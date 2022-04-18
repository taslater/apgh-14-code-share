// Morse Code with dictionary arrays

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

            char[] b = { 'A', 'B', 'C', 'D', 'E' };
            string[] c = { ".- ", "-.. ", "-.-. ", "-... ", ". " };


            Console.WriteLine("What message would you like to translate?");
            string message = Console.ReadLine();
            message = message.ToUpper();
            string output = "";

            for (int i = 0; i < message.Length; i++)
            {
                // if(message[i] == 'a')

                for (int j = 0; j < b.Length; j++)
                {
                    if (message[i] == b[j])
                    {
                        output = output + c[j];
                    }
                }

            }

            Console.WriteLine("Your translated message is " + output);

            Console.ReadLine();
        }
    }
}
