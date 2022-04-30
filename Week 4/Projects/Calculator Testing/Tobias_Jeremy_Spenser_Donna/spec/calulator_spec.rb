require "calculator"
describe Calculator do
  describe ".calc" do
    context "given 2 + 3" do
      it "returns 5" do
        calc = Calculator.new
        expect(calc.calc("2 + 3")).to eql(5)
      end
    end
    context "given 5 - 3" do
      it "returns 2" do
        calc = Calculator.new
        expect(calc.calc("5 - 3")).to eql(2)
      end
    end
    context "given 2 * 4" do
      it "returns 8" do
        calc = Calculator.new
        expect(calc.calc("2 * 4")).to eql(8)
      end
    end
    context "given 6 / 2" do
      it "returns 3" do
        calc = Calculator.new
        expect(calc.calc("6 / 2")).to eql(3)
      end
    end
    context "given 15 + 13" do
      it "returns 28" do
        calc = Calculator.new
        expect(calc.calc("15 + 13")).to eql(28)
      end
    end
    context "given 2 + 3 + 4" do
      it "returns 9" do
        calc = Calculator.new
        expect(calc.calc("2 + 3 + 4")).to eql(9)
      end
    end
    context "given 8 + 3 - 2" do
      it "returns 9" do
        calc = Calculator.new
        expect(calc.calc("8 + 3 - 2")).to eql(9)
      end
    end
    context "given 2 + 3 * 4" do
      it "returns 14" do
        calc = Calculator.new
        expect(calc.calc("2 + 3 * 4")).to eql(14)
      end
    end
  end
end
