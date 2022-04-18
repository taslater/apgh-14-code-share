(1..100).each do |i|
    
    if i % 3 == 0 && i % 5 == 0
        puts "fizzbuzz"
    elsif i % 5 == 0
        puts "buzz"
    elsif i % 3 == 0
        puts "fizz"
elsif 
    puts i
end
end

# 100.downto(1) do |i|

(1..100).to_a.reverse.each do |i|
    if i % 3 == 0 && i % 5 == 0
        puts "fizzbuzz"
    elsif i % 5 == 0
        puts "buzz"
    elsif i % 3 == 0
        puts "fizz"
elsif 
    puts i
end
end
