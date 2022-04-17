using System;

namespace Session14Kata01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[10];
            names[0] = "John";
            names[1] = "Jean";
            names[2] = "Saturn";

            Console.WriteLine("Hey, type in a name!");
            names[3] = Console.ReadLine();

            if(String.IsNullOrEmpty(names[5]))
            {
                Console.WriteLine("Yes, box 5 in that array is empty.");
            }


            Console.WriteLine("Print out names from array with loop: ");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
