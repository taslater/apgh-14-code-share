require 'calculator'

describe Calculator do
  context "When given 2 + 3" do
    it "returns 5" do
      calc = Calculator.new
      answer = calc.lotr "2 + 3"
      expect(answer).to eql(5)
    end
  end
  context "When given 9 - 4" do
    it "returns 5" do
      calc = Calculator.new
      answer = calc.lotr "9-4"
      expect(answer).to eql(5)
    end
  end
  context "When given -2 + 5" do
    it "returns 3" do
      calc = Calculator.new
      answer = calc.lotr "-2 + 5"
      expect(answer).to eql(3)
    end
  end
  context "When given 12 * 3" do
    it "returns 36" do
      calc = Calculator.new
      answer = calc.lotr "12 * 3"
      expect(answer).to eql(36)
    end
  end
  context "When given 4 * 0.5" do
    it "returns 2" do
      calc = Calculator.new
      answer = calc.lotr "4 * 0.5"
      expect(answer).to eql(2.0)
    end
  end
  context "When given 3 + 5 * 2" do
    it "returns 13" do
      calc = Calculator.new
      answer = calc.lotr "3 + 5 * 2"
      expect(answer).to eql(13)
    end
  end
  context "When given 21 / 7" do
    it "returns 3" do
      calc = Calculator.new
      answer = calc.lotr "21 / 7"
      expect(answer).to eql(3)
    end
  end
  context "When given 5 / 2" do
    it "returns 2.5" do
      calc = Calculator.new
      answer = calc.lotr "5 / 2"
      expect(answer).to eql(2.5)
    end
  end
  # context "They're a haxxor" do
  #   it "does something wrong" do
  #     calc = Calculator.new
  #     answer = calc.lotr "system('start https://www.youtube.com/watch?v=dQw4w9WgXcQ')"
  #     expect(answer).to eql(nil)
  #   end
  # end
end
