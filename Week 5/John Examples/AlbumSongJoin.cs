using System;
using System.Data.SqlClient;

namespace Session14iTunes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Connection
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\john\source\repos\Session14iTunes\Session14iTunes\Database1.mdf;Integrated Security=True;");
            conn.Open();

            // Show my itunes library
            // show each album
            // under each album, show its songs

            // Thriller, Michael Jackson
            // - Billie Jean
            // - Beat It

            // Command
            // Reader

            // my loop that shows albums
            SqlCommand cmd = new SqlCommand("SELECT *, Songs.Title AS SongName FROM Albums JOIN Songs ON Albums.Id = Songs.AlbumId ORDER BY Albums.Title, Songs.Title", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            string previousAlbumTitle = "";

            while (reader.Read())
            {
                // separate writelines for the songs and albums
                // for each album id, show the album only once, then show all the songs
                if (previousAlbumTitle != reader["Title"].ToString())
                {
                    Console.WriteLine("Album: " + reader["Title"]);

                }
                Console.WriteLine(" - " + reader["SongName"]);
                previousAlbumTitle = reader["Title"].ToString();
            }
            reader.Close();

            conn.Close();
            Console.ReadLine();
        }
    }
}
