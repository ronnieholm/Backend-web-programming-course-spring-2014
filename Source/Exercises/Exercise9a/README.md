# Exercise 9a: Using and modifying existing class

This exercise is about *using* and *modifying* an existing class. The solution contains 
a new class called Status in the file Status.cs.

1. Have a look inside Status.cs and see what the Status class 
   definition contains. See if you can identify the instance fields, 
   the constructor, the methods that return information (accessors), 
   and the methods that change the value of an instance field (mutators)
2. Now try to *use* the Status class yourself. Insert some code into the 
   solution that does the following: (a) Creates a 
   new Status object, (b) Prints out some information about the Status object: 
   The status text, the number of likes, and the number of dislikes. In 
   order to do this, you need to call some method on the Status object. (c) 
   Makes some calls of the methods which change the number of likes and dislikes. (d) 
   Prints out the information again – now you should see that the information has changed
3. After this we decide that we want to keep track of the number of times the 
   status has been read. To do this we need to *add code* to the Status class. 
   More specifically, you need to: (a) Add a new instance field numberOfReads to 
   store the number of times a status has been read, (b) Update the constructor 
   to give this instance field an initial value (what seems like an obvious initial value?),
   (c) Add a new method ReadStatus that will increase the number of times the 
   status has been read by one (Hint: the method will be very similar to the 
   AddOneLike method), (d) Add a method GetNumberOfReads that will return the 
   value of the new instance field, (e) Update your test code, so the new methods 
   are tested as well.
4. [Extra – only if you have time] Add a method ReadStatusMultiple that will 
increase the number of times the status has been read with a number given by 
the user (Hint: the method will then need to take this number as a parameter).