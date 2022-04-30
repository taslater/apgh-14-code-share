class Calculator
  def calc input_string
    input_string.gsub!(" ", "") # eliminate spaces
    input_array = input_string.split(/([\D])/) # splits input string into individual components and keeps operator, uppercase D splits at not digits
    total = input_array.shift().to_i # 1st position of input array becomes variable total due to .shift
    operator = "x" # creates new variable operator
    input_array.each do |element| # establish loop to iterate through each position of array
      if "+-*/".include? element # check if element is an operator
        operator = element # sets current active operator
      elsif operator == "+"
        total = total + element.to_i
      elsif operator == "-"
        total = total - element.to_i
      elsif operator == "*"
        total = total * element.to_i
      elsif operator == "/"
        total = total / element.to_i
      end
    end
    return total
  end
end
# does not work with PEMDAS, but does work with multiple operators
