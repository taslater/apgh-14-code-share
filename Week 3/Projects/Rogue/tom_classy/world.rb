class World
  @@display_hash = {
    ground: "·",
    gold: "$",
    lava: "~",
  }

  def initialize(n_rows:, n_cols:)
    @n_rows = n_rows
    @n_cols = n_cols
    @grid = Array.new(@n_rows) { Array.new(@n_cols) { :ground } }
    self.update_display
  end

  def add_material(material:, lava_ratio:, player_pos:)
    max_lava = (@n_rows.to_f * @n_cols.to_f * lava_ratio).floor
    (0..max_lava).each do |_|
      pos = [rand(@n_rows), rand(@n_cols)]
      if pos != player_pos
        @grid[pos[0]][pos[1]] = material
      end
    end
    self.update_display
  end

  def center
    [(@n_rows.to_f / 2).floor, (@n_cols.to_f / 2).floor]
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
