class Weapon
    def initialize(name:, cost:, damage:)
        if name[...2].downcase == "a " || name[...3].downcase == "an"
            @name = name
        else
            if "aeiou".include? name[0]
                @name = "an #{name}"
            else
                @name = "a #{name}"
            end
        end
        @cost = cost
        @damage = damage
    end

    def name
        @name
    end

    def cost
        @cost
    end

    def to_s
        "#{@name.capitalize} worth $#{@cost} dealing #{@damage} damage."
    end
end

class Inventory
    def initialize
        @contents = []
    end

    def add(item)
        @contents << item
    end

    def to_s
        case @contents.length
        when 0
            "an empty inventory"
        when 1
            @contents[0].name
        when 2
            @contents.map{|item| item.name}.join(" and ")
        else
            "#{@contents[...-1].map{|item| item.name}.join(", ")}, and #{@contents[-1].name}"
        end
    end
end

class Player
    def initialize(name:)
        @name = name
        @inventory = Inventory.new
        @hp = 100
        @cash = 100
    end

    def buy(item)
        if !item.is_a? Weapon
            puts "#{@name} can't buy that.\n\n"
        elsif @cash >= item.cost
            @inventory.add(item)
            @cash -= item.cost
            puts "#{@name} bought #{item.name} for $#{item.cost}.\n#{@name} now has $#{@cash} and is carrying #{@inventory}.\n\n"
        else
            puts "#{@name} can't afford #{item.name}. It costs $#{item.cost} and #{@name} only has $#{@cash}.\n\n"
        end
    end

    def to_s
        "#{@name} is stuck in a dungeon with #{@hp} HP, carrying $#{@cash} in cash, and #{@inventory}.\n\n"
    end
end


kim = Player.new(name: "Kim")
puts kim

pea_shooter = Weapon.new(name: "pea shooter", cost: 5, damage: 1)
big_knife = Weapon.new(name: "big knife", cost: 50, damage: 10)
little_gun = Weapon.new(name: "little gun", cost: 100, damage: 50)

kim.buy(pea_shooter)
kim.buy("pea_shooter")
kim.buy(pea_shooter)
kim.buy(pea_shooter)
kim.buy(big_knife)
kim.buy(little_gun)

puts kim