birthdays = {
    "john" => "9/12/78",
    "jean" => "4/17/84"
}

# add to a hash
birthdays["saturn"] = "6/22/11"

# view from a hash
puts birthdays["jean"]

# print everything from a hash
birthdays.each do |key, value|
    puts "#{key}'s birthday is on #{value}"
end
