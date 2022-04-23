require './game'

game = Game.new(n_rows: 15, n_cols: 21, lava_ratio: 0.2, gold_ratio: 0.05)

game.play
