require "calculator"

describe Calculate do
  describe "math" do
    context "given 2+2" do
      it "returns 4" do
        cl = Calculate.new
        expect(cl.math("2+2")).to eql(4)
      end
    end
    context "given 10-2" do
      it "returns 8" do
        cl = Calculate.new
        expect(cl.math("10-2")).to eql(8)
      end
    end

    context "given 10*10" do
      it "returns 100" do
        cl = Calculate.new
        expect(cl.math("10*10")).to eql(100)
      end
    end

    context "given 10/2" do
      it "returns 5" do
        cl = Calculate.new
        expect(cl.math("10/2")).to eql(5)
      end
    end
  end
end
