using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace Session14dbstuff
{
    class Program
    {
        static void Main(string[] args)
        {
            // Connection (where am I running commands?)
            // Command (what am I running?)
            // Reader (what I get back from the database)

            SQLiteConnection connection = new SQLiteConnection(@"Data Source=C:\Users\john\Desktop\databases\mydatabase.sqlite;");
            connection.Open();

            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Addresses", connection);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader["Name"]);
            }
            reader.Close();

            connection.Close();
            Console.ReadLine();
        }
    }
}
