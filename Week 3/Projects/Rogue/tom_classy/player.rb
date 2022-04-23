class Player
  @@max_hp = 10

  @@move_hash = {
    "a" => [1, -1],
    "d" => [1, +1],
    "w" => [0, -1],
    "s" => [0, +1],
  }

  @@wandering_messages = [
    "...",
    "...",
    "...",
    "...",
    "...",
    "Kinda dark?",
    "It's ... dungeon-y",
    "Mom? Is that you?"
  ]

  def initialize(world:)
    @world = world
    @hp = @@max_hp
    @pos = @world.center.dup
    @gold = 0
    self.randomize_message
  end

  def randomize_message
    @message = @@wandering_messages.sample
  end

  def message
    current_message = @message.dup
    self.randomize_message
    current_message
  end

  def move direction
    if @@move_hash.key?(direction)
      axis, amount = @@move_hash[direction]
      @pos[axis] += amount
      self.check_pos
    end
  end

  def hit_wall
    prev_pos = self.pos
    @pos[0] = @pos[0].clamp(0, @world.n_rows - 1)
    @pos[1] = @pos[1].clamp(0, @world.n_cols - 1)
    prev_pos != self.pos
  end

  def check_pos
    if self.hit_wall
      @message = "Ow, stupid wall"
    end
  end

  def damage
    @hp -= 1
  end

  def heal value:
    @hp = [@hp + value, @@max_hp].min
  end

  def finds_gold
    @gold += 1
  end

  def pos
    Marshal.load(Marshal.dump(@pos))
  end

  def info
    ["HP: #{@hp}", "Gold: #{@gold}"]
  end

  def to_s
    "@"
  end
end
