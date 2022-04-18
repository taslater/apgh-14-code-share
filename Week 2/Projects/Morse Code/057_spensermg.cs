using System;

namespace RomanNumeralKata01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user for a message
            //Convert string to characters
            //Be able to set each letter to a morse code, either with a library or array

            char[] alphabet = new char[4] { 'a', 'b', 'c', 'd' };
            string[] morsealphabet = new string[4] { ".- ", "-... ", "-.-. ", "-.. " };

            Console.WriteLine("What is the message you would like to write in morse code");
            string input = Console.ReadLine().ToLower();

            //Convert message into morse code using a series of if statements
            //Need to compare the alphabet to the morse alphabet

            string output = "";

            //run this loop the same number of times, as number of characters in the message
            for (int i = 0; i < input.Length; i++)
            {
                //run this loop for the same number of strings in our morse alphabet array
                for (int y = 0; y < morsealphabet.Length; y++)
                {
                    //this if statement is only used once the character in the user's input is the same as the alphabet array
                    if (input[i] == alphabet[y])
                    {
                        //the string variable we established outside the double for loops sets the blank variable to be the morse code that corresponds to the same position of the alphabet
                        output = output + morsealphabet[y];
                    }
                }

            }

            Console.WriteLine("Your message in morse code is: " + output);

        }
    }
}