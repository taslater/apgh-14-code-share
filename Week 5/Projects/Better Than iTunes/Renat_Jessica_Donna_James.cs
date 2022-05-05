using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace Albums
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instructions:
            // Write a program that lets you ahve a list of albums / songs
            // You should be a able to a) View library (show all albums and songs)
            // You should be a able to b) Add Albums
            // You should be a able to c) Add Songs to Albums

            SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Renat\source\repos\Albums\Albums\Database1.mdf; Integrated Security = True");
            connection.Open();
            Console.WriteLine("Yo! Welcome to iTunes! What would you like to do yo?\nA)View your library\nB)Add an album\nC)Add songs to Albums\nD)Quit");
            string userInput = Console.ReadLine().ToLower();

            SqlCommand command = new SqlCommand("SELECT *, Songs.Title AS Portal FROM Albums JOIN Songs ON Albums.Id = Songs.AlbumId", connection);


            if (userInput == "a")
            {
                SqlDataReader reader = command.ExecuteReader();
                //if (reader.HasRows)                            //Scott why


                while (reader.Read())
                {
                    Console.Write("Id: " + reader["Id"] + "Album Title: " + reader["Title"] + "" + reader["isNeilC"] + "Year: " + reader["Year"] + "Artist: " + reader["Artist"] + "Genre: " + reader["Genre"] + "Length: " + reader["Length"] + "Rating: " + reader["Rating"] + "Song Title: " + reader["Portal"] + "Guest Artist: " + reader["Guest Artist"] + "AlbumId: " + reader["AlbumId"]);

                    Console.WriteLine();
                }
                reader.Close();
            }
            if (userInput == "b")
            {
                Console.WriteLine("Tell us about your funky fresh albums you want to add yo: ");

                Console.WriteLine("Yo who's the artist?: ");
                string artist = Console.ReadLine();
                Console.WriteLine("What's the title?: ");
                string title = Console.ReadLine();
                Console.WriteLine("What's the genre?: ");
                string genre = Console.ReadLine();
                Console.WriteLine("What year was it published?");
                int year = Convert.ToInt32(Console.ReadLine());
                command = new SqlCommand("INSERT INTO ALBUMS ([Artist], [Title], [Genre], [Year]) VALUES(@artist,@title,@genre,@year)", connection);
                command.Parameters.AddWithValue("@artist", artist);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@genre", genre);
                command.Parameters.AddWithValue("@year", year);
                command.ExecuteNonQuery();
            }
        }
    }
}

