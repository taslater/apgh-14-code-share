#ask what they wanna do
#save message
#dump message into array
#retrieve
#exit
#==========
#need a loop in here to keep the whole thing going
messages=[]
working = true
while working
#puts a menu
    puts "Would you like to"
    puts "A) leave a message"
    puts "B) retrieve a message"
    puts "C) exit/quit/leave/whatever"
    #recieve task input and store it (make a variable here, probably)
    input = gets.chomp.upcase
    #if statementsx3 to navigate between options
        #if they wanna "write-and-save" a message
        if input == "A"
            #puts "ask for message"
            puts "please enter your message to be saved"
            #recieve message and add to array
            userMessage = gets.chomp
            messages<<userMessage
            #report the message number
            puts "Your message number is #{messages.length-1}"
        end
        #if they wanna get a message we need to ask what message they want
        #store that input and grab a message from it
    #Dave Lasky Special on the error messages
        #if for quit message
        #switch working to false
#always close your loops
end
