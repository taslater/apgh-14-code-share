// Latest Working Code

using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for a math problem
            //Break math problem into three parts--first number, plus/minus, second number
            //Do the math
            Console.WriteLine("Please input problem:");
            string math = Console.ReadLine();
            //string number1 = "";
            //string op = "";
            //string number2 = "";
            //expand mathparts somehow--add spaces? Infinite space? To infinity and beyond?
            //mathparts is an array that stores the seperate parts of the math problem
            string[] mathparts = new string[3];
            //variablecounter does something. I kind of forget what.
            //I think it helps count out the different numbers somehow?
            //tells computer where to store characters in mathparts
            int variablecounter = 0;
            //tells computer when to break between parts of the equation that are being stored in mathparts
            //keeps track of whether previous character is an integer or an operator
            bool isinteger = true;
            //loops over user input one character at a time
            for (int i = 0; i < math.Length; i++)
            {
                //Console.WriteLine(math[i]);
                char potato = math[i];
                //check if potato is an integer
                //check if potato is a space character
                //check if potato is an operator
                if (potato == '0' || potato == '1' || potato == '2' || potato == '3' || potato == '4' || potato == '5' || potato == '6' || potato == '7' || potato == '8' || potato == '9')
                {
                    //mathparts[variablecounter] += potato;
                    Console.WriteLine("This is an integer " + potato);
                    if (!isinteger)
                    {
                        //identify where number stops and operator starts
                        variablecounter++;
                        isinteger = true;
                        Console.WriteLine("Transition from number to operator");
                    }
                }
                else if (potato == '+' || potato == '-' || potato == '*' || potato == '/')
                {
                    Console.WriteLine("This is an operator " + potato);
                    char op = potato;
                    if (isinteger)
                    {
                        //identify where operator stops and number starts
                        variablecounter++;
                        isinteger = false;
                        Console.WriteLine("Transition from operator to number");
                    }
                }
                else
                {
                    Console.WriteLine("This is not an integer " + potato);
                    continue;
                }
                mathparts[variablecounter] += potato;
            }
            for (int j = 0; j < mathparts.Length; j++)
            {
                Console.WriteLine(mathparts[j]);
            }
            int number1 = Convert.ToInt32(mathparts[0]);
            //Console.WriteLine(number1);
            int number2 = Convert.ToInt32(mathparts[2]);
            //Console.WriteLine(number2);
            int result = 0;
            if (mathparts[1] == "+")
            {
                result = number1 + number2;
            }
            else if (mathparts[1] == "-")
            {
                result = number1 - number2;
            }
            else if (mathparts[1] == "*")
            {
                result = number1 * number2;
            }
            else if (mathparts[1] == "/")
            {
                result = number1 / number2;
            }
            Console.WriteLine(result);
        }
    }
}
