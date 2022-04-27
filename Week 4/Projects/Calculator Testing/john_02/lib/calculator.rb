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

      temp_cone = ""
      right_number = ""
      operator = ""

      snow_cones = [] # this will hold the math problem like this ["2", "+", "2", "*", "5"]
      current_state = "number" # valid states: number, operator


      problem = problem.gsub(" ", ""); # get rid of all spaces
      # problem.gsub!(" ", "");

      problem.each_char do | character |

          # make sure to save every character
          # no matter what state we start at
          # or what the current character is, all combinations
          # should save that character (in the right place)

          # "32 + 15"
          # "4 + 2325"

          # I look at a character
          # - if it's a number, I either add it to the end of an existing number
          # - or start a new number
          # - if it's an operator, put it in, then be ready for the next new number

          if current_state == "number"
              # currently filling the left bucket
              if "0123456789.".include? character
                  # we found a number
                  # temp_cone = temp_cone + character
                  temp_cone << character
              else
                  if character == "-" && temp_cone == ""
                      # left number is empty and we found a -
                      # so this is probably a negative first number
                      temp_cone << character
                  else
                      # we didn't find a number
                      snow_cones << temp_cone
                      temp_cone = ""
                      current_state = "operator"
                  end
              end
          end
          if current_state == "operator"
              snow_cones << character
              current_state = "number"
          end
      end
      # end of each_char loop
      snow_cones << temp_cone

      # have this lower code run a bunch instead of just once
      # until we're out of single math problems to do

      while(snow_cones.length > 1)
          # look over the whole snow_cones and find the first one do the math on
          # look for any * or /, first one we find is the one to do
          # if there are no * or /, then the first + or - we find
          first_md = 0 # first multiply or divide
          first_as = 0 # first add or subtract

          snow_cones.each_with_index do | cone, index |
              if (cone == "*" || cone == "/") && first_md == 0
                  first_md = index
              end
              if (cone == "+" || cone == "-") && first_as == 0
                  first_as = index
              end
          end

          if first_md > 0
              current_operator_index = first_md
          else
              current_operator_index = first_as
          end
          #puts "current operator index => #{current_operator_index}"
          # now I have what index we're working on!

          
          # get all of the snow_cones to the left of that math
          left_side = snow_cones[0...current_operator_index-1]
          # get all of the snow_cones to the right of that math
          right_side = snow_cones[(current_operator_index+2)..]
          # do the math and save that answer
          answer = do_math snow_cones[current_operator_index-1], snow_cones[current_operator_index+1], snow_cones[current_operator_index]

          # put the snow_cones in order, left + answer + right
          snow_cones = left_side + [answer] + right_side
      end

      return snow_cones[0]
  end

  def do_math left_number, right_number, operator
      #puts "left => #{left_number} right => #{right_number} op => #{operator}"
      if ((left_number.to_s.include? ".") || (right_number.to_s.include? "."))
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
