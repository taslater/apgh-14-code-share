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
#put it all in a loop
#clear shit
#make grid
    #start with a 5x5
#display it!
#recieve user input and directions
#get to the rest later???

#makes an array
game_map_tall = 10
game_map_wide = 20
game_map = Array.new(game_map_tall) { Array.new(game_map_wide) { "~" } }

#first value is vertical, second value is horizontal
#player starting positions in array
x = 2
y = 3

#loop
playing = true
while playing
    present_position = [x,y]
    system('cls')
    #system('clear') this is for mac
    #display
    (0...game_map_tall).each do |row|
            (0...game_map_wide).each do |column|
                if present_position == [row,column]
                    print "@"
                else 
                print game_map[row][column]
                end
            end
        puts
    end

    require 'io/console'
    puts "Press a letter"
    letter = STDIN.getch.upcase # this makes ctrl + c no longer stop a program, make sure to have your q = quit logic working!

    #motion
    if letter == "W" && x > 0
        x -= 1
    elsif letter == "S" && x < (game_map_tall-1)
        x +=1
    elsif letter == "A" && y > 0
        y -=1
    elsif letter == "D" && y < (game_map_wide-1)
        y +=1  
    elsif letter == "Q"
        playing = false
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

#puts "You pressed #{letter}"
