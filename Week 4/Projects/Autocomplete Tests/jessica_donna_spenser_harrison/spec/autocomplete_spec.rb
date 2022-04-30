require "autocomplete"

describe Autocomplete do
  context "When given cat, car, dog" do
    context "when asked to complete ca" do
      it "returns cat, car" do
        ac = Autocomplete.new
        ac.AddWords ["cat", "car", "dog"]
        result = ac.Complete "ca"
        expect(result).to eql(["cat", "car"])
      end
    end
    context "when asked to complete d" do
      it "returns dog" do
        ac = Autocomplete.new
        ac.AddWords ["cat", "car", "dog"]
        result = ac.Complete "d"
        expect(result).to eql(["dog"])
      end
    end
    context "when asked to complete bug" do
      it "returns an empty array" do
        ac = Autocomplete.new
        ac.AddWords ["cat", "car", "dog"]
        result = ac.Complete "bug"
        expect(result).to eql([])
      end
    end
    context "when given rh" do
      it "returns rhino" do
        ac = Autocomplete.new
        ac.AddWords ["cat", "car", "dog", "rhino"]
        result = ac.Complete "rh"
        expect(result).to eql(["rhino"])
      end
    end
    # purposeful fail
    context "when given rh" do
      it "returns cat" do
        ac = Autocomplete.new
        ac.AddWords ["cat", "car", "dog", "rhino"]
        result = ac.Complete "rh"
        expect(result).to eql(["cat"])
      end
    end
  end
end