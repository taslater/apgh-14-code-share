class Autocomplete
  def initialize
    # initialize tells the program the variables exsist
    @words = []
    @partial = ""
    @output = []
  end

  def AddWords new_words
    # words = cat car dog
    @words = new_words
  end

  def Complete new_partial
    # partial = "ca"
    @partial = new_partial
    # loop iterates through the words in the array
    # loop that iterates through letters in each word
    @words.each do |word|
      usable = true
      (0...@partial.length()).each do |i|
        # if the first letter of input is NOT equal to the first letter of word
        # if @partial[i] != word[i]
        # @words.delete(word)
        # THE ORDER IS FUCKED
        if @partial[i] != word [i]
          usable = false
        end
      end
      if usable
        @output << word
      end
    end
    # puts @words
    # return @words
    puts @output
    return @output
  end
end
