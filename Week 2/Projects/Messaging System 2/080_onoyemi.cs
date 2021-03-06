using System;

namespace MessageSystem
{
    class Message
    {
        public string Name;
        public string Text;


        public void Print()
        {
            Console.WriteLine($"My name is {Name}. My text is {Text}.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // can you store and call a message using classes instead of functions
            // Make a system that allows you to either a) save a message or b) retrieve a message
            // When saving, return a # that the user can use to retrieve a message
            // When retrieving, allow a user to put in a # to see the message saved

            // create a class that is person, message
            // class = message (name and text combined)
            // create an array of person message classes
            // then create an instance of a class
            // fill out instances? will have stored a text and a name attached to it
            // ask if they want to leave or retrieve a message (text)
            // leave: ask for text and name
            // retrieve: ask for name
            // run through array until we find name
            // print name and text

            Message instance = new Message();
            Console.WriteLine("What name?");
            string input1 = Console.ReadLine();
            Console.WriteLine("What Text?");
            string input2 = Console.ReadLine();
            instance.Name = input1;
            instance.Text = input2;
            instance.Print();

            //Message instance2 = new Message();
            //instance2.Print();

        }
    }
}
