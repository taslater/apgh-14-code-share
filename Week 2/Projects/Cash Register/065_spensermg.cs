using System;

namespace Cash_Register
{
    class Program
    {
        static void Main(string[] args)
        {
            //Automatic cash register
            //Create a cash register application that will:
            //Take in a cost of goods sold and cash given
            //Return the change based to be returned to the customer
            //Give the change back in the appropriate bills and coins

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

            string lastdigit = showchange.ToString();
            int lastbox = lastdigit.Length - 1;
            int[] breakdown = new int[8];

            if (lastdigit[lastbox] == '3')
            {
                Console.WriteLine("The last number is 3.");
                //Utilize a loop similar to the else statement where the changes is produced in a random order
                //Have to be a while loop that keeps selecting change once each time through until it reaches zero
                while (change > 0)
                {
                    int numeral = 0;

                    if (change > 0)
                    {
                        //this creates a random number
                        Random number = new Random();
                        //this creates a variable that receives that random number which is a positive int less than 9
                        numeral = number.Next(9);
                        //Console.WriteLine(numeral);
                    }
                    //These if statements are conditional upon the random number and the amount of change left
                    //They add one to each count of bills and/or coins given both conditions are true
                    if (numeral == 1 && change >= 2000)
                    {
                        change = change - 2000;
                        breakdown[0] = breakdown[0] + 1;
                    }
                    if (numeral == 2 && change >= 1000)
                    {
                        change = change - 1000;
                        breakdown[1] = breakdown[1] + 1;
                    }
                    if (numeral == 3 && change >= 500)
                    {
                        change = change - 500;
                        breakdown[2] = breakdown[2] + 1;
                    }
                    if (numeral == 4 && change >= 100)
                    {
                        change = change - 100;
                        breakdown[3] = breakdown[3] + 1;
                    }
                    if (numeral == 5 && change >= 25)
                    {
                        change = change - 25;
                        breakdown[4] = breakdown[4] + 1;
                    }
                    if (numeral == 6 && change >= 10)
                    {
                        change = change - 10;
                        breakdown[5] = breakdown[5] + 1;
                    }
                    if (numeral == 7 && change >= 5)
                    {
                        change = change - 5;
                        breakdown[6] = breakdown[6] + 1;
                    }
                    if (numeral == 8 && change >= 1)
                    {
                        change = change - 1;
                        breakdown[7] = breakdown[7] + 1;
                    }
                }
            }
            else
            {
                //===break down change into various denominations
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

            //Bonus:
            //Any time the change being returend ends in a 3,
            //give the correct change but with random denominations
            //instead of largest to smallest

            //ex:
            //How much did it cost?
            //3.43
            //How much did they pay?
            //10
            //They get 6.57 in change
            //1 five, 1 one, 2 quarters, 1 nickel, 2 pennies
        }
    }
}

// andrew imaniemanuel Joe W (he/him)
// I took a crack at getting the system to randomly generate change if it ended in a 3. It's lengthy but works, found a random number generating function and included comments