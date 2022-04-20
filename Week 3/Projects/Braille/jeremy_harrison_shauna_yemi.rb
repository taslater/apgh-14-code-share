alphabet = {}
alphabet ["a"] = {"top" => "0.", "middle" => "..", "bottom" => ".."}
alphabet ["b"] = {"top" => "0.", "middle" => "0.", "bottom" => ".."}
alphabet ["c"] = {"top" => "00", "middle" => "..", "bottom" => ".."}
alphabet ["d"] = {"top" => "00", "middle" => ".0", "bottom" => ".."}
alphabet ["e"] = {"top" => "0.", "middle" => ".0", "bottom" => ".."}
alphabet ["f"] = {"top" => "00", "middle" => "0.", "bottom" => ".."}
alphabet ["g"] = {"top" => "00", "middle" => "00", "bottom" => ".."}
alphabet ["h"] = {"top" => "0.", "middle" => "00", "bottom" => ".."}
alphabet ["i"] = {"top" => ".0", "middle" => "0.", "bottom" => ".."}
alphabet ["j"] = {"top" => ".0", "middle" => "00", "bottom" => ".."}
alphabet ["k"] = {"top" => "0.", "middle" => "..", "bottom" => "0."}
alphabet ["l"] = {"top" => "0.", "middle" => "0.", "bottom" => "0."}
alphabet ["m"] = {"top" => "00", "middle" => "..", "bottom" => "0."}
alphabet ["n"] = {"top" => "00", "middle" => ".0", "bottom" => "0."}
alphabet ["o"] = {"top" => "0.", "middle" => ".0", "bottom" => "0."}
alphabet ["p"] = {"top" => "00", "middle" => "0.", "bottom" => "0."}
alphabet ["q"] = {"top" => "00", "middle" => "00", "bottom" => "0."}
alphabet ["r"] = {"top" => "0.", "middle" => "00", "bottom" => "0."}
alphabet ["s"] = {"top" => ".0", "middle" => "0.", "bottom" => "0."}
alphabet ["t"] = {"top" => ".0", "middle" => "00", "bottom" => "0."}
alphabet ["u"] = {"top" => "0.", "middle" => "..", "bottom" => "00"}
alphabet ["v"] = {"top" => "0.", "middle" => "0.", "bottom" => "00"}
alphabet ["x"] = {"top" => "00", "middle" => "..", "bottom" => "00"}
alphabet ["y"] = {"top" => "00", "middle" => ".0", "bottom" => "00"}
alphabet ["z"] = {"top" => "0.", "middle" => ".0", "bottom" => "00"}

puts "type a word"
word = gets.chomp.downcase

(0..word.length - 1).each do |i|
print alphabet[word[i]]["top"]
end 
puts ""
(0..word.length - 1).each do |i|
print alphabet[word[i]]["middle"]
end
puts ""
(0..word.length - 1).each do |i|
print alphabet[word[i]]["bottom"]
end
