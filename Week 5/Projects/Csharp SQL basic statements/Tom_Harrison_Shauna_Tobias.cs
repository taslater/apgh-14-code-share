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
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\H\source\repos\week5kata\Database1.mdf;Integrated Security=True");
            connection.Open();
            bool running = true;
            while (running)

            {
                // main menu
                Console.WriteLine("Show address book (a), Add address (b), Change Enty (c), Delete Entry (g); Quit (q)? ");
                string menuchoice = Console.ReadLine().ToLower();

                if (menuchoice == "a")
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM AddressTest", connection);
                    SqlDataReader getsreader = command.ExecuteReader();
                    Console.WriteLine("Here you go!");

                    while (getsreader.Read())
                    {
                        //here we set up a nice pretty display of each row / all the data
                        Console.WriteLine(getsreader["ID"]);
                        Console.WriteLine(getsreader["Name"]);
                        Console.WriteLine(getsreader["Address"]);
                        Console.WriteLine();
                    }
                    getsreader.Close();
                    // no more info from that reader
                }

                else if (menuchoice == "b")
                {
                    Console.WriteLine("Let's add your friend.");
                    Console.WriteLine("Name?");
                    string newname = Console.ReadLine();
                    Console.WriteLine("Address?");
                    string newaddress = Console.ReadLine();
                    SqlCommand command = new SqlCommand($"INSERT INTO AddressTest (Name, Address) VALUES ('{newname}', '{newaddress}')", connection);

                    command.ExecuteNonQuery();
                    // runs with no return after adding
                    Console.WriteLine();
                    // a nice space to take a breath *phew*
                }

                else if (menuchoice == "c")
                {

                    Console.WriteLine("What is the id number of the entry you would like to change?");
                    int idnumber = Convert.ToInt32(Console.ReadLine());

                    SqlCommand command = new SqlCommand($"SELECT * FROM AddressTest WHERE Id={idnumber}", connection);
                    SqlDataReader getsreader = command.ExecuteReader();
                    Console.WriteLine("Here you go!");

                    while (getsreader.Read())
                    {
                        Console.WriteLine($"{getsreader["Id"]}, {getsreader["Name"]}, {getsreader["Address"]}");
                        //displays on one line unlike the nice pretty menu above
                    }
                    getsreader.Close();

                    Console.WriteLine("Change Name (a), Change Address (b), Change City(c), or back to main menu (d)");
                    menuchoice = Console.ReadLine();
                    // sub-menu babbyyyyyyy!!

                    if (menuchoice == "a")
                    {
                        Console.WriteLine("What is the new name?");
                        string changename = Console.ReadLine();

                        command = new SqlCommand($"UPDATE AddressTest SET Name = '{changename}' WHERE Id={idnumber}", connection);

                        command.ExecuteNonQuery();
                        Console.WriteLine();
                        // still phew
                    }

                    else if (menuchoice == "b")
                    {
                        Console.WriteLine("What is the new address?");
                        string changeaddress = Console.ReadLine();

                        command = new SqlCommand($"UPDATE AddressTest SET Address = '{changeaddress}' WHERE Id={idnumber}", connection);

                        command.ExecuteNonQuery();
                        Console.WriteLine();
                        //wow it works
                    }

                    else if (menuchoice == "c")
                    {
                        Console.WriteLine("What is the new city?");
                        string changecity = Console.ReadLine();

                        command = new SqlCommand($"UPDATE AddressTest SET City = '{changecity}' WHERE Id={idnumber}", connection);

                        command.ExecuteNonQuery();
                        Console.WriteLine();
                        //phew
                    }
                }

                else if (menuchoice == "d")
                {
                    Console.WriteLine("What is the id number of the entry you would like to delete?");
                    int idnumber = Convert.ToInt32(Console.ReadLine());

                    SqlCommand command = new SqlCommand($"Delete AddressTest WHERE Id={idnumber}", connection);

                    command.ExecuteNonQuery();
                    Console.WriteLine("Your entry has been deleted");
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
        }
    }
}
