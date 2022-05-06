using System;

// Mac/Linux SQLite Bridge
//using System.Data.SQLite;
//using Connection = System.Data.SQLite.SQLiteConnection;
//using Command = System.Data.SQLite.SQLiteCommand;
//using DataReader = System.Data.SQLite.SQLiteDataReader;

// // Microsoft SQL Bridge
using System.Data.SqlClient;
using Connection = System.Data.SqlClient.SqlConnection;
using Command = System.Data.SqlClient.SqlCommand;
using DataReader = System.Data.SqlClient.SqlDataReader;

// AGENDA:
// 1. [x] Create back end -- all data
// - Create tables
// - Fill in seed data
// 2. ==> Display message
// -  [x] Show all messages
// - [x] In chronoloogical order
// - [x] Include user info
// - Make it pretty
// 3. Create user sign in
// 4. Create new posts

namespace Twitterclonedb01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Shauna: @"Data Source = /Users/shaunapage/Desktop/database/Twitterclonedb01.sqlite"
            // Tobias: @"Data Source = /home/tob/Documents/Academy/Code/Database/dbs/tweeter.db"

            // Console.WriteLine(DateTime.Now.Ticks);

            Connection conn = new Connection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\james\source\repos\TwitterClonedb01\TwitterClonedb01\Database1.mdf; Integrated Security = True");
            conn.Open();

            Command command = new Command("SELECT * FROM Messages ORDER BY [Time Posted] ASC", conn);


            command = new Command("SELECT *, Users.Names AS username FROM Users JOIN Messages ON Users.Id = Messages.[User Id]", conn);
            DataReader messagereader = command.ExecuteReader();

            while (messagereader.Read())
            {
                Console.WriteLine(messagereader["Text"]);
                Console.WriteLine(messagereader["Time Posted"]);
                Console.WriteLine(messagereader["username"]);
            }




            messagereader.Close();




            conn.Close();
        }
    }
}


