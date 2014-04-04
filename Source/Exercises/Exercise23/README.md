# Exercise 23: Car pool manager

This exercise is about completing the definition of a class 
that uses a Dictionary object.

The project contains the class Car. This is a very simple 
representation of a car with only three instance fields: license 
plate, brand, and model. This class does *not* need to be changed.

The project also contains the class CarPool. This class is supposed 
to represent a pool of cars. For this purpose an instance field 
carList of type Dictionary is used to hold Key/Value pairs consisting 
of license plates and Car objects (since a car is uniquely identified
by its license plate).

  1. Look in the class definition of CarPool. You will see that three 
     methods (AddCarToPool, RemoveCarFromPool, LookupCar) are not 
	 completed. Your job is to complete these methods according to 
	 the specification given in the comments in the code.
  2. In the file InsertCodeHere.cs, some code that tests the CarPool 
     class has been inserted. Run the program, and check that your 
	 CarPool class behaves as expected.