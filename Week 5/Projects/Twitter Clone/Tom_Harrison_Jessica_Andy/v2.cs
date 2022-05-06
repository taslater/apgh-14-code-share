using System;
using System.Data.SqlClient;

namespace twitterclone
{
    class Program
    {
        static void Main(string[] args)
        {

            //           ==**~~ Twitter Clone ~~**==

            // Lets you say what user you are
            // Lets you post things
            // Lets you see a list of posts from all people
            // - in chronological order

            // Tables:
            // [Users]
            // Id
            // Name
            // Handle


            // [Messages]
            // Id
            // Time Posted
            // UserId
            // Text

            Console.WriteLine("Welcome to Twatter! What is your username?");
            string username = Console.ReadLine();

            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\H\source\repos\twitterclone\twitterclonedb.mdf;Integrated Security=True");
            connection.Open();

            SqlCommand finduserCommand = new SqlCommand($"Select Id FROM Users WHERE Username = '{username}'", connection);
            SqlDataReader reader = finduserCommand.ExecuteReader();

            int userId = 0;
            bool loggedin = false;


            while (reader.Read())
            {
                userId = Convert.ToInt32(reader["Id"]);
            }
            Console.WriteLine(userId);

            if (userId != 0)
            {
                Console.WriteLine($"found Id {userId}");
                loggedin = true;

            }
            else
            {
                Console.WriteLine("User not found, goodbye!");

            }
            reader.Close();

            long multiplier = 60L * 10000 * 1000;

            while (loggedin)
            {
                Console.WriteLine("What would you like to do? A) Post your twoughts B) Look at twoughts Q) Quit");
                string option = Console.ReadLine().ToLower();

                if (option == "a")
                {
                    Console.WriteLine("What is your twoot?");
                    string twoot = Console.ReadLine();

                    //Console.WriteLine(DateTime.Now.Hour);
                    //Console.WriteLine(DateTime.Now.Minute);

                    long currentTime = DateTime.Now.Ticks / (multiplier);
                    int currenttime = Convert.ToInt32(currentTime);

                    //~~~~~~~~~ SQL to create message ~~~~~~~~~
                    //INSERT INTO Messages (Text, Time, UserId) VALUES ('This is a new message', 1350, 3);

                    SqlCommand newtwat = new SqlCommand($"INSERT INTO Messages (Text, Time, UserId) VALUES ('{twoot}', '{currenttime}', {userId})", connection);

                    newtwat.ExecuteNonQuery();
                }
                else if (option == "b")
                {
                    //~~~~~~~~~ SQL to display messages ~~~~~~~~~
                    //SqlCommand finduserCommand = new SqlCommand("Select * FROM Messages", connection);
                    //SqlDataReader reader = finduserCommand.ExecuteReader();

                    //while (reader.Read())
                    //{
                    //    Console.WriteLine(reader["Text"]);
                    //}
                    //reader.Close();
                    //connection.Close();

                    SqlCommand getall = new SqlCommand("SELECT Messages.Text, Messages.Time, Users.Username, Users.Handle FROM Messages JOIN Users ON Users.Id = Messages.UserId ORDER BY Messages.Time DESC", connection);

                    SqlDataReader reader2 = getall.ExecuteReader();

                    while (reader2.Read())
                    {
                        long bigtime = Convert.ToInt64(reader2["Time"]) * multiplier;
                        DateTime dt = new DateTime(bigtime);
                        Console.WriteLine($"{reader2["Handle"]}, {dt},\n {reader2["Text"]}");
                    }
                    reader2.Close();

                }
                else if (option == "q")
                {
                    loggedin = false;
                }
                else
                {
                    Console.WriteLine("does not compute");
                }
            }
        }
    }
}
