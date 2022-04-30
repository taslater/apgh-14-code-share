# Importing the regex.rb file from lib
require "calculator"

# This is the class our function lives in
describe RegexCalculator do
  # This is the function that lives in our class
  describe ".calculate" do
    context "given 1 + 2 " do
      it "returns 3" do
        # Instantiating the class RegexCalculator
        calc = RegexCalculator.new
        # Actually running the test, given an input string "1+2", and expected result: 3
        expect(calc.calculate("1+2")).to eql(3)
      end
    end

    # Testing for decimal point inputs
    context "given 1.5 + 2.5 " do
      it "returns 4" do
        calc = RegexCalculator.new
        expect(calc.calculate("1.5+2.5")).to eql(4)
      end
    end

    # Testing more decimal inputs, but also outputs
    context "given 1.5 + 2 " do
      it "returns 3.5" do
        calc = RegexCalculator.new
        expect(calc.calculate("1.5+2")).to eql(3.5)
      end
    end

    # Testing for more numbers than just two (multiple operations)
    context "given 1 + 2 + 3.5 +12 " do
      it "returns 18.5" do
        calc = RegexCalculator.new
        expect(calc.calculate("1+2 +3.5 +12")).to eql(18.5)
      end
    end

    # Mixing in operators (it will not follow PEMDAS)
    context "given 9/3+2*2.5 -2 " do
      it "returns 10.5" do
        calc = RegexCalculator.new
        expect(calc.calculate("9/3+2*2.5-2")).to eql(10.5)
      end
    end

    # Testing for starting the operations with a negative number
    context "given -1 - 5 " do
      it "returns -6" do
        calc = RegexCalculator.new
        expect(calc.calculate("-1-5")).to eql(-6)
      end
    end

    # Testing with adding a negative number
    context "given 5+ -2 " do
      it "returns 3" do
        calc = RegexCalculator.new
        expect(calc.calculate("5+-2")).to eql(3)
      end
    end

    # Testing multiplying by negative numbers (currently fails)
    context "given 5* -2 " do
      it "returns -10" do
        calc = RegexCalculator.new
        expect(calc.calculate("5*-2")).to eql(-10)
      end
    end
  end
end
