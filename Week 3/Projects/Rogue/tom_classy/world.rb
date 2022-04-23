class World
  @@display_hash = {
    ground: "·",
    gold: "$",
    lava: "~",
  }

  def initialize(n_rows:, n_cols:, lava_ratio:, gold_ratio:)
    @n_rows = n_rows
    @n_cols = n_cols
    @grid = Array.new(@n_rows) { Array.new(@n_cols) { :ground } }
    self.update_display
    self.add_material(material: :lava, ratio: lava_ratio)
    self.add_material(material: :gold, ratio: gold_ratio)
    # @gold_count = self.count_gold
  end

  def add_material(material:, ratio:)
    max_lava = (@n_rows.to_f * @n_cols.to_f * ratio).floor
    (0..max_lava).each do |_|
      pos = [rand(@n_rows), rand(@n_cols)]
      if pos != self.center
        @grid[pos[0]][pos[1]] = material
      end
    end
    self.update_display
  end

  def count_gold
    @grid.flatten.select { |mat| mat.equal?(:gold) }.length
  end

  def center
    [(@n_rows.to_f / 2).floor, (@n_cols.to_f / 2).floor]
  end

  def check_pos(pos)
    material = @grid[pos[0]][pos[1]]
    if material.equal?(:gold)
      @grid[pos[0]][pos[1]] = :ground
      self.update_display
    end
    material
  end

  def n_rows
    @n_rows
  end

  def n_cols
    @n_cols
  end

  def update_display
    @display_grid = @grid.map { |row| row.map { |sym| @@display_hash[sym] } }
  end

  def display_grid
    Marshal.load(Marshal.dump(@display_grid))
  end

  def to_s
    @display_grid.map { |row| row.join(" ") }.join("\n")
  end
end
