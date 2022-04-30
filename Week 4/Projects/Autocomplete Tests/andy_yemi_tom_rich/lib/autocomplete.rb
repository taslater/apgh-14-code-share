class Autocomplete
  # initialize new autocomplete with empty @dictionary array
  def initialize
    # stores complete words that we would like auto complete to find
    @dictionary = []
  end

  # adds an array of words to @dictionary
  def AddWords words
    # iterate over the given words to add each to @dictionary
    words.each do |word|
      @dictionary << word
    end
  end

  # Takes string partial and returns an array of possible completions
  ### array of alphabet? add lists of words to each letter in the alphabet. hash table.
  # partial string inputs need saved
  # compare partial to each entry in @dictionary
  # make a new array of matches with @dictionary
  # return new array of complete entries in @dictionary
  def Complete partial
    # stores words to complete given partial
    possible_completions = []
    # each entry in @dictionary is stored in complete_word
    @dictionary.each do |complete_word|
      # send partial and complete_word into MatchPartial.
      if MatchPartial partial, complete_word
        # if match returns true, stores in possible_completions
        possible_completions << complete_word
      end
    end
    # returns the array of strings that are possible matches/completions
    return possible_completions
  end

  # keep testing
  # take inside of matchtwo and put it inside complete and compare to @dictionary, then repeat
  def MatchPartial partial, complete
    start_complete = complete[0...partial.length]
    is_matched = start_complete == partial # boolean checking for match, comparing strings
    # is_matched = start_complete.eql? partial ## same as above, which format?
    # if start_complete == partial
    #     return true
    # else
    #     return false
    # end
    return is_matched
  end
end

# ac = Autocomplete.new
# puts ac.MatchPartial "a", "apple"
# puts ac.MatchPartial "apple", "a"
