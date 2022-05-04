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

            SQLiteConnection connection = new SQLiteConnection(@"Data Source =/Users/rich/Desktop/databases/mydatabase.sqlite");

            connection.Open();

            //Ask the user if they want to show the address book or add to the address book

            bool keepGoing = true;

            while (keepGoing)
            {

                Console.WriteLine("Welcome to your Rolodex, would you like to view or add to the address book?");
                Console.WriteLine("a) View\nb) Add to\nc) Edit \ne) Quit \nd) Delete");
                string answer = Console.ReadLine().ToLower();

                if (answer == "e")
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
                        Console.WriteLine(dataReader["Id"]);
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
                if (answer == "c") // allows user to edit
                {
                    Console.WriteLine("What column would you like to change?");
                    Console.WriteLine("a) name");
                    Console.WriteLine("b) phone");
                    Console.WriteLine("c) address");
                    Console.WriteLine("d) city");
                    Console.WriteLine("e) zip");
                    string change = Console.ReadLine(); // stores user answer into change variable

                    //nested if's required for each column

                    if (change == "a") // allows user to update name per row
                    {
                        Console.WriteLine("where will you be making changes?");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("what's the new name??");
                        string newName = Console.ReadLine();
                        SQLiteCommand command = new SQLiteCommand($"UPDATE addresses SET name = '{newName}' WHERE Id = {id}", connection);

                        command.ExecuteNonQuery();

                    }
                    if (change == "b") // allows user to update phone per row
                    {
                        Console.WriteLine("where will you be making changes?");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("what's the new phone number??");
                        int newPhone = Convert.ToInt32(Console.ReadLine());
                        SQLiteCommand command = new SQLiteCommand($"UPDATE addresses SET phone = {newPhone} WHERE Id = {id}", connection);

                        command.ExecuteNonQuery();
                    }
                    if (change == "c") // allows user to change address per row
                    {
                        Console.WriteLine("where will you be making changes?");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("what's the new address??");
                        string newAddress = Console.ReadLine();
                        SQLiteCommand command = new SQLiteCommand($"UPDATE addresses SET address = '{newAddress}' WHERE Id = {id}", connection);

                        command.ExecuteNonQuery();
                    }
                    if (change == "d") // allows user to change city per row
                    {
                        Console.WriteLine("where will you be making changes?");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("what's the new city??");
                        string newCity = Console.ReadLine();
                        SQLiteCommand command = new SQLiteCommand($"UPDATE addresses SET city = '{newCity}' WHERE Id = {id}", connection);

                        command.ExecuteNonQuery();
                    }
                    if (change == "e") // allows user to change zip PER ROW
                    {
                        Console.WriteLine("where will you be making changes?");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("what's the new zip??");
                        int newZip = Convert.ToInt32(Console.ReadLine());
                        SQLiteCommand command = new SQLiteCommand($"UPDATE addresses SET zip = {newZip} WHERE Id = {id}", connection);

                        command.ExecuteNonQuery();
                    }



                }

                if (answer == "d") // allows user to delete entry in specific row
                {
                    Console.WriteLine("Which id would you like to delete?");
                    int delete = Convert.ToInt32(Console.ReadLine());


                    SQLiteCommand command = new SQLiteCommand($"DELETE FROM Addresses WHERE Id = {delete}", connection);

                    command.ExecuteNonQuery();
                }

                //show the menu again
            }
            connection.Close();
        }
    }
}
