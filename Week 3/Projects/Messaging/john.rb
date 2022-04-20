

# create a system to hold messages
# ask a user to save or retrieve
# when retrieving, ask for a message # and show that message
messages = []
messages = Array.new

keep_running = true
while keep_running == true

    puts "Would you like to s)ave or r)etrive a message?"
    menu_choice = gets.chomp.downcase

    if menu_choice == "s"
        # ask the user for a message
        puts "What is your message?"
        message = gets.chomp

        # put that message into storage (which we've agreed will be an array)
        messages << message
        # messages[messages.length] = message

        # tell the user where we saved their message
        # this is at messages.length - 1
        puts "Your message is at id #{messages.length - 1}"
    elsif menu_choice == "r"
        # ask the user for which id they want back
        puts "What number message would you like?"
        id = gets.to_i

        # show the message at that id
        puts "Your message is: #{messages[id]}"
    elsif menu_choice == "q"
        puts "Thank you, please come again."
        keep_running = false
    else
        puts "I don't know that option"
    end

end
