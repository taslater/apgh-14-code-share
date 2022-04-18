#count from 1 to 10 ---
#checking for multiples of 2 ---
#if yes print 
#if no skip

# (1..10).each do |i|
#     if i%2 == 0
#         puts i 
#     end
#     # if i%2 != 0
#     #     next
#     # end
# end


# (1..10).reverse_each do |i|
#     puts i 
# end

#count from 1-100
#check for multiples of 3
#check for multiples of 5
#make a variable that is our output
#if multiple of 3 add fizz to output
#if multiple of 5 add buzz to output
#if niether print i

(1..100).each do |i|
    output = ""
    # if i%15 == 0
    #     output = output + "fizzbuzzz"
    #    # puts output
    # end
        
    if i%3 == 0
        output = output + "fizz"
       # puts output 
    end

    if i%5 == 0
        output = output + "buzz"
      #  puts output 
    end

    if i%3 != 0 && i%5 != 0
        output = output + i.to_s
        #puts output
    end
    puts output
end
