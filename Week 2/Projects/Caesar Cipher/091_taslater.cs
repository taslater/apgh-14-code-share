// davidlasky Yemi Truechild (she/her) Renat  samsnowdon

// Caesar salad encryption/decryption project:

using System;

namespace decoder
{
    class Program
    {
        static string Decode(string message, int rotation)
        {
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string outmessage = "";

            //loop through message we're given
            foreach (char c in message)
            {
                //
                int currentIndex = Array.IndexOf(alphabet, c);
                //spaces remain spaces, should not be translated
                if (currentIndex == -1)
                {
                    //Console.WriteLine(c);
                    outmessage = outmessage + c;
                    continue;
                }

                //for each character in the string we're gonna add or subtract the rotation from it
                int newIndex = (currentIndex + rotation) % alphabet.Length;
                //compensate for the ends of the arrays
                if (newIndex < 0)
                {
                    newIndex = newIndex + alphabet.Length;
                }

                //assemble all resulting characters into empty string
                outmessage = outmessage + alphabet[newIndex];
            }

            return outmessage;
        }
        static void Main(string[] args)
        {

            // Decoder
            // ask for the encoded message
            // ask for the rotation
            // show the decoded version

            // JGNNQ BQQ
            // 2
            // HELLO ZOO
            // Encoder
            // Ask for the message
            // Ask for the rotation
            // ask to encrypt/decrypt
            Console.WriteLine("Would you like to encrypt or decrypt a message? (e/d)");
            bool encrypt = Console.ReadLine().ToLower() == "e";
            // show the encoded version
            string prefix = encrypt ? "en" : "de";
            Console.WriteLine($"Enter a message to {prefix}crypt");
            string message = Console.ReadLine().ToUpper();
            //
            //ask if they need something encoded or decoded
            //ask for message
            //capture message
            //ask for rotation (specify direction)
            //capture rotation
            Console.WriteLine($"Enter a rotation for {prefix}cryption: (integer)");
            int rotation = Convert.ToInt32(Console.ReadLine());
            // rotation direction is reversed for en/decryption
            rotation *= encrypt ? 1 : -1;
            //enter alphabet into an array (come back here, Tom and Yemi have some ABC solves)

            string converted = Decode(message, rotation);

            string antiprefix = !encrypt ? "en" : "de";

            Console.WriteLine($"\nYour original ({antiprefix}crypted) message:");
            Console.WriteLine(message);
            //print answer
            Console.WriteLine($"Your {prefix}crypted message:");
            Console.WriteLine(converted);
        }
    }
}

// Repost from Academy Session 14 chat w/ minor modifications