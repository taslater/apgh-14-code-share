using System;
using System.Data.SqlClient;


namespace AlbumSong2
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\dclas\source\repos\AlbumSong2\AlbumSong2\Database1.mdf; Integrated Security = True");

            connection.Open();

            SqlCommand command;
            SqlDataReader reader;

            bool library = true;
            while (library == true)
            {

                //menu
                Console.WriteLine("You wanna read or write to tables? \nA) Read \nB) Write \nQ) Quit");
                string task = Console.ReadLine().ToUpper();


                //read?
                if (task == "A")
                {
                    //which table?
                    Console.WriteLine("Which Table? \nA) Albums \nB) Songs");
                    string destination = Console.ReadLine().ToUpper();
                    if (destination == "A")
                    {
                        //print the album table
                        command = new SqlCommand("SELECT * FROM Albums", connection);
                        reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                //artist genre title neilc year
                                Console.WriteLine($"{reader["Name"]} {reader["Artist"]} {reader["Genre"]} {reader["NeilC"]} {reader["Year"]}");
                            }
                        }
                        reader.Close();
                    }
                    if (destination == "B")
                    {
                        command = new SqlCommand("SELECT * FROM Songs", connection);
                        reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                //artist genre title neilc year
                                Console.WriteLine($"{reader["Length"]} {reader["Rating"]} {reader["Title"]} {reader["Guest Artist"]} {reader["Album ID"]}");
                            }
                        }
                        reader.Close();
                    }
                }

                if (task == "B")
                {
                    Console.WriteLine("Which Table? \nA) Albums \nB) Songs");
                    string destination = Console.ReadLine().ToUpper();

                    if (destination == "A")
                    {
                        MakeAlbum(connection);

                        //Console.WriteLine("What's the name?");
                        //string name = Console.ReadLine();
                        //Console.WriteLine("What's the Artist?");
                        //string artist = Console.ReadLine();
                        //Console.WriteLine("What's the Genre?");
                        //string genre = Console.ReadLine();
                        //Console.WriteLine("What's the involvement of Neil Cicieriga? 1)Present 0)tragically absent");
                        //int neilC = Convert.ToInt32(Console.ReadLine());
                        //Console.WriteLine("What year was it made?");
                        //int year = Convert.ToInt32(Console.ReadLine());

                        //command = new SqlCommand($"INSERT INTO Albums ([Name], [Artist], [Genre], [NeilC], [Year]) VALUES ('{name}','{artist}', '{genre}', {neilC}, {year})", connection);
                        //command.ExecuteNonQuery();
                    }

                    if (destination == "B")
                    {
                        Console.WriteLine("What's the length?");
                        int length = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("What's the rating?");
                        int rating = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("What's the Title?");
                        string title = Console.ReadLine();
                        Console.WriteLine("Who, if anyone, was the Guest Artist?");
                        string guest = Console.ReadLine();
                        Console.WriteLine("What is the Album ID");
                        int album = Convert.ToInt32(Console.ReadLine());

                        command = new SqlCommand("SELECT Id FROM Albums", connection);
                        reader = command.ExecuteReader();

                        bool album_exists = false;
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (Convert.ToInt32(reader["Id"]) == album)
                                {
                                    album_exists = true;
                                }
                            }
                        }
                        reader.Close();

                        if (!album_exists)
                        {
                            Console.WriteLine("That Album does not exist. Please enter it into the database");
                            MakeAlbum(connection);
                        }

                        command = new SqlCommand($"INSERT INTO Songs ([Length], [Rating], [Title], [Guest Artist], [Album ID]) VALUES ({length}, {rating}, '{title}', '{guest}', {album})", connection);
                        command.ExecuteNonQuery();
                    }
                }

                //display library accordingly
                //write?
                //which table? (B or C?)
                //ask for input
                //update input into table
                //show updated table
                //quit!
                //pull info from both tables to link album ID to the key of Albums Table


            }
            connection.Close();
        }
        static void MakeAlbum(SqlConnection connection)
        {
            Console.WriteLine("What's the album name?");
            string name = Console.ReadLine();
            Console.WriteLine("What's the Artist?");
            string artist = Console.ReadLine();
            Console.WriteLine("What's the Genre?");
            string genre = Console.ReadLine();
            Console.WriteLine("What's the involvement of Neil Cicieriga? 1)Present 0)tragically absent");
            int neilC = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What year was it made?");
            int year = Convert.ToInt32(Console.ReadLine());

            SqlCommand command = new SqlCommand($"INSERT INTO Albums ([Name], [Artist], [Genre], [NeilC], [Year]) VALUES ('{name}','{artist}', '{genre}', {neilC}, {year})", connection);
            command.ExecuteNonQuery();
        }
    }
}
