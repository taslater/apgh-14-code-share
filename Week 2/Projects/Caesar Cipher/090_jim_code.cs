// Team 3 current working code for encryption: andrew Joe W (he/him) shaunapage 
using System;

namespace DecoderRing01
{
    class Program
    {
        static void Main(string[] args)

        {
            // Ovaltine
            // JGNNQ BQQ
            // 2
            // HELLO ZOO

            // Encoder
            // Ask for the message
            // Ask for the rotation
            // show the encoded version

            // Decoder
            // ask for the encoded message
            // ask for the rotation
            // show the decoded version

            

            Console.WriteLine("What would you like to do? \na:encode \nb:decode");
            string option = Console.ReadLine();

            if(option == "a")
            {
                Console.WriteLine("What is your message?");
                string messageEncode = (Console.ReadLine().ToLower());
                Console.WriteLine("How many rotations?");
                int rotation = Convert.ToInt32(Console.ReadLine());
                string encoded = encrypt(messageEncode, rotation);
                Console.WriteLine("Your encoded message is: ");
                Console.WriteLine(encoded);

            }
            
        }
        static string encrypt(string inputMessage, int rotation)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] messageAsChar = inputMessage.ToCharArray();
            char[] encryption = new char[inputMessage.Length];

            for (int i = 0; i < inputMessage.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (messageAsChar[i] == alphabet[j])
                    {
                        encryption[i] = alphabet[j + rotation];
                    }
                }
            }
            //char[] chars = { 'a', ' ', 's', 't', 'r', 'i', 'n', 'g' };
            //string s = new string(chars);
            string finalMessage = new string(encryption);
            return finalMessage;
        }
    }
}