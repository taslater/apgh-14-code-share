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


            bool game = true;

            grid[3, 7] = 5;
            grid[7, 7] = 8;
            grid[1, 4] = 3;



            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    Console.Write(grid[row, column]);
                }
                Console.WriteLine();
            }
            //ask which row to shoot
            while (game == true)
            {
                Console.WriteLine("Where in the row would you like to shoot?");
                int rowchoice = Convert.ToInt32(Console.ReadLine());

                //ask which column to shoot
                Console.WriteLine("Where in the column would you like to shoot?");
                int colchoice = Convert.ToInt32(Console.ReadLine());

                //determine hit or miss
                if (rowchoice == 3 && colchoice == 7)
                {
                    Console.WriteLine("hit");
                    hitcounter++;
                }
                else if (rowchoice == 7 && colchoice == 7)
                {
                    Console.WriteLine("hit");
                    hitcounter++;
                }
                else if (rowchoice == 1 && colchoice == 4)
                {
                    Console.WriteLine("hit");
                    hitcounter++;
                }
                else //((rowchoice != 3 && colchoice != 7)|| (rowchoice != 7 && colchoice != 7)|| (rowchoice != 1 && colchoice != 4)) 
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

