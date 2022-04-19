#build an array that we can put messages into
#get the messages back out
#build a menu to let the user choose

messages = []
runMenu = true
while (runMenu == true)
    puts "Press A to store a message"
    puts "Press B to retrieve a message"
    puts "Press C to exit"
    menuInput = gets.chomp.downcase
    if menuInput == 'a'
        puts "Please enter your message"
        messages[messages.length] = gets
        puts "Your message is in slot #{messages.length}"
    end
    if menuInput == 'b'
        puts "Please enter the message number"
        messageCode = gets.chomp.to_i
        puts messages[messageCode - 1]
    end
    if menuInput == 'c'
        puts "Goodbye"
        runMenu = false
    end
end
