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

            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\john\source\repos\Session14dbstuff\Session14dbstuff\Database1.mdf;Integrated Security=True");
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Addresses", connection);
            SqlDataReader reader = command.ExecuteReader();

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
