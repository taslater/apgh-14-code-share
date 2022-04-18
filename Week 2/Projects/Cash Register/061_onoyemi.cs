using System;

namespace Cash_Register
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a cash register application that will
            // Take in a cost of goods sold and cash given
            // and will return the change to be given and
            // the appropriate bills and coins to give

            Console.WriteLine("How much did it cost?");
            decimal cost = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("How much did you pay?");
            decimal payment = Convert.ToDecimal(Console.ReadLine());

            decimal change = (payment - cost);
            Console.WriteLine("Change dispensed is " + change);

            if (change >= 100)
            {
                int hundreds = (int)Math.Floor(change / 100);
                Console.WriteLine("Hundreds = " + hundreds);
                change = change - hundreds * 100;
                Console.WriteLine(change);
            }
            if (change <= 99)
            {
                int twenties = (int)Math.Floor(change / 20);
                Console.WriteLine("Twenties = " + twenties);
                change = change - twenties * 20;
                Console.WriteLine(change);
            }
            if (change <= 20)
            {
                int tens = (int)Math.Floor(change / 10);
                Console.WriteLine("Tens = " + tens);
                change = change - tens * 10;
                Console.WriteLine(change);
            }
            if (change <= 10)
            {
                int fives = (int)Math.Floor(change / 5);
                Console.WriteLine("Fives = " + fives);
                change = change - fives * 5;
                Console.WriteLine(change);
            }
            if (change <= 5)
            {
                int ones = (int)Math.Floor(change / 1);
                Console.WriteLine("Ones = " + ones);
                change = change - ones;
                Console.WriteLine(change);
            }
            if (change < 1)
            {
                int quarters = (int)Math.Floor(change / (decimal).25);
                Console.WriteLine("Quarters = " + quarters);
                change = change - quarters * (decimal)0.25;
                Console.WriteLine(change);
            }
            if (change < (decimal)0.25)
            {
                int dimes = (int)Math.Floor(change / (decimal).1);
                Console.WriteLine("Dimes = " + dimes);
                change = change - dimes * (decimal).1;
                Console.WriteLine(change);
            }
            if (change < (decimal).1)
            {
                int nickels = (int)Math.Floor(change / (decimal).05);
                Console.WriteLine("Nickels = " + nickels);
                change = change - nickels * (decimal).05;
                Console.WriteLine(change);
            }
            if (change < (decimal).05)
            {
                int pennies = (int)Math.Floor(change / (decimal).01);
                Console.WriteLine("Pennies = " + pennies);
                change = change - pennies * (decimal).01;
                Console.WriteLine(change);
            }
        }
    }
}