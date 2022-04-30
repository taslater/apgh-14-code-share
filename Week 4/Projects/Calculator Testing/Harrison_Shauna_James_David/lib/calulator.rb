class Calculator
  def math(text)
    if text.include? "+"
      numbers = text.split "+"
      return (numbers[0].to_i + numbers[1].to_i)

    elsif text.include? "-"
      numbers = text.split "-"
      return (numbers[0].to_i - numbers[1].to_i)

    elsif text.include? "*"
      numbers = text.split "*"
      return (numbers[0].to_i * numbers[1].to_i)

    elsif text.include? "/"
      numbers = text.split "/"
      return (numbers[0].to_i - numbers[1].to_i)
    end
  end
end
