##======messaging system=====
#display options for leaving a message, retreiving a message, exiting
#storing user input as a message
#provide ID for message to be retreived

#using ID pull message out to be seen

#leave program

message = []
keepgoing = true

while(keepgoing)
        puts "Welcome to our Answering service  \nWhat would you like to do?  \na.) leave a message \nb.) retreive a message \nc.) quit"

        option = gets.chomp.downcase

    if option =="a"
        #store messages
        puts "What is the message you would like to store"
        message << gets
        puts "your message ID number is #{message.length - 1}"


    elsif option =="b"
        #retrieve message
        puts "What is the ID number of your message" 
        id = gets.chomp.to_i
        puts message[id]
          

    elsif option =="c"
        #quit
     keepgoing = false
    else
        puts "you think this is a game!?"
    end
end
