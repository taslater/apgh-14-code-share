# Night Writer

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

#create a double array
#get it working in lower case and single words
#have a loop iterate through the user input to write out the braille for each letter
#create a "library" for the braille text

braille = {
    "a" => {"top" => "0.", "middle" => "..", "bottom" => ".."},
    "b" => {"top" => "0.", "middle" => "0.", "bottom" => ".."},
    "c" => {"top" => "00", "middle" => "..", "bottom" => ".."},
    "d" => {"top" => "00", "middle" => ".0", "bottom" => ".."},
    "e" => {"top" => "0.", "middle" => ".0", "bottom" => ".."},
    "f" => {"top" => "00", "middle" => "0.", "bottom" => ".."},
    "g" => {"top" => "00", "middle" => "00", "bottom" => ".."},
    "h" => {"top" => "0.", "middle" => "00", "bottom" => ".."},
    "i" => {"top" => "0.", "middle" => ".0", "bottom" => ".."},
    "j" => {"top" => ".0", "middle" => "00", "bottom" => ".."},
    "k" => {"top" => "0.", "middle" => "..", "bottom" => "0."},
    "l" => {"top" => "0.", "middle" => "0.", "bottom" => "0."},
    "m" => {"top" => "00", "middle" => "..", "bottom" => "0."},
    "n" => {"top" => "00", "middle" => ".0", "bottom" => "0."},
    "o" => {"top" => "0.", "middle" => ".0", "bottom" => "0."},
    "p" => {"top" => "00", "middle" => "0.", "bottom" => "0."},
    "q" => {"top" => "00", "middle" => "00", "bottom" => "0."},
    "r" => {"top" => "0.", "middle" => "00", "bottom" => "0."},
    "s" => {"top" => ".0", "middle" => "0.", "bottom" => "0."},
    "t" => {"top" => ".0", "middle" => "00", "bottom" => "0."},
    "u" => {"top" => "0.", "middle" => "..", "bottom" => "00"},
    "v" => {"top" => "0.", "middle" => "0.", "bottom" => "00"},
    "w" => {"top" => ".0", "middle" => "00", "bottom" => ".0"},
    "x" => {"top" => "00", "middle" => "..", "bottom" => "00"},
    "y" => {"top" => "00", "middle" => ".0", "bottom" => "00"},
    "z" => {"top" => "0.", "middle" => ".0", "bottom" => "00"},
    " " => {"top" => " ", "middle" => " ", "bottom" => " "},
    }
    
    
    puts "What is the message you'd like to convert to braille?"
    userInput = gets.chomp.downcase.chars
    
    puts "Your message in braille is:"
    
    
    (0..userInput.length - 1).each do |i|
            print braille[userInput[i]]["top"] 
    end
    puts ""
    (0..userInput.length - 1).each do |i|
        print braille[userInput[i]]["middle"] 
    end
    puts ""
    (0..userInput.length - 1).each do |i|
        print braille[userInput[i]]["bottom"] 
    end
    