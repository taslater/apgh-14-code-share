using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Twitter
{
    class Program
    {
        static void Main(string[] args)
        //Lets you say what user you are

        //Lets you post things

        //Lets you see a list of posts from all people
        //- in chronological order

        {
            //establish connection
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AcademyPGH\source\repos\TwitterClone\TwitterClone\Database1.mdf;Integrated Security=True");

            //establish command, reader, looping variables so we don't have to reestablish them deeper in the loops
            SqlDataReader reader;
            SqlCommand command;
            bool keepgoing = true;

            //open connection
            connection.Open();

            Console.WriteLine("Please enter your User Name");
            string userName = Console.ReadLine();
            command = new SqlCommand($"SELECT Id FROM Users WHERE Users = '{userName}'", connection);
            //asking the user for their username and using that input to compare to our Users table


            reader = command.ExecuteReader();
            int ID = 0;
            //start the reader and create a alterable ID variable

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ID = Convert.ToInt32(reader["Id"]);
                    //inside the reader: converter the ID variable from line 31 to a c# variable; to use later
                }
                reader.Close();
                //close reader
            }


            while (keepgoing == true)
            {
                //display menu
                Console.WriteLine("What would you like to do? \na)Write tweet \nb)See feed \nq) quit");
                //establishing variable for user's response
                string input = Console.ReadLine().ToLower();

                if (input == "a")
                {
                    Console.WriteLine("What would you like to say? (280 chars)?");
                    string text = Console.ReadLine();
                    //take in user message as text
                    DateTime timeposted = Convert.ToDateTime(DateTime.Now);
                    //record the time of user message via datetime.now

                    command = new SqlCommand($"INSERT INTO Messages ([TimePosted],[UserId],[Text]) VALUES ('{timeposted}', {ID} ,'{text}')", connection);
                    command.ExecuteNonQuery();
                    //plug all our variables into the insert function to craft a complete tweet
                    //text and timeposted taken from above and ID taken from sign in 
                }

                if (input == "b")
                {
                    //pulls data from Messages and Users table and joins based on UserID
                    command = new SqlCommand("SELECT * FROM Messages JOIN Users ON Messages.UserID = Users.Id ORDER BY TimePosted", connection);

                    //start the reader
                    reader = command.ExecuteReader();

                    //complete loop to go through all messages
                    while (reader.Read())
                    {
                        //displays the user and then message and when it was posted in chonological order
                        Console.WriteLine("User: " + reader["Users"]);
                        Console.WriteLine("Message: " + reader["Text"] + " Time Posted: " + reader["TimePosted"]);
                        Console.WriteLine();
                    }
                    reader.Close();
                }

                if (input == "q")
                {
                    keepgoing = false;
                    connection.Close();
                    //ends the while loop of the menu and closes connection to the databases
                }
            }
        }

    }
}
