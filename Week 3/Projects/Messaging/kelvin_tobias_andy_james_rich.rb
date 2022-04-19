# Andy, Tobias, Rich, James, Team 4
message = [] # new blank array
running = true

while running
  puts 'What would you like to do?'
  puts " a) Save a message\n b) Retrieve a message \nc) Delete a message\n q) Quit"
  menuChoice = gets.chomp.downcase
  if menuChoice == 'a'
    puts "\nWhat do you have to say?"
    message[message.length] = gets
    puts "Your message is saved in box #{message.length - 1}"
    gets
  elsif menuChoice == 'b'
    puts "\nWhat message you want?"
    input = gets.to_i
    puts message[input]
    gets
  elsif menuChoice == 'c'
    puts "\n What message do you want destroyed?"
    input = gets.to_i
    message[input] = ''
    puts 'That message is no more.'
  elsif menuChoice == 'q'
    running = false
  else
    puts 'Does not compute.'
    gets
  end
  system('cls')
end
