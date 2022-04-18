(1..100).each do |i|
    if i % 5.0 == 0 && i % 3.0 == 0
        puts "fizzbuzz"
    elsif i % 3.0 == 0
        puts "fizz"
    elsif i % 5.0 == 0 
        puts "buzz"
    else puts i
    end
end
