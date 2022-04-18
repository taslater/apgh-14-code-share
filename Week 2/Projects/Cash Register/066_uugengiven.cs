// Cash Register with Modulo

using System;

namespace Session14Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            // cash register

            // ask for how much it costs
            // ask for how much they paid
            Console.WriteLine("How much did it cost?");
            int cost = (int)(Convert.ToDecimal(Console.ReadLine()) * 100);

            Console.WriteLine("How much did they pay?");
            int paid = (int)(Convert.ToDecimal(Console.ReadLine()) * 100);

            // show them the amount of change they're getting back
            int change = paid - cost;
            Console.WriteLine("I owe you $" + change / 100.0);

            // show them the denominations they're getting back

            int numberOfTwenties = change / 2000;
            Console.WriteLine(numberOfTwenties + " Twenties");
            change = change % 2000;

            int numberOfTens = change / 1000;
            Console.WriteLine(numberOfTens + " Tens");
            change = change % 1000;

            int numberOfFives = change / 500;
            Console.WriteLine(numberOfFives + " Fives");
            change = change % 500;

            int numberOfOnes = change / 100;
            Console.WriteLine(numberOfOnes + " Ones");
            change = change % 100;


            Console.ReadLine();
        }
    }
}
