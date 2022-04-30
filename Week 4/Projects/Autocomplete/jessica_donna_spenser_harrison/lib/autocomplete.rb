class Autocomplete
  def initialize
    # establish variables
    # create a place to store stuff
    @terms = []
    @search = "" # look over string to find "c" "ca"
    @display = []
  end

  def AddWords words
    # words -- list of search terms, comp prints based on letters entered
    (0...words.length).each do |i|
      @terms << words[i] # calls words from spec
    end

    # store search terms comp has in background
    # call terms in complete
  end

  def Complete partial
    @search << partial # function complete calls partial ex "ca"
    # for loop similar to line 12
    (0..@terms.length - 1).each do |i|
      if @terms[i].include? @search
        @display << @terms[i]
      end
    end
    return @display
    # if @search == "ca"
    #     return @terms[0..1]

    # elsif @search == "d"
    #     return @terms[2..2] #to return array including brackets

    # elsif @search == "bug"
    #     return []
    # end

    # establish letters that someone could enter
    # partial -- could be "c" "ca" "d" "do"
    # "c" "ca" return search words
    # transform list of words
    # searching for letters.include?
  end
end
