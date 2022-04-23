require './game'

game = Game.new(n_rows: 11, n_cols: 13, lava_ratio: 0.1)

game.play
