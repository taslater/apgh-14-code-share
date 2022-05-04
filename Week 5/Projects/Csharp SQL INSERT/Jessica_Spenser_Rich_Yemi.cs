using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite;

namespace SQLtrial
{
    class Program
    {
        static void Main(string[] args)
        {

            SQLiteConnection connection = new SQLiteConnection(@"Data Source = /Users/jessicayockey/Desktop/databases/mydatabase.sqlite");

            connection.Open();

            //Ask the user if they want to show the address book or add to the address book

            bool keepGoing = true;

            while (keepGoing)
            {

                Console.WriteLine("Welcome to your Rolodex, would you like to view or add to the address book?");
                Console.WriteLine("a) View\nb) Add to\nc) Quit");
                string answer = Console.ReadLine().ToLower();

                if (answer == "c")
                {
                    keepGoing = false;
                }

                //If show, list all of the names and addresses or phone numbers

                if (answer == "a")
                {
                    SQLiteCommand command = new SQLiteCommand("SELECT * FROM Addresses", connection);

                    SQLiteDataReader dataReader = command.ExecuteReader();

                    //if (dataReader.HasRows) //.HasRows checks if the database table has information stored within it. If no information exists, the while loop won't run
                    //{
                    while (dataReader.Read())
                    {
                        Console.WriteLine(dataReader["Name"]);
                        Console.WriteLine(dataReader["Phone"]);
                        Console.WriteLine(dataReader["Address"]);
                        Console.WriteLine(dataReader["City"]);
                        Console.WriteLine(dataReader["Zip"]);
                        Console.WriteLine();
                    }
                    //}
                    dataReader.Close();

                }

                //If add, ask the user for the name, address (or phone number), add those as a new row to the data base

                if (answer == "b")
                {

                    Console.WriteLine("I'm gonna need the following info: Name, Phone Number, Address, City, and Zip Code.");
                    string a = Console.ReadLine();
                    //char.ToUpper(name[0]);
                    string b = Console.ReadLine();
                    string c = Console.ReadLine();
                    string d = Console.ReadLine();
                    string e = Console.ReadLine();

                    SQLiteCommand command = new SQLiteCommand($"INSERT INTO Addresses ([Name], [Phone], [Address], [City], [Zip]) VALUES ('{a}','{b}', '{c}', '{d}', '{e}')", connection);

                    command.ExecuteNonQuery();

                }

                //show the menu again
            }
            connection.Close();
        }
    }
}
