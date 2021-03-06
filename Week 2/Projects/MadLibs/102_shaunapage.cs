using System;

namespace decoder_ring
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is the madlib we'll be defining'
            string madlib = "I wanted to go my favorite bar [animal]" +
            "I left home without my [noun]. \n ";
            //"I never leave home without my [noun]! " +
            //"\n Instead I stayed home and baked [noun] ";
            //words that define the madlib that we'll be replacing
            string[] words = new string[100];
            //Array that defines the replacement words
            string[] answers = new string[100];
            //start variable
            int start = 0;
            //end variable
            int end = 0;

            //Console.WriteLine("Please give us a noun. ");

            //tells us how many times to search for replacement words
            while ((madlib.Split('[').Length - 1) > 0)
            {
                //tells us the number of times we need to replace words 
                Console.WriteLine(madlib.Split('[').Length - 1);
                //tells us to search through every character of the madlib
                for (int i = 0; i < madlib.Length; i++)
                //if function: tells us to look for the start brackets
                {
                    if (madlib[i] == '[')
                    {
                        //Console.WriteLine(i);
                        start = i;
                    }
                    //tells us to look for the end brackets 
                    if (madlib[i] == ']')
                    {
                        //Console.WriteLine(i);
                        end = i;
                    }
                }
                //formatting of a substring is : madlib.Substring(int start, int length)
                //madlib.Replace(search for, replacement)

                //tells the user the instances that need replaced
                Console.WriteLine("Please enter a " + madlib.Substring(start, end - start + 1));
                //defines user's response as the answer
                answers[0] = Console.ReadLine();
                //defines a particular word to be replaced w/ start and ends of brackets
                words[0] = madlib.Substring(start, end - start + 1);
                //replaces that particuar word w/ that particualr answer
                Console.WriteLine(madlib.Replace(words[0], answers[0]));
                //makes changes within madlib at each individual instance
                madlib = madlib.Replace(words[0], answers[0]);
            }
        }
    }
}