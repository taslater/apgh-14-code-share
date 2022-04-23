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

  @@gold_messages = [
    "Yummy munny!",
    "My precious!",
    "Saving for college"
  ]

  @@ouch_messages = [
    "Owie",
    "Yikes",
    "That burns",
    "Unpleasant"
  ]

  @@won_messages = [
    "I'm the best",
    "Feels good",
    "Such confidence",
    "Oooh the swagger"
  ]

  @@dead_messages = [
    "Jeez, I'm dead",
    "Not what I expected",
    "Had such high hopes",
    "Hard to move when dead"
  ]

  def initialize(world:)
    @world = world
    @hp = @@max_hp
    @pos = @world.center.dup
    @gold = 0
    @max_gold = @world.count_gold
    @status = :alive
    self.randomize_message
  end

  def randomize_message
    case @status
    when :won
      @message = @@won_messages.sample
    when :dead
      @message = @@dead_messages.sample
    else
      @message = @@wandering_messages.sample
    end
  end

  def message
    current_message = @message.dup
    self.randomize_message
    current_message
  end

  def status
    @status
  end

  def move direction
    if @@move_hash.key?(direction) && !@status.equal?(:dead)
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
      return
    end
    self.collect(@world.check_pos(@pos))
  end

  def collect(material)
    case material
    when :gold
      self.find_gold
    when :lava
      self.damage
    end
  end

  def damage
    @hp -= 1
    @message = @@ouch_messages.sample
    if @hp <= 0
      @message = "I ded."
      @status = :dead
    end
  end

  # def heal value:
  #   @hp = [@hp + value, @@max_hp].min
  # end

  def find_gold
    @gold += 1
    if @gold.equal?(@max_gold)
      @message = "I WON!"
      @status = :won
    else
      @message = @@gold_messages.sample
    end
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
