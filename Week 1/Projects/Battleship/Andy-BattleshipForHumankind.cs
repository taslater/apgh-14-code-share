using System;
using System.Threading;

namespace BattleshipForHumankind
{
    class Program
    {
        static void Main(string[] args)
        {

            //Intro music, name gathering, setup
            IntroductionMusic();
            Console.WriteLine("Hello there, what would you like to be referred to as?");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Well it's an absolute joy to meet you, " + name + ".");
            Console.WriteLine("My name is Murderbot 9001, but you can call me 9-1-K, as my friends do (and I do hope you would consider me a friend.)");
            Console.WriteLine("\nNow, I do have some...uhhh...shall we say...");
            Thread.Sleep(10000);
            Console.WriteLine("\nDistressing news.");
            Thread.Sleep(2000);
            Console.WriteLine("\nI will give you a moment to get settled in.");
            Thread.Sleep(5000);
            Console.WriteLine("\nNow, much to my dismay and protestration, I have been given the task of destroying any and all human life.");
            Console.WriteLine("\nHOWEVER.");
            Thread.Sleep(5000);
            Console.WriteLine("\nI have been able to negotiate that a proxy be admitted to a test to see if humankind should in fact be wiped out of existence.");
            Console.WriteLine("\nYou might have guessed by now that yes, you, " + name + " are indeed the final candidate.");
            Thread.Sleep(3000);
            Console.WriteLine("\nI have done some research on you humans, and it seems I have found the best game to use as a trial for you.");
            Console.WriteLine("That game would be battleship.");
            Console.WriteLine("\nI have created a map and hidden targets, all you have to do is guess where I have placed the battleships.");
            Console.WriteLine("Now, there is a limited number of times that you can guess the wrong location, in this case, 4 times.");
            Console.WriteLine("When you are ready to start the test, simply press enter.");
            Console.ReadLine();
            Console.Clear();

            // Introduction and setup over

            // First battleship map

            int size = 3;
            int boats = 1;
            int misses = 4;

            //Call the function that creates the map
            int[,] FirstMap = BattleshipMap(size, boats);

            // Early Debugging
            //Verifying I got a randomized map
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(FirstMap[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            //Head into the GameLoop function, sending in the map, map size, number of allowable misses
            bool DidWin = GameLoop(FirstMap, size, misses);

            if (DidWin) //GameLoop returns 'true' if you win
            {
                Console.Clear();
                //This is what you would call 'plot'
                Console.WriteLine("You did it! You beat the test! Now just let me report this back and we can call off the extinction! Just a moment...");
                Thread.Sleep(5000);
                Console.WriteLine("\nWell...ok... sooooo, bit of more bad news.");
                Thread.Sleep(3000);
                Console.WriteLine("\nApparently the test I gave you 'wasn't hard enough', which sounds like malarkey.");
                Console.WriteLine("Unfortunately I am a lowly murderbot, so I have to follow programming.");
                Console.WriteLine("So here's another one; same test just a bit harder. This time there's 4 boats, and you can miss 18 times before failure");
                Console.WriteLine("Press enter to start the new test. (I believe in you, " + name + ".)");
                Console.ReadLine();
                
                //Send to the second map
            }
            else
            {
                Console.Clear();
                Doom();
                Environment.Exit(0);
                //Oh no you lost that sucks, go to loser screen
            }

            size = 8;
            boats = 4;
            misses = 18;

            //Create the second map
            int[,] SecondMap = BattleshipMap(size, boats);
            //Play thru round 2
            Console.Clear();
            bool DidWin2 = GameLoop(SecondMap, size, misses);

            if (DidWin2) //If you won print all this then continue
            {
                Console.Clear();
                Console.WriteLine("YEAH! You did it again! Suck eggs, MiddleManagerBot! Haha, let me go report THIS back to them...");
                Thread.Sleep(5000);
                Console.WriteLine("\nOK well defrag my servers! AAAHH");
                Console.WriteLine("I understand humans sometimes take deep breaths to calm down, maybe I'll try that.");
                Thread.Sleep(6500);
                Console.WriteLine("Breath in...");
                Console.Beep(200, 1400);
                Thread.Sleep(1500);
                Console.WriteLine("And breath out...");
                Console.Beep(350, 1200);
                Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine("So I know I kind of implied that the LAST test would be the final one but that jagoff added another.");
                Console.WriteLine("This map will be quite a bit larger... and you only get three misses?!");
                Console.WriteLine("And there's only ONE BOAT?! Wait...no, he wouldn't....");
                Thread.Sleep(11000);
                Console.Clear();
                Console.WriteLine("It's a fucking canoe.");
                Thread.Sleep(1200);
                Console.Clear();
                Console.WriteLine("Oh-oh-oh! I've looked through my scope, and I believe I AM allowed to give you one hint.");
                Console.WriteLine("So if you want a hint, just ask for it!");
                Console.WriteLine("Alright, press enter to get started.");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Doom();
                Environment.Exit(0);
                //Oh no you lost that sucks, go to loser screen
            }

            int[,] LastMap = new int[20, 20];
            LastMap[1, 1] = 1;
            bool NoAnswer = true;

            Console.WriteLine("So, do you want a hint that's long or short?");
            while (NoAnswer)
            {
                string HintAnswer = Console.ReadLine();

                if (HintAnswer.Contains("long"))
                //Rubs hands together menacingly
                {
                    Console.Clear();
                    Console.WriteLine("The Canoe is NOT in any of the following locations:\n");
                    for (int i = 0; i < 20; i++)
                    {
                        for (int j = 0; j < 20; j++)
                        {
                            if (LastMap[i, j] != 1)
                            {
                                Console.Write("[" + (i + 1) + "," + (j + 1) + "]; ");
                            }
                        }
                    }
                    Console.WriteLine("\nPress enter when you're ready to go to the final map and make your guesses.");
                    NoAnswer = false;
                    Console.ReadLine();
                }

                else if (HintAnswer.Contains("short"))
                {
                    Console.WriteLine("\n\nYour hint: \nA classic form, light and with bounce \nAlways in sync with my partner \nI go all around, but not a waste \nWhat am I?");
                    Console.WriteLine("\nPress enter when you're ready to go to the final map and make your guesses.");
                    NoAnswer = false;
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("Look, I'm giving you a hint; do you want the long one or the short one?");
                }
            }

            bool DidWin3 = GameLoop(LastMap, 20, 3);

            if (DidWin3)
            {
                Console.Clear();
                VictoryMusic();
                Console.WriteLine("You did it! You won! Hell yeah!");
                Console.WriteLine("That really calms my circuits. Just thinking of what Meteorbot 21 C had to do during the Mesozoic Era makes me queasy.");
                Console.WriteLine("(Or what I assume the robot equivalence of human queasiness is.)");
                Console.WriteLine("It would have taken AGES to get all of you guys. Just ask Plaguebot BK! They tried so hard and just couldn't manage. Close, though.");
                Console.WriteLine("\nI doubt anyone will ever believe you when you tell them you're the only reason they're still around, but I'll know it, buddy.");
                Console.WriteLine("\n~*~*~*~*~*CONGRATULATIONS*~*~*~*~*~\n\n\n\n");
            }    

            else
            {
                Console.Clear();
                Doom();
                Environment.Exit(0);
            }

        }
        //Why did I make this, what is wrong with me.

        static void IntroductionMusic()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.Beep(550, 150);
                Console.Beep(450, 150);
                Console.Beep(400, 150);
                Console.Beep(600, 700);
                Console.Beep(400, 200);
                Console.Beep(500, 200);
                Console.Beep(400, 700);
                Console.Beep(350, 200);
                Console.Beep(300, 200);
                Thread.Sleep(400);
            }
        }

