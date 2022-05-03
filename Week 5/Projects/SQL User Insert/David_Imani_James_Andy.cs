
//Andy, David, Imani, James; Team 1: Fun, Fun, Fun
using System;
using System.Data.SqlClient;

namespace DatabaseTry
{
    class Program
    {
        static void Main(string[] args)
        {
            //I named my table 'Addresses' and has the columns "Name, Street, City, Zip, Phone"

            // Create the variable connection that is a SQL connection
            SqlConnection connection;
            //Define connection such that it connects to where the database is stored, this is called the connection string (right click on database in Server Explorer)
            connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\andre\source\repos\DatabaseTry\DatabaseTry\Database1.mdf; Integrated Security = True");

            //Boolean variable to keep the while loop going
            bool tableMore = true;

            while (tableMore)
            {
                //Display a menu of what options to pick from and take in the answer
                Console.WriteLine("Would you like to: \nA: Display table info? \nB: Add info to table?\nQ: Quit");
                string task = Console.ReadLine().ToUpper();

                //Open the connection to the database (this needs to be inside the while loop or it breaks)
                connection.Open();
                //Create an empty command and reader variable
                SqlCommand command;
                SqlDataReader reader;
                //If user selects Display table from menu do this
                if (task == "A")
                {
                    //Define command as a new command that ask for all the data in the table, store that data in reader
                    command = new SqlCommand("SELECT * FROM Addresses", connection);
                    reader = command.ExecuteReader();

                    //While loop to print out all the data stored in reader
                    while (reader.Read())
                    {
                        Console.WriteLine($"Name: {reader["Name"]} | Street address: {reader["Street"]} | Phone number: {reader["Phone"]}");
                    }
                    //It's polite to close the reader when done with it.
                    reader.Close();
                }

                //If the user wants to add data to the table
                else if (task == "B")
                {
                    //Ask the user for the data for each column in the table and store the data in variables
                    Console.WriteLine("What name do you want to add?");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is the name of the street?");
                    string street = Console.ReadLine();
                    Console.WriteLine("What is the name of the city");
                    string city = Console.ReadLine();
                    Console.WriteLine("What is the zip code?");
                    string zip = Console.ReadLine();
                    Console.WriteLine("What is the phone number?");
                    string phone = Console.ReadLine();

                    //Create a command, variable name 'addinfo' to insert the data gathered into the table
                    SqlCommand addinfo = new SqlCommand($"INSERT INTO Addresses (Name, Street, City, Zip, Phone) VALUES ('{name}', '{street}', '{city}', '{zip}', '{phone}')", connection);
                    //Execute the command we just wrote
                    addinfo.ExecuteNonQuery();

                    //Display the address book after adding in gathered data; same as selecting A
                    command = new SqlCommand("SELECT * FROM Addresses", connection);
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine($"Name: {reader["Name"]} | Street address: {reader["Street"]} | Phone number: {reader["Phone"]}");
                    }
                    //Politely close the reader
                    reader.Close();
                }


                else if (task == "Q")
                {
                    tableMore = false;
                }

                else
                {
                    Console.WriteLine("Did not compute, beep boop");
                }
                //Close the connection
                connection.Close();
            }
        }
    }
}



