using System;

using System.Data.SQLite;

namespace Albums_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a menu asking user what they want to do
            //creating a variable for the connection, setting variable to connection string
            SQLiteConnection connection;
            connection = new SQLiteConnection(@"Data Source =/Users/shaunapage/Desktop/Database/Albums_Database.sqlite");

            //establishing main menu, taking in user input
            Console.WriteLine("What would you like to do? \n A: View Library \n B: Add an Album to library \n C: Add Songs");
            string Task = Console.ReadLine().ToUpper();
            connection.Open(); //opening connection to database

            //establishing command and reader variables that will be used later in if statements
            SQLiteCommand command;
            SQLiteDataReader reader;

            //to display the library
            if (Task == "A")
            {
                //set the command variable to pull all albums and join songs to that table
                command = new SQLiteCommand("SELECT * FROM Albums JOIN Songs ON Albums.Id = Songs.AlbumID", connection);
                reader = command.ExecuteReader();

                //displaying all albums and songs
                while (reader.Read())
                {
                    Console.WriteLine($"{reader["Id"]}, {reader["Title"]}, {reader["Artist"]}, {reader["Year"]}");

                    Console.WriteLine(reader["Name"]);
                }
                //remember to close the reader!
                reader.Close();
            }
            //if statement to add an ablum to the album table
            else if (Task == "B")
            {
                //gathering info to create new album from user input
                Console.WriteLine("What is the Album Title?");
                string albumTitle = Console.ReadLine();

                Console.WriteLine("Who is the Artist?");
                string artist = Console.ReadLine();

                Console.WriteLine("What is the Year of the Album?");
                string year = Console.ReadLine();

                //setting command to insert user input into album table
                command = new SQLiteCommand($"INSERT INTO Albums(Title, Artist, Year) VALUES('{albumTitle}', '{artist}', {year})", connection);
                command.ExecuteNonQuery();
            }

            //if statement to add songs to an album
            else if (Task == "C")
            {
                //first, we display all albums in library so user can pick one to add songs to 63-74
                command = new SQLiteCommand("SELECT * FROM Albums ", connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"{reader["Id"]}, {reader["Title"]}, {reader["Artist"]}, {reader["Year"]}");


                }
                //remember to close reader!
                reader.Close();

                //retrieving info about new song from user
                Console.WriteLine("What Album Id do you want to add songs to?");
                int albumId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the song title?");
                string songTitle = Console.ReadLine();

                Console.WriteLine("How long is this song on seconds?");
                int length = Convert.ToInt32(Console.ReadLine());

                //setting command to insert new song into song table, using user input
                command = new SQLiteCommand($"INSERT INTO Songs(AlbumID, Name, Length) VALUES({albumId}, '{songTitle}', {length})", connection);
                command.ExecuteNonQuery();

            }




            // Loop through option C & B
            // recieve user input & perform task
            // task#1: view all albums & songs
            //task#2: add albums with relavent info
            //task#3: add songs (to albums)

        }
    }
}


