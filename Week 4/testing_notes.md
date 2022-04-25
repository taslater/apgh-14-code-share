# Testing #

Companies SAY they test...

There are different "levels" and "kinds" of testing

Functional vs Non-functional

Unit tests

Mutation tests (testing tests)

End-to-end testing

Integration testing

Regression testing

## TDD ##

Test-driven design

Mostly unit tests (littlest tests)

Write tests BEFORE writing code

### Red-Green Refactor ###

* RED: Write tests first, they will fail
* GREEN: Write code to satisfy tests
* REFACTOR: Update code to be more readable, better written

This is more code

### 3 Major Benefits ###

* Gives devs the safety net to change code, knowing immediately things won't break
* Provides a form of documentation
* Provides guidance on how to build your code (it must be testable, tests normally come from needed functionality)

Helps us to practice thinking about functions, how to plan their requirements, success, design, just writing them

Testing annoys devs who aren't used to it...?

Testing is largely invisible to management

## Building Tests ##

Test all the "interesting" cases

* Have a rationale for the cases, not too many, not too few
* Maximize coverage and minimize the number of cases

Should be readable

Should cover failure cases

Should be built when requirements dictate

* You ain't gonna need it: [YAGNI](https://en.wikipedia.org/wiki/You_aren%27t_gonna_need_it)

### Heuristics? ###

Write tests to hit **each branch** of your function and also mix-and-match to hit combinations of branches, but you don't need every possible combination.
