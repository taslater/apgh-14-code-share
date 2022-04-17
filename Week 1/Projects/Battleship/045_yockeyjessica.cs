using System;

namespace Session14Battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a grid(an array with two dimensions) that is 8 by 8.

            int[,] grid = new int[8, 8];
            grid[2, 2] = 1;
            grid[4, 4] = 1;

            int[,] displaygrid = new int[8, 8];

            bool ships = true;
            Console.WriteLine("1 is miss, 2 is hit");

            while (ships == true)
            {
                for (int row = 0; row < 8; row++)
                {
                    for (int column = 0; column < 8; column++)
                    {
                        Console.Write(displaygrid[row, column]);
                    }
                    Console.WriteLine();

                }

                Console.WriteLine("Please select a row.");
                int userrowguess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please select a column.");
                int usercolumnguess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(userrowguess + "," + usercolumnguess);

                if (grid[userrowguess, usercolumnguess] != 0)
                {
                    Console.WriteLine("Hit!");
                    grid[userrowguess, usercolumnguess] = 0;
                    displaygrid[userrowguess, usercolumnguess] = 2;

                }
                else
                {
                    Console.WriteLine("Miss!");
                    displaygrid[userrowguess, usercolumnguess] = 1;
                    if (grid[userrowguess + 1, usercolumnguess] == 1 || grid[userrowguess - 1, usercolumnguess] == 1 || grid[userrowguess, usercolumnguess + 1] == 1 || grid[userrowguess, usercolumnguess - 1] == 1)
                    {
                        Console.WriteLine("Close!");
                    }

                }

                int aretherethings = 0;

                for (int row = 0; row < 8; row++)
                {
                    for (int column = 0; column < 8; column++)
                    {
                        if (grid[row, column] != 0)
                        {
                            aretherethings++;

                        }
                    }

                }

                if (aretherethings == 0)
                {
                    ships = false;
                    Console.WriteLine("GAME OVER!");
                }
            }
            //This grid will hold whether there is a ship in a given square or not.You can use a bool or an int for this.You will need to be able to display this grid, with
            //00000000
            //0000*000
            //00**0000
            //00000000
            //000**000
            //*0*00000
            //00000**0
            //00****00

            //Let the user try to "shoot" a ship by selecting two coordinates (the column and the row)
            //When users shoot an enemy, clear the ship in that cell
            //When all enemies are gone, make the "game" end.
            // Bonus:
            // If user picks a cell next to a ship, say "close!"

        }
    }
}