using System;

namespace project_3_morsse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Morse Code
            // Ask the user for a message. Print out the morse code version of that message.
            // morse code message is: .... . .-.. .-.. ---

            // VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV

            string[] morse = { ".- ", "-... ", "-.-. ", "-.. ", ". ", "..-. ", "--. ", ".... "
             , ".. ", ".--- ", "-.- ", ".-.. ", "-- ", "-. ", "--- ", ".--. ", "--.- ", ".-. "
             , "... ", "- ", "..- ", "...- ", ".-- ", "-..- ", "-.-- ", "--.. " };



            //==== Ask user for message
            // Display question to user
            Console.WriteLine(" Please enter the message you want converted? ");
            // Store user response in variable 
            string usermessage = Console.ReadLine();
            usermessage = usermessage.ToLower();
            usermessage = usermessage.Trim();
            // 0 index offset for ascii codes. 
            int offset = 97;

            //==== Convert message to morse code
            // iterate over usermessage

            Console.WriteLine(" Your message in morse code is: ");
            bool previouswasspace = false;
            for (int i = 0; i < usermessage.Length; i++)
            {
                // Extract character from string 

                char c = usermessage[i];
                // Look up unicode integer from character

                // subtract to get 0 index array
                int n = (int)c - offset;

                // make sure the character is a letter
                if (n < 0 || n > 25)
                {
                    if (n == -65 && !previouswasspace)
                    {
                        Console.Write(" / ");                     //user.removeCat (keeps cats off keyboard)
                        previouswasspace = true;
                    }
                    continue;             // <--- flow control. If you get inside that f block. Once you hit continue it goes back to for.
                }

                //Console.WriteLine($"{c} {n} {morse[n]}");


                Console.Write(morse[n]);
                previouswasspace = false;
            }
            //==== Relay message to user

            // DON'T FORGET ABOUT SPACES. !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            // Go through the message that the user enters.
            // Convert each of those characters into an integer
            // You can then have an array which is basically like a 26 element array of strings
            // Then you can be like okay the letter a turns into the code for a is "3" (example)
            // Go to the array so you have the array setup something something morse code. Making our own ascii table.
            // Parse through the user message. At some point capital letters
            // Goes through and makes a new array of numbers. We have a for loop that goes through that array

            // Simpler method explanation? 
            // Convert message character by character into a number
            // Then we are going to convert each number into morese code
            // For loops that are going to have to go through and check each one thing
            // will need a table 


        }
    }
}