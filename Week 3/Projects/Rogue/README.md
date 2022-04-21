# Rogue-like #

```ruby
grid = Array.new(8) { Array.new(8) { 0 } }

# clear the screen
system('clear')
system('cls')

# print that
(0...8).each do |row|
    (0...8).each do |column|
        print grid[row][column]
    end
    puts
end

# better drawing in miro
# maybe some ascii art

# getting a letter input without hitting enter

require 'io/console'
puts "Press a letter"
letter = STDIN.getch # this makes ctrl + c no longer stop a program, make sure to have your q = quit logic working!

puts "You pressed #{letter}"
```

## Groups ##

Team 1: PEW-PEW laser gun - Sam

* Andrew
* Tobias
* David
* Shauna

Team 2: Electric boogaloo - Kelvin

* Imani
* Rich
* Spenser
* Jessica

Team 3: Let it be - Joyce

* Yemi
* Tom
* Donna
* Joe

Team 4: Have s'more - Scott

* Renat
* Jeremy
* Harrison
* James
