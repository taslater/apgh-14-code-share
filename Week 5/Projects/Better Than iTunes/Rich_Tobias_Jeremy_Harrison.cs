using System;
using System.Data.SQLite;
namespace musicdb
{
    class Program
    {
        static void Main(string[] args)
        {
            //        Instructions:
            //            Write a program that lets you have a list of albums / songs
            //            You should be able to a) View library(show all albums and songs)
            //            You should be able to b) Add Albums
            //            You should be able to c) Add Songs to Albums

            SQLiteConnection connection = new SQLiteConnection(@"Data Source =/Users/rich/Desktop/databases/musicdb.sqlite");
            connection.Open();
            bool running = true;
            while (running)
            {
                System.Console.WriteLine("Choose an option:\na) View Song Library\nb) Add New Album\nc) Add New Song\nq) Quit");
                string menuOption = Console.ReadLine().ToLower();


                if (menuOption == "a") // View Song Library
                {
                    SQLiteCommand command = new SQLiteCommand("SELECT * FROM Songs", connection);
                    SQLiteDataReader songReader = command.ExecuteReader();



                    Console.WriteLine("Songs:");
                    while (songReader.Read())
                    {



                        command = new SQLiteCommand($"SELECT * FROM Albums WHERE Id = {songReader["AlbumId"]}", connection);
                        SQLiteDataReader albumReader = command.ExecuteReader();

                        while (albumReader.Read())
                        {
                            Console.WriteLine(songReader["Title"]);
                            Console.WriteLine(albumReader["Artist"]);
                            Console.WriteLine(albumReader["Year"]);
                            Console.WriteLine(albumReader["Title"]);
                            Console.WriteLine();

                        }
                        albumReader.Close();
                    }
                    Console.ReadLine();
                    songReader.Close();

                }
                // ______________HERE_______________________________________-
                else if (menuOption == "b")
                {
                    Console.WriteLine("What album would you like to add?");
                    string newTitle = Console.ReadLine();
                    Console.WriteLine("What is the name of the artist");
                    string newArtist = Console.ReadLine();
                    Console.WriteLine("what is the genre of the new album?");
                    string newGenre = Console.ReadLine();
                    Console.WriteLine("what year did the album release?");
                    string newYear = Console.ReadLine();


                    SQLiteCommand command = new SQLiteCommand($"INSERT INTO Albums ([Title],[Artist],[Genre],[Year]) VALUES ('{newTitle}', '{newArtist}', '{newGenre}', {newYear})", connection);




                }
                else if (menuOption == "q")
                {
                    running = false;
                }
            }
            connection.Close();
        }
    }
}
