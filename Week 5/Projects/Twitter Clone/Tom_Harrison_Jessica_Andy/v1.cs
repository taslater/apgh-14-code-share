using System;
using System.Data.SQLite;
namespace TwitterDB
{
    class Program
    {
        static void Main(string[] args)
        {
            //=== Twitter Clone ===
            //Lets you say what user you are
            //Lets you post things
            //Lets you see a list of posts from all people
            //- in chronological order

            //Tables:
            //[Users]
            //Id
            //Name
            //* Handle
            //*Password
            //* Alignment

            //[Messages]
            //Id
            //Time Posted
            //UserId
            //Text

            //~~~~~~~~~ Query to check userid ~~~~~~~~~
            //SELECT Id FROM Users WHERE Username = 'jesswins';

            //~~~~~~~~~ Query to get messages ~~~~~~~~~
            //SELECT Messages.Text, Messages.Time, Users.Username, Users.Handle
            //FROM Messages
            //JOIN Users ON Users.Id = Messages.UserId
            //ORDER BY Messages.Time - in chronological order

            //~~~~~~~~~ SQL to create message ~~~~~~~~~
            //INSERT INTO Messages (Text, Time, UserId) VALUES ('This is a new message', 1350, 3);

            //Bonus: -Follow only certain people instead of everyone
            //-- BONUS ONLY
            //[Followers]
            //Id
            //UserId
            //UserFollowedId

            Console.WriteLine("Welcome to Twatter! What is your username?");
            string username = Console.ReadLine();

            SQLiteConnection connection = new SQLiteConnection(@"Data Source = /Users/jessicayockey/Desktop/databases/TwatterDB.sqlite");

            connection.Open();

            SQLiteCommand findUserCommand = new SQLiteCommand($"SELECT Id FROM Users WHERE Username = '{username}'", connection);

            SQLiteDataReader reader = findUserCommand.ExecuteReader();

            int userId = 0;
            bool loggedIn = false;

            while (reader.Read())
            {
                userId = Convert.ToInt32(reader["Id"]);
            }
            if (userId != 0)
            {
                Console.WriteLine($"found Id {userId}");
                loggedIn = true;
            }
            else
            {
                Console.WriteLine("User not found, goodbye!");
            }

            reader.Close();

            long multiplier = 3600L * 10000 * 1000;

            while (loggedIn)
            {
                Console.WriteLine("What would you like to do? A) Post your twoughts B) Looks at twoughts Q) Quit");
                string option = Console.ReadLine().ToLower();

                if (option == "a")
                {
                    Console.WriteLine("What is your twoot?");
                    string twoot = Console.ReadLine();

                    long currentTime = DateTime.Now.Ticks / (multiplier);
                    int currenttime = Convert.ToInt32(currentTime);

                    SQLiteCommand newtwat = new SQLiteCommand($"INSERT INTO Messages (Text, Time, UserId) VALUES ('{twoot}', '{currenttime}', '{userId})", connection);

                    newtwat.ExecuteNonQuery();
                }
                else if (option == "b")
                {
                    SQLiteCommand getall = new SQLiteCommand("SELECT Messages.Text, Messages.Time, Users.Username, Users.Handle FROM Messages JOIN Users ON Users.Id = Messages.UserId ORDER BY Messages.Time DESC", connection);

                    SQLiteDataReader reader2 = getall.ExecuteReader();

                    while (reader2.Read())
                    {
                        long bigtime = Convert.ToInt64(reader2["Time"]) * multiplier;
                        DateTime dt = new DateTime(bigtime);
                        Console.WriteLine($"{reader2["Handle"]}, {dt},\n {reader2["Text"]},");
                    }
                    reader2.Close();
                }
                else if (option == "q")
                {
                    loggedIn = false;
                }
                else
                {
                    Console.WriteLine("does not compute");
                }
            }
            connection.Close();
        }
    }
}
