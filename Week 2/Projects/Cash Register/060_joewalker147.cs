using System;

namespace project_next
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a cash register application that will
            // Take in a cost of goods sold and cash given
            // and will return the change to be given and
            // the appropriate bills and coins to give

            // ex:
            // How much did it cost?
            // 3.43
            // How much did they pay?
            // 10
            // They get 6.57 in change
            // 1 five, 1 one, 2 quarters, 1 nickel, 2 pennies



            //===Ask user how much their groceries cost
            Console.WriteLine("How much did your goods cost?");
            double costtoinput = Convert.ToDouble(Console.ReadLine());
            int cost = Convert.ToInt32(costtoinput * 100);

            //===Ask user the amount the are paying with
            Console.WriteLine("What is the total amount you are paying with?");
            double paymenttoinput = Convert.ToDouble(Console.ReadLine());
            int payment = Convert.ToInt32(paymenttoinput * 100);

            //===figure out the change
            int change = (payment - cost);
            double showchange = Convert.ToDouble(change / 100.0);
            Console.WriteLine("your change is " + showchange);

            //===break down change into various denominations
            int[] breakdown = new int[8];

            while (change >= 2000)
            {
                change = change - 2000;
                breakdown[0] = breakdown[0] + 1;
            }
            if (change >= 1000)
            {
                change = change - 1000;
                breakdown[1] = breakdown[1] + 1;
            }
            if (change >= 500)
            {
                change = change - 500;
                breakdown[2] = breakdown[2] + 1;
            }
            while (change >= 100)
            {
                change = change - 100;
                breakdown[3] = breakdown[3] + 1;
            }
            while (change >= 25)
            {
                change = change - 25;
                breakdown[4] = breakdown[4] + 1;
            }
            while (change >= 10)
            {
                change = change - 10;
                breakdown[5] = breakdown[5] + 1;
            }
            if (change >= 5)
            {
                change = change - 5;
                breakdown[6] = breakdown[6] + 1;
            }
            while (change >= 1)
            {
                change = change - 1;
                breakdown[7] = breakdown[7] + 1;
            }

            Console.WriteLine("The change you will be receiving is:");
            string[] bills = { ": 20 dollar bill(s)", ": 10 dollar bill(s)", ": 5 dollar bill(s)", ": 1 dollar bill(s)", " Quarter(s)", " Dime(s)", " Nickel(s)", " Pennie(s)" };

            for (int i = 0; i < 8; i++)
            {
                if (breakdown[i] > 0)
                {
                    Console.Write(breakdown[i] + bills[i] + ", ");
                }
                //Console.WriteLine();

            }
        }
    }
}