# Week 3 Class Notes #

Ruby stuff

## Day 1 ##

Setup IDE (VS Code), recap C# vs Ruby, using terminal to run scripts

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

### Compiled vs interpreted ###

If there's stuff that has to happen repeatedly, compiled can be faster

You can add code "on-the-fly" with interpreted languages

Writing assembly, you probably can't outsmart a good compiler

### Conditionals ###

Make blocks of code optional

The operators are the same as C#

```ruby
if true
    puts "Hello, this is true!"
end

if false
    puts "Hello, this is false!"
end

x = 10

if x > 5
    puts "x is greater than five"
end
```

`if true` and `if (true)` both work, but `if true` is idiomatic to Ruby.

### Scope ###

Variable initialized with value:

```ruby
if true
    y = "Hello there!"
end

puts "Y equals #{y}"
```

returns `Y equals Hello there!`

Variable declared but uninitialized:

```ruby
if false
    y = "Hello there!"
end

puts "Y equals #{y}"
```

returns `Y equals`

Variable undeclared:

```ruby
puts "Y equals #{y}"
```

throws `undefined local variable or method 'y' for main:Object (NameError)`

### Boolean Syntax ###

TODO

### Loops ###

While:

```ruby
counter = 0
while counter < 10
    puts "Hello there!"
    counter += 1
end
```

For loops in ruby are actually each loops. They 'grab' each value one-by-one...?

```ruby
(1..10).each do |i|
    puts i
end
```

```ruby
for i in 1..10 # 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
    i = 100
    puts i
end
```

Prints 100 ten times.

```ruby
([1, 3, 2]).each do |i|
    puts i
end
```

### Ruby Loop Controls ###

#### Next ####

very common

basically `continue`?

#### Redo ####

quite rare

#### Retry ####

extremely rare
