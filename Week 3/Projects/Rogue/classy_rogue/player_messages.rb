class PlayerMessages
  @@wandering_messages = [
    "...",
    "...",
    "...",
    "...",
    "...",
    "Kinda dark?",
    "It's ... dungeon-y",
    "Mom? Is that you?"
  ]

  @@gold_messages = [
    "Yummy munny!",
    "My precious!",
    "Saving for college"
  ]

  @@ouch_messages = [
    "Owie",
    "Yikes",
    "That burns",
    "Unpleasant"
  ]

  @@won_messages = [
    "I'm the best",
    "Feels good",
    "Such confidence",
    "Oooh the swagger"
  ]

  @@dead_messages = [
    "Jeez, I'm dead",
    "Not what I expected",
    "Had such high hopes",
    "Hard to move when dead"
  ]

  def won
    @@won_messages.sample
  end

  def dead
    @@dead_messages.sample
  end

  def wander
    @@wandering_messages.sample
  end

  def ouch
    @@ouch_messages.sample
  end

  def gold
    @@gold_messages.sample
  end
end
