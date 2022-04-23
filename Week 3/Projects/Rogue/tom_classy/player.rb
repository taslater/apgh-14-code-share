class Player
  @@max_hp = 10

  @@move_hash = {
    "a" => [1, -1],
    "d" => [1, +1],
    "w" => [0, -1],
    "s" => [0, +1],
  }

  def initialize(world:)
    @world = world
    @hp = @@max_hp
    @pos = @world.center.dup
    @gold = 0
  end

  def move direction
    if @@move_hash.key?(direction)
      axis, amount = @@move_hash[direction]
      @pos[axis] += amount
      self.clamp_pos
    end
  end

  def clamp_pos
    @pos[0] = @pos[0].clamp(0, @world.n_rows - 1)
    @pos[1] = @pos[1].clamp(0, @world.n_cols - 1)
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

  def to_s
    "@"
  end
end
