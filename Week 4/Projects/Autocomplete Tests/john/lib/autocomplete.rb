class Autocomplete
  def initialize
    @words = []
  end

  def AddWords words
    @words = @words + words
  end

  def Complete partial
    @words.select do |word|
      word.start_with? partial
    end
  end
end
