# Group 4 - Kelvin
# Tobias, Andy, James (not here), Rich

# Ask the user for a message
# Return that message translated into morse code

# What is your message?
# > hello
# Your message is: .... . .-.. .-.. ---

# Define the morse for each character
alpha = {
    "A"	=> ".-",
    "B"	=> "-...",
    "C"	=> "-.-.",
    "D"	=> "-..",
    "E"	=> ".",
    "F"	=> "..-.",
    "G"	=> "--.",
    "H"	=> "....",
    "I"	=> "..",
    "J"	=> ".---",
    "K"	=> "-.-",
    "L"	=> ".-..",
    "M"	=> "--",
    "N"	=> "-.",
    "O"	=> "---",
    "P"	=> ".--.",
    "Q"	=> "--.-",
    "R"	=> ".-.",
    "S"	=> "...",
    "T"	=> "-",
    "U"	=> "..-",
    "V"	=> "...-",
    "W"	=> ".--",
    "X"	=> "-..-",
    "Y"	=> "-.--",
    "Z"	=> "--..",
    " "	=> "/"
}

# Ask user for a message
puts "What message do you want to translate?"

# Accept the message, chomp it, uppercase it
message = gets.chomp.upcase

# Put the message into an array 
chars = message.split("") # "test" => ["t", "e", "s", "t"]

# Create the `morse` variable
outputString = ""

# each loop through each item in the `chars` array (each character in `message` string)
# "char" is the name we are giving the character we are looking at. Equivalent to chars[i] in C#
chars.each do |char|

    # if this letter exists in `alpha`
    # (will skip characters we don't have a translation for instead of giving an error)
    if alpha[char]

        # adds the morse for this letter to `outputString`
        outputString << alpha[char]

        # adds a space after each morse character
        outputString << " "

    end # end of IF statement
end # end of EACH loop

# Outputs the translated string
puts outputString
