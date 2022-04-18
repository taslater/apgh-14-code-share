# Get user name
puts "Hi, what's your name?"
name = gets.chomp

# Does their name contain a certain letter?​
puts "\nPick a letter:"
# get just the first character from user input
letter = gets.chomp[0]

notMaybe = (name.include? letter) ? "" : "not "

puts "\n'#{name}' does #{notMaybe}include the character '#{letter}'."

# Is their name more than 10 characters long?​
notMaybe = (name.length > 10) ? "" : "not "
puts "\n'#{name}' is #{notMaybe}greater than ten characters."

# Can you make something more complex with what you have?​
# convert __name__ to an array of characters and alphabetize them using 'casecmp'
# then join them back together
puts "\nIf you alphabetize the characters in '#{name}' you get '#{name.chars.sort(&:casecmp).join}'. Weird."

puts "\nThanks for playing!\n"

# Garden Boxes:​

# Ask the user what they want to plant and only show that option