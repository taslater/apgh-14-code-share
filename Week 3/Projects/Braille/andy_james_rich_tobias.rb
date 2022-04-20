# Team 4 Andy, James, Rich, Tobias
# ==Night Writer== 

# Convert user text into braille using the traditional 2x3 square of
# dots and spaces for each letter (using a 0 for a dot and . for a space).

# Each line of text you change will end up with 3 lines of text.

# Here is the map of how to braille: https://www.pharmabraille.com/pharmaceutical-braille/the-braille-alphabet/

# Eventually we will do this with all of these bits, for now you don't
# have to make tests or anything yet, just make it function
# https://github.com/turingschool/curriculum/blob/master/source/projects/night_writer.markdown

# Example:

# Type something for me to convert:
# hello
# Your braille version is: 
# 0.0.0.0.0.
# 00.00.0..0
# ....0.0.0.
#===================


#Braille dictionary; key is the letter, the value is an array of the top two dots of the letter, then middle two dots, then bottom dots. We just did to D for testing purposes
braille = {
    "A" => ["0.", "..",".."],
    "B" => ["0.", "0.", ".."],
    "C" => ["00", "..",".."],
    "D" => ["00", ".0", ".."],
    " " => [" ", " ", " "] # This allows for the messages to have a space in them
}
#To call the array values use this form: braille["key letter"][i]; (e.g "A" - middle is braille["A"][1])

#ask the user for the message
puts "What message do you want to translate?"
    message = gets.chomp.upcase # take in the message, chomp, upper case
    letters = message.split("") # split message into array of letters

    output = "" # create output variable but leave it empty

    # This method will create a single string that when output displays the whole message translated into braille
    # The first each-loop is setting which box in the value array we're looking at, so 0 is the top line, 1 the middle, 3 the bottom
    (0..2).each do |i| 

        # The nested each-loop is finding the character the message put in and putting the equivalent braille into the output. The first time thru will do the top of the braille
        letters.each do |char|
            # If statement is checking to see if the letter is in the dictionary of characters we can translate
            if braille[char] 
                output << braille[char][i]
            end
        end

        # After each line of braille there's a linebreak so that the dots appear above each other where they should
        output << "\n"
    end

    # Prints out the output as a single string
    puts output

#======================

    # This method uses seperate strings that will be output on top of each other. Basically the same as above but instead of a single output there are three.

    puts "What message do you want to translate?"
        message = gets.chomp.upcase # take in the message, chomp, upper case
        letters = message.split("") # split message into array of letters

    # Create output variables but put nothing in them
    outputTop = ""
    outputMid = ""
    outputBot = ""

    # This each-loop goes over each character in the letters array and if it matches the one in the dictionary, assigns the appropriate braille to the corresponding output.
    letters.each do |char|
        if braille[char]
            outputTop << braille[char][0]
            outputMid << braille[char][1]
            outputBot << braille[char][2]
        end
    end

    # This prints the braille output, each section of the translation one at a time
    puts outputTop
    puts outputMid
    puts outputBot
    
