require './player'
require './world'
require 'io/console'

class Game
  def initialize(n_rows:, n_cols:, lava_ratio: 0.1, gold_ratio: 0.1)
    @world = World.new(
      n_rows: n_rows,
      n_cols: n_cols,
      lava_ratio: lava_ratio,
      gold_ratio: gold_ratio
    )
    @player = Player.new(world: @world)
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

  def move(char_in)
    @player.move(char_in)
    self.status
    puts self
  end

  def status
    @player.status
  end

  def quit
    @playing = false
    system("clear") || system("cls")
  end

  def char_width
    (2 * @world.n_cols - 1)
  end

  def h_line
    "+#{"-" * self.char_width}+"
  end

  def menu_line(message)
    "\| #{message + " " * (self.char_width - message.length - 1)}\|"
  end

  def info_display(infos)
    infos.map { |s| self.menu_line(s) }.join("\n")
  end

  def instructions
    self.info_display(["w,a,s,d to move", "p to quit"])
  end

  def display_grid
    display_grid = @world.display_grid
    player_pos = @player.pos
    display_grid[player_pos[0]][player_pos[1]] = @player.to_s
    display_grid
  end

  def to_s
    system("clear") || system("cls")
    "#{self.h_line}\n"\
    "#{self.instructions}\n"\
    "#{self.h_line}\n"\
    "#{self.display_grid.map { |row| "\|#{row.join(" ")}\|" }.join("\n")}\n"\
    "#{self.h_line}\n"\
    "#{self.info_display([@player.message])}\n"\
    "#{self.h_line}\n"\
    "#{self.info_display(@player.info)}\n"\
    "#{self.h_line}"
  end
end
