# Including functionality for using decimals from a default ruby library
require "bigdecimal"
require "bigdecimal/util"

# Create the class RegexCalculator
class RegexCalculator
  # Define our function calculate, it takes in a string ("1+2" e.g )
  def calculate input_string
    # Regex to match the strings "+", "-", "*", "/" (creating delimiters)
    # You need the "\" to tell Regex not to use the built in functionality of those characters you want to use as delimiters
    math_ops = /[\+\-\*\/]/

    # This splits the input string around the delimiters into an array. The .map shortens a .each loop to turn each of the strings and turns it into a decimal with .to_d
    # .map {|s| s.to_d} is shorthand for the following:
    # nums = []
    # split_strings = input_string.split(math_ops)
    # split_strings.each do |s|
    #     nums << s.to_d
    # end
    nums = input_string.split(math_ops).map { |s| s.to_d }

    # This creates an array of just the math operators (.scan is sort of opposite of split)
    ops = input_string.scan(math_ops)

    # .zip creates an array of arrays combining the ops array and nums array, except for nums[0]; each subarray has an operator and a number in order of appearance in the string
    zipped = ops.zip(nums[1..-1])
    # An example of using .zip:
    # [1,2,3].zip(["a", "b", "c"]) => [[1,"a"],[2,"b"],[3,"c"]]

    # Start result out as the first number in the string
    result = nums[0]

    # puts "result start: #{result} " #Testing puts

    # Each loop goes thru each pair (operators and numbers) in the zipped array, looks at which operator it is, and does that operation based on the case. This allows for longer strings to be input e.g. "1 + 2 + 5 - 4". (This however does not take into account order of operations in math.)
    zipped.each do |op, num|
      # puts "#{op} , #{num}" #puts for testing

      # Switch case based on the operator
      case op
      # Addition
      when "+"
        result += num
      # Subtraction
      when "-"
        result -= num
      # Multiplication
      when "*"
        result *= num
      # Division
      when "/"
        result /= num
      end

      # puts "result current: #{result}" #puts for testing
    end
    result
  end
end
