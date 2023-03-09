# Switches (Bulbs) Technical Interview Practice.
---
Designed as a live coding problem.


###Problem Description
---
Pretend we have a series of N lights on the wall, each with their own switch.
When you turn on the switch for one of the lights, it flips the 
switch for all lights to the right of the one you flipped. Meaning, any lights that were
on previously are now off, and any lights that were off previously are now on.

Your goal is to write a function to determine how many times you need to flip a switch in order to 
turn on all of the lights, and return that value.

Example 1:           Example 2:
[0, 1, 0, 1]         [0, 0, 1, 1]        

Hit Switch 0:        Hit Switch 0:        
[1, 0, 1, 0]         [1, 1, 0, 0]        

Hit Switch 1:        Hit Switch 2:        
[1, 1, 0, 1]         [1, 1, 1, 1]        

Hit Switch 2:        Result: 2 Presses        
[1, 1, 1, 0]                

Hit Switch 3:
[1, 1, 1, 1]

Result: 4 Presses


###Testing Class Usage
---
The Testing class has two constructors, a default and an overload that takes a randomness seed, and the number of tests, and the maximum number of switches. 
It has two functions, RunForPassed and RunWithDetails.

RunForPassed will show expected results, actual results and display passed or failed.
RunWithDetails will display the actual switches themselves, and your result for each test case.

