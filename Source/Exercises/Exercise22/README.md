# Exercise 22: Introducing lists

This exercise illustrates the concept of a *catalog*. A catalog 
is a class that can store and use data of a certain type, without 
revealing the specific representation of data to the user of 
the catalog.

The project contains the simple data class Book (note however 
that we consider the instance field isbn to be a "key" for Book,
i.e. no two Book objects can have the same isbn value). Also, it 
contains the (incomplete) catalog class BookCatalog. The three 
public methods in BookCatalog allow the user to store and use 
Book objects in a simple way (see the comments in the code for 
more details about each method).

Given that we have chosen to use a List<Book> to store Book 
objects internally in the BookCatalog class your job is now:

  1. Complete the three methods in the BookCatalog class.
  2. Study the test written in the runner class and figure 
     out what you expect the test to output.
  3. Run the program and see if the output of the test matches 
     your expectations (if not, you will have to examine the 
	 test and your code once again)
  4. Is there anything in the program that prevents a user 
     from entering two Book objects with the same isbn value?