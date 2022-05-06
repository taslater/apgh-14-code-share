--Messages definition
using System;
using System.Data.SQLite;

namespace Twitterclonedb01
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLiteConnection conn = new SQLiteConnection(@"Data Source = /Users/shaunapage/Desktop/database/Twitterclonedb01.sqlite");
            conn.Open();

            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Messages", conn);
            SQLiteDataReader messagereader = command.ExecuteReader();

            messagereader.Close();


            conn.Close();

        }
    }
}
