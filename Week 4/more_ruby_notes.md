# More Ruby #

## Returns ##

Can check what a statement returns in IRB by check what follows `=>`

`return` isn't necessary at the very end of a function, but is helpful inside blocks to early return something, also for clarity...

`x = 5` returns `5`, which seems strange to me, why not return `nil`?! Why does this confuse me?

Is Ruby weird or am I?

## UI/UX Testing ##

These tests prone to breaking if they're too specific

Unit test the little fiddly well-defined bits

Allow there to be some flexibility in your UI design pretty stuff, otherwise ppl will just ignore your tests...?

## Rspec before ##

```ruby
before (:each) do
  @calc = Calculator.new
end
```

* What is Rspec let for?? Ppl on the internets seem to like `let`
