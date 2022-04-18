{
    {
        MessageAndName[] voicemail = new MessageAndName[3];
        string[] messages = new string[3];
        int numberofmessage = 0;
        bool on = true;
        while (on)
        {
            Console.WriteLine("Please choose A, B, or C:");
            Console.WriteLine("A: Save a message");
            Console.WriteLine("B: Retrieve a message");
            Console.WriteLine("C: Exit system");
            string response = Console.ReadLine().ToLower();
            {
                if (response == "a")
                {
                    voicemail[numberofmessage] = new MessageAndName();
                    Console.WriteLine("What is your message?");
                    voicemail[numberofmessage].message = Console.ReadLine();

                    Console.WriteLine("What is your name?");
                    voicemail[numberofmessage].name = Console.ReadLine();
                    numberofmessage++;
                }
                else if (response == "b")
                {
                    Console.WriteLine("Enter number to retrieve message (start with 0)");
                    int code = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(voicemail[code].message);
                    Console.WriteLine("from: " + voicemail[code].name);
                }
                else if (response == "c")
                {
                    on = false;
                    Console.WriteLine("Goodbye");
                    Console.ReadLine();
                }
            }
        }
    }
}
class MessageAndName
{
    public string message;
    public string name;
}
