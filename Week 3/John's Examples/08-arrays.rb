
number = 10
name = "john"

# creating an array
colors = ["red", "blue", "green"]

# printing out one item
puts colors[0]

# printing out everything in an array
puts colors

# printing out everything in an array
puts colors[0..2]

# printing out everything in an array
(0..2).each do |i|
    puts colors[i]
end

# printing out everything in an array
colors.each do |single_color|
    puts single_color
end

# add to an array
colors << "purple"

# add to an array
colors[4] = "orange"

# add to an array
colors[colors.length] = "brown"

puts colors

# how dare you
colors[10] = "yellow"

puts colors


# Three states of a variable (which includes a spot in an array)
# Defined and has value
# x = 12 - ruby knows about that variable and it has a value in it
# Defined and has no value
# nil - ruby knows about that variable but no value is in it
# Undefined
# ruby doesn't even know that variable name