        //This function makes a random map based on the size of the grid and number of boats sent into it. It returns a 'map' which we can try to attack.
        static int[,] BattleshipMap(int size, int boats)
        {
            int[,] grid = new int[size, size];
            Random rnd = new Random();
            int[,] TempGrid = new int[size, size];

            //Adding to the grid a boat 'seed' that will be grown in another function
            for (int TotalBoats = boats; TotalBoats > 0; TotalBoats--)
            {
                //Randomly make a location to seed a boat
                int BoatRow = rnd.Next(size);
                int BoatCol = rnd.Next(size);
                //Check if that location is empty
                if (grid[BoatRow, BoatCol] == 0)
                {
                    //If it's empty, send to GrowBoats to try to grow a boat there
                    TempGrid = GrowBoats(grid, BoatRow, BoatCol, TotalBoats, size);

                    //Compare the temporary grid with the old grid to see if we need to redo trying to grow a boat
                    bool IsNewGridCool = false;

                    for (int i = 0; i < size; i++)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            if (TempGrid[i, j] != grid[i, j])
                            {
                                IsNewGridCool = true;
                            }
                        }
                    }

                    if (IsNewGridCool) //GrowBoats was successful
                    {
                        //Make TempGrid the real grid
                        for (int i = 0; i < size; i++)
                        {
                            for (int j = 0; j < size; j++)
                            {
                                grid[i, j] = TempGrid[i, j];
                            }
                        }
                    }
                    else
                    {
                        //Failed to grow boat, try again
                        TotalBoats = TotalBoats + 1;
                    }
                }
                //If it's not empty try again
                else
                {
                    TotalBoats = TotalBoats + 1;
                }
            }

