// Joe W (he/him) donna.san davidlasky 


using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // == PLAN ==
            // - ask for a math problem
            // - store as string
            // - break down problem
            // - compute and answer
            // - display the answer

            // Ask question
            Console.WriteLine("Please enter your math problem.");
            // Get input as a string
            string problem = Console.ReadLine();
            // Remove potential spaces
            problem = problem.Replace(" ", "");

            // Define variables
            // Empty strings to build numbers
            string firstNumberString = "";
            string secondNumberString = "";
            // Character to store operator
            char Operator = '0';
            // Marks whether first number has been finished
            bool firstNumberDone = false;

            // FOR LOOP checks characters one by one
            for (int i = 0; i < problem.Length; i++)
            {
                // checks if the character is a number
                if (Char.IsNumber(problem, i))
                {
                    // checks if first number is done
                    if (firstNumberDone == false) // first number is not done
                    {
                        firstNumberString += problem[i];
                    }
                    else // first number is done
                    {
                        secondNumberString += problem[i];
                    }
                }
                else // Character is not a number
                {
                    // when it hits not-a-number => first number is complete
                    firstNumberDone = true;

                    // capture operator
                    Operator = problem[i];

                }
            }

            // convert numbers to integers
            int firstNumber = Convert.ToInt32(firstNumberString);
            int secondNumber = Convert.ToInt32(secondNumberString);

            Console.WriteLine("firstNumber: " + firstNumber);
            Console.WriteLine("secondNumber: " + secondNumber);


            // pipe it through existing math statement

            int solution = 0;

            // DO THE MATH

            // identify the operator
            if (Operator == '+')
            {
                solution = firstNumber + secondNumber;
            }
            else if (Operator == '-')
            {
                solution = firstNumber - secondNumber;
            }
            else if (Operator == '*')
            {
                solution = firstNumber * secondNumber;
            }

            Console.WriteLine("solution: " + solution);

        }
    }
}