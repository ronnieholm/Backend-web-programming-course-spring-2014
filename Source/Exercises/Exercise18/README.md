# Exercise 18: Sentinel-controlled while loops

This exercise is about implementing a sentinel-controlled while-statement yourself

1. In the file CubeCalculator.cs, a new class CubeCalculator has been defined. It 
   contains methods useful for calculating the cube of a number given to the program 
   by the user. Read the comments in the class definition and make sure you 
   understand what each method does (it is not needed to understand how the methods 
   work).
2. Run the program. You will see that you can input a number, and the cube of that 
   number is then calculated. The program even handles the situation where the input 
   is not a number. All this is done by the code in the Runner class. 
   Read that code and make sure you understand what it does.
3. A major drawback of the program is that you have to start it again each time you 
   want to calculate a new cube value. Change the code in Runner class such 
   that it becomes a sentinel-controlled while-loop. That is, the user can keep 
   entering numbers until some particular value. The exact details are left for 
   you to decide.