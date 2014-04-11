# Exercise 28: Exceptions

This exercise is about throwing and catching exceptions.

The project contains a class BankAccount. It defines a fairly 
straightforward bank account but there are a few restrictions 
in it (see the code). One restriction is that the balance 
must not become negative.

The project also contains three additional classes:

  - IllegalInterestRateException
  - NegativeAmountException
  - WithdrawAmountTooLargeException

They are all exception classes, i.e. they inherit from Exception. 
The specific purpose of each exception class is described in the 
code.

The BankAccount class already uses the WithdrawAmountTooLargeException 
class to prevent that the balance becomes negative (see the Withdraw 
method).

  1. Modify the code in the BankAccount class such that the 
     additional exception classes are used properly.
  2. Update the test code found in the Runner such that 
     method calls that could cause an exception to be thrown 
	 are enclosed in try-catch blocks.
  3. Test that the exceptions are thrown and handled properly, by 
     adding some test code that will provoke the exceptions to happen.