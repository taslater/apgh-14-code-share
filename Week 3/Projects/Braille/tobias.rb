# What positions each number maps to:
# 1 4
# 2 5
# 3 6

patterns = {
    'a' => '1',
    'b' => '12',
    'c' => '14',
    'd' => '145',
    'e' => '15',
    'f' => '124',
    'g' => '1245',
    'h' => '125',
    'i' => '24',
    'j' => '245',
    'k' => '13',
    'l' => '123',
    'm' => '134',
    'n' => '1345',
    'o' => '135',
    'p' => '1234',
    'q' => '12345',
    'r' => '1235',
    's' => '234',
    't' => '2345',
    'u' => '136',
    'v' => '1236',
    'w' => '2456',
    'x' => '1346',
    'y' => '13456',
    'z' => '1356',
    ' ' => '',
    '?' => '236'
  }
  
  # This set of variables is more human-readable (for humans who can read braille visually)
  # The alignment might break if your monospace font doesn't include these characters
  on = '● '
  off = '○ '
  space = ' '
  
  # # This set of variables matches the assignment & test cases
  # on = "0"
  # off = "."
  # space = ""
  
  # Get the string we're convering
  puts 'Type something for me to convert:'
  input = gets.chomp.downcase
  
  # Establish the row we are currently adding to
  row = 0
  
  # Establish that there are three rows of characters
  output = ['', '', '']
  
  # Convert _input_ string to an array of single characters
  input
    .split('')
    .each do |char|
      # If _char_ doesn't exist in _patterns_, post a message and convert it to a question mark
      if !patterns[char]
        puts "Unknown character: #{char}."
        char = '?'
      end
  
      # Loop through numbers 1-6 to set each of the 6 positions in a pattern
      (1..6).each do |i|
        # Check if the _patterns_ value for key _char_ includes _i_ (as a string)
        # Add the appropriate character ( _on_ or _off_ ) to the correct row in _output_
        if patterns[char].include? i.to_s
          output[row] << on
        else
          output[row] << off
        end
  
        # Iterate through the three rows
        # I could also continually count up and use modulo to get the 0-1-2 loop
        if row == 2
          row = 0
        else
          row += 1
        end
      end
  
      # Add _space_ to each row of _output_ at the end of each cell
      output.each { |n| n << space }
    end
  
  # Once _output_ has been built, print it
  puts 'Your braille version is:'
  puts output
  
  