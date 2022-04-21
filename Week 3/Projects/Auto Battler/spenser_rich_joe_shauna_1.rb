#make it simple first
#1 weapon, 10 health, 1 healing item, 1 enemy, money
#shop may be most difficult - how to adjust inventory levels
#create an interface for the user to interact with the game
#start out with asking a name for their character
    #explore/encounter a monster
    #visit the shop
    #heal
#hash for character - need to be able to 
    #health => 10
    #attack => 
    #number of medkits => 1
    #money =>
#hash for monster
    #health => 10
    #weapon => club
    #hit or miss via randomized counter
    #eventually diversify the weapons

#Take a look at the shop to adjust what can be sold
#make it so that attack and hp are adjustable
# Adjust variable names, such as health/hp
    #declare these variables above the game loop
    #make the names the same so the variables are adjusted through the game
#make multiple enemies
#setup an inventory system
#create a variable for gold for the shop

#change each if statement from the main menu into functions to reduce lines of code in main game

require './shop_method'

puts "Before we begin, I'll need to know who you are. What do people call you around here?"
userName = gets.chomp
puts "Well met #{userName}"

puts "And I don't mean to pry too much but do tell what zodiac you were born under."
userZodiac = gets.chomp
puts "How auspicious, I knew a #{userZodiac} once, not sure what happened to him though...Anyway! Let's get started!"
gets

puts "Your horse carriage slowly comes to a halt"
gets

puts "As you stroll into town, the chatter of people rushing by and the noise of the market fills your ears.\nThe scent of fresh baked bread wafts by."
gets
               
puts "Welcome to BloomHill Morning Heights!\nThe place where you'll test your might against hordes of goblins, maybe, that's up to you."
gets

system ("cls")

keepGoing = true
player = {"hp" => 10, "atk" => 1}
goblin = {"hp" => 3, "atk" => 1}
# monsters ={
#     "goblin" = {"hp" => 3, "atk" => 1}
#     "bandit" = {"hp" => 5, "atk" => 2}
# }

while keepGoing
    puts "What is it that you would like to do?"
    puts "A) To the thrill of adventure! (mostly goblins tho)"
    puts "B) Address your health concerns"
    puts "C) Visit the shop"
    puts "D) I'm done for now"
    userAnswer = gets.chomp.downcase

    if userAnswer == "a"

    adventure = true
    while (adventure)
    puts "you have encountered a Goblin! \nWhat will you do? \na-fight em \nb-flee"
    option =gets.chomp.downcase
    if option == "a"
        #do the fight
        puts "thus the fight begins, you have #{player["hp"]} HP"

        fight = true
        while (fight)
            puts"you strike the Goblin"
            goblin["hp"] -= player["atk"]
            puts "the Goblin scratches you!"
            player["hp"] -= goblin["atk"]

            if player["hp"]==0
                puts "you've been slain by the gobling"
                adventure = false
            elsif goblin ["hp"] ==0
                puts "You have slain the beast!" 
                puts "your currently have #{player ["hp"]} HP."
                
                puts "Would you like to continue adventuring? y/n"
                    fightOption =gets.chomp.downcase
                    
                    if fightOption == "y"
                        puts "Good on ya adventurer \nYou take a deep breath and continue on your way"
                    elsif fightOption == "n"
                        puts "*you return to town*"
                        fight = false
                        adventure = false
                    end
                        
                
            end
        end
    end
    if option =="b"
        #flee the encounter
        puts"*you run from the beast and return to town*"
        adventure = false
    end
end

    end

    if userAnswer == "b"

        hp = 7

medkit = 2

healing = true 
while healing
health = hp   
puts "Hello traveler! Medkits will increase your health, +2.\n 
Your current health is #{health} and you have #{medkit}.\n"
puts "What would you like to do:\n
     Heal (h)? \n 
    Return to Start? (s)"
    choice = gets.chomp

    # heal
    if choice == "h" && hp <= 8
        puts "You have been healed! Your new health is #{hp+2} hp! \n
        You have #{medkit - 1} medkits remaining."
        hp = hp+2
        medkit = medkit - 1
    elsif choice == "h" && hp >= 9
        puts "Don't be greedy! Be on your way..."
    end

    # start
    if choice == "s"
        puts "Be well, traveler!"
    healing = false
    end
end


    end

    if userAnswer == "c"

        #<----------shop method---------->
        shop_method
    

    end

    if userAnswer == "d"
        puts "Are you sure about that? Y/N"
        leave = gets.chomp.downcase

        if leave == "y"
            keepGoing = false
            puts "Well, it was nice knowing you #{userName}, see you next time."
            gets
        elsif leave == "n"
            keepGoing = true
        end
    end
    system ("cls")
end




def shop_method
    shop = true
        while shop
        menu = {
        "a: sword" => 100,
        "b: medkit" => 50,
        "c: cup of coffee" => 1
    }
    puts ""
    puts "Welcome to the shop!"
    puts "a: buy an item."
    puts "b: sell an item."
    puts "c: exit shop."
    shop_choice = gets.chomp.downcase
    
    if shop_choice == "a"
        system("clear")
        puts "What would you like to buy?"
        menu.each do |item, cost|
            puts "#{item}: #{cost}-gold"
        buy_choice = gets.chomp
            if buy_choice == "a"
                puts "sword aquired!"
                gold -= 100
                #player_inventory[sword] + 1
            elsif buy_choice == "b"
                puts "metkit aquired!"
                gold -= 50
                #player_inventory[medkit] + 1
            elsif buy_choice == "c"
                puts "cup of coffee!"
                gold -= 1
                #player_inventory[coffee] + 1
            end
        
        end
        puts ""
    
    elsif shop_choice == "b"
        puts "What would you like to sell?"
        sellChoice = gets.chomp
    
    else shop_choice == "c"
    puts "goodbye!"
    shop = false
    end
    end
    end
