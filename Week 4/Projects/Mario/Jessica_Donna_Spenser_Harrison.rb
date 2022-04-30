require "ruby2d"

# size of window
set width: 1200, height: 800

# Here we define Mario
# Please come to the castle. I've baked a cake for you.

mario = Image.new('mario.png', width: 128, height: 128)

mushroom = Image.new('mushroom.png', width: 64, height: 64)
mushroom.x = 1136
mushroom.y = 736

coin = Sprite.new(
  'coin.png',
  clip_width: 84,
  time: 300,
  loop: true
)

coin.y = 200
coin.x = 200
coin.play

mario_falling_speed = 0
mario_right_speed = 0
# only need two speeds because we only have a width and height
# up is the same as negative down

# setting up wasd controls to move mario around the window
on :key_down do |event|
  if event.key == 'w'
    mario_falling_speed = -10
    # mario's fall speed acts as gravity, but we program gravity later
  end
end

on :key_down do |event|
  if event.key == 'd'
    mario_right_speed = mario_right_speed + 1
  end
end

on :key_down do |event|
  if event.key == 'a'
    mario_right_speed = mario_right_speed - 1
  end
end

on :key_down do |event|
  if event.key == 's'
    mario_right_speed = 0
  end
end

# adding ground (maybe a form of collision detection?)
# setting a bottom boundary that interacts with the mario image
# runs every update
update do
  # mario.y refers to his y axis
  mario.y = mario.y + mario_falling_speed
  # this is the part that gives mario gravity:
  mario_falling_speed = mario_falling_speed + 1

  mushroom.x = mushroom.x - 2

  if mario.y >= 672
    mario.y = 672
    # 672 is (starting window height) minus 128 (height of mario)
    mario_falling_speed = 0
    # tells him to stop falling when his body hits the floor, shoutout drowning pool
  end

  if mario.x == mushroom.x
    # muchroom goes somewhere, or is deleted, or is eaten
    mushroom.x = 5000
  end

  if mario.x == coin.x
    coin.x = 5000
  end

  # moves mario to the right or left depending on wasd inputs:
  mario.x = mario.x + mario_right_speed
end

show
