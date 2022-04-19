##======messaging system=====
#display options for leaving a message, retreiving a message, exiting
#option a - storing user input as a message
#option a - provide ID for message to be retreived

#option b - using ID pull message out to be seen

#option c - leave program
name = []
message = []
time = []
keepgoing = true

while(keepgoing)
        puts "Welcome to our Answering service  \nWhat would you like to do?  \na.) leave a message \nb.) retreive a message \nc.) quit"

        option = gets.chomp.downcase

    if option =="a"
        #store messages
        puts"Who may I ask is leaving a message?"
        name << gets.chomp
        puts "What is the message you would like to store"
        message << gets.chomp
        time << Time.now
        puts "your message ID number is #{message.length - 1}"


    elsif option =="b"
        #retrieve message
        puts "What is the ID number of your message" 
        id = gets.chomp.to_i
        puts "at #{time[id]}"
        puts "#{name[id]} has left you the following message: #{message[id]} "


    elsif option =="c"
        #quit
     keepgoing = false
    else
        puts "you think this is a game!?"
    end
end
