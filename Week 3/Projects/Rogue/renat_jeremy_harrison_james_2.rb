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


on = true

while on
grid[playerrow][playercolumn] = 'X'
    #Money and walls and stuff
    (0...8).each do |row|
        (0...8).each do |column|
            print grid[row][column]
            
        end
        puts 
    end

    puts "Press a letter"
    letter = STDIN.getch # this makes ctrl + c no longer stop a program, make sure to have your q = quit logic working!

    if letter == "a"
        grid[playerrow][playercolumn] = 0
        playercolumn = playercolumn - 1
    end

    if letter == "w"
        grid[playerrow][playercolumn] = 0
        playercolumn = playercolumn - 1
    end

    if letter == "s"
        grid[playerrow][playercolumn] = 0
        playercolumn = playercolumn - 1
    end

    if letter == "d"
        grid[playerrow][playercolumn] = 0
        playercolumn = playercolumn - 1
    end

    if letter == "q"
        on = false
    end
    #clear the grid
    system('clear')
    system('cls')
    

end
