# The Bank Job

In this exercise we will try to evolve parts of what could become a bank system. 
Note that the exercise is a bit different from the previous exercises in that 
the end goal is not as precisely defined as usual. Your own thoughts and ideas 
are thus quite important here.

The progression of the exercise is to start out from a set of more or less 
well defined requirements and move toward a design for a set of classes. Then to 
try to code (and improve) upon such a set of classes and finally to use them to
create a more complex application.

You will thus have less guidance than usual, but this also means that there 
is not as such one "final" or "correct" solution. Some of the requirements 
stated in the assignment might not be clear. You must then choose a way to 
interpret them.

## The setup

We wish to create classes representing a bank. We have played around with bank 
account classes before (in exercise 14) but they were very simplistic. 
In this setup, the bank wants a more complex model. More specifically, they 
imagine the bank should have three kinds of bank accounts:

  - A "basic" account where you can deposit and withdraw money and get the 
    balance.
  - A "savings" account which works like the "basic" account but with some 
    extra features:
	(a) You can only deposit money up to a certain limit.
	(b) You can only withdraw money from the account three times. After the 
	    third withdrawal there is a fee of 25 kr. for withdrawals.
  - A "young limited" account which works like the "basic" account but with 
    some extra features:
    (a) You can only withdraw a certain amount of money per day.
	
Furthermore, all bank accounts should include:

  - A unique bank account number
  - The name of the bank account owner

## Step 1

*Your job* in step 1 is to think about (not code) how you could implement this
application. More specifically, think about what classes you will need for 
this, what instance fields will be needed, what methods will be needed, and 
how the methods would actually work. You can make some notes, draw some diagrams, 
etc, but you do not need to code anything just yet. When all groups are done 
with this step, we will do a general class discussion about the results.

## Step 2

*Your job* in step 2 is to try to actually code the classes needed as discussed 
in Step 1. Note that you do *not* need to code the classes exactly according to 
your own design in step 1. During the class discussion about step 1, you may 
at some point have thought "hey, that’s a nice way of doing it" and you should 
feel absolutely free to use any ideas or suggestions that came up during the 
discussion. Remember to also make a few tests of the code that you have created. 
As in step 1 we will at some point do a class discussion about this step. If 
you want to have a starting point, you could the BankVersion2 project, which 
already contains a very simple bank account class.

*Important*: You do not need to think about inheritance in this step.

## Step 3

*Your job* in step 3 is now to see if your code from step 2 could be improved,
more specifically by using inheritance. The classes representing the different 
kinds of bank accounts will most likely have some things in common. For 
instance, they have common instance fields and methods. Think about how 
you can use inheritance to avoid declaring the same instance fields in many 
different classes. See if we can use the fact that we can override the 
implementation of a method, etc.

## Step 4

*Your job* in step 4 is to develop a single, but probably a bit complex, class 
called Bank, which is supposed to be the "interface" or entry point to the bank 
system. A programmer using the bank system should thus not create bank account 
objects directly, but should do so through the methods of the Bank class. In 
fact, it should be possible to do all bank account operations through the Bank 
class, given the account number of a specific account. The Bank class must thus 
be able to create, store, and maintain bank account objects (by "store" we just 
mean while the program is running, not in a file or database). This will 
require that you think about what methods we need for the Bank class and how 
bank account objects are stored appropriately inside the Bank class.
