using System;

namespace decoder_ring
{
    class Program
    {
        static void Main(string[] args)
        {
            string madlib = "The world's best [noun]";
            int start = 0;
            int end = 0;
            Console.WriteLine("Please give us a noun . ");
            string answer1 = Console.ReadLine();

            for (int i = 0; i < madlib.Length; i++)
            {
                if (madlib[i] == '[')
                {


                    Console.WriteLine(i);
                    start = i;
                }
                if (madlib[i] == ']')
                {
                    Console.WriteLine(i);
                    end = i;
                }
            }
            //formatting of a substring is : madlib.Substring(int start, int length)
            //madlib.Replace(search for, replacement)

            Console.WriteLine(madlib.Substring(start, end - start + 1));
            string word1 = madlib.Substring(start, end - start + 1);
            Console.WriteLine(madlib.Replace(word1, answer1));



        }
    }
}
