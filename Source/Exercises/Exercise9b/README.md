﻿# Exercise 9b: Using and modifying existing class

This exercise is about using and modifying an existing class. The solution 
contains a new class FruitBox in the file FruitBox.cs.

1. Have a look inside FruitBox.cs and see what the FruitBox class definition 
   contains. See if you can identify the instance fields, the constructor, 
   the methods that return information (accessors), and the methods that 
   change the value of an instance field (mutators).
2. Now try to use the FruitBox class yourself. Insert some code into the solution 
   that does the following: (a) Creates a new FruitBox object, (b) Prints out 
   information about the fruit box – use the method GetBoxContentDescription 
   for this purpose, (c) Adds some fruit to the box, by calling the appropriate methods,
   (d) Prints out the information again – now you should see that the information 
   has changed
3. We now wish to add a new method that can calculate the total price of the 
   fruit in the box, and return the total price to the caller. The method 
   should be named GetTotalPrice. Write this method, and add some code to test 
   the new method as well.
4. Now add two new methods that can change the price of bananas and apples, 
   respectively. The new price must then be a parameter to the method. Remember 
   to add code in InsertCodeHere.cs to test the new methods.
5. We now have a situation where the price of a piece of fruit can be different 
   for two different boxes of fruit. Is that a good model of how things really 
   are in a supermarket?