using System;

namespace Session14Kata01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name;
            name = Console.ReadLine();

            Console.WriteLine("Nice to meet you, " + name);

            Console.WriteLine("How old are you?");
            int age;
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You are " + age + " years old!");

            Console.WriteLine("You will be " + (age + 5) + " years old in 5 years.");
        }
    }
}
