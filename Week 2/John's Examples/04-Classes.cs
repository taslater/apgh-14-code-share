using System;
using System.Collections.Generic;

namespace Session14Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[10];
            string[] phones = new string[10];
            string[] address = new string[10];

            Person anyVariableNameIWant = new Person();
            anyVariableNameIWant.Name = "John";
            anyVariableNameIWant.Phone = "123";
            anyVariableNameIWant.Address = "820 Brookline";

            Person[] people = new Person[10];


            for (int i = 0; i < 3; i++)
            {
                people[i] = new Person();
                Console.WriteLine("Give me a name");
                people[i].Name = Console.ReadLine();

                Console.WriteLine("Give me a phone number");
                people[i].Phone = Console.ReadLine();

                Console.WriteLine(people[i].Address);
            }


        }
    }

    class Person
    {
        public string Name;
        public string Phone;
        public string Address;
    }
}
