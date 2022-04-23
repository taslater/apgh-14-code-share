require './game'

game = Game.new(n_rows: 9, n_cols: 11, lava_ratio: 0.1)

game.play
