# Changelog

### Documentation of the process

### Step 1
the simplest test we can conceive is 1 returning "I".
started by using {} -> nill, the tests still fail.
### Step 2
The first transformation was not successful in making the first test pass.
We move on to the second premise nil -> constant.
The second transformation was enough to make the first test pass.
### Step 3
The second test for 2 -> II fails.
We third transformation we move straight to constant -> variable, as constant -> constant +
adds nothing to our process.
This is not sufficient to make the tests pass.
### Step 4
The next transformation of use is number 5 statement -> statements.
This is still not sufficient to make the tests pass, although its worth noting that the second test 
now passes but the first test fails which is not what we want  at all.
No refactors have yet been necessary.