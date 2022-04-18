# puts to the console for user display
puts "Hi, what's your name?"

# chomp bites off the newline (\n) from the user input
name = gets.chomp

puts "Why, hello #{name}!\nHow old are you?"

# .to_i converts the string to an integer
age = gets.chomp.to_i

# string interpolation is fun and readable
puts "In five years time, you'll be #{5 + age.to_i}!"