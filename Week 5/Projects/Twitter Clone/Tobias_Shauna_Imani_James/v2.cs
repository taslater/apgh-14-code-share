using System;

// Mac/Linux SQLite Bridge
using System.Data.SQLite;
using Connection = System.Data.SQLite.SQLiteConnection;
using Command = System.Data.SQLite.SQLiteCommand;
using DataReader = System.Data.SQLite.SQLiteDataReader;

// // Microsoft SQL Bridge
// using System.Data.SqlClient;
// using Connection = System.Data.SqlClient.SQLConnection;
// using Command = System.Data.SqlClient.SQLCommand;
// using DataReader = System.Data.SqlClient.SQLDataReader;

// AGENDA:
// 1. [x] Create back end -- all data
// - Create tables
// - Fill in seed data
// 2. ==> Display message
// - Show all messages
// - In chronoloogical order
// - Include user info
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

            Connection conn = new Connection(@"Data Source = /home/tob/Documents/Academy/Code/Database/dbs/tweeter.db");
            conn.Open();

            Command command = new Command("SELECT * FROM Messages", conn);
            DataReader messagereader = command.ExecuteReader();






            messagereader.Close();




            conn.Close();
        }
    }
}

