counter = 0
while counter < 10
    puts "Hello there!"
    counter += 1
end

keepLooping = true
while keepLooping
    puts "You're pretty cool"
    
    puts "Would you like another compliment? (y/n)"
    answer = gets.chomp
    if answer == "n"
        keepLooping = false
    end
end
