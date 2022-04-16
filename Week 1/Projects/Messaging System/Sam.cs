
namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (counter < 3)
            {
                Console.WriteLine("Would you like to create or retrieve a message? (C/R)");
                string input = Console.ReadLine();
                string[] messages = new string[100];
                if (input == "C")
                {
                    Console.WriteLine("Let's create a message!");
                    messages[0] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Let's retrieve your message!");
                }
                Console.WriteLine(messages[0]);
                counter++;
            }



        }
    }
}
