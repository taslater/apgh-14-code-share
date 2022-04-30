# Import the calculator.rb file from lib
require "calculator"

# ------------addition test--------------
#   input will be a string
#   first test will be single digits (1+2)
#   will return an int, not a string

# ------------subtraction test--------------
#   input will be a string
#   first test will be single digits (3-2)
#   will return an int, not a string

# Went to Regex version before implimenting these tests
# ------------multiply test--------------
#   input will be a string
#   first test will be single digits (1*2)
#   will return an int, not a string

# ------------divide test--------------
#   input will be a string
#   first test will be single digits (2/2)
#   will return an int, not a string

# This is the class our function lives in
describe Calculator do
  # The addition function inside our class
  describe ".addition" do
    context "given 1 + 2 " do
      it "returns 3" do
        # Instantiating a new Calculator class
        add = Calculator.new
        # Run the test using "1+2" as the input string and we expect: 3
        expect(add.addition("1+2")).to eql(3)
      end
    end

    # Testing for spaces
    context "given 1 + 1 " do
      it "returns 2" do
        add = Calculator.new
        expect(add.addition("1+1")).to eql(2)
      end
    end

    # Testing for multiple places in the numbers added
    context "given 11 + 11 " do
      it "returns 22" do
        add = Calculator.new
        expect(add.addition("11+11")).to eql(22)
      end
    end
  end

  # Subtraction function that lives in our class
  describe ".subtraction" do
    context "given 3 - 2 " do
      it "returns 1" do
        # Instantiating Calculator class
        sub = Calculator.new
        # Testing the subtraction function with "3-2" as the input, expecting result: 1
        expect(sub.subtraction("3-2")).to eql(1)
      end
    end

    # Testing for going into the negative
    context "given 3 - 5 " do
      it "returns -2" do
        sub = Calculator.new
        expect(sub.subtraction("3-5")).to eql(-2)
      end
    end

    # Testing if can start math with a negative number
    context "given -3 - 5 " do
      it "returns -8" do
        sub = Calculator.new
        expect(sub.subtraction("-3-5")).to eql(-8)
      end
    end
  end
end
