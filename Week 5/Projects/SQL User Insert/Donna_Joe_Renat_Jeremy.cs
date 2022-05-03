using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user if they want to show address book or add to address book
            //If show, list all of the names and addresses(or phone numbers)
            //If add, ask the user for the name, address (or phone number), add those as a new row to the database
            //Show the menu again

            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AcademyPGH\source\repos\SQL\SQL\Database1.mdf;Integrated Security=True");
            connection.Open();
            bool keeprunning = true;
            while (keeprunning)
            {
                Console.WriteLine("Welcome to the address book \nWhat would you like to do? \na)Show data from address book \nb)Add data to address book \nc)exit");
                string response = Console.ReadLine();


                SqlCommand command = new SqlCommand("SELECT * FROM Addresses", connection);

                if (response == "a")
                {

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.Write("Name: " + reader["Name"] + " Address: " + reader["Address"]);
                        Console.WriteLine();
                    }
                    reader.Close();
                }

                if (response == "b")
                {
                    Console.WriteLine("Please provide the name.");
                    string name = Console.ReadLine();
                    Console.WriteLine("Please provide the phone.");
                    string phone = Console.ReadLine();
                    Console.WriteLine("Please provide the address.");
                    string address = Console.ReadLine();
                    Console.WriteLine("Please provide the city.");
                    string city = Console.ReadLine();
                    Console.WriteLine("Please provide the zip.");
                    string zip = Console.ReadLine();

                    command = new SqlCommand("INSERT INTO Addresses([Name], [Phone], [Address], [City], [Zip]) VALUES(@name, @phone, @address, @city, @zip)", connection);
                    {
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@phone", phone);
                        command.Parameters.AddWithValue("@address", address);
                        command.Parameters.AddWithValue("@city", city);
                        command.Parameters.AddWithValue("@zip", zip);

                        command.ExecuteNonQuery();
                    }
                }
                if (response == "c")
                {
                    keeprunning = false;
                    connection.Close();
                }


                Console.ReadLine();
            }
        }
    }
}

