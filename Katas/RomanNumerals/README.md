# Roman Numeral Kata V2

##Sticking to TPP more strictly.
I found a blog article by Pedro Santos of codurance https://codurance.com/2015/05/18/applying-transformation-priority-premise-to-roman-numerals-kata/
I plan on using his examples to attempt to gain a better understanding of TPP and TDD with respect to this exercise.
As a reminder the transformation priotiy premise is as such:
It gives guidance on how to apply small transformations to the code under test in order to evolve it to a more generic implementation
1. ({} -> nil) no code at all->code that employs nil
1. (nil -> constant)
1. (constant -> constant+) a simple constant to a more complex constant
1. (constant -> scalar) replacing a constant with a variable or an argument
1. (statement -> statements) adding more unconditional statements.
1. (unconditional -> if) splitting the execution path
1. (scalar -> array)
1. (array -> container)
1. (statement -> recursion)
1. (if -> while)
1. (expression -> function) replacing an expression with a function or algorithm
1. (variable -> assignment) replacing the value of a variable.

My aim here is to stick purely to these rules in order to reach a solution.
This exercise is purely for learning as i have pedro's solution to guide me becuase i want to undersand more deeply
the way in which this applies to tdd.
I shall be commiting with a changelog each step and what i did in a changelog file.
