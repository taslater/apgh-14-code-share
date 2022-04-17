using System;

namespace Session14Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(5, 7));
            Console.WriteLine(Sum(12, 89));

            int feet = 2;
            int hands = 13;
            Console.WriteLine("I have this many hands and feet: " + Sum(feet, hands));

            Console.WriteLine("If I double my feet, I'll have this many feet: " + DoubleIt(feet));
            Console.WriteLine(feet);

            feet = DoubleIt(feet);


            Console.WriteLine("Before changing");
            string[] names = { "John", "Jean", "Saturn" };
            PrintMe(names); // prints the names

            Console.WriteLine("After changing");
            ChangeFirstName(names);
            PrintMe(names);



            int x = 5;
            int y = x;

            x = 15;

            Console.WriteLine("X: " + x);
            Console.WriteLine("Y: " + y);


            int[] numX = { 1, 2, 3 };
            int[] numY = numX;
            int[] numZ = new int[10];

            Random rnd = new Random();


            numY[1] = 23;

            Console.WriteLine(numX[1]);


            Console.ReadLine();
        }

        // a function that will add two numbers and return the result
        static int Sum(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }

        static int DoubleIt(int someNumber)
        {
            someNumber = someNumber * 2;
            return someNumber;
        }

        static void PrintMe(string[] strings)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                Console.WriteLine(strings[i]);
            }
        }

        static void ChangeFirstName(string[] names)
        {
            names[0] = "Hello there!";
        }

    }
}
