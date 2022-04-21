
# Create an auto-battler game.

# In this game, you should create a character. This can consist of giving it a name. Or more, up to you. Mostly a name. Maybe a job? The character should be assigned some number of hp.

# There should be a main menu, from this menu, the player should be able to:

#Making the character:

#name
#wallet
#hp status
#equipment
#tracking inventory

# 1) Buy some gear

#present user with list of items for purchase
#let user select which items to buy
#check how much money user has
#do math and see what they can afford
#when they purchase items, deduct from their available funds
# 2) Go heal

#ask them if they want to heal
#tell them cost to heal
#check to see if they can afford it
#if they can afford. heal and deduct cost
# 3) Look for a fight

#find a monster
#player and monster take turns doing damage
#winner takes money
#if player loses. present option to make new character

# When buying gear, the player should be able to buy an item that gives them more damage when looking for a fight. (A sword, a stick, a book of insults, a biochemistry textbook in a sock) - This should cost money

# When healing, the player should be charged money to put their health points up to the maximum level

# When looking for a fight, the player should find a monster. The player and the monster should take turns doing damage to each other until one is out of health points. If the monster loses, the player gains some money. If the player loses, the game is over and they must make a new character. The player should not be given any options during the fight, they should just watch it happen and find out the results.

puts 'Welcome to insert game name!'

#get name and setting character variables
# each stat has a starting value that doesn't change and a current value that does
# capital letters makes a thing a constant
puts 'Please name your character!'
name = gets.chomp

WALLET = 0
wallet = WALLET

HP = 20
hp = HP

DAMAGE = 1
damage = DAMAGE

# Define shop inventory
# itemName => [cost, damage]
shop = { 'stick' => [1, 1], 'sword' => [5, 5], 'magic sword' => [50, 25] }

#main menu selection and current stats
while true
  puts "Welcome #{name}! You have #{wallet} gold coins and #{hp} HP."
  puts "Menu: \na) Buy gear \nb) Heal \nc) Look for a fight"
  selection = gets.chomp.downcase

  #player selections
  #if you select go to shop and buy gear: deduct cost and add damage
  if selection == 'a'
        puts 'Welcome to the shop. What would you like to buy?'
        #Build the shop menu
        #shop.each do |item_name, item_stats| 
        # Allign columns TODO later
        shop.each_with_index do |(item, stats), index|
            puts " #{index} |  #{item} | cost: #{stats[0]} | dmg: #{stats[1]}"             
        end
        shop_selection = gets.to_i
        
        # puts shop.keys[shop_selection];
        if wallet >= shop.values[shop_selection][0]
            damage = shop.values[shop_selection][1]
            wallet = wallet - shop.values[shop_selection][0]
        puts "Thank you for your business. Please come again."
        else 
        puts "You're broke"
        end


        # puts "a) stick-1 gold coin \nb) sword-5 gold coins \nc) exit"
        # item = gets.chomp.downcase
        # if item == 'a'
        #   wallet = wallet - 1
        #   damage = damage + 1
        # end
        # if item == 'b'
        #   wallet = wallet - 5
        #   damage = damage + 5
        # end
        # if item == 'c'
        #   #shopping = false
        # end
  end
  
  #if you select heal: go to back alley: deduct cost and add hp
  if selection == 'b'
        puts 'Welcome to the mystical back alley'
        puts "Your hp is currently: #{hp}. You max hp is: #{HP}."
        puts 'Would you like to heal? That will be 10 gold coins. y/n'
        heal = gets.chomp.downcase

        # if they choose "yes" to heal
        if heal == 'y'
            # TODO: check if they have enough money
            puts "Ok poff you're healed!"

            # set HP to default
            hp = HP

            # charge them money
            wallet = wallet - 10
        end
        if heal == 'n'
            #if they choose not to heal
            puts "Ok see you next time. Hope you don't die."
        end
  end

  # TODO: hash table for different enemies
  #if you select fight: damages to player and goblin until one dies
  if selection == 'c'
        #Hash of enemies. Key is monster name, values are Damage, HP, purse, and randomization number sort of probability but not technically
        enemies = {"Goblin" => [1, 5, 5, 35], "Blue Slime" => [3, 15, 10, 55], "Bugbear" => [6, 35, 18, 85], "Phase Spider" => [15, 69, 25, 98], "Dragon" => [50, 300, 1000000, 100]}
        # Give us a random number between 1 and 100
        random_enemy = rand(1..100)
        # Making enemy variables but leave empty
        enemy_name = ""
        enemy_damage = 0
        enemy_health = 0
        enemy_purse = 0

        #This loop checks the 'probability' in the enemies hash versus the random number generated to see which one we're fighting.
        puts random_enemy
        enemies.each do |name, stats|
            if random_enemy <= stats[3]
                puts "You found a wild #{name}!"
                enemy_name = name
                enemy_damage = stats[0]
                enemy_health = stats[1]
                enemy_purse = stats[2]
                break
            end
        end

        puts "your hp: #{hp}, enemy hp: #{enemy_health}"
        while true 
            #Player does damage
            enemy_health = enemy_health - damage

            # print current damage
            puts "your hp: #{hp}, enemy hp: #{enemy_health} - you did #{damage} damage"

            #checks to see if goblin is dead
            if enemy_health <= 0
                # if goblin is dead, add money to wallet and leave fight
                puts "You defeated the #{enemy_name}!"
                wallet = wallet + enemy_purse
                break
            end

            # Enemy does damage
            hp = hp - enemy_damage

            #print current damage
            puts "your hp: #{hp}, enemy hp: #{enemy_health} - enemy did #{enemy_damage} damage"

            #checks to see if player dies
            if hp <= 0
            #TODO: handle character death
                #if player dies... nothing happens yet
                puts "You've been defeated!"
                break
            end
            #pause for a moment so user can see HP going down
            sleep 0.5
        end




    end

    

    #   if selection == 'c'
    #     puts 'You found a goblin to fight!'
    #     enemy_health = 5
    #     goblin_dmg = 1

    #     puts "your hp: #{hp}, enemy hp: #{enemy_health}"
    #     while true
    #       # system('cls') || system('clear')

    #       # Player does damage
    #       enemy_health = enemy_health - damage

    #       # print current damage
    #       puts "your hp: #{hp}, enemy hp: #{enemy_health} - you did #{damage} damage"

    #       #checks to see if goblin is dead
    #       if enemy_health <= 0
    #         # if goblin is dead, add money to wallet and leave fight
    #         puts 'You defeated the goblin!'
    #         wallet = wallet + 5
    #         break
    #       end

    #       # Enemy does damage
    #       hp = hp - goblin_dmg

    #       #print current damage
    #       puts "your hp: #{hp}, enemy hp: #{enemy_health} - enemy did #{goblin_dmg} damage"

    #       #checks to see if player dies
    #       if hp <= 0
    # #TODO: handle character death
    #         #if player dies... nothing happens yet
    #         puts "You've been defeated!"
    #         break
    #       end
    #       #pause for a moment so user can see HP going down
    #       sleep 0.5
    #     end
    #   end
end

# puts wallet
# puts damage
# puts hp

