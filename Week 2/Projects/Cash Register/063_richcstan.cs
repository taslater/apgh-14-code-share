using System;

namespace registerApp
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


            //------------------Program---------------------
            Console.WriteLine("how much does the item cost?");
            decimal cost = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("how much was paid?");
            decimal paid = Convert.ToDecimal(Console.ReadLine());

            decimal total = paid - cost;
            Console.WriteLine("your change is: " + total);



            int twenty = 0;
            int ten = 0;
            int five = 0;
            int one = 0;
            int quarter = 0;
            int dime = 0;
            int nickel = 0;
            int penny = 0;


            while (total > 0)
            {
                if (total >= 20)
                {
                    twenty = twenty + 1;
                    total = total - 20;

                }
                else if (total >= 10)
                {
                    ten = ten + 1;
                    total = total - 10;
                }
                else if (total >= 5)
                {
                    five = five + 1;
                    total = total - 5;
                }
                else if (total >= 1)
                {
                    one = one + 1;
                    total = total - 1;
                }
                else if (total >= .25m)
                {
                    quarter = quarter + 1;
                    total = total - 0.25m;
                }
                else if (total >= .10m)
                {
                    dime = dime + 1;
                    total = total - 0.10m;
                }
                else if (total >= 0.05m)
                {
                    nickel = nickel + 1;
                    total = total - 0.05m;
                }
                else if (total >= .01m)
                {
                    penny = penny + 1;
                    total = total - 0.01m;
                }


            }

            Console.WriteLine("this is the number of 20's.. " + twenty);
            Console.WriteLine("this is the number of 10's.. " + ten);
            Console.WriteLine("this is the number of 5's.. " + five);
            Console.WriteLine("this is the number of 1's.. " + one);
            Console.WriteLine("this is the number of quarter's.. " + quarter);
            Console.WriteLine("this is the number of dime's.. " + dime);
            Console.WriteLine("this is the number of nickel's.. " + nickel);
            Console.WriteLine("this is the number of penny's.. " + penny);

        }
    }
}