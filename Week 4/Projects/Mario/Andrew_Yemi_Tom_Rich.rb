require "ruby2d"

set width: 600, height: 400
gravity = 0.1
y_velocity = 0
jump_velocity = 3.5
ground_height = 200
on_ground = false
megaman = Image.new('shoot.png')

Line.new(
  x1: 0,
  y1: (ground_height + megaman.height),
  x2: 600,
  y2: (ground_height + megaman.height),
  width: 2,
  color: 'white'
)

update do
  if megaman.y < ground_height
    # megaman is in the air
    y_velocity += gravity
    # megaman.y = megaman.y + gravity
    # gravity = gravity + 0.1
    on_ground = false
  else
    megaman.y = ground_height
    y_velocity = 0
    on_ground = true
  end
  megaman.y += y_velocity
end

on :key_down do |event|
  if event.key == 'w' && on_ground
    # megaman.y = megaman.y - 50
    y_velocity -= jump_velocity
    megaman.y = ground_height - 1
  end
end
on :key_held do |event|
  if event.key == 'd'
    megaman.x = megaman.x + 10
  end
  if event.key == 'a'
    megaman.x = megaman.x - 10
  end
end
show
