using System;

namespace Session14Kata01
{
    class Program
    {
        static void Main(string[] args)
        {
            string name0 = "John";
            string name1 = "Jean";
            string name2 = "Saturn";
            string name3 = "Mars";


            string[] names = { "John", "Jean", "Saturn", "Mars", "Scott", "Joyce", "Kelvin", "Sam", "Drew", "Sean", "Regina" };

            Console.WriteLine(name0);
            name1 = "Jean!";
            Console.WriteLine(name1);

            Console.WriteLine(names[2]);


            Console.WriteLine("Print out names from individual variables:");
            Console.WriteLine(name0);
            Console.WriteLine(name1);
            Console.WriteLine(name2);
            Console.WriteLine(name3);

            Console.WriteLine("Print out names from array:");
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);

            Console.WriteLine("Print out names from array with loop: ");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
