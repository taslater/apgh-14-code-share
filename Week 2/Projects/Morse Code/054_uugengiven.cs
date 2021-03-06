// Morse Code with replace

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

            message = message.Replace("A", ".- ");
            message = message.Replace("B", "-... ");
            message = message.Replace("C", ".-.- ");
            message = message.Replace("D", "-.. ");

            Console.WriteLine("Your translated message is: " + message);

            Console.ReadLine();
        }
    }
}
