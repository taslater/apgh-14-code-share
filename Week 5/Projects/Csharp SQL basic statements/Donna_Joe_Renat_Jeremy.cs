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


            //determines data source for connection
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AcademyPGH\source\repos\SQL\SQL\Database1.mdf;Integrated Security=True");
            //opens connection
            connection.Open();
            //boolean to loop menu
            bool keeprunning = true;
            while (keeprunning)
            {
                //provide option menu
                Console.WriteLine("Welcome to the address book \nWhat would you like to do? \na)Show data from address book \nb)Add data to address book \nc)Edit an entry \nd)Delete entry\nq)Exit");
                string response = Console.ReadLine().ToLower();

                //pulls data from database
                SqlCommand command = new SqlCommand("SELECT * FROM Addresses", connection);

                if (response == "a")
                {
                    //executes the reader
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        //writes back whats in the database
                        Console.Write("ID: " + reader["Id"] + " Name: " + reader["Name"] + " Phone: " + reader["Phone"] + " Address: " + reader["Address"] + " City: " + reader["City"] + " Zip: " + reader["Zip"]);
                        Console.WriteLine();
                    }
                    reader.Close();
                }

                if (response == "b")
                {
                    //asks user for the data to add
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


                    //command to add data into appropriate columns
                    command = new SqlCommand("INSERT INTO Addresses([Name], [Phone], [Address], [City], [Zip]) VALUES(@name, @phone, @address, @city, @zip)", connection);
                    {
                        //links the variables together for insertion
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@phone", phone);
                        command.Parameters.AddWithValue("@address", address);
                        command.Parameters.AddWithValue("@city", city);
                        command.Parameters.AddWithValue("@zip", zip);

                        //executes the insert
                        command.ExecuteNonQuery();
                    }

                }
                if (response == "c")
                {
                    Console.WriteLine("Which would you ID do you want to edit?");
                    int ID = Convert.ToInt32(Console.ReadLine()); //converting ID to an interger
                    Console.WriteLine("Which field would you like to edit? (ie. Name, Phone, Address, City, Zip");
                    string field = Console.ReadLine();
                    Console.WriteLine("Please provide update.");
                    string update = Console.ReadLine();

                    command = new SqlCommand($"UPDATE Addresses SET {field} ='{update}' WHERE ID = {ID}", connection);
                    {
                        //can't use these command parameters to update field. Only values
                        //command.Parameters.Add("@ID", System.Data.SqlDbType.Int);
                        //command.Parameters[@ID].Value = ID;
                        //command.Parameters.AddWithValue("@field", field);
                        //command.Parameters.AddWithValue("@update", update);

                        //executes update
                        command.ExecuteNonQuery();
                    }
                }
                if (response == "d")
                {
                    Console.WriteLine("Which ID would you like to delete?");
                    int ID = Convert.ToInt32(Console.ReadLine());
                    command = new SqlCommand($"DELETE FROM Addresses WHERE ID={ID}", connection);
                    command.ExecuteNonQuery();
                }
                if (response == "q")
                {
                    //ends loop
                    keeprunning = false;
                    //closes connection
                    connection.Close();
                }
            }
        }
    }
}


