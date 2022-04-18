# Week 3 Class Notes #

Ruby stuff

## Day 1 ##

Setup IDE (VS Code)

### What is programming? ###

Interpreting between two parties to help them understand what thery're tyring to do - between programmer and computer, user and interface

if/then statements until "it works"

repeatable series of instructions

### Ruby vs C# ###

interpreted not compiled

still object oriented

Jean says `ruby` what created for programmer happiness (by someone named [Yukihiro "Matz" Matsumoto](https://en.wikipedia.org/wiki/Yukihiro_Matsumoto) in Japan)

### Hello World ###

`irb` is interactive ruby in the command line

otherwise write `.rb` files

`puts "Hello World!"`

### Math operators ###

basically the same as `C#` except we have exponentiation (`**`) in `ruby`

`7/3 == 2`

`7%3 == 1`

`7/3.0` ~= 2.3333333

`5 * 2 / 4 == 2`

`5 * (2/4) == 0`

`Math::PI`

### Type conversion (and strings) ###

`"hello" + 2` throws TypeError (no implicit conversion)

`"hello" + 2.to_s == "hello2"`

`"hello" * 2 == "hellohello"`

`"5".to_i * 2 == 10`

`"hello".to_i == 0`

`Ruby` tries not to crash when conversion fails. `C#` is more strict with type, but `Ruby` doesn't want to crash all the time. It's just a different design, prioritizing not crashing, but may hide bugs from programmer.

### A little terminal interlude ###

The terminal is another way to navigate file structures. Shared (Windows, etc) Linux commands:

* `ls` list everything in current working directory
* `pwd` print current working directory
* `cd <path>` change directory to `<path>`
* `mkdir <foldername>` creates directory (folder) `<foldername>`
* `Code <filename or path>` open file or folder with VS Code
* `ruby <script.rb>` use local ruby to run `<script.rb>`
* `ruby --version` check if local ruby interpreter is working (returns version number)
* `which ruby` prints the path to `ruby` interpreter
* `touch <filename>` creates file `<filename>` in current working directory

### Variables (Ruby vs C#) ###

* **not** staticatlly typed (type can change)
* type declaration not required
* type is inferred at initialization
* no implicit conversion from int to string! (`.to_s`)

There are pros and cons! (cf. `TypeScript`)

### User input / String interpolation ###

`gets` get string from CLI user (ie. `name = gets`)

String interpolation is cool!

```ruby
feet = 3
puts "I have #{feet} feet"
```

I have 3 feet.

```ruby
feet = 3
puts "I have #{3*feet} feet"
```

I have 9 feet.
