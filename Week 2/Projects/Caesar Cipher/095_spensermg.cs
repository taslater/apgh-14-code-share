// imaniemanuel: Tobias Tobak (he/him) Jessica Yockey 

using System;

namespace Decoder_Rings
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ovaltine
            // JGNNQ BQQ
            // 2
            // HELLO ZOO

            // ASCII or array storing the letters of the alphabet
            // If array: breakdown each character into a corresponding number 'a=1' 'b=2' 'c=3'
            // Apply the shift to the number, and then switch back to the letter
            // If ASCII: apply the change to the ASCII number. no need to have several arrays
            // How to change to ASCII = (int)'a'

            // either: solve one character at a time
            // or make an array of every single letter's ASCII number
            // Ask for encoding or decoding, put the if statements for encode or decode within the loop
            // Encoder
            // Ask for the message

            // have the loop end once it reaches the end of the message. for loop?
            // show the encoded message to the user
            // Decoder
            // ask for the encoded message
            // ask for the rotation
            // show the decoded version
            string response = "";
            while (response != "q")
            {
            
            Console.WriteLine("Welcome to the encoder ring, would you like to encode or decode? \n Type E to encode, D to decode, or Q to quit.");
            response = Console.ReadLine().ToLower();
                //if (response != "e" || response != "d" || response != "q")
                //{
                //    Console.WriteLine("Please try again.");
                //}

            Console.WriteLine("Drink more ovaltine. \n What is the message you would like to encode or decode?");
            string message = Console.ReadLine().ToLower();

            // Ask for the rotation (or how many spaces the letter will change by)
            Console.WriteLine("How many characters are you shifting by?");
            int rotation = Convert.ToInt32(Console.ReadLine());
           
            // create a loop that will change each letter by the number of spaces (rotation)
            for(int i = 0; i < message.Length; i = i + 1)
            {
                char thisletter = message[i];
                int letterNum = (int)thisletter;

                string encodedLetter = "";
                int encodedNum = 0;

                    if (thisletter == ' ')
                    {
                        encodedLetter = " ";
                    }
                    else
                    {
                        if (response == "e")
                        {
                            encodedNum = letterNum + rotation;
                            if (encodedNum > 122)
                            {
                                encodedNum = encodedNum - 26;
                            }
                        }
                        if (response == "d")
                        {
                            encodedNum = letterNum - rotation;
                            if (encodedNum < 97)
                            {
                                encodedNum = encodedNum + 26;
                            }
                        }
                        encodedLetter = Convert.ToString((char)encodedNum);
                        Console.Write(encodedLetter);
                    }
                }               
            }
        }
    }
}