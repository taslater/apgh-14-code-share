// andrew: Joe W (he/him) shaunapage 
// Team 3 functioning code:

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


            bool keepGoing = true;
            while (keepGoing)
            {
                Console.WriteLine("What would you like to do? \na:encode \nb:decode \nc:quit");
                string option = Console.ReadLine();

                if (option == "a")
                {
                    Console.WriteLine("What is your message?");
                    string messageEncode = (Console.ReadLine().ToLower());
                    Console.WriteLine("How many rotations? (1 to 26)");
                    int rotation = Convert.ToInt32(Console.ReadLine());
                    string encoded = encrypt(messageEncode, rotation);
                    Console.WriteLine("Your encoded message is: ");
                    Console.WriteLine(encoded);

                }
                else if (option == "b")
                {
                    Console.WriteLine("Enter your encrypted message.");
                    string messageDecode = (Console.ReadLine().ToLower());
                    Console.WriteLine("How many rotations? (1 to 26)");
                    int rotation = Convert.ToInt32(Console.ReadLine());
                    string decoded = decrypt(messageDecode, rotation);
                    Console.WriteLine("Your decoded message is: ");
                    Console.WriteLine(decoded);
                }
                else if (option == "c")
                {
                    Console.WriteLine("Thank you for encoding with Caesar Bot!");
                    keepGoing = false;
                }
                else
                {
                    Console.WriteLine("Did not understand input.");
                }
            }
        }
        static string encrypt(string inputMessage, int rotation)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] messageAsChar = inputMessage.ToCharArray();
            char[] encryption = new char[inputMessage.Length];

            for (int messagePosition = 0; messagePosition < inputMessage.Length; messagePosition++)
            {
                for (int key = 0; key < alphabet.Length; key++)
                {
                    if (messageAsChar[messagePosition] == alphabet[key])
                    {
                        if (key + rotation < alphabet.Length)
                        {
                            encryption[messagePosition] = alphabet[key + rotation];
                        }
                        else if (key+rotation >= alphabet.Length)
                        {
                            encryption[messagePosition] = alphabet[key + rotation - 26];
                        }
                    }
                }
            }
            
            string finalMessage = new string(encryption);
            return finalMessage;


        }
        static string decrypt(string inputMessage, int rotation)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] messageAsChar = inputMessage.ToCharArray();
            char[] decryption = new char[inputMessage.Length];

            for (int messagePosition = 0; messagePosition < inputMessage.Length; messagePosition++)
            {
                for (int key = 0; key < alphabet.Length; key++)
                {
                    if (messageAsChar[messagePosition] == alphabet[key])
                    {
                        if (key - rotation >= 0)
                        {
                            decryption[messagePosition] = alphabet[key - rotation];
                        }
                        else if (key - rotation < 0)
                        {
                            decryption[messagePosition] = alphabet[key - rotation + 26];
                        }
                    }
                }
            }

            string finalMessage = new string(decryption);
            return finalMessage;
        }
     }
}