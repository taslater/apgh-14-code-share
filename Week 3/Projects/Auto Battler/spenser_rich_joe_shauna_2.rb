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

#Ended up changing this bit to def game, which defined the game as a function running the other functions within
    #END runs what's in the brackets last, despite being written first
    #our functions that are called in for the start menu are run first
        #so that the computer can define the functions and then get used in the game


        def game

            player = {"hp" => 10, "atk" => 1, "gold" => 300, "medkit" => 2, "coffee" => 2}
            goblin = {"hp" => 3, "atk" => 1}
            
            #Moved these variables into the hashes so they could be edited and store the edits across the game/functions
                # gold = 300
                # medkit = 2
                # coffee = 2
            #begin the game
            #receive the user name
            puts "Before we begin, I'll need to know who you are. What do people call you around here?"
            userName = gets.chomp
            puts "Well met #{userName}"
        
            #receive the zodiac sign because why not
            puts "And I don't mean to pry too much but do tell what zodiac you were born under."
            userZodiac = gets.chomp
            puts "How auspicious, I knew a #{userZodiac} once, not sure what happened to him though...Anyway! Let's get started!"
            gets
        
            #setting the stage for the game
            #the gets below each puts lets the user read each line before moving to the next by hitting enter
            puts "Your horse carriage slowly comes to a halt"
            gets
        
            puts "As you stroll into town, the chatter of people rushing by and the noise of the market fills your ears.\nThe scent of fresh baked bread wafts by."
            gets
                        
            puts "Welcome to BloomHill Morning Heights!\nThe place where you'll test your might against hordes of goblins, maybe, that's up to you."
            gets
        
            #clearing the terminal window to begin the game loop
            system ("cls")
           
            keepGoing = true #boolean value keeps the game running. if equals false the game will end
        
            #potential option to have multiple different monsters
            # monsters ={
            #     "goblin" = {"hp" => 3, "atk" => 1}
            #     "bandit" = {"hp" => 5, "atk" => 2}
            # }
        
            #beginning of the game loop
            while keepGoing
                puts "What is it that you would like to do?"
                puts "A) To the thrill of adventure! (mostly goblins tho)"
                puts "B) Address your health concerns"
                puts "C) Visit the shop"
                puts "D) I'm done for now"
                userAnswer = gets.chomp.downcase
        
                #enters each if statement/function based on the user answer. the functions are listed at the end of the game loop
                if userAnswer == "a"
        
                adventure_method player, goblin #the variables need to be declared here so the function knows which ones to include when it runs
                #listing the variables was one of the road blocks we encountered to making the functions work
        
                end
        
                if userAnswer == "b"
        
                healing_method player
        
                end
        
                if userAnswer == "c"
        
                shop_method player
        
                end
        
                #ends the game
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
                #clears the terminal window everytime a function is completed and resets to the start menu
                system ("cls")
            end
        end
        
        
        
        
        #this is where our functions live
        
        
        
        #<---adventure method--->
        
        def adventure_method player, goblin #calls the variables
        
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
        
                            if player["hp"] <= 0
                                puts "you've been slain by the goblin"
                                adventure = false
                            elsif goblin ["hp"] <= 0
                                puts "You have slain the beast!" 
                                puts "your currently have #{player ["hp"]} HP."
                                
                                puts "Would you like to continue adventuring? y/n"
                                    fightOption = gets.chomp.downcase
                                
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
            end
        
            if option =="b"
                #flee the encounter
                puts"*you run from the beast and return to town*"
                adventure = false
            end
        end
        
        # #<---healing method--->
        
        def healing_method player
           
            healing = true 
            while healing
                health = player["hp"]   
                puts "Hello traveler! Medkits will increase your health, +2.\n 
                    Your current health is #{health} and you have #{player["medkit"]}.\n"
                puts "What would you like to do:\n
                    Heal (h)? \n 
                    Return to Start? (s)"
                choice = gets.chomp
            
                # heal
                if choice == "h" && player["hp"] <= 8
                    puts "You have been healed! Your new health is #{player["hp"]+2} hp! \n
                    You have #{player["medkit"] - 1} medkits remaining."
                    player["hp"] = player["hp"]+2
                    player["medkit"] = player["medkit"] - 1
                elsif choice == "h" && player["hp"] >= 9
                    puts "Don't be greedy! Be on your way..."
                end #this is the end for line 178
            
                # start
                if choice == "s"
                    puts "Be well, traveler!"
                healing = false
                end #this is the end for line 188
            end    
        end
        
         #<----------shop method---------->
        def shop_method player
            menu = {
            "a: sword" => 100,
            "b: medkit" => 50,
            "c: cup of coffee" => 1
            }
        shop = true
            while shop
        
        puts "Welcome to the shop! You have #{player["gold"]} gold"
        puts "a: buy an item."
        puts "b: sell an item."
        puts "c: exit shop."
        shop_choice = gets.chomp.downcase
        
        if shop_choice == "a"
            system("clear")
            puts "What would you like to buy?"
            menu.each do |item, cost|
                puts "#{item} ---------------- #{cost} gold"
            end 
                buy_choice = gets.chomp
                if buy_choice == "a"
                    puts "sword aquired!"
                    player["gold"] -= 100
                    player["atk"] += 1
                    #player_inventory[sword] + 1
                elsif buy_choice == "b"
                    puts "medkit aquired!"
                    player["gold"] -= 50
                    player["medkit"] += 1
                    #player_inventory[medkit] + 1
                elsif buy_choice == "c"
                    puts "cup of coffee aquired!"
                    player["gold"] -= 1
                    player["coffee"] += 1
                    #player_inventory[coffee] + 1
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
        
        game
        
        