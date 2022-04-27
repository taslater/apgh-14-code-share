# singular, processes two numbers with an operator in between

class Calculator
  def lotr problem
    # solve it for real

    # take our problem and put it into 3 variables
    # left_number
    # right_number
    # operator

    # loop over every character
    # we are filling 3 buckets - left, op, right
    # which bucket are we filling
    # when do we change buckets

    # change buckets when we hit something that isn't what it used to be?

    left_number = ""
    right_number = ""
    operator = ""
    current_bucket = "left"

    problem = problem.gsub(" ", "");
    # problem.gsub!(" ", "");

    problem.each_char do |character|
      if current_bucket == "left"
        # currently filling the left bucket
        if "0123456789.".include? character
          # we found a number
          # left_number = left_number + character
          left_number << character
        else
          if character == "-" && left_number == ""
            # left number is empty and we found a -
            # so this is probably a negative first number
            left_number << character
          else
            # we didn't find a number
            current_bucket = "op"
          end
        end
      end
      if current_bucket == "op"
        # currently filling the operator bucket
        if "+-*/".include? character
          # found the operator
          operator << character
        else
          # didn't find an operator
          current_bucket = "right"
        end
      end
      if current_bucket == "right"
        # currently filling the right bucket
        if "0123456789.".include? character
          # we found a number
          # right_number = right_number + character
          right_number << character
        end
      end
    end
    # end of each_char loop
    if ((left_number.include? ".") || (right_number.include? "."))
      left_number = left_number.to_f
      right_number = right_number.to_f
    else
      left_number = left_number.to_i
      right_number = right_number.to_i
    end

    if operator == "+"
      return left_number + right_number
    elsif operator == "-"
      return left_number - right_number
    elsif operator == "*"
      return left_number * right_number
    elsif operator == "/"
      if left_number % right_number == 0
        return left_number / right_number
      else
        return left_number.to_f / right_number.to_f
      end
    else
      return nil
    end
  end
end
