using System;

namespace RomanNumeralKata01
{
    class Program
    {
        static void Main(string[] args)
        {   //Create a message storage and retrieval system
            //Show a menu that offers the user options on what they can do
            //Delete a message, or replace
            //Fixed size array, if we add too many messages, write a message that says you cannot do that
            //If someone asks for a message number that doesn't exist, have a message saying that that one does not exist
            Person[] allMessages = new Person[10];
            int index = 0;
            int on = 1;
            // create a person array to store our variables
            //replace the individual arrays with class array in for loop
            while (on == 1)
            {
                Console.WriteLine("Please make a choice ");
                Console.WriteLine("A. Save a message ");
                Console.WriteLine("B. Retrieve a message ");
                Console.WriteLine("C. Delete a Message");
                Console.WriteLine("D. Exit ");
                string reply = Console.ReadLine().ToLower();

                if (reply == "a")
                {
                    if (index <= allMessages.Length - 1)
                    {
                        //ask for a name
                        //read & store that name
                        //create an array
                        //create a class if time allows

                        allMessages[index] = new Person();
                        Console.WriteLine("Please leave your name.");
                        allMessages[index].name = Console.ReadLine();
                        Console.WriteLine("Please leave a message ");
                        allMessages[index].message = Console.ReadLine();
                        Console.WriteLine("Your message number is: " + index);
                        index = index + 1;
                    }
                    else
                    {
                        Console.WriteLine("Your messages are full.");
                    }
                }
                else if (reply == "b")

                {
                    //else statment- add console write line for name & msg being retreived

                    Console.WriteLine("Please give a message number ");

                    int id = Convert.ToInt32(Console.ReadLine());
                    if (id > index)
                    {
                        Console.WriteLine("Your message doesn't exists");
                    }
                    else
                    {
                        Console.WriteLine(allMessages[id].name + " left you a message!");
                        Console.WriteLine(allMessages[id].message);
                    }
                }

                //else if (reply == "c")
                //{
                //Console.WriteLine("What is the number of the message you would like to delete?");
                //int id = Convert.ToInt32(Console.ReadLine());
                //messages[id] = "This message doesn't exist, spooky";
                //Console.WriteLine("Your message has been deleted");
                //}

                else if (reply == "d")
                {
                    on = 0;
                }
                else
                {
                    Console.WriteLine("Option does not exist. Please enter either A, B, C, or D.");

                }
            }
        }
        class Person
        {
            public string name;
            public string message;

        }
    }
}