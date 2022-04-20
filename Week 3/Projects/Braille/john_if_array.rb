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

# a = ["0.", "..", ".."]
# b = ["0.", "0.", ".."]

letters = [
    ["0.", "..", ".."],
    ["0.", "0.", ".."]
]

message.each_char do |letter|
    if letter == "a"
        top = top + letters[0][0]
        middle = middle + letters[0][1]
        bottom = bottom + letters[0][2]
    end
    if letter == "b"
        top = top + letters[1][0]
        middle = middle + letters[1][1]
        bottom = bottom + letters[1][2]
    end
end

# print out the new version of the message
puts top
puts middle
puts bottom
