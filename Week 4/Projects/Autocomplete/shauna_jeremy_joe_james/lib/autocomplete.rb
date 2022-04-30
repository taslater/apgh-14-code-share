class Autocomplete
  def initialize
    @list = []
    # making an array that will hold the words we are searching for (i, word)
  end

  def AddWords words # dog, cat, car
    words.each do |i|
      @list << i
    end
    # taking the words and putting them into the array for every word(i) entered
    # putting them in to the array allows them to be searched for partials(matches)
  end

  def Complete partial
    @search = []
    # create an empty array to be filled with "word" that start with "partial"
    @list.each do |word|
      if word.start_with?(partial)
        @search << word
      end
      # for each word that contains partial in @list put them into our search array
    end
    return @search
    # return our search array containing all matches or an empty array if no matches
  end
end
