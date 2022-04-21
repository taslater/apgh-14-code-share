#======character creation =======
    #ask user to name character
    #give character starting HP & weapon


#========Game Play=============
    #main menu:
        #1.buying
            #-show a menu of gear options

        #2.healing
            #-charge $$ & return health to full

        #3.fighting 
            #- select a monster as an opponent   
                #fight cycle- player & monster takes turns dealing each other damage
                    #if player dies first- lose game (exits to main menu) & have to build a new character 
                    #if the monster dies first the player gets some $$

        #each if statement should return us to main menu

#========implementation stuff for us===========
    #characters have attributes- names, money, HP, & weapons
    #weapons have attributes- names, cost, damage
    #build an index of gear (cost & damage)
    #monsters have attributes- names HP, damage

    weapons = {
        "knife" => {
            "cost" => 50, 
            "damage" => 5
        },
        "gun" => {
            "cost" => 100,
            "damage" => 15
        }
    }
    
    gaming = true
    while gaming
    
    
      #======character creation =======
        #ask user to name character
        #give character starting HP & weapon
    
    
            puts "Whats you character's name?"
        character_name = gets.chomp
        character_HP = 100
        character_money = 100
        character_weapon = ""
        puts "Welcome #{character_name} you have #{character_HP} hit points and #{character_money} dollars."
    
        #========Game Play=============
        playing = true
        while playing
    
    
                #main menu:
            puts "what do you want to do?"
            puts "B.) Buy a weapon"
            puts "H.) Healing"
            puts "F.) Fighting"
            puts "Q.) Quit"
            action = gets.chomp.upcase
            # display character health, weaponry, money (stats)
    
            if action == "B"
                puts "What weapon would you like to buy?"
                puts "A.) $50 Big Knife"
                purchase = gets.chomp.upcase
                if purchase == "A"
                    character_money = character_money - 50
                    character_weapon = character_weapon + "Big Knife"
                end
                puts "You have #{character_money} dollars and #{character_weapon}."
                    #1.buying
                        #-show a menu of gear options
            elsif action == "H"
                puts "Healing will cost 10 dollars would you like to heal (Y/N)?"
                healing = gets.chomp.upcase
                if healing == "Y"
                    character_HP = 100
                    character_money = character_money - 10
                
                    
                end
                puts "You have #{character_HP} hit points and #{character_money} dollars."
        
    
                #make a note stating "you've been healed!"
                    #2.healing
                        #-charge $$ & return health to full
            elsif action == "F"
                puts "A wild wolf appeared!"
                wolf_HP = 20
    
    
                fighting = true
                while fighting
    
    
                    if character_HP > 0 && wolf_HP > 0
                        wolf_HP = wolf_HP - 5 #<--this number is the damage of our weapon
                        character_HP = character_HP - 7 
                        puts "#{character_name} HP is #{character_HP}, Wolf HP is #{wolf_HP}."
                        sleep(1)
                    elsif character_HP > 0 && wolf_HP <= 0
                        character_money = character_money + 9
                        puts "Holy shit you won!"
                        fighting = false
                    elsif character_HP <= 0 && wolf_HP > 0
                        puts "Oh my God #{character_name} you died!"
                        fighting = false
                        playing = false
                    end
                end
    
    
                    #3.fighting 
                        #- select a monster as an opponent   
                            #fight cycle- player & monster takes turns dealing each other damage
                                #if player dies first- lose game (exits to main menu) & have to build a new character 
                                #if the monster dies first the player gets some $$
            elsif action == "Q"
                puts "Goodbye"
                playing = false
                gaming = false
    
            else 
                puts "I didn't understand that"
            end
                    #each if statement should return us to main menu
        end
    end
        #========implementation stuff for us===========
            #characters have attributes- names, money, HP, & weapons
            #weapons have attributes- names, cost, damage
            #build an index of gear (cost & damage)
            #monsters have attributes- names HP, damage  
    