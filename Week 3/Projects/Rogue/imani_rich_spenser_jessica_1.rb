require 'io/console'
#<--------------------OBJECTIVES---------------------------->

# objective 1: create Grid
# objective 2: display goals and obstacles on grid
#              * board must be re-drawn after player move 
#              * randomize board on restart..
#              * set limits on number of goals and obstacles
# objectives 3: track obstacle effects (what happens when you encounter an object)
# objective 4: have a character that can move freely on grid
#              * grid boundry
# objective 5: character collect goals 
# objective 6: keep track of points/health -- hash tables?
# objective 7: escape/quit option..
# objective 8: ascii art! BONUS
# objective 9: shop menu! bonus bonus



#<----------------PROGRAM------------------------------------->




grid = Array.new(10) { Array.new(10) { ".  " } }


#-------Goals---------------
goal = "#  "
(0...10).each do |i|
    grid[rand(10)][rand(10)] = "#  "
end

#-------Obstacles-----------
(0...10).each do |x,y|
    if (grid[x] != goal)
        grid[rand(10)][rand(10)] = "%  "
    elsif (grid[y] != goal)
        grid[rand(10)][rand(10)] = "%  "
    end
end 
player_row = 4
player_column = 4






#-------THE GAME------------------
game = true
score = 0
lives = 10
while game
    system('clear')
    system('cls')
    #----controls------
puts ""
puts "Controls are ..."
puts "W S A D: up, down, left, right ---> q for quit"

    grid[player_row][player_column] = "@  "
    puts ""
    puts " ==============================="
    (0...10).each do |row|
        print "| "
        (0...10).each do |column|
            print grid[row][column]
        end
        print "|"
        puts
    end
    puts " ==============================="
    puts "         your score is #{score}!"
    puts "         you have #{lives} left!"
    letter = STDIN.getch.chomp 
    if (letter == "w" )
        if (player_row == 0)
            grid[player_row][player_column] = ".  "
            player_row = player_row + 9
        else
            grid[player_row][player_column] = ".  "
            player_row = player_row - 1
        end
        
    elsif (letter == "s")
        if (player_row == 9)
            grid[player_row][player_column] = ".  "
            player_row = player_row - 9
        else
            grid[player_row][player_column] = ".  "
            player_row = player_row + 1
        end
    
    elsif (letter == "a")
        if (player_column == 0)
            grid[player_row][player_column] = ".  "
            player_column = player_column + 9
        else
            grid[player_row][player_column] = ".  "
            player_column = player_column - 1
        end
        
    elsif (letter == "d")
        if (player_column == 9)
            grid[player_row][player_column] = ".  "
            player_column = player_column - 9
        else
            grid[player_row][player_column] = ".  "
            player_column = player_column + 1
        end
        
        elsif (letter == "q")
            puts
            puts "----------GOODBYE!-------------"
            gets

            game = false
    end
    
    
    
    check = false
    (0...10).each do |row|
        (0...10).each do |column|
        if (grid[row][column] == goal && letter != "q")
            check = true
        end
    end
end
        if check == true
            game = true
        else
            game = false
            puts "you won"
            puts ""
        end   
    

    


    if (lives <= 0)
        game = false
        puts "YOU LOSE"
    end
    
    
end

