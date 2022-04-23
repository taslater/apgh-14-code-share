require './player'
require './world'
require 'io/console'

class Game
  def initialize(n_rows:, n_cols:, lava_ratio: 0.1, gold_ratio: 0.1)
    @world = World.new(n_rows: n_rows, n_cols: n_cols)
    @player = Player.new(world: @world)
    self.add_material(:lava, lava_ratio)
    self.add_material(:gold, gold_ratio)
    puts self
    @playing = true
  end

  def play
    while @playing
      char_in = STDIN.getch
      char_in == "p" ? self.quit : self.move(char_in)
    end
  end

  private

  def add_material(material, ratio)
    @world.add_material(
      material: material,
      lava_ratio: ratio,
      player_pos: @player.pos
    )
  end

  def move(char_in)
    @player.move(char_in)
    puts self
  end

  def quit
    @playing = false
    system("clear") || system("cls")
  end

  def h_line
    "+#{"-" * (2 * @world.n_cols - 1)}+"
  end

  def to_s
    display_grid = @world.display_grid
    player_pos = @player.pos
    display_grid[player_pos[0]][player_pos[1]] = @player.to_s
    system("clear") || system("cls")
    "#{self.h_line}\n"\
    "#{display_grid.map { |row| "\|#{row.join(" ")}\|" }.join("\n")}\n"\
    "#{self.h_line}"
  end
end
