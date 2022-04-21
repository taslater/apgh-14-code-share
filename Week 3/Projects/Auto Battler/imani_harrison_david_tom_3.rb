weapons = {
    "knife" => {
        "cost" => 50, 
        "damage" => 5
    },
    "gun" => {
        "cost" => 100,
        "damage" => 15
    }
}
gun = weapons["gun"]
puts gun["cost"]

puts weapons["gun"]["cost"]
