# Defining the Calculator class
class Calculator
  # Defining the addition function that takes in a string
  def addition input
    # Splits the string into two numbers based on the "+" operator
    number1, number2 = input.split("+")
    # Add the numbers together but change them from strings to integers
    number1.to_i + number2.to_i
  end

  # Defining the subtraction function
  def subtraction input
    # Splits the input string into 3 variables
    negative, number1, number2 = input.split("-")
    # If the input starts with a negative number, the split will put an empty string into negative
    if negative == ""
      # Sets number1 to the negative version of itself and turns into an integer
      number1 = number1.to_i * (-1)
      # Change number2 into an integer
      number2 = number2.to_i
      # Do subtraction
      result = number1 - number2
    else
      # If negative isn't "" then input starts with a positive number and we can reassign number1 and number2
      number1, number2 = input.split("-")
      # Subtract, changing variable into integers
      result = number1.to_i - number2.to_i
    end
    # Return our result
    result
  end
end
