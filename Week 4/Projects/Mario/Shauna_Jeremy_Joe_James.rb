require "ruby2d"
set width: 600, height: 400
floor = Rectangle.new(
  x: 0, y: 350,
  width: 600, height: 150,
  color: 'green'
)
mario = Image.new('mario.png', width: 64, height: 64)
ball = Circle.new(
  x: 600, y: 325,
  radius: 50,
  sectors: 32,
  color: 'yellow'
)
mario_falling_speed = 0
circle_roll_speed = 0
on :key_down do |event|
  if event.key == 'w'
    mario_falling_speed = -15
  end
end
update do
  mario.y = mario.y + mario_falling_speed
  mario_falling_speed = mario_falling_speed + 1
  if mario.y >= 300
    mario_falling_speed = 0
  end
  ball.x = ball.x + circle_roll_speed
  circle_roll_speed = circle_roll_speed - 0.125
end
show
