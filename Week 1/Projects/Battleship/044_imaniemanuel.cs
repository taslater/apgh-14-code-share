using System;

namespace battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a grid
            int[,] grid = new int[8, 8];
            int hitcounter = 0;

            int[,] grid2 = new int[8, 8];
            

            bool game = true;

            grid[3, 7] = 1;
            grid[7, 7] = 1;
            grid[1, 4] = 1;



            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    Console.Write(grid2[row, column]);
                }
                Console.WriteLine();
            }
            //ask which row to shoot
            while (game == true)
            {

                

                Console.WriteLine("Where in the row would you like to shoot?");
                int rowchoice = Convert.ToInt32(Console.ReadLine());

                
                Console.WriteLine("Where in the column would you like to shoot?");
                int colchoice = Convert.ToInt32(Console.ReadLine());



                if (rowchoice == 3 && colchoice == 7)
                {
                    Console.WriteLine("hit");
                    hitcounter++;
                    grid2[3, 7] = 1;

                    Console.WriteLine("---------------------------------------------------");

                    for (int row = 0; row < 8; row++)
                    {
                        for (int column = 0; column < 8; column++)
                        {
                            Console.Write(grid2[row, column]);
                        }
                        Console.WriteLine();
                    }
                }
                else if (rowchoice == 7 && colchoice == 7)
                {
                    Console.WriteLine("hit");
                    hitcounter++;
                    grid2[7, 7] = 1;

                    Console.WriteLine("----------------------------------------------------");

                    for (int row = 0; row < 8; row++)
                    {
                        for (int column = 0; column < 8; column++)
                        {
                            Console.Write(grid2[row, column]);
                        }
                        Console.WriteLine();
                    }
                }
                else if (rowchoice == 1 && colchoice == 4)
                {
                    Console.WriteLine("hit");
                    hitcounter++;
                    grid2[1, 4] = 1;

                    Console.WriteLine("-----------------------------------------------------");

                    for (int row = 0; row < 8; row++)
                    {
                        for (int column = 0; column < 8; column++)
                        {
                            Console.Write(grid2[row, column]);
                        }
                        Console.WriteLine();
                    }
                }
                else if ((rowchoice == 3 + 1 || rowchoice == 3 - 1) && (colchoice == 7 + 1 || colchoice == 7 - 1))
                {
                    Console.WriteLine("You're close!");
                }

                else if ((rowchoice == 7 + 1 || rowchoice == 7 - 1) && (colchoice == 7 + 1 || colchoice == 7 - 1))
                {
                    Console.WriteLine("You're close!");
                }

                else if ((rowchoice == 1 + 1 || rowchoice == 1 - 1) && (colchoice == 4 + 1 || colchoice == 4 - 1))
                {
                    Console.WriteLine("You're close!");
                }
                else
                {

                    Console.WriteLine("miss");
                }

                if (hitcounter >= 3)
                {
                    game = false;
                    Console.WriteLine("That's game. you win... i guess :(");
                }
            }

        }
    }
}