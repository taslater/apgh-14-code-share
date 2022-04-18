using System;


namespace morse_code
{
    class Program
    {
        static void Main(string[] args)
        {
            // if statements to define morse
            // ask user for a message, string
            // translate string into array?
            // translate user message to morse
            // translate individual letters to morse

            Console.WriteLine("Want morse? Tell me what to say!");
            string message = Console.ReadLine().ToUpper();

            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == ' ')
                {
                    Console.Write(" ");
                }
                else if (message[i] == 'A')
                {
                    Console.Write(".- ");
                }
                else if (message[i] == 'B')
                {
                    Console.Write("-... ");
                }
                else if (message[i] == 'C')
                {
                    Console.Write("-.-. ");
                }
                else if (message[i] == 'D')
                {
                    Console.Write("-.. ");
                }
                else if (message[i] == 'E')
                {
                    Console.Write(". ");
                }
                else if (message[i] == 'F')
                {
                    Console.Write("..-. ");
                }
                else if (message[i] == 'G')
                {
                    Console.Write("--. ");
                }
                else if (message[i] == 'H')
                {
                    Console.Write(".... ");
                }
                else if (message[i] == 'I')
                {
                    Console.Write(".. ");
                }
                else if (message[i] == 'J')
                {
                    Console.Write(".--- ");
                }
                else if (message[i] == 'K')
                {
                    Console.Write("-.- ");
                }
                else if (message[i] == 'L')
                {
                    Console.Write(".-.. ");
                }
                else if (message[i] == 'M')
                {
                    Console.Write("-- ");
                }
                else if (message[i] == 'N')
                {
                    Console.Write("-. ");
                }
                else if (message[i] == 'O')
                {
                    Console.Write("--- ");
                }
                else if (message[i] == 'P')
                {
                    Console.Write(".--. ");
                }
                else if (message[i] == 'Q')
                {
                    Console.Write("--.- ");
                }
                else if (message[i] == 'R')
                {
                    Console.Write(".-. ");
                }
                else if (message[i] == 'S')
                {
                    Console.Write("... ");
                }
                else if (message[i] == 'T')
                {
                    Console.Write("- ");
                }
                else if (message[i] == 'U')
                {
                    Console.Write("..- ");
                }
                else if (message[i] == 'V')
                {
                    Console.Write("...- ");
                }
                else if (message[i] == 'W')
                {
                    Console.Write(".-- ");
                }
                else if (message[i] == 'X')
                {
                    Console.Write("-..- ");
                }
                else if (message[i] == 'Y')
                {
                    Console.Write("-.-- ");
                }
                else if (message[i] == 'Z')
                {
                    Console.Write("--.. ");
                }
                else
                {
                    //Console.WriteLine("Does not compute!");
                }
            }

        }
    }
}