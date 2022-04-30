require "ruby2d"

set width: 600, height: 600, background: 'blue'

timer = 0
mario = Image.new('mario.png', width: 64, height: 64)
speed = Text.new("")

ground = Rectangle.new(
  x: 0, y: 464,
  width: 600, height: 200,
  color: 'green'
)

s = Square.new(
  x: 500, y: 336,
  size: 64,
  color: 'red',
)

mario_falling_speed = 0
mario_running_speed = 0

on :key_down do |event|
  if event.key == 'w'
    mario.y -= 1
    mario_falling_speed = -15
  elsif event.key == 'd'
    mario_running_speed += 10
  elsif event.key == 'a'
    mario_running_speed -= 10
  end
end

update do
  if mario.y >= 400
    mario_falling_speed = 0
    mario.y = 400
  end

  mario.y = mario.y + mario_falling_speed
  mario_falling_speed = mario_falling_speed + 1

  if mario_running_speed > 0 || mario_running_speed < 0
    mario_running_speed = mario_running_speed * 0.95
  end

  mario.x = mario.x + mario_running_speed
  # mario_falling_speed = mario_falling_speed + 1

  speed.text = mario_falling_speed

  timer += 1
  if timer >= 300
    s.x = 600
    timer = 0
  end

  s.x = s.x - 5

  mario_right_edge = mario.y - 64
  if s.contains? mario.x, mario.y
    mario_running_speed = mario_running_speed - 10
    mario_falling_speed = mario_falling_speed - 10
  elsif s.contains? mario.x, mario_right_edge
    mario_running_speed = mario_running_speed - 10
    mario_falling_speed = mario_falling_speed - 10
  end

  # every second: make a box on the right side of the screen that moves towards mario, so he'll have to jump over it
  # if he hits the box, he DIES
end

show
