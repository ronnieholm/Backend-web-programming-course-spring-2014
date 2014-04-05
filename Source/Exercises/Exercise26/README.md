# Exercise 26: Company info I

Initially, the project is rather simple. It just contains the class Employee. 
This class is supposed to serve as a base class for a number of derived classes.

  1. Examine the Employee class. You can see that an employee just has a name 
     and a monthly salary, both of which are set through the constructor. 
	 After construction the values cannot be changed. Note that the method 
	 GetSalaryPerMonth() is declared to be virtual.
  2. Define a class Worker. The Worker class is supposed to be derived from 
     the Employee class. A worker has a skill which can be represented by a 
	 simple string, like "truck driver" or "maintenance". The Worker class 
	 should thus have an instance field to represent this. The skill should 
	 be set when a Worker object is constructed but it should also be possible 
	 to change the skill later. When implementing the Worker class, pay 
	 special attention to implementing the constructor correctly (it must 
	 call the base class constructor).
  3. Define a class Manager. This class should also be derived from the 
     Employee class. In addition to having a monthly salary, a manager also 
	 has a monthly bonus, which should be specified at construction. The bonus 
	 is paid out if the manager has worked more than 180 hours in a month. 
	 It should be possible to specify the number of worked hours after the 
	 object has been created. When implementing the Manager class, pay special 
	 attention to implementing the method GetSalaryPerMonth() correctly, since 
	 this should also include the bonus if the bonus condition is fulfilled. 
	 Remember that the method is supposed to override the method in the base 
	 class.
  4. Define a class Director. The Director class is supposed to be derived 
     from the Manager class, i.e., not the Employee class. A director is just 
	 a manager who has a fixed monthly bonus of 20000. The condition for 
	 triggering the bonus is the same as for a manager. When implementing the 
	 Director class, pay special attention to implementing the constructor 
	 correctly. Does the class need anything else than a constructor?
  5. Create a test of the classes as usual with a runner class. More 
     specifically, you should (a) Create a list which can hold Employee 
	 objects, (b) Create some Worker objects and add them to the list, (c) 
	 Create some Manager objects, set the hours worked, and add them to the 
	 list, (d) Create some Director objects, set the hours worked, and add 
	 them to the list, (e) Using a loop statement, print out the content of 
	 the arraylist, like "(name) has a salary of (salary)".