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

puts "\nThanks for playing!"

# Garden Boxes:​
puts "\nNon sequitur: let's talk about garden boxes."

# Ask user for length, width of box
puts "How long is your garden box? (in feet)"
length = gets.chomp.to_i
puts "How wide is your garden box? (in feet)"
width = gets.chomp.to_i

area = length * width
perimeter = 2 * (length + width)

# Tell them the area of the box​
puts "The area of your garden box is #{area} square feet."

# Tell them the perimeter of the box​
puts "The perimeter of your garden box is #{perimeter} feet."

# What formula should we choose?
# squares = area / 16
squares = (length / 4) * (width / 4)

# Ask the user what they want to plant and only show that option
puts "What do you want to plant?\n a) carrots\n b) corn\n c) beets"
plant_choice = gets.chomp
case plant_choice
when "a"
    # Carrots = 16 per 4x4 square (1 per sq foot)​
    puts "You can plant #{16 * squares} carrots."
when "b"
    # Corn = 3 per 4x4 square​
    puts "You can plant #{3 * squares} corn."
when "c"
    # Beets = 9 per 4x4 square
    puts "You can plant #{9 * squares} beets."
else
    puts "I don't understand #{plant_choice}"
end



