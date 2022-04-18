# Ask user for length, width of box
puts "How long is your garden box? (in feet)"
length = gets.chomp.to_i
puts "How wide is your garden box? (in feet)"
width = gets.chomp.to_i

area = length * width
perimeter = 2 * (length + width)

# What formula should we choose?
# squares = area / 16
squares = (length / 4) * (width / 4)

# Tell them the area of the box​
puts "The area of your garden box is #{area} square feet."

# Tell them the perimeter of the box​
puts "The perimeter of your garden box is #{perimeter} feet."

# Tell them how many carrots/beets/corn they can plant​

# Carrots = 16 per 4x4 square (1 per sq foot)​
puts "You can plant #{16 * squares} carrots."

# Corn = 3 per 4x4 square​
puts "You can plant #{3 * squares} corn."

# Beets = 9 per 4x4 square
puts "You can plant #{9 * squares} beets."