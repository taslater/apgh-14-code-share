# // Ask a user for a message
# // convert that into morse code
# // spit the message back out

# char[] b = { 'A', 'B', 'C', 'D', 'E' };
# string[] c = { ".- ", "-.. ", "-.-. ", "-... ", ". " };
morse_hash = {
  "A" => ".-",
  "B" => "-...",
  "C" => "-.-.",
  "D" => "-..",
  "E" => ".",
  "F" => "..-.",
  "G" => "--.",
  "H" => "....",
  "I" => "..",
  "J" => ".---",
  "K" => "-.-",
  "L" => ".-..",
  "M" => "--",
  "N" => "-.",
  "O" => "---",
  "P" => ".--.",
  "Q" => "--.-",
  "R" => ".-.",
  "S" => "...",
  "T" => "-",
  "U" => "..-",
  "V" => "...-",
  "W" => ".--",
  "X" => "-..-",
  "Y" => "-.--",
  "Z" => "--..",
  " " => " ",
}
translating = true
while translating
  # Console.WriteLine("What message would you like to translate?");
  puts "What message would you like to translate?(use only characters 'A-Z')"
  # string message = Console.ReadLine();
  message = gets.chomp.upcase
  # message = message.ToUpper();
  # string output = "";
  out_message = ""
  message_is_good = true

  # for (int i = 0; i < message.Length; i++)
  message.split("").each do |c|
    if morse_hash.key?(c)
      # puts "#{c} is in the alphabet"
      out_message += morse_hash[c] + " "
    else
      puts "#{c} is a FORBIDDEN CHARACTER, CAN YOU READ?!?!?"
      message_is_good = false
      break
    end

    # keep space for now, come back to remove space at end of out_message
  end
  if message_is_good
    puts "your translated message is" + out_message
  end
end

# {
#    // if(message[i] == 'a')
#
#     for (int j = 0; j < b.Length; j++)
#     {
#         if (message[i] == b[j])
#         {
#             output = output + c[j];
#         }
#     }
#
# }

# Console.WriteLine("Your translated message is " + output);

# Console.ReadLine();
