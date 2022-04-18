// Tobias Tobak (he/him): Jessica Yockey jallison 

using System;

namespace MorseCode01
{
    class Program
    {
        static void Main(string[] args)
        {

            //What is your message ?
            //> hello
            //    Your message in morse code is: .... . .-.. .-..---

            Console.WriteLine("What is your message?");
            string input = Console.ReadLine().ToLower();

            //Ask for user input
            //Get the input
            //Convert to morse code
            //Return morse code conversion

            //Build an index for morse code to English letters
            //For loop for conversion
            Console.WriteLine("Your message in Morse code is: ");
            for (int i = 0; i < input.Length; i++)
            {
                string output = "";
                switch (input[i])
                {
                    case 'a':
                        output = ".-";
                        break;

                    case 'b':
                        output = "-...";
                        break;

                    case 'c':
                        output = "-.-.";
                        break;

                    case 'd':
                        output = "-..";
                        break;

                    case 'e':
                        output = ".";
                        break;

                    case 'f':
                        output = "..-.";
                        break;

                    case 'g':
                        output = "--.";
                        break;

                    case 'h':
                        output = "....";
                        break;

                    case 'i':
                        output = "..";
                        break;

                    case 'j':
                        output = ".---";
                        break;

                    case 'k':
                        output = "-.-";
                        break;

                    case 'l':
                        output = ".-..";
                        break;

                    case 'm':
                        output = "--";
                        break;

                    case 'n':
                        output = "-.";
                        break;

                    case 'o':
                        output = "---";
                        break;

                    case 'p':
                        output = ".--.";
                        break;

                    case 'q':
                        output = "--.-";
                        break;

                    case 'r':
                        output = ".-.";
                        break;

                    case 's':
                        output = "...";
                        break;

                    case 't':
                        output = "-";
                        break;

                    case 'u':
                        output = "..-";
                        break;

                    case 'v':
                        output = "...-";
                        break;

                    case 'w':
                        output = ".--";
                        break;

                    case 'x':
                        output = "-..-";
                        break;

                    case 'y':
                        output = "-.--";
                        break;

                    case 'z':
                        output = "--..";
                        break;

                }
                Console.Write(output + " ");

            }


        }
    }
}