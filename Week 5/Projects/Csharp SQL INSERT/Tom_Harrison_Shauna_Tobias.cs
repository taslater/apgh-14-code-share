using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data.SQLite;

//Ask the user if they want to show address book or add to address book
//If show, list all of the names and addresses (or phone numbers)
//If add, ask the user for the name, address (or phone number), add those as a new row to the database
//Show the menu again

namespace Session14dbstuff
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source= /Users/shaunapage/Desktop/database/mydatabase.sqllite;");
            connection.Open();
            SQLiteCommand getscommand = new SQLiteCommand("SELECT * FROM Address", connection);
            bool running = true;
            while (running)

            {
                Console.WriteLine("Show address book (a), Add address (b), Quit (q)? ");
                string menuchoice = Console.ReadLine().ToLower();

                if (menuchoice == "a")
                {

                    SQLiteDataReader getsreader = getscommand.ExecuteReader();
                    Console.WriteLine("Here you go!");

                    while (getsreader.Read())
                    {
                        Console.WriteLine(getsreader["Name"]);
                        Console.WriteLine(getsreader["Address"]);
                        Console.WriteLine(getsreader["Phone"]);
                        Console.WriteLine();
                    }
                    getsreader.Close();
                }
                else if (menuchoice == "b")
                {
                    Console.WriteLine("Let's add your friend.");
                    Console.WriteLine("Name?");
                    string newname = Console.ReadLine();
                    Console.WriteLine("Address?");
                    string newaddress = Console.ReadLine();
                    SQLiteCommand newcommand = new SQLiteCommand($"INSERT INTO Address (Name, Address) VALUES ('{newname}', '{newaddress}')", connection);

                    newcommand.ExecuteNonQuery();
                    Console.WriteLine();
                }
                else if (menuchoice == "q")
                {
                    Console.WriteLine("Have a good day!");
                    running = false;
                }
                else
                {
                    Console.WriteLine("Nope; Try again.");
                }
            }




            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Address", connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["Name"]);
            }
            reader.Close();

            connection.Close();
            Console.ReadLine();
        }
    }
}
