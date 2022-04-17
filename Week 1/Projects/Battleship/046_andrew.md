Team 1! (Spenser, Jessica, and James) I think the following code will check nearby the guess and tell you if it was close. I also put a bunch of comments in, I'm curious if I explained it well enough. I haven't actually run it so we can try tomorrow.
```
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
            if(userrowguess != 0) //This is statement is false if the guess is on the top already. (In grid[0,any number].)
            {
                if (grid[userrowguess + 1, usercolumnguess] == 1) // This is the same column guessed but one row up, which it only checks for if it's not in the top row.
                {
                    IsClose = true; // If there's a boat right above the guess, this variable goes from false to true
                }
            }

            //Checking below
            if (userrowguess != 7)
            {
                if (grid[userrowguess - 1, usercolumnguess] == 1) // Same column, one row down
                {
                    IsClose = true;
                }
            }

            //Checking left
            if (usercolumnguess != 0) 
            {
                if (grid [userrowguess, usercolumnguess -1] == 1) // Same row, one column to the left
                {
                    IsClose = true;
                }
            }

            //Checking right
            if (usercolumnguess != 7)
            {
                if (grid [userrowguess, usercolumnguess + 1] == 1) // Same row, one column to the right
                {
                    IsClose = true;
                }
            }

            if (IsClose) // When it checked the boxes nearby and found a boat, it would change IsClose to true, so if it's true that means it found a boat. Otherwise it skips the stuff inside this if statement.
            {
                Console.WriteLine("Close");
            }
```
