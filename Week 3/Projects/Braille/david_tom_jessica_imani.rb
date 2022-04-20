#make a hashtable for the alphabet and the braille rows
#iterate through a message
#print top row of message
#print middle row of message
#print bottom row of message

braille_hash = {
    "A"=>["0.","..",".."],
    "B"=>["0.","0.",".."],
    "C"=>["00","..",".."],
    "D"=>["00",".0",".."],
    "E"=>["0.",".0",".."],
    "F"=>"..-.",
    "G"=>"--.",
    "H"=>"....",
    "I"=>"..",
    "J"=>".---",
    "K"=>"-.-",
    "L"=>".-..",
    "M"=>"--",
    "N"=>"-.",
    "O"=>"---",
    "P"=>".--.",
    "Q"=>"--.-",
    "R"=>".-.",
    "S"=>"...",
    "T"=>"-",
    "U"=>"..-",
    "V"=>"...-",
    "W"=>".--",
    "X"=>"-..-",
    "Y"=>"-.--",
    "Z"=>"--..",
    " "=> " ", 
}
#make an user_message
user_message = "ABC"
#iterate through the rows, from top to bottom
(0..2).each do |row_index|
    #make an empty variable to build a row of characters
    current_row = ""
    #break the message apart into characters
    user_message.split("").each do |c|
        #updated current_row  past current_row, plus the charcter we just translated      
         current_row = current_row + braille_hash[c][row_index] + " "
     end
     puts current_row
    #puts row_index
end


# translating = true
# while translating 
#     # Console.WriteLine("What message would you like to translate?");
#     puts "What message would you like to translate?(use only characters 'A-Z')"
#     # string message = Console.ReadLine();
#     message = gets.chomp.upcase
#     # message = message.ToUpper();
#     # string output = "";
#     out_message = ""
#     message_is_good = true

#     #for (int i = 0; i < message.Length; i++)
#     message.split("").each do |c|
#         if morse_hash.key?(c)
#             #puts "#{c} is in the alphabet"
#             out_message += morse_hash[c] + " "
#         else
#             puts "#{c} is a FORBIDDEN CHARACTER, CAN YOU READ?!?!?"
#             message_is_good = false
#             break
#         end
        
#         #keep space for now, come back to remove space at end of out_message
#     end
#     if message_is_good
#         puts "your translated message is" + out_message
#     end
# end