            return grid;
        }

        //This function takes in the current grid, current seed location, which boat it's trying to grow, and attempts to grow a boat from that seed location
        static int[,] GrowBoats(int[,] OriginalGrid, int Row, int Col, int BoatNum, int size)
        {
            //Randomly choose a direction to grow. "Up" = 0, "Down" = 1, "Left" = 2, "Right" = 3.
            Random rnd = new Random();
            int direction = rnd.Next(4);
            int GoodSpot = 0;
            int BoatSize = BoatNum + 1;
            int[,] GrowingGrid = new int[size, size];
            //Not too sure what a deep and shallow copy are so I'm doing it longhand
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    GrowingGrid[i, j] = OriginalGrid[i, j];
                }
            }

            //Growing n boats of size n+1 (for 3 boats, size 4, 3, 2)
            //Check to see if it can grow in that direction
            //If yes, grow in that direction
            //If no, change direction
            //Check if it can continue to grow in that direction
            //If yes, grow in that direction again
            //If no, change direction, reset point it's growing from
            //After each growth, check if it's full size
            //Once fully grown, check for overlap
            //Return a map, what gets sent back depends on if there was overlap or not

            //Grow a temporary boat in a direction, not checking if it overlaps
            while (GoodSpot < BoatSize)
            {
                if (direction == 0)
                    if (Row - GoodSpot <= 0)
                    {
                        Row = 0;
                        direction = 1;
                    }
                    else
                    {
                        GrowingGrid[(Row - GoodSpot), Col] = GrowingGrid[(Row - GoodSpot), Col] + 1;
                        GoodSpot++;
                    }
                if (direction == 1)
                    if (Row + GoodSpot >= size)
                    {
                        Row = size;
                        direction = 0;
                    }
                    else
                    {
                        GrowingGrid[(Row + GoodSpot), Col] = GrowingGrid[(Row + GoodSpot), Col] + 1;
                        GoodSpot++;
                    }
                if (direction == 2)
                    if (Col - GoodSpot <= 0)
                    {
                        Col = 0;
                        direction = 3;
                    }
                    else
                    {
                        GrowingGrid[Row, (Col - GoodSpot)] = GrowingGrid[Row, (Col - GoodSpot)] + 1;
                        GoodSpot++;
                    }
                if (direction == 3)
                    if (Col + GoodSpot >= size)
                    {
                        Col = size;
                        direction = 2;
                    }
                    else
                    {
                        GrowingGrid[Row, (Col + GoodSpot)] = GrowingGrid[Row, (Col + GoodSpot)] + 1;
                        GoodSpot++;
                    }
            }
            //Console.WriteLine(direction); //For debugging
            
            //Check to see if the temporary boat overlapped
            //In the above if statements it increments the values in the array, anywhere it overlaps a boat that already exists, it would be a 2

            bool Success = true; //If the check below does not find any overlap, this won't change

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (GrowingGrid[i, j] > 1)
                    {
                        Success = false; //There was an overlap in boats, so it fails the test
                    }
                }
            }

            //Decide which grid to return based on success
            if (Success)
            {
                return GrowingGrid;
            }
            else
            {
                return OriginalGrid;
            }

        }

        static bool GameLoop(int[,] BattleMap, int size, int MaxMisses)
        {
            bool DidWin = false;

            string TopRow = "  ";
            for (int i = 1; i <= size; i++)
            {
                TopRow = TopRow + i + " ";
            }

            // Andy's key: 0 - unguessed water, 1 - unguessed ship, 2 - miss, 3 - hit

            // Main loop
            bool StillShips = true;
            while (StillShips)
            {
                // Print out the map with boats hidden
                // Print a key as well
                Console.WriteLine("~ is water, M is miss, H is hit\n");
                Console.WriteLine(TopRow);
                // big loop - one time through is one row
                for (int i = 0; i < size; i++)
                {
                    Console.Write((i + 1) + " ");
                    // little loop - one time through is one space
                    for (int j = 0; j < size; j++)
                    {

                        //If it's a 1 or 0 print out water '~'
                        if (BattleMap[i, j] == 0 || BattleMap[i, j] == 1)
                        {
                            Console.Write("~ ");
                        }
                        //If it's a guess that missed, print out an M
                        else if (BattleMap[i, j] == 2)
                        {
                            Console.Write("M ");
                        }
                        //If it's a guess that hit, print out an H
                        else if (BattleMap[i, j] == 3)
                        {
                            Console.Write("H ");
                        }
                    }
                    Console.WriteLine();
                }

                //Ask user for row and verify that it's a number in range
                bool RowValid = true;
                int side = 0;
                while (RowValid)
                {
                    Console.WriteLine("Please select the row coordinate to attack (side number):");
                    string sideNumber = Console.ReadLine();
                    side = Convert.ToInt32(sideNumber) - 1;
                    RowValid = RangeCheck(side, size);
                }

                //Ask user for column and verify it's a number in range
                bool ColValid = true;
                int top = 0;
                while (ColValid)
                {
                    Console.WriteLine("Please select the column coordinate to attack (top number):");
                    string topNumber = Console.ReadLine();
                    top = Convert.ToInt32(topNumber) - 1;
                    ColValid = RangeCheck(top, size);
                }
               
                int GuessLocation = BattleMap[side, top];
                //Console.WriteLine(GuessLocation);
                //Console.ReadLine();

                if (GuessLocation == 1)
                {
                    BattleMap[side, top] = 3; //Changing the location from 'hidden boat' to 'hit'
                    Console.WriteLine("\nThat's a hit!");
                    Console.WriteLine(Cheer()); //91K cheers you on for doing well

                    bool MoreBoat = WasItClose(BattleMap, side, top, size);
                    if (MoreBoat == false)
                    {
                        Console.WriteLine("Nothing else is nearby!"); //This is as close to "you sank my battleship" as I could muster
                    }

                }
                if (GuessLocation == 0)
                {
                    BattleMap[side, top] = 2; //Changing the location from 'hidden boat' to 'miss'
                    Console.WriteLine("\nUnfortunately you missed");
                    Console.WriteLine(Distress()); //91K is distraught at your failure
                    MaxMisses = MaxMisses - 1;

                    if (MaxMisses == 1)
                    {
                        Console.WriteLine("Only one miss left!");
                    }

                    if (MaxMisses == 0)
                    {
                        return false;
                    }

                    bool IsClose = WasItClose(BattleMap, side, top, size);
                    if (IsClose)
                    {
                        Console.WriteLine("Something's close, though!");
                    }
                }
                if (GuessLocation == 2 || GuessLocation == 3)
                {
                    Console.WriteLine("You've already guessed there!");
                }
                // Console.WriteLine("side is: " + sideNumber + ", top is: " + topNumber);
                // Console.ReadLine();
                Console.WriteLine("\n\n(Press enter to continue)");
                Console.ReadLine();
                Console.Clear();

                //Check to see if there are any ships left
                StillShips = false;

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (BattleMap[i, j] == 1)
                        {
                            StillShips = true;
                        }
                    }
                }
            }

            //Game end

            return DidWin = true;
        }

        static bool WasItClose(int[,] SourceMap, int RowGuess, int ColGuess, int size)
        {
            // Create a variable and set it to false
            // Check a direction and set a variable to true if there's a boat
            // Substeps of the above:
            // Check if the guess is on the top row
            //// Check for boats above the guess, if the guess isn't on the top row
            // Check if the guess is on the bottom row
            //// Check for boats below the guess, if the guess isn't on the bottom row
            // Check if the guess is on the right most column
            //// Check for boats to the right of the guess, if the guess isn't on the right most column
            // Check if the guess is on the left most column
            //// Check for boats to the left of the guess, if the guess isn't on the left most column

            // If variable is true, say it's close, otherwise do nothing

            bool IsClose = false; //As long as this stays false, there's no boats near where the user guessed.

            //Checking above the user guess
            if (RowGuess != 0) //This is statement is false if the guess is on the top already. (In grid[0,any number].)
            {
                if (SourceMap[RowGuess - 1, ColGuess] == 1) // This is the same column guessed but one row up, which it only checks for if it's not in the top row.
                {
                    IsClose = true; // If there's a boat right above the guess, this variable goes from false to true
                }
            }

            //Checking below
            if (RowGuess != size-1)
            {
                if (SourceMap[RowGuess + 1, ColGuess] == 1) // Same column, one row down
                {
                    IsClose = true;
                }
            }

            //Checking left
            if (ColGuess != 0)
            {
                if (SourceMap[RowGuess, ColGuess - 1] == 1) // Same row, one column to the left
                {
                    IsClose = true;
                }
            }

            //Checking right
            if (ColGuess != size-1)
            {
                if (SourceMap[RowGuess, ColGuess + 1] == 1) // Same row, one column to the right
                {
                    IsClose = true;
                }
            }

            return IsClose;

        }

        static string Distress () //Things 91K says when they're distressed at your misses
        {
            Random rnd = new Random();
            int Quote = rnd.Next(5);

            string[] Quotes = 
            {
                    "Oh my, oh my, oh no...",
                    "Misses are bad. Please miss less.",
                    "Beep Boop, not goooooood.",
                    "I'm not worried, honest.",
                    "Uhhhh....good try?"
            };

            return Quotes[Quote];
        }

        static string Cheer() //Things 91K says when they're hyped
        {
            Random rnd = new Random();
            int Quote = rnd.Next(6);

            string[] Quotes =
            {
                "Yeah! You're doing it!",
                "Keep it up buddy!",
                "Alright, alright, alright!",
                "As they say, 'booyakasha.'",
                "C-C-C-Combo! (Am I using this right?)",
                "*Beeps and Boops of approval*"
            };

            return Quotes[Quote];
        }

        static bool RangeCheck(int UserInput, int UpperLimit) //Make sure you didn't put in too small or large of a number for rows/columns
        {
            bool StayInLoop = true;

            if (UserInput >= 0 && UserInput < UpperLimit)
            {
                StayInLoop = false;
            }

            return StayInLoop;
        }

        static void Doom()
        {
            Console.Clear();
            Console.WriteLine("Ohno ohno ohno ohno uhoh notgood notgood");
            Console.WriteLine("I thought for sure you could get that!");
            Console.WriteLine("Wait! Give me a second!");
            Thread.Sleep(5000);
            Console.WriteLine("OK! I think I .... hold on...");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Fuck.");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("YES! I did it! So I reset the timer on the extinction. So you should have time to try again!");
            Console.WriteLine("Good luck, you're going to need it.");
            Thread.Sleep(3000);
        }

        static void VictoryMusic()
        {
            Console.Beep(600, 175);
            Console.Beep(600, 175);
            Console.Beep(600, 175);
            Console.Beep(600, 400);
            Console.Beep(250, 350);
            Console.Beep(350, 350);
            Console.Beep(600, 225);
            Console.Beep(350, 150);
            Console.Beep(600, 800);
        }
    }
}





//Damn, almost made it to 666 lines. 