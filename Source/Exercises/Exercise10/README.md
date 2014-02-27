# Exercise 10: Dice game

This exercise is about *using* an existing class and *completing* an unfinished class. 
The solution contains two classes called Die and DiceCup in the files Die.cs 
and DiceCup.cs, respectively.

1. Investigate the Die class. It is complete and fairly simple. Note that 
   we use another class in the Die class, called Random. This class is 
   from the .NET class library, so it is not as such part of the 
   project. It is "given". Try out the class by creating a Die object 
   (in the usual place for inserting code), call the methods RollDie and 
   GetValue, and print the value you get back. Notice that when you run 
   the program again, you may get different values, just like for a real die.
2. Investigate the DiceCup class. This class is supposed to represent a cup 
   with two dice in it. Therefore, the class has two instance fields, both 
   of type Die. The constructor of the class has also been completed. 
   However, we would like to have three public methods in the DiceCup class as well:
   (a) RollDice: Should roll both dices in the cup. No value is returned.
   (b) GetTotalValue: Should return the total value of the two dice in the cup.
   (c) IsTotalValueLargerThan: This method should take one integer value as input, and 
   return either true or false. The return value should be true if the total value of 
   the two dice is larger than the input value; otherwise, it should return false.
3. Your job is now to add these three methods to the DiceCup class. As a help, 
   the "headers" for each method is already included as a comment in the class. 
   Once you have completed the methods you should of course add some code 
   test that the completed class works as expected
4. [Extra – only if you have time] How can you change the game such that 
   it uses 10-sided dice instead? Can you even make it so that the user decides 
   how many sides the dice have?