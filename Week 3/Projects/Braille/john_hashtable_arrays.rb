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

# (0...message.length).each do |i| # [0, 1, 2, 3]
#     puts message[i]
# end

# a = ["0.", "..", ".."]
# b = ["0.", "0.", ".."]

letters = {
    "a" => ["0.", "..", ".."],
    "b" => ["0.", "0.", ".."]
}

message.each_char do |letter| # ["a", "b", "b", "a"]
    top = top + letters[letter][0]
    middle = middle + letters[letter][1]
    bottom = bottom + letters[letter][2]
end

# print out the new version of the message
puts top
puts middle
puts bottom
