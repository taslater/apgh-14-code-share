using System;

namespace Session14Kata01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = 10;
            Console.WriteLine(a);

            int b = 20;
            Console.WriteLine(b);

            a = b * 2;
            Console.WriteLine(a);

            a = a * 2;
            Console.WriteLine(a);

            string name;
            name = Console.ReadLine();
            Console.WriteLine(name.ToUpper());
        }
    }
}
