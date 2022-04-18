#Loop that doesn't count by 1's
(3..100).step(3) do |i|
    puts i
end

#What about one that loops backward?​
(1..100).reverse_each do |i|
    puts i
end

#Print the numbers 1-100​
(1..100).each do |i|

    #If the number is a multiple of both, print “fizzbuzz”​
    if i % 3 == 0 && i % 5 == 0
        puts "fizz buzz"

    #If the number is a multiple of 5, instead of the number, print “buzz”​
    elsif i % 5 == 0 
        puts "buzz"

    #If the number is a multiple of 3, instead of the number, print "fizz"
    elsif i % 3 == 0
        puts "fizz"
    else
        puts i
    end
end
