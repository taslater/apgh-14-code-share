using System;
using System.Data.SqlClient;

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
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AcademyPGH\source\repos\Twitter\Twitter\Database1.mdf;Integrated Security=True");

            //establish command and reader variables so we don't have to reestablish them deeper in the loops
            SqlDataReader reader;
            SqlCommand command;

            //open connection
            connection.Open();
            //display menu
            Console.WriteLine("What would you like to do? \na)Write tweet \nb)See feed");
            //establishing variable for user's response
            string input = Console.ReadLine().ToLower();

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
                    Console.WriteLine("Message: " + reader["Text"] + "Time Posted: " + reader["TimePosted"]);
                }
                reader.Close();
            }
        }
    }
}

