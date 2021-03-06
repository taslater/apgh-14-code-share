using System;

namespace CashRegister
{
    class Program
    {
        // ======== PROMPT ========
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

        // ---- Variables required:
        // howMuchDidItCost, howMuchDidTheyPay, change, coinAmounts, changeString???
        // ---- Variable types
        // Double it all
        //
        // ===== Get inputs =====
        // Ask for amount owed
        // Receive cost from user
        // Ask for amount paid
        // Receive amount paid

        // ===== Do Maff =====


        // this is a function that asks for a currency amounts (in decimals)?
        static decimal GetUserDecimal(string askType)
        {
            // ask the user for what we want
            Console.WriteLine($"What was the {askType}? (dollas & censs plz)");
            // get the input from the user and converts it
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            // returns a decimal from the user input
            return amount;
        }

        static void Main(string[] args)
        {
            // use our function to get money inputs from the user
            decimal cost = GetUserDecimal("cost");
            decimal paid = GetUserDecimal("paid");

            // find the change from the difference and assign to __change__
            // __change__ will be modified
            decimal change = paid - cost;

            // our initial difference is saved for later
            // we want to tell the user what the total is
            // but we will alter __change__ during the rest of the code
            // so we have to save it
            decimal totalChange = change;

            // declaring variables for our denominations
            // bills and coins
            int twenties = 0;
            int tens = 0;
            int fives = 0;
            int ones = 0;
            int quarters = 0;
            int dimes = 0;
            int nickels = 0;
            int pennies = 0;

            // THESE ARE JUST REMINDERS (to-do list)
            // loooOOOOOoo000op
            // modulo?
            // RomanNumeralzzzz?
            // wwwwwwwhhhillllee
            // $0.60 - $0.25 = $0.35
            // $0.35 - $0.25 = $0.10
            // ohh no funkshuns!

            // error checking
            // make sure amount paid > price

            // do cute stuff with arrays and loopz


            // breaking __change__ down into currency (denominations)
            // __change__ is being modified
            // while the remaining change is greater than the denomination's value
            // we are removing that value

            // use while-loop instead of if-block because we may need
            // more than one bill/coin to make change
            while (change >= (decimal)20.0)
            {
                // subtract denomination value from __change__
                change -= (decimal)20.0;
                // add one bill/coin for each subtraction
                twenties += 1;
            }
            while (change >= (decimal)10.0)
            {
                change -= (decimal)10.0;
                tens += 1;
            }
            while (change >= (decimal)5.0)
            {
                change -= (decimal)5.0;
                fives += 1;
            }
            while (change >= (decimal)1.0)
            {
                change -= (decimal)1.0;
                ones += 1;
            }
            while (change >= (decimal)0.25)
            {
                change -= (decimal)0.25;
                quarters += 1;
            }
            while (change >= (decimal)0.1)
            {
                change -= (decimal)0.1;
                dimes += 1;
            }
            while (change >= (decimal)0.05)
            {
                change -= (decimal)0.05;
                nickels += 1;
            }
            while (change >= (decimal)0.01)
            {
                change -= (decimal)0.01;
                pennies += 1;
            }

            // declaring string that we will print out to display results to user
            // message will tell the user __totalChange__ and all the change denominations
            string outMessage = $"Your change is ${totalChange} which amounts to";

            // invoking function once per denomination
            outMessage = updateOutMessage(outMessage, twenties, "twenty");
            outMessage = updateOutMessage(outMessage, tens, "ten");
            outMessage = updateOutMessage(outMessage, fives, "five");
            outMessage = updateOutMessage(outMessage, ones, "one");
            outMessage = updateOutMessage(outMessage, quarters, "quarter");
            outMessage = updateOutMessage(outMessage, dimes, "dime");
            outMessage = updateOutMessage(outMessage, nickels, "nickel");
            outMessage = updateOutMessage(outMessage, pennies, "penny");
            outMessage += ". That's amazing.";

            // print out all of our hard work to share with the world
            // and make it a better place for you and for me <3
            Console.WriteLine(outMessage);

            //Console.WriteLine( {twenties} twenties, {tens} tens, {fives} fives {ones} ones {quarters} quarters {dimes} dimes {nickels} nickels {pennies} pennies!");
        }

        // implemented around line 140
        // has 3 ARGUMENTS (parameters, inputs)...
        // __outMessage__ is the message that we're modifying and we will return (modified)
        // __count__ is the number of units of each denomination (that we calculate previously)
        // __denomination__ is the name of the units (singular not plural)
        static string updateOutMessage(string outMessage, int count, string denomination)
        {
            // if there's only one coin or bill
            if (count == 1)
            {
                // the nouns stays singular and we add that info to the message
                outMessage += $" 1 {denomination},";
            }
            // if there's more than one coin or bill
            else if (count > 1)
            {
                // we add different information to the message (including coin/bill count)
                // apply gramar
                // rewriting plural denomination because English is hard
                outMessage += $" {count} {denomination.Replace("y", "ie")}s,";
            }
            // if there are no units of that denomination, make no changes to the message

            // return the modified (or unmodified) message
            return outMessage;
        }
    }
}