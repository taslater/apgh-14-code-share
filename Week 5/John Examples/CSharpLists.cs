using System;
using System.Collections.Generic;
using System.Linq;

namespace Session14dbstuff
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[3];
            names[0] = "John";
            names[1] = "Jean";
            names[2] = "Saturn";

            List<string> otherNames = new List<string>();
            otherNames.Add("John");
            otherNames.Add("Jean");
            otherNames.Add("Saturn");
            otherNames.Add("Mars");


            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            for (int i = 0; i < otherNames.Count; i++)
            {
                Console.WriteLine(otherNames[i]);
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            foreach (string name in otherNames)
            {
                Console.WriteLine(name);
            }

            names[1] = "The Jean";
            otherNames[1] = "The other Jean";

            List<string> jnames = otherNames.Where(s => s.ToLower().Contains("j")).ToList();
            foreach (string name in jnames)
            {
                Console.WriteLine(name);
            }


            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
