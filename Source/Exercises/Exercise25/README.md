# Exercise 24: Student info manager

This exercise is about completing the definition of a class that 
uses a Dictionary object.

The project contains the class Student. This is a simple representation 
of a student, with three instance fields: student id, name, and test 
scores. The first two are simple, but the "test scores" field is a 
Dictionary field holding Key/Value pairs of course names (string) and 
scores (int).

The project also contains the class StudentInfo. This class is supposed 
to be able to retrieve various information about a group of students. 
For this purpose, an instance field students of type Dictionary is 
used to hold Key/Value pairs consisting of student ids and Student 
objects (since a student is uniquely identified by a student id).

  1. The class Student is complete and you need not change anything 
     in it. However, take a good look at the Student class anyway and 
	 make sure you understand how the methods work. Pay particular 
	 attention to the method GetScoreAverage.
  2. Look in the class definition of StudentInfo. You will see that 
     five methods (GetStudentCount, AddStudent, GetStudent, 
	 GetAverageForStudent, GetTotalAverage) are not completed. Your 
	 job is to complete these methods, according to the specification 
	 given in the comments in the code.
  3. In the file Runner class some code that tests the StudentInfo class 
     has been inserted. Run the program and check that your StudentInfo 
	 class behaves as expected.