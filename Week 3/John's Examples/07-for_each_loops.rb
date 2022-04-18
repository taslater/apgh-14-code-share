(1..10).reverse_each do |i|
    puts i
end

(1..10).to_a.reverse.each do |i|
    puts i
end

10.downto(1) do |i|
    puts i
end

puts "Modulo"
(1..100).each do |i|
    if i % 3 == 0
        puts i
    end
end

puts "While"
counter = 0;
while counter < 100
    puts counter
    counter += 3
end

puts "Step(3)"
(0..100).step(3) do |i|
    puts i
end
