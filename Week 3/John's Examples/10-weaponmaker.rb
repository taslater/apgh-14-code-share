# item
# Name
# Cost
# Strength

# [Adjective] [Adjective] [Noun]
# Rusty Sword
# Shining Pickaxe
# Cracked Rusting Polearm

adjectives = [
    ["cracked", 0.50],
    ["brilliant", 1.20],
    ["rusty", 0.80],
    ["cursed", 0.70],
    ["sharpened", 1.10],
    ["carpeted", 1.40],
    ["soldier's", 1.25],
    ["fishy", 0.95],
    ["sparkly", 1.30],
    ["upset", 1.5]
]

nouns = [
    ["sword", 10],
    ["long sword", 15],
    ["boxing gloves", 20],
    ["flail", 20],
    ["glaive", 18],
    ["falchion", 22],
    ["laser sword (tm)", 40],
    ["hammer", 30],    
    ["javelin", 35]
]

# which adjective
# which noun
which_adjective = rand(0...adjectives.length)
which_noun = rand(0...nouns.length)

# Name
# Cost
# Strength

puts "The item name is #{adjectives[which_adjective][0]} #{nouns[which_noun][0]}"
puts "The strength is #{nouns[which_noun][1] * adjectives[which_adjective][1]}"
puts "The cost is #{nouns[which_noun][1] * adjectives[which_adjective][1] * 10}"
