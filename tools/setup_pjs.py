import os
from pathlib import Path

current_dir = './'
pj_names = ['andy_yemi_tom_rich',
            'shauna_jeremy_joe_james',
            'tobias_david_renat_imani', 'jessica_donna_spenser_harrison']

pj_structure = [('/lib', ['autocomplete.rb']),
                ('/spec', ['autocomplete_spec.rb'])]


spec_text = """require "autocomplete"

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
    end
end
"""

for pj_name in pj_names:
    dir_name = current_dir + pj_name
    os.mkdir(dir_name)
    for sub_dir, filenames in pj_structure:
        sub_dir_path = '/'.join([dir_name, sub_dir])
        os.mkdir(sub_dir_path)
        for filename in filenames:
            file_path = '/'.join([sub_dir_path, filename])
            Path(file_path).touch()
            if filename == 'autocomplete_spec.rb':
                with open(file_path, "w") as f:
                    f.write(spec_text)
