using System;
using System.Data.SqlClient;

namespace Twater
{
    class Program
    {
        static void Main(string[] args)
        {

            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\emetr\source\repos\Twater\Twater\Database1.mdf;Integrated Security=True");
            connection.Open();

            SqlCommand command;
            SqlDataReader reader;

            int signinID = 0;

            bool signin = false;
            while (!signin)
            {
                Console.WriteLine("What's your handle?");
                string userHandle = Console.ReadLine();
                Console.WriteLine("What's your password?");
                string userPW = Console.ReadLine();

                command = new SqlCommand("SELECT * FROM users", connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (userPW == reader["password"].ToString() && userHandle == reader["handle"].ToString())
                    {
                        signinID = Convert.ToInt32(reader["Id"]);
                        signin = true;
                    }
                }
                reader.Close();

                while (signin)
                {
                    // menu

                    Console.WriteLine("Welcome to Twater, you twat. What do you want?\na) View User Info\nb) View Feed\nc) Write Message\nd) Exit ");
                    string whatitdo = Console.ReadLine().ToLower();


                    if (whatitdo == "a")
                    {

                        command = new SqlCommand($"SELECT * FROM users WHERE Id = {signinID}", connection);
                        reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"{reader["Name"]}\n{reader["Handle"]}\n");
                            }
                        }
                        reader.Close();
                    }

                    if (whatitdo == "b")
                    {

                        //command = new SqlCommand("SELECT * FROM messages JOIN users ON users.Id = messages.UserID ORDER BY time DESC", connection);
                        command = new SqlCommand($"SELECT * FROM messages JOIN users ON users.Id = messages.UserID JOIN followers ON users.Id = followers.UserFollowedID WHERE followers.userID = {signinID} ORDER BY time DESC", connection);
                        reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"{reader["Name"]} {reader["Handle"]}\n{reader["Text"]}\n{reader["Time"]}\n");
                            }
                        }
                    }

                    if (whatitdo == "c")
                    {
                        Console.WriteLine("What do you want to publish on the internet forever?");
                        string message = Console.ReadLine();

                        command = new SqlCommand($"INSERT INTO messages (userID, Text, Time) VALUES ({signinID}, '{message}', '{DateTime.Now}' )", connection);
                        command.ExecuteNonQuery();
                    }

                    if (whatitdo == "d")
                    {
                        signin = false;
                    }
                }
                connection.Close();
            }
        }
    }
}

