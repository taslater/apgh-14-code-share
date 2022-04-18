# take in a name
# see if it is more than 10 characters
# see if it has a certain letter in it

# puts "What is your name?"
# name = gets

# if name.length > 10
#     puts "That's a long name!"
# end

# if name.include? "a"
#     puts "You've got an a in your boot"
# end

puts "What is the length of the box?"
length = gets.to_i

puts "What is the width of the box?"
width = gets.to_i

area = length * width
perimeter = 2 * length + 2 * width

puts "The area of your box is #{area} and the perimeter is #{perimeter}"

puts "What plant are you planting? (corn, carrots, beets)"
plant = gets.chomp

if plant == "corn"
    puts "You can plant #{3.0 / 16 * area} corns"
elsif plant == "carrots"
    puts "You can plant #{16.0 / 16 * area} carrots"
elsif plant == "beets"
    puts "You can plant #{9.0 / 16 * area} beets"
end
