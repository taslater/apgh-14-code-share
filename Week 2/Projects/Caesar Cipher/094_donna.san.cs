// Team 2:fixed encryption
// Rich Stanley jallison Harrison (They / Them) 

using System;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            // Encoder
            // Ask for the message
            // Ask for the rotation
            // show the encoded version

            // Decoder
            // ask for the encoded message
            // ask for the rotation
            // show the decoded version


            bool on = true;
            while (on)
            {
                Console.WriteLine("\nDo you want to encrypt or decrypt a message?");
                Console.WriteLine("a)encrypt message \nb)decrypt message \nc)quit");
                string response = Console.ReadLine().ToLower();
                if (response == "a")
                {
                    Console.WriteLine("\nType a message to encrypt.");
                    string input = Console.ReadLine().ToLower();
                    Console.WriteLine("What is the rotation?");
                    int rotation = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < input.Length; i++)
                    {
                        Console.Write(cipher(input[i], rotation));
                    }
                }

                else if (response == "b")
                {
                    Console.WriteLine("\nType encrypted message.");
                    string input = Console.ReadLine().ToLower();
                    Console.WriteLine("What is the rotation?");
                    int rotation = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < input.Length; i++)
                    {
                        Console.Write(decipher(input[i], rotation));
                    }
                }
                else if (response == "c")
                {
                    Console.WriteLine("Goodbye");
                    on = false;
                }


            }
        }
        public static char cipher(char input, int rotation)
        {

            char currentletter = 'a';
            if (input == ' ')
            {
                currentletter = ' ';
            }
            else if ((int)input >= 123 - rotation)
            {
                currentletter = (char)(input - (26 - rotation));
            }
            else if ((int)input >= 97)
            {
                currentletter = (char)(input + rotation);
            }
            
            return currentletter;
        }
        public static char decipher(char input, int rotation)
        {
            char currentletter = (char)(input - rotation);
            if((int) currentletter < 97)
            {
                currentletter = (char)(input + 24);
            }
            return currentletter;

        }
    }
}