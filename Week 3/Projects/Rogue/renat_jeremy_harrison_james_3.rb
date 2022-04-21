require 'io/console'



#We want to make a rogue like game that introduces movement and collecting. 
#Making a grid for a playable movable character to move around the grind collecting items. 

#Start with movement within the grid

#Or placing other things within the grid 

#Either way we'll need a system to quickly refresh the grid when we make changes to it.
#If we can get a grid to print. We can find a way to locate items within the grid. 
#An array of 8 made

grid = Array.new(8) {Array.new(8) { 0 } }



#Assign the player a starting location
#Assign the variables
#Back from lunch WRITE if statements including code for 'wasd'.
#Depending on what letter is hit it will affect the integer and where it moves. 

playerrow = 3
playercolumn = 3 
money = 0
#Money and walls and stuff
grid[1][2] = "$"
grid[6][5] = "$"
grid[1][3] = "|"
grid[6][6] = "|"

on = true
while on

    grid[playerrow][playercolumn] = 'X'
    #player is X

    (0...8).each do |row|
        (0...8).each do |column|
            print grid[row][column]      
        end
        puts 
    end

    puts "You have #{money} money"
    puts "Press a letter"
    letter = STDIN.getch # this makes ctrl + c no longer stop a program, make sure to have your q = quit logic working!

    if letter == "w"
        if grid[playerrow-1][playercolumn] == "|"
            #this checks if the location above the user is a wall and then does nothing
        elsif grid[playerrow-1][playercolumn] == "$"
            money = money + 10
            grid[playerrow][playercolumn] = 0
            playerrow = playerrow - 1
        else
            grid[playerrow][playercolumn] = 0
            playerrow = playerrow - 1
            if playerrow < 0
                playerrow = 7
            end
        end
    end
    
    if letter == "a"
        if grid[playerrow][playercolumn-1] == "|"
        elsif grid[playerrow][playercolumn-1] == "$"
            money = money + 10
            grid[playerrow][playercolumn] = 0
            playercolumn = playercolumn - 1
        else
            grid[playerrow][playercolumn] = 0
            playercolumn = playercolumn - 1
            if playercolumn < 0
                playercolumn = 7
            end
        end
    end

    if letter == "s"
        if grid[playerrow+1][playercolumn] == "|"
        elsif grid[playerrow+1][playercolumn] == "$"
            money = money + 10
            grid[playerrow][playercolumn] = 0
            playerrow = playerrow + 1
        else
            grid[playerrow][playercolumn] = 0
            playerrow = playerrow + 1
            if playerrow > 7
                playerrow = 0
            end
        end
    end

    if letter == "d"
        if grid[playerrow][playercolumn+1] == "|"
        elsif grid[playerrow][playercolumn+1] == "$"
            money = money + 10
            grid[playerrow][playercolumn] = 0
            playerrow = playerrow + 1
        else
            grid[playerrow][playercolumn] = 0
            playercolumn = playercolumn + 1
            if playercolumn > 7
                playercolumn = 0
            end
        end
    end

    if letter == "q"
        on = false
    end
    
    #clear the grid
    system('clear')
    system('cls')

end
