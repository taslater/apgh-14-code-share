# auto battler game
# Create a character, assign them a name. Character should have HP and money
# Create a menu. Options are buy gear, heal, and fight
# When buying gear, exchange money for an item that increases damage
# When healing, exchange money to increase HP to maximum
# When fighting, find a monster
# Turn based combat until one runs out of HP
# If player wins, gains money
# If player loses, game over, make new character
# Player should not have options other than watch fight
runGame = true # bool
puts "Welcome to Thunderdome" # welcome message
puts "Let's create your character! Please enter a name: " # asks for name
name = gets.chomp # save name variable
character = {} # hash table to store character stats
character["name"] = name # key that holds character name
character["weapon"] = {"weaponTitle" => "Sock with a Brick in it", "weaponDamage" => 8.to_i} # key that holds weapon info (including base weapon stats)
character["gold"] = {"characterGold" => 50.to_i} # key that holds money
character["hp"] = {"healthPoints" => 50.to_i} # key that holds money
while runGame # starts while loop so that if a menu is exited, returns to beginning
puts "Hi, #{name}! You have #{character["gold"]["characterGold"]} gold and #{character["hp"]["healthPoints"]} HP!" # Greets character, provides gold and HP
puts "You have a #{character["weapon"]["weaponTitle"]} that will do #{character["weapon"]["weaponDamage"]} damage" # Provides weapon information
puts "What would you like to do?" # Asks what the player wants
puts "Press 1 to buy some gear" # buy gear
puts "Press 2 to rest at the inn" # heal
puts "Press 3 to fight in the Thunderdome" # fight
puts "Press 4 to leave the game" # quit
mainMenu = gets.chomp # saves response to main menu
if mainMenu == "1" # if player chooses to buy gear
    shop = {} # hash table for shop
    shop["sword"] = {"weaponTitle" => "Sword", "weaponDamage" => 10.to_i} # weapon option 1
    shop["stick"] = {"weaponTitle" => "Stick", "weaponDamage" => 20.to_i} # weapon option 2
    puts "What would you like to buy?" # asks for purchase
    puts "Press 1: Sword (10 gold)" # purchase option 1
    puts "Press 2: Stick (4 gold)" # purchase option 2
    puts "Press 3: Leave"
    purchase = gets.chomp # saves response to purchase
    if purchase == "1" # if sword chosen
        character["weapon"]["weaponTitle"] = shop["sword"]["weaponTitle"] # replaces player's weapon name with shop weapon name
        character["weapon"]["weaponDamage"] = shop["sword"]["weaponDamage"] # replaces player's weapon damage with shop weapon damage
        character["gold"]["characterGold"] = character["gold"]["characterGold"] - 10 # subtracts weapon price from player's gold
    end # ends if loop
    if purchase == "2" # if stick chosen
        character["weapon"]["weaponTitle"] = shop["stick"]["weaponTitle"] # same
        character["weapon"]["weaponDamage"] = shop["stick"]["weaponDamage"] # same
        character["gold"]["characterGold"] = character["gold"]["characterGold"] - 4 # same
    end # end if loop
    if purchase == "3" # blank if loop to exit menu
    end # end if loop
end # end if loop
if mainMenu == "2" # if player chooses to rest at inn
    puts "Do you want to rest at the inn for 30 gold?" # presents choice
    puts "Press 1: Yes"
    puts "Press 2: No"
    rest = gets.chomp # saves response
    if rest == "1" # if yes
        character["hp"]["healthPoints"] = 50 # resets HP to maximum
        character["gold"]["characterGold"] = character["gold"]["characterGold"] - 30 # subtracts inn cost from player's gold
    end
    if rest == "2" # return to main menu
    end
end
if mainMenu == "3" # initiates fight menu
    enemy = {} # hash table for enemy stats
    enemy["hp"] = {"healthPoints" => 50.to_i} # enemy HP
    enemy["damage"] = {"enemyAttack" => 10.to_i} # enemy damage
    puts "Do you want to fight, or do you need to prepare first?" #asks if you want to fight
    puts "Press 1: Yes, I'm ready"
    puts "Press 2: I still need to get ready"
    wantToFight = gets.chomp # saves response
    if wantToFight == "1" #if the player wants to fight
        fightloop = true # bool for fight
        puts "#{name} enters the arena!" # flavor text
        puts "The enemy enters the arena!" # flavor text
        while fightloop # while loop for fight
        enemy["hp"]["healthPoints"] = enemy["hp"]["healthPoints"] - character["weapon"]["weaponDamage"] # subtracts character weapon damage from enemy HP
        puts "#{name} attacks the enemy!" # flavor text
        if enemy["hp"]["healthPoints"] <= 0 # enemy has 0 or less
            fightloop = false # fight ends
            puts "Congratulations! You win!"
            puts "You won 10 gold!" # win 10 gold
            character["gold"]["characterGold"] = character["gold"]["characterGold"] + 10 # add 10 gold to money
        elsif enemy["hp"]["healthPoints"] > 0 # if enemy has more than 0 HP
            character["hp"]["healthPoints"] = character["hp"]["healthPoints"] - enemy["damage"]["enemyAttack"] # subtracts enemy damage from character HP
            puts "The enemy attacks #{name}" # flavor text
            puts "You have #{character["hp"]["healthPoints"]} HP." # test for character damage
            puts "Would you like to forfeit?"
            puts "Press 1: Keep Fighting"
            puts "Press 2: Forfeit"
            stopfighting = gets.chomp
            if stopfighting == "1"
            end
            if stopfighting == "2"
                fightloop = false
                puts "You lose 10 gold for forfeiting"
                character["gold"]["characterGold"] = character["gold"]["characterGold"] - 10
            end
        end
        if character["hp"]["healthPoints"] <= 0 # if character has 0 or less HP
            fightloop = false # fight ends
            puts "You lost"
            runGame = false # game ends
        end
        end
    end # end fight
    if wantToFight == "2" # return to main menu
    end
end
if mainMenu == "4" # If player wants to quit
    puts "See you later!" # flavor text
    runGame = false # ends game
end
end
# buy sword(actual weapon!), 10 damage, 10 gold
# buy stick(lethal joke weapon), 20 damage, 4 gold
# stay at inn(HP to full), 30 gold
# enemy attacks second, 10 damage, 50 HP
# if name reaches 0 HP, game ends
# if enemy reaches 0 HP, reward 10 gold and return to menu
# if quit, end game
