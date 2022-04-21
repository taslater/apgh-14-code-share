#Team 1: PEWPEW Laser Gun - (Sam) Andy, David, Shauna, Tobias
# grid = Array.new(8) { Array.new(8) { 0 } }

# # clear the screen
# system('clear')
# system('cls')

# # print that
# (0...8).each do |row|
#     (0...8).each do |column|
#         print grid[row][column]
#     end
#     puts
# end

# # better drawing in miro
# # maybe some ascii art

# # getting a letter input without hitting enter

# require 'io/console'
# puts "Press a letter"
# letter = STDIN.getch # this makes ctrl + c no longer stop a program, make sure to have your q = quit logic working!

# puts "You pressed #{letter}"

#==========bits to make===========
# put it all in a loop
# clear shit
# make grid
# start with a 5x5
# display it!
# recieve user input and directions
# get to the rest later???



require 'io/console' #controls on keyboard for user to input
# makes an array
game_map_tall = 10 # height of game map
game_map_wide = 20 # width of game map
game_map = Array.new(game_map_tall) { Array.new(game_map_wide) { '~' } } #game map, fills the array w/ tildays ~ 
number_of_money = 20 # Variable to set how many moneys to put on the map
number_of_traps = 10 # Variable to set how many traps to put on the map

#Randomly puts money on the map
(1..number_of_money).each do
    game_map[rand(0...game_map_tall)] [rand(0...game_map_wide)] = "$"
end

#Randomly puts traps on the map
while number_of_traps > 0
    rand_tall = rand(0...game_map_tall) #Get a random value for tall
    rand_wide = rand(0...game_map_wide) #Get a random value for wide
    if game_map[rand_tall][rand_wide] == "~" #Only put a trap where there is a ~
        game_map[rand_tall][rand_wide] = "#" #Put a trap in that location if it is currently a ~
        number_of_traps -= 1 #Reduce the number of traps we need to put out by 1
    end
end
    
# Types of items:
# trap = "#"
# money = "$"

# first value is vertical, second value is horizontal

#Starting the player in a random location
bad_spot = true #Bool to keep the while running until we find a good spot
while bad_spot
    # Two random numbers to check location
    rand_start_tall = rand(0...game_map_tall)
    rand_start_wide = rand(0...game_map_wide)
    if game_map[rand_start_tall][rand_start_wide] == "~" #Making sure spot has a ~ currently
        #Sets the starting location to the randomly chosen one
        x = rand_start_tall
        y = rand_start_wide
        bad_spot = false #Ends the while loop
    end
end

player_score = 0 

# main game-map loop
playing = true 

while playing
  present_position = [x, y] #present positon is user's current positon on the map
  system('cls') #clears screen
  system('clear') # this is for mac
  # display
  (0...game_map_tall).each do |row| #loops through each of rows
    (0...game_map_wide).each do |column| #loops through each of the cells in a row 
      if present_position == [row, column] #if user position is in current cell we're looking at
        if game_map[row][column] == '#' #if current positon is on #, and user's in cell
          print 'X'
          playing = false #death
        elsif game_map[row][column] == '$'#if current positon is on $, and user's in cell
          print '!'
          game_map[row][column] = "~" 
          player_score += 1
        else #otherwise, diplay @ to show where user currently is 
          print '@'
        end
      else
        print game_map[row][column] #if user is not on this cell, print character in map
      end
    end
    puts #formatting _after done with row, moves you to next row
  end
    puts "player score: #{player_score}" 
    puts 'you died' unless playing #message to infrom user they died

   
  puts 'Press a letter'
  letter = STDIN.getch.upcase # this makes ctrl + c no longer stop a program 

  # motion : changes user's present location on map with keybpard controls
  if letter == 'W' && x > 0 
    x -= 1
  elsif letter == 'S' && x < (game_map_tall - 1)
    x += 1
  elsif letter == 'A' && y > 0
    y -= 1
  elsif letter == 'D' && y < (game_map_wide - 1)
    y += 1
  elsif letter == "Q" #quit option to exit game
    playing = false #end of main loop
  end
end

# (0...5).each do |row|
#     (0...5).each do |column|
#        if present_position == [row,column]
#            print "@"
#        else
#        print game_map[row][column]
#        end
#    end
# puts
# end

# puts "You pressed #{letter}"

