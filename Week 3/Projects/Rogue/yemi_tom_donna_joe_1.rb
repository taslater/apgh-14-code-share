# require './SAworld'
require 'io/console'

#### Class World

class World
    # symbols hash table
    @@display_hash = {
        ground: ".",
        player: 2.chr,
        gold: 3.chr,
        lava: "~",
    }
    # 2d array using symbols 
    def initialize rows:, cols:
        @n_rows = rows
        @n_cols = cols
        @grid = Array.new(@n_rows) { Array.new(@n_cols) { :ground } }
        @player_pos = [(rows.to_f / 2).floor, (cols.to_f / 2).floor]
        @grid[ @player_pos[0] ][ @player_pos[1] ] = :player
        @grid[ @player_pos[0] - 2][ @player_pos[1] + 3] = :gold

        max_lava = (@n_rows.to_f * @n_cols.to_f * 0.1).floor
        (0..max_lava).each do |i|
            pos = [ rand(0...@n_rows) , rand(0...@n_cols) ]
            if @grid[pos[0]][pos[1]] != :player
                @grid[ pos[0] ][ pos[1] ] = :lava
            end
        end
    end


    def move_player direction

        prev_player_pos = [@player_pos[0], @player_pos[1]]
        
        @grid[ @player_pos[0] ][ @player_pos[1] ] = :ground # ground pooper
        case direction
        when "w"
            @player_pos = [@player_pos[0] - 1, @player_pos[1]]
        when "s"
            @player_pos = [@player_pos[0] + 1, @player_pos[1]]
        when "a"
            @player_pos = [@player_pos[0], @player_pos[1] - 1]
        when "d"
            @player_pos = [@player_pos[0], @player_pos[1] + 1]
        end
        # if @player_pos[1] >= @n_rows
        #     @player_pos[1] = @n_rows
        # end

        @player_pos[0] = [[@player_pos[0], 0].max, @n_rows - 1].min # wall
        @player_pos[1] = [[@player_pos[1], 0].max, @n_cols - 1].min # wall

        if @grid[@player_pos[0]][@player_pos[1]] == :lava
            self.danger prev_player_pos    
        end
        
        @grid[@player_pos[0]][ @player_pos[1]] = :player

    end

    def danger prev_player_pos
        # danger_pos = [@player_pos[0], @player_pos[1]]
        @grid[@player_pos[0]][ @player_pos[1]] = :player
        puts self
        # lava at randomized spots in initializer, should we start with a fixed position lava?
        puts "ouchie"
        sleep 1.0
        @grid[@player_pos[0]][ @player_pos[1]] = :lava
        @player_pos = [prev_player_pos[0],prev_player_pos[1]]
    end

    def to_s
        result = ""
        @grid.each do |row|
            row.each do |hash_symbol|
                result << @@display_hash[hash_symbol] + " "
            end
            result << "\n"
        end
        system("clear") || system("cls")
        result
    end
end


puts "Welcome to Smiley Adventure!" 

world = World.new( rows: 20, cols: 20)
puts world

running = true
while running

    letter = STDIN.getch
    world.move_player letter
    puts world
    sleep 0.05
    if letter == "p"
        running = false
    end
end