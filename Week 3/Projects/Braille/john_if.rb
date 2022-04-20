# convert a message from english to braille characters
puts "What is your message?"
message = gets.chomp


top = ""
middle = ""
bottom = ""

# do some garbage to message
# look at every letter in message
# do something based on that letter
# cool
# message.split("").each do |letter| # message.chars.each 
#     puts letter
# end

# (0...message.length).each do |i|
#     puts message[i]
# end

message.each_char do |letter|
    if letter == "a"
        top = top + "0."
        middle = middle + ".."
        bottom = bottom + ".."
    end
    if letter == "b"
        top = top + "0."
        middle = middle + "0."
        bottom = bottom + ".."
    end
end

# print out the new version of the message
puts top
puts middle
puts bottom
