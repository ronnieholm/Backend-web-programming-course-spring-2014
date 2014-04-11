# Exercise 29: Static examples

This exercise is about using and defining static classes, 
methods, and instance variables.

The project contains the class ListMethods which defines two 
methods FindSmallestNumber and FindAverage. The names should 
hopefully indicate what they do.

Code that tests the class is included in the Runner. The class 
is tested in the traditional way: create an object, and call 
methods on the object.

  1. Modify the ListMethods class such that it becomes a static 
     class. Remember that a static class can only contain static 
	 methods.
  2. Modify the code in the Runner such that it uses the 
     ListMethods class as a static class. The output of running 
	 the program should of course be as before.

The project also contains a simple class Car (see the code). We 
would now like to track how the class is used. More specifically, 
we wish to track:

  - How many objects of type Car have been created
  - How many times has the method GetLicensePlate been called?
  - How many times has the method GetPrice been called?

Note that it is the "grand totals" we wish to track, not the number 
of method calls on each object.

  3. Add static instance fields to the Car class to enable the 
     tracking described above. Increment the value of each variable 
	 at the appropriate place in the class.
  4. Add a static method that can print out the values of the static 
     instance fields. It could be called PrintUsageStatistics.
  5. Test that your additions work by including some test code in 
     the Runner class. Create some Car objects, call methods on them, 
	 and finally call the static method to observe the usage statistics.