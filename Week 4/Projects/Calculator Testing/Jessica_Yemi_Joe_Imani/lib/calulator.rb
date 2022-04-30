class Calculate
  def math text
    if text.include? "+"
      num = text.split "+"
      return num[0].to_i + num[1].to_i

    elsif text.include? "-"
      num = text.split "-"
      return num[0].to_i - num[1].to_i

    elsif text.include? "*"
      num = text.split "*"
      return num[0].to_i * num[1].to_i

    else
      text.include? "/"
      num = text.split "/"
      return (num[0].to_i / num[1].to_i)
    end
  end
end

# create program
#   find all the operators & corresponding operands within the string

#   do the math aka calculate

# create test
#   if we come up "string" & give it to calculator, we expect the solution

# receive written math problem
#   splitting string
#     seperate int's & operators
#     execute math based on operator received
#     for division- int to decimals/ remainders modulo?
#     display the math solution
