# Exercise 14: Bank account

This project contains a working BankAccount class. However, it has some problems.

1. Try to test the *BankAccount* class by adding code in the usual runner class. 
   Specifically, make some tests that make the balance go negative.
2. Now change the code in the *Withdraw* method such that a withdrawal is only 
   done if the balance is larger than or equal to the given amount. Remember 
   to test that the change works as expected.
3. This makes the *BankAccount* class more realistic but there are still problems.
   You can call both *Withdraw* and *Deposit* with negative amounts (try it), 
   which does not make much sense. Make changes to both methods such that they 
   only perform a withdrawal/deposit if the given amount is positive. Remember 
   that for the *Withdraw* method, the change made in part 2 must still work.
4. Test that all your changes work as expected.

 

