// Help, I need something better to do with my evenings!

// Solution to "Calculator" (string parsing) using regex to split the input including some tests. I would love to throw helpful errors for malformed inputs, but it doesn't yet.


using System;
using System.Text.RegularExpressions;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Test[] tests = {
                new Test("1+1", 2m),
                new Test("111 - 11", 100m),
                new Test("2 * 4    - 3", 5m),
                new Test("2.14/ 1.07 - 3.08 * 11   + 40.62", 28.74m),
            };

            Calculator calculator = new Calculator();

            for (int i = 0; i < tests.Length; i++)
            {
                Test t = tests[i];
                Console.WriteLine($"Test {i + 1}:");
                t.Check(calculator.Calculate(t.input));
                Console.WriteLine();
            }
        }
    }

    public struct Test
    {
        public string input;
        public decimal output;

        public Test(string _input, decimal _output)
        {
            input = _input;
            output = _output;
        }

        public void Check(decimal calculated)
        {
            string equalNotEqual;
            if (output == calculated)
            {
                Console.WriteLine("Passed");
                equalNotEqual = "==";
            }
            else
            {
                Console.WriteLine("Failed");
                equalNotEqual = "!=";
            }
            Console.WriteLine($"{input} {equalNotEqual} {calculated}");
        }

    }

    class Calculator
    {
        Regex numberSplitter = new Regex(@"\s*[\+\-\*\/]\s*");

        public decimal Calculate(string input)
        {
            string[] numberStrings = numberSplitter.Split(input);
            decimal[] numbers = new decimal[numberStrings.Length];
            for (int i = 0; i < numberStrings.Length; i++)
            {
                numbers[i] = Convert.ToDecimal(numberStrings[i]);
            }

            MatchCollection operatorMatches = numberSplitter.Matches(input);
            char[] operatorStrings = new char[operatorMatches.Count];
            for (int i = 0; i < operatorMatches.Count; i++)
            {
                operatorStrings[i] = operatorMatches[i].Value.Trim()[0];
            }

            decimal result = Convert.ToDecimal(numberStrings[0]);
            for (int i = 0; i < operatorStrings.Length; i++)
            {
                result = Combine(result, operatorStrings[i], numbers[i + 1]);
            }

            return result;
        }

        private decimal Combine(decimal m0, char op, decimal m1)
        {
            if (op == '+')
            {
                return m0 + m1;
            }
            else if (op == '-')
            {
                return m0 - m1;
            }
            else if (op == '*')
            {
                return m0 * m1;
            }
            else if (op == '/')
            {
                return m0 / m1;
            }

            return 0m;
        }
    }
}