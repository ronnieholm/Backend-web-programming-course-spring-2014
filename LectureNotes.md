# What is backend web programming?

A typical modern application: A Web Shop 
 
What tasks are involved in a Web Shop? 

  * Presenting content 
  * Receiving user input 
  * Constructing an order 
  * Storing the resulting order 
  * Storing other data (user preferences, ...)

We usually divide such an application into "layers" (although terms may vary).

  * GUI Layer 
  * Logic Layer 
  * Data layer 

GUI Layer: responsible for presenting content and managing user 
interaction (receiving input, showing output).
 
Logic Layer: responsible for applying business rules (logic) to 
incoming data, thereby producing data for storage. 
 
Data layer: storing the "final" data, e.g., for processing by other 
subsystems like an order shipment system.

## Why bother to divide into these layers?

  * Right tools for the job. The tools used for constructing the 
different parts of an application are different in nature
  * Flexibility. Having an application pieced together by 
dedicated subsystems makes it easier to replace or 
supplement the GUI, while preserving logic/data parts

## PBA Web terminology

  * GUI Layer is Front End (FE) 
  * Logic layer is Back End (BE) 
  * Data Layer is Databases (DB) 

In backend we'll thus concentrate on *tools and techniques 
for implementing business rules and logic, using a so-called 
Object-Oriented programming language*. 

Note: Some might know ASP.NET technology, is that not Back-End? In this 
context, we don't consider it "pure" backend since it deals with 
the creation of HTML, i.e., GUI. It's a bit in the grey zone, though.

# Course Goals

Experience from previous semesters: Object-Oriented programming is quite 
different from what most non-CS students have experienced before. How 
much experience do you have with:

  * HTML
  * CSS
  * JavaScript
  * PHP
  * Other programming languages

Goals for the course:

  * To be able to *read*, *understand* and *modify* C# programs of 
    low-to-moderate complexity
  * To be able to *create* (from scratch) C# programs of low complexity

You will not become full-blown C# programmers after this course, and nobody 
expects you to.

# How we work in PBA Web BE Programming

Schedule: 5 classes/week, 15 weeks in a semester = 75 classes of 45 
minutes each (plus one extra day¡K)

What will the exam be like?

  * Oral exam
  * 30 minutes total, 20-25 minutes actual talk
  * 30 minutes preparation

You must be able to

  * Explain concepts within a given area in the curriculum
  * Explain a given piece of code
  * Use the relevant vocabulary
  * Do all this in an understandable English

## Your resources

  * Classes (Teacher explains and illustrates main concepts, no time for all details, work on exercises, projects)
  * Book (Rather large, use for background and details)
  * Teachers Notes (defines what will be tested at the exam)
  * Exercises, including solved versions of the exercises
  * Class website
  * Internet (use it actively to find tutorials, alternative explanations, etc.)

Your most important tool: PRACTICE!

Even though the course goal is primarily to become able to read and understand 
code, experience shows that actually doing some programming yourself is really 
the key to deeper learning about the concepts.

If you are unable to do the exercises in class, then give it a try at home, 
maybe using the solved versions of the exercises for reference. Also pose 
some challenges for yourself – start out with something very simple, and then 
gradually work your way towards more complex problems.

# The Programming Process

If you have never tried something like programming before, it may seem 
like a mysterious activity – what is it really that we are doing? If we 
focus primarily on programming as a way of defining "business logic", we 
are usually *defining and manipulating a model of a small piece of the world*.

What does that mean more specifically? Suppose we wish to make a program 
for administration of a school. Then we probably need to store certain 
information about students (and other things) in the program. What things 
are relevant to know about a student? Date of birth? Shoe size? That will 
depend entirely on the *requirements* to the system, which the users of the 
system will have to define.

The result will probably be that certain information is needed, while 
some information can be left out. So, the “model” of a student in the 
program may only contain certain information; the information which is 
relevant in relation to the requirements. Exatcly which pieces of 
information we include will depend on the specific situation, i.e. the 
specific requirements.

Once we have figured out what information we need to include for each
"concept" (student, teacher, class room, ...) in the model, we need to 
figure out how to represent that information in our program. We get 
to that part very soon!

In almost all cases, the information will need to be manipulated somehow. 
A very simple manipulation could be just to show the information to a 
user. A more complex manipulation could be to change the information. 
For a student, some information will probably never change (the date of
birth), while some informa-tion will most likely change (the number of 
courses taken).

The way information changes can range from quite simple to very complex. 
The simplest change could simply be to change the current value to a new,
given value. Say, when a student has taken one more course, the number of 
courses is increased by one. Other change are more complex. If we e.g. 
store an average of the exams passed by the student, then passing an 
additional exam will require a recalculation of the average. In any case, 
there will always be *rules* for how to manipulate the information.

In programming, we then try to *translate* such rules (formulated in a 
human language) to instructions/logic written in a language the computer
can understand, in this course the language C#. This will result in 
writing a number of *statements*. When we have large collections of 
statements, we can organise the statements into so-called *methods*, 
which we discuss later.

# Environment

Backend programming is often done in terms of an Object-Oriented 
programming language ¡V we have chosen C# (why?)

What is C#?

  * Object-Oriented Language
  * Part of Microsoft .NET Technology
  * Related to Java and C++

Most widespread tool for C# programming is Microsoft Visual Studio (newest 
version is 2012, which we use in this course), abbreviated MSVS.

MSVS is a professional and commercial tool (Express version somewhat scaled down)

  * Has quite a lot of facilities, huge knowledge base (+)
  * Has quite a lot of facilities, not that easy to master (-)

We only need to use a fraction of the functionality

  * Understand the structure of a "solution" or "project"
  * Being able to navigate a project
  * Understand the role of the included files
  * Add code to a project
  * Compile/build a project
  * Run a project
  * Understand error messages from MSVS

Try not to be too intimidated by the environment (tunnel vision).

Top level of a C# application is a solution – an application is a solution.

A solution can contain one or more *projects*. In practice, we will always 
have just one project in our solutions.

A solution consists of several files: we do not need to worry about all of the files.

The *Solution Explorer* gives us an overview of the current solution. Do 
not worry about what is contained in the sections *Properties* and *References*.

Below these sections will be a list of files with the extension *.cs*. 
These files contain the actual source code of the solution.

The files with the .cs extension contains C# *classes*. We'll get back to classes later.

Classes contain *methods*, methods contains *statements*. A statement 
is one single instruction for the program about what to do next (add 
two numbers, print something, etc.).

How do I open a Project/Solution in MSVS?

  * Choose File | Open | Project/Solution
  * Navigate to the folder where the project is (note that a C# project is 
    contained in a single folder in the file system)
  * Click on the file with the same name as the project, with the extension 
    .sln (.sln for "solution")
  * The project should now be loaded, and you can see it in the Solution Explorer

Before a program can be run (executed), it must be compiled and built. MSVS will

  * Check that the code is vaild (correct syntax)
  * Compile the code into "native" .NET code
  * Build the project, making it executable

Our main concern is to enter valid (and correct) code into a project. MSVS does the rest.

Note the difference between "valid" and "correct" code. A piece of code 
is "valid" if it obeys the syntax for C# code, which makes it possible 
to compile the code. However, we only consider a piece of code to be "correct"
if it does what it is intended to do. That is an important difference!

Running a program: Press the little green triangle (or press F5).

# Statements

At the most fundamental level, all C# programs consist of a collection of C# *statements*.

Statements are organized into *methods* and *classes*; we'll get to that later.

Statements are instructions to the program about what to do next. Examples are:

  * Do some arithmetic or logical calculation
  * Read or write data to e.g. a file, the screen, etc.
  * Control the "flow of execution"
  * Etc.

Only common property for all statements: they end with a ";" (semicolon).

Depending on their purpose, a statement has a certain syntax.

Syntax is very important, it MUST be obeyed 100%. If not, you will get an 
error message from MSVS, if you try to run the program. In fact, If a statement 
is not syntactically correct, you will be notified even before running the 
program! Wavy red lines will appear in the code.

You will be annoyed by this… But there is no way around it! (Well, it is 
possible to switch off, but better to get used to it).

DO NOT ignore the red lines! They indicate that something is wrong, so fix 
it right away. Can be somewhat annoying that they appear as soon as you 
type in a statement.

If an error appears – hover the mouse over the error indicator. A tooltip 
with an error description will appear. Alternatively press F6 (build solution) 
– a list of errors will appear.

Error descriptions can sometimes be more confusing than helpful – best 
advice is to read the code again, and use common sense.

Good advice when programming:

  * Fix errors as soon as possible
  * Keep the number of "open" errors minimal
  * Test whenever possible

# Programming Fundamentals

What is programming? Presentation, manipulation and storage of data.

In Web-programming terms

  * Presentation: Front-End
  * Manipulation (Calculation): Back-End
  * Storage: Databases

Data manipulation can (a bit abstract) be broken down to:

  * Receive the data needed for the calculation
  * Store the data in memory, in suitable data structures
  * Perform manipulation, according to business logic
  * Store the result in suitable data structures
  * Enable the user to access the result

In back-end programming, we concentrate on:

  * Data representation, using suitable data structures
  * Data manipulation, using suitable logic

What types of data do we wish to manipulate:

  * Numerical data
  * Text data
  * Logical data (true/false, Boolean logic)
  * (Binary data, e.g. pictures) ¡V not the primary focus

# Types and variables

How does a program store the data it needs to manipulate? Data is 
stored in the memory of the computer (RAM).

What is computer memory actually? Just a lot of elements (called *bits*), 
each of which can be either 0 or 1. We refer to a collection of eight bit 
as a *byte*. 256 possible distinct bytes.

Each byte in memory has an address. A modern computer has billions
of bytes (one billion bytes = Gigabyte).

Raw storage of data – no matter the type – amounts to setting the value 
of certain bytes at certain addresses in memory. This is possible,
but somewhat tedious.

Almost all programming languages therefore support the use of so-called 
*variables*.

What is a variable actually? It is a piece of memory; i.e. a certain 
amount of bytes, located at a certain address in memory.

In order to make it easy – for humans – to use variables, we can give 
a variable a *name*, instead of having to refer to the actual address 
in memory. Also, we do not need to define the actual address of the
variable ourselves – the program does that for us.

In addition to this, we must choose a *type* for the variable. This defines 
the kind of data the variable can store.

Some types for storing data (primitive types, built-in):

  * int: whole numbers (no decimals), from about -2,000,000,000 to 2,000,000,000. Uses 32 bits = 4 bytes
  * double: decimal numbers, with "high" precision. Why not exact values? Uses 64 bits = 8 bytes
  * bool: a true/false value. Usually uses 4 bytes, even though it in theory should use much less
  * string: A text of arbitrary length. Uses one byte for each character in the string.

The great advantage of having types is that we do not have to convert the 
data from the “human” type (e.g. a string) to the "computer" type, which 
is always 0/1 values.

Declaration of a variable in C#:

    // Reserve space in memory for an int,
    // refer to the address by the name “age”
    int age;

    // Put the value 24 in the bytes
    // referred to by “age”
    age = 24;

Note that the above types can also be written like *Boolean* (for bool), 
*Int32* (for int), *Double* (for double), and *String* (for string). 
Choose the name that you prefer.

# Arithmetic

A very important part of most programming tasks is arithmetic. Almost 
all programming languages support arithmetic, since much data manipulation 
has an arithmetic nature – we perform calculations. The specific syntax
may vary somewhat.

C# supports most common arithmetic operations, but there are certain 
operations that differ from "classic" arithmetic.

We have already seen assignment:

    int age;
    age = 24; // Assignment, NOT an expression

Very important to note that this means, "set age equal to 24". It does 
NOT mean "age is equal to 24" (which may be true or false).

Simple arithmetic:

    int age;
    age = 24 + 32; // Now age is 56
    age = age + 10; // Now age is 66

    int legalAge = 18;
    age = legalAge + 10; // Now age is 28

The right-hand side is always evaluated first, and the result can e.g. 
be stored in a variable. The same variable can occur on both sides of the "="
(assignment) sign.

Note that the exact type is important. Consider this assignment:

    int a = 7;
    int b = 4;
    int c = a/b; // a divided by b

The result is NOT 1.75 as you might expect but 1. When doing arithmetic 
with integers, the result will also be an integer. Note also that there 
is no rounding of the result. It might seem more natural that c should 
become 2, but it doesn’t.

There are some non-standard operators in C#. For instance the "remainder" 
operator % (or "modulo"):

    int a = 7 % 4;

The result of the above is 3 – the remainder when dividing 7 with 4 (integer division)

Usual rules for precedence apply, so e.g.

    int a = 2*3+4; // This is 10, NOT 14

Some forms of conversion between types are possible, like:

    int a = 7;
    double b = a;     // b is now 7.00000
    double c = b / 4; // c is now 1.75

Type conversion is a larger subject – short story: you can convert automatically 
when you do not lose information (7 -> 7.0 OK, 7.4 -> 7 not OK).

Use of brackets is also allowed, and follows standard rules. Good idea to use 
brackets to increase readability, even if they are not strictly necessary.

# Simple data output on the screen

Even though Back-End programming is not about GUI, we still need – as part of 
learning about programming – to output data to the screen, so we can see if our 
program works as expected. We have actually seen this already:

    Console.WriteLine("Hello Class");

So, the statement *Console.WriteLine* will output something on the screen. 
In the above example, it will output:

    Hello Class

In general, *Console.WriteLine* will output the data we specifiy in the 
brackets () following the *Console.WriteLine* words them-selves. If we 
write something within quotation marks, like "Hello Class", then this is 
interpreted as data of the type string, and the string (minus the 
quotation marks themselves) is printed. However, Console.WriteLine* is 
rather flexible. Consider the below piece of code:

    int age = 21;
    Console.WriteLine(age);

If you execute this piece of code, the program will print:

    21

Why did it not print the word "age" instead? In general, *Console.WriteLine*
will print a string. If we put something else in the bracket, the program 
will try to convert it to a string. That is, not the variable itself, but 
the value of the variable. In fact, all values can be converted to a string.
What was actually printed in the example is the string "21", because the 
value 21 was conver-ted to the string "21". This can be done for all types 
of values.

Also very useful is the ability to "chain together" values, for instance like:

    int age = 21;
    Console.WriteLine("The age is " + age);

If you execute this piece of code, the program will print:

    The age is 21

What is going on inside the brackets? Actually several things. First, it 
seems we are adding two things – a string and an int. Can we even do that? 
In general, you can only add things of the same type. But since any value 
can be converted into a string, the value of age (21) can be converted 
into a string. So, we are then trying to add "The age is " and "21". Since 
addition of two string is defined as concatenating the string (writing 
the first string after the other), the result of the addition is "The age 
is 21", which is then printed to the screen. This ability if chaining 
together several values (you can add as many values as you like inside 
the brackets) is very useful for outputting a message on the screen.

Using string concatenation is one way of printing a longer message – 
consisting of a mix of text parts and variable values – on the screen, 
using *Console.WriteLine*. However, there is another way to do this 
which might be more convenient, by using a so-called formatting string.

Suppose we have two variables like:

    string name = "James"; 
	int age = 23;

and want to print a message like:

    James is 23 years old

Using a formatting string, this will look like:

    Console.WriteLine("{0} is {1} years old", name, age);

Notice the use of the curly braces, like the {0} and {1}, inside the string. 
This should be understood as: Take the value from the first variable 
following the string (in this case, the variable called *name*), and 
replace {0} with that value. Then take the value from the next variable (*age*),
and replace {1} with that value. So in this example, {0} is replaced with 
"James", and {1} is replaced with "23", producing the string above. Note that 
you can use this principle for as many variables as you wish, by 
adding {2}, {3} etc. to the formatting string, and adding the variables 
themselves after the formatting string (separated by comma).

# Logic

The ability to work with *Boolean logic* is also a very important feature of C#.

Boolean logic: expressions can evaluate to true or false. Becomes very 
important for controlling the flow of execution through control statements (later).

The most common use of boolean logic is when testing for *equality* or 
testing for a *relation* (strictly speaking, equality is also a type of relation).

Testing for equality: Are two entities (e.g. numbers) equal to each other, or 
different from each other.

Testing for relation: Do two entities (e.g. numbers) have a parti-cular 
relation to each other, like e.g. the first being greater than the other.

Just like for arithmetic there are a number of relational (or logic) operators
available in C#:

  * == means "equal to" (notice two equal-signs)
  * != means "not equal to"
  * > means "greater than"
  * < means "smaller than"
  * >= means "greater than or equal to"
  * <= means "smaller than or equal to"

Notice that we use these operators to *compare* values, not to change values.

Any expression using these relational operators will evaluate to either *True*
or *False* which are exactly the values a variable of type *bool* can have.

    int a = 7;
    bool b = (a == 7);   // b will be True
    bool c = (a < 7);    // c will be False
    bool d = (a <= 7);   // d will be True

Fairly straightforward for integers, slightly more tricky for double (decimal numbers).
4.0000000002 is not equal to 4.0000000001 (but maybe it is "close enough"?).

Comparing strings is also done using the "==" operator.

How can we test if the value of a variable is inside an interval, e.g. between 10 and 20 (included)?

    int a = 14;
    bool lowLimitOK = (a >= 10);
    bool highLimitOK = (a <= 20);
    bool isInInterval = lowLimitOK && highLimitOK;

Notice the operator && – this means "and".
The expression A && B is only true if A is true *and* b is true as well.

We also have an || operator – this means "or".
The expression A || B is true if A is true *or* b is true. Note that the expression is also true if both A and B are true.

Finally, we have the ! operator – this means "not".
The expression !A is true if A is false and vice versa. The ! operator can be said to "reverse" the value of an expression.

"or" is obviously more forgiving than "and". By using the operators, we can 
combine expressions to form quite complicated expressions:

    bool isOK = ((a < 20) && (a > 10)) || (a > 60);

Logical expressions become harder and harder to understand as they grow in length.

Another way to look at the values these operators produce is to use a *truth table*:

<table>
  <tr>
    <th>A</th>
	<th>B</th>
	<th>A && B</th>
	<th>A || B</th>
	<th>!A</th>
  <tr>
  <tr>
    <td>True</td>
	<td>True</td>
	<td>True</td>
	<td>True</td>
	<td>False</td>
  </tr>
  <tr>
    <td>True</td>
	<td>False</td>
	<td>False</td>
	<td>True</td>
	<td>False</td>
  </tr>
  <tr>
    <td>False</td>
	<td>True</td>
	<td>False</td>
	<td>True</td>
	<td>True</td>
  </tr>
  <tr>
    <td>False</td>
	<td>False</td>
	<td>False</td>
	<td>False</td>
	<td>True</td>
  </tr>
</table>

# The concept of functions

With arithmetic and boolean expressions we can begin to write non-trivial pieces 
of business logic. For instance, we can calculate the average of three integers:

    int average = (a1 + a2 + a3) / 3;

This is rather simple, but if we must do this many places in our code, it can 
become tedious to write again and again. This is even more problematic if the logic 
is more complex. Instead of this, we would like to define the logic in *one* place, 
and then *refer* to that logic instead of writing it again over and over. We can 
do this by defining a function.

A function is a fundamental concept in programming. The syntax may vary from language
to language, but you always need to:

  - *Name* the piece of logic so you can refer to it
  - Define what *input* the function needs
  - Define the *logic* of the function
  - Define what the *output* of the function is

A function for calculating average as per above could in C# look something like
this (details of syntax not so important yet):

    int CalculateAverage(int val1, int val2, int val3) {
        int average = (val1 + val2 + val3) / 3;
        return average;
    }

This function is called *CalculateAverage*, takes three integer as input, and 
produces one integer value as output.

We can now refer to this logic when we wish to calculate an average. For the 
previous example, it will look like:

    int average = CalculateAverage(a1, a2, a3);

We say that we *call* or *invoke* the function CalculateAverage. Now the caller 
of the function does not need to know the details of the logic, only how to refer to it.

When we call the function, we can use the output – which is more precisely called 
the *return value* – in the same way as any other value, for instance in an 
assignment statement as above. We can even use function calls in expressions, like:

    int total = func1(x) + func2(y);

assuming that the functions *func1* and *func2* were defined.

You can compare a function in C# with a function in mathematics: it takes some 
input, and produces some output, depending on the specific nature of the function. 
In programming, a function can, however, take many values (even zero) as input.

# Pre-OO programming

We have now been introduced to types and variables, basic arithmetic and 
logic statements, and the concept of functions.

In the "old days" of computer programming (before 1990) – before *Object-Oriented 
programming* – this was more or less the level of abstraction programs were written at.

  - Good: using variables and types allows us not to worry about details of data 
    representation and memory management.
  - Bad: still quite far between real-life concepts such as Student, Employee, Animal, ...
    and data representation.

Note that it is quite possible to make very complex software using this "old school" 
style. Still, it was recognised that a different "paradigm" would make it possible 
to create better representations of real-life concepts in software.

# Object-oriented (OO) Programming

In non-OO programming, data and functions are separated. No encapsulation, data 
belonging to the same conceptual entity is spread out over multiple data structures.

In Object-Oriented programming, data and functions are joined into objects. 
The state (data) and behavior (methods, which is essentially the same as functions) 
of objects of a certain type are specified in a class definition.

Advantages:

  - Code structure will be more similar to conceptual models.
  - Encapsulation – the user of a certain class only gets to know what the 
    user needs to know. There is freedom to change the internal structure of a class.
  - Reuse – OO contains facilities that allows reuse of code through e.g. inheritance.

NOTE: OO is still "just" a tool for helping human beings in developing computer programs 
– internal representation in memory is the same as before.

# The Class concept

A class definition is a "recipe" or "blueprint" that defines how an object of this 
particular class will behave.

A class definition defines the objects "interface" to the outside world, by 
defining methods that a user of the object can invoke on the object. This is 
very similar to the *functions* we discussed earlier.

Methods are collections of statements, such that a sequence of statements can 
easily be executed by "calling" the method. By "calling" we mean that somebody 
invokes the method, thereby executing the statements in the method.

A class definition also defines the internal structure of the object, more 
specifically the *state* of the object, which is represented by one or more 
*instance fields* (a special kind of variables).

A class definition may also define some internal methods, that can help the 
object perform its tasks, without being directly available to an external user 
of the object.

The interface to the external user should prefereably not change. If it changes, 
the user of the object may have to change his code, and we wish to avoid that. 
As long as the interface does not change, we have freedom to change the internal 
structure, without affecting an external user.

# Using objects of an existing class

It is possible to start using classes without actually knowing anything about 
how to define classes.

We use a class by creating an object of that class. That is, an object which 
will behave as specified in the class definition.

    // Create a new Student object
    Student s1 = new Student();

Note that this is actually quite similar to a statement like:

    int age = 19;

On the left-hand side, we have the declaration of a variable, consisting of a 
*type* and a *name* of the variable.

On the right-hand side, we have an actual value which we assign to the variable. 
In the new case, that value is actually a *new object* of the type *Student*.

The *new* keyword is always used when creating a new object followed by the 
name of the class (here Student).

Now the variable *s1* refers (points to) to an object of type Student and we 
can begin to call methods on the object.

When a variable refers to an object of a certain type, we can call methods on 
that object by using the so-called "dot" syntax:

    // Call a public method
    s1.PrintName();

Notice the dot (full stop) that follows the variable name. After the dot, 
we write the *name* of the method we wish to use.

How can we know what methods that are available? If we have written the 
method ourselves. In a more professional system, there will be some 
documentation of the available methods that you can refer to.

In Visual Studio, you will see that a list box of available methods pops up,
as soon as you type the dot. Don’t be confused.

In general in order to call a method on an object, we must supply

  - The method name
  - Any parameters needed (the parameter list)

Some methods may require information from the caller in order to do its job. 
We could imagine a method on a Student object:

    s1.SetTestResult("English", 80);

This method requires the caller to provide two *parameters*: a string (the name 
of the subject which was tested for), and an int (the result of the test). 
arameters are always provided inside the brackets () that follows the method 
name, must be provided in the correct order, and must have the correct type.

Other methods may return information to the caller. This is called a *return value*. 
This will be indicated in the documentation. The special return value *void* means 
"no return value". It may seem strange that you have to specify that a method does 
not return any information – couldn’t we just not write anything? The syntax of 
C# is so that you *must* specifiy what a method will return to the caller, so the 
word void has this special meaning of indicating that nothing comes back when 
calling this method.

If we want to use the return value for something (we usually do), we need to 
"pick it up" in a variable:

    int average = s1.GetAverageTestScore();

Now the variable *average* will have the value which was returned by the method call.

Note that when a method call returns a value that value can be used directly 
just as a simple variable, e.g. like:

    Console.WriteLine(s1.GetAverageTestScore());

We *cannot*, however, make assignment in this way:

    // NOTE: This will NOT work!
    s1.GetAverageTestScore() = 75;

# Class definition elements

A definition of a class is placed in a separate file, which has the extension .cs. 
The class definition itself must contain:

The "signature" of the class definition. The first line will contain the name of 
the class; the rest of the definition (the body) must follow inside the area 
delimited by { and }.

    public class Student {
        // Rest of class definition is here
    }

*Zero or more instance fields*. An instance field is a variable, which belong 
specifically to an individual object. Each object of a given class will have its 
own "set" of instance fields. Setting the values of the instance fields on one 
object will not affect the values of the instance fields in another object.

*One or more "public" methods*. The public methods are the methods that a user 
of the class can invoke on the object. These mehtods fall in two categories: 
Those that "ask a question" to the object (accessor), and those that may 
change the state of the object (mutators). Note that a method definition is 
also delimited by { and }. The collection of statements inside the delimiters 
is called the *body* of the method.

*Zero or more "private" methods*. The private methods are helper methods that 
help the public methods complete their tasks. They are *not* available to an 
external user.

*One or more "constructors"*. A constructor is a special kind of method that is 
invoked when the object is created. Its primary purpose is to ensure that the 
object is created in a well-defined state, i.e. give the instance variables 
well-defined values.

# Instance Fields and State

Class definition (part of):

    public class Student {
        private string name;
        private int yearOfBirth;
        private int testsTaken;
        private bool isMale;
    }

The four lines between the { and the } define four *instance fields*, that are not 
directly available for a user; this is indicated by the *private* keyword in front 
of each definition. In Object-Oriented programming, an instance field is 
typically made private, since an external user should *not* manipulate the values 
of the instance fields directly, but rather do it indirectly by calling methods.

All of the values for the instance fields define the *state* of a specific object. 
Recall that state is indeed object-specific. Two different objects of the same class 
will have the same set of instance fields, but the *values* of the instance fields may 
be different:

    State of one object: { “John”, 1988, 3 , True}
    State of a different object: { “Susan”, 1984, 0, False}

# Methods and Behavior

Class definition (part of):

    public class Student {
        public void PrintName() {
            Console.WriteLine(Name);
        }

        public void IncreaseTestsTaken(int NewTests) {
            TestsTaken = TestsTaken + NewTests;
        }

        public int GetTestsTaken() {
            return TestsTaken;
        }

        public bool IsStudentMale() {
            return isMale;
        }
    }

A method definition consists of

  - Access specifier
  - Return type
  - Method name
  - Parameters

Some methods return information about the state of the object. This could simply be 
the value of an instance field, or it could be a compund or calculated value.

Note that when a method does not return any value, we indicate this by using the 
*void* return value.

Methods that return information are often called *accessors*, while methods that 
change the state are called *mutators*.

Some methods are neither accessors or mutators, but have some kind of "side effect",
like printing something (not very common in back-end). Also, some methods may both 
be an accessor and a mutator. Usually not recommended, since it may indicate too 
many responsibilities for the method.

Note that we use the keyword *public* to indicate that a method is available 
to an external user. Only methods that an external user is intended use should 
be marked public. A *private* method can only be used by other methods in the 
class itself.

Instance fields are usually *private*. We want to encapsulate the true 
representation. Users do not need to know that represen-tation, and we 
then can change it without affecting the user.

Note that we can use *local variables* inside a method. They are used to 
make caluclations easier, and are only “alive” while the method executes. 
They *cannot* be accessed by other methods in the class, or by external users.

# Class constructors

A *constructor* is invoked when we create a new instance of a class, i.e. when 
we create an object:

    // We call a constructor without parameters
    Student s1 = new Student();

The primary purpose of the constructor is to set the state of the object to 
something sensible and well-defined.

In many cases, it will not make sense to create an object without having certain 
information available, like name and birth for a Student. We would then use a 
constructor with parameters:

    // We call a constructor with parameters
    Student s1 = new Student("Per", 1967, True);

*We* define constructors! And we may define as many as we want; one without 
parameters, and one (or more) with parameters. Note that if we do not define 
any constructors at all, there will still exist a "default" constructor with
zero parameters, that does nothing. This is usually not a recommended approach.

In general, if it does not make sense to create an object without certain 
information, the constructor should include parameters that represent this 
information. This prevents that objects can be created without this information.

Example of a constructor for the Student class:

    public class Student {
        public Student(string s_name, int s_yearOfBirth, bool s_isMale) {
            name = s_name;
            yearOfBirth = s_yearOfBirth;
            isMale = s_isMale;
            testsTaken = 0;
        }

        ... 
        // Methods will follow here
    }

Note two very important features for a constructor:

  - It looks like a method, but it always has the same name as the class itself
  - It has no return type

You can always recognise a constructor by these features.

The statements inside the constructor do exactly what we stated before: set the 
values of the instance fields to well-defined values. Some of these values are 
given from the outside, in this case name, year of birth, and the gender indicator 
(is male or not), while the number of tests taken is set to 0. The first three 
values will thus be "individual" for each new object, while the last one will 
*always* be set to 0 for all new Student objects. This is very typical; some initial 
values are individual and require information from the caller, while other values
have a sensible initial value which is the same for all objects of that class.

Note also the names of the parameters in the constructor (s_ and then something).
Why did we not just write the constructor like:

    public Student(string name, int yearOfBirth, bool isMale) {
        name = name;
        yearOfBirth = yearOfBirth;
        isMale = isMale;
        testsTaken = 0;
    }

If we did this (it is actually legal syntax), then we suddenly have two things with the 
same name: the instance field *name* and the parameter *name*. The program cannot 
figure out that the left-hand side should be the instance field, while the right-hand 
side should be the parameter. In this case, it will use the parameter on both sides, 
which is not what we want.

In order to solve this, we can do two things. We can use different names as in 
the s_ example, or we can use the keyword this. That is very commonly used, and looks like:

    public Student(string name, int yearOfBirth, bool isMale) {
        this.name = name;
        this.yearOfBirth = yearOfBirth;
        this.isMale = isMale;
        this.testsTaken = 0;
    }

The keyword *this* should be understood as "this specific object", so writing 
this-dot-something will refer to elements inside this specific object, in this 
case the instance fields. It is just a matter of taste if you prefer to use the 
"different names for instance fields and parameters" approach, or the "using the
this keyword" approach. The latter approach is however very common used in real 
life, so you should know about it.

# Handling conditions

So far, we can only define "deterministic" sequences of statements that will 
always be executed in the same order. This sets significant constraints on 
the complexity of code we can write.

To create more complex code, we also need statements that control the "flow" 
of other statements. That is, the order in which other statements are executed.

These statements are called "control statements". The main types of control 
statements are:

  - Conditional statements
  - Repetition statements

In the category of conditional statements, the if-statement is the most 
prominent member.

Other conditional statements:

  - if/else-statement
  - Switch-statement

## The if-statement

The business logic we are trying to implement will very often contain *conditions*.

Examples:

  - Only allow withdrawal from a bank account *if* the balance is larger than 
    the amount to withdraw
  - A car is defined as being a family car *if* it has at least four seats 
    *and* has air conditioning

The C# syntax for a conditional statement is:

    if (condition) {
        // sequence of statements
    }

Three elements in an if-statement:

  1. The keyword if
  2. The logical condition (which is a boolean expression) inside the brackets
  3. The code block inside the { and }

Remember that a boolean (or logical) expression will always evaluate to 
true or false. The expression can be simple or very complex, but it must 
always evaluate to either true or false.

How will the *withdraw* method from the *BankAccount* class look, if we add 
the condition that the balance must be larger than or equal to the amount 
we are trying to withdraw?

    if (balance >= amount) {
        balance = balance – amount;
    }

It is very important to understand the main propertiers of the if-statement

  - If the condition evaluates to *true*, the code inside the code block 
    will be executed *once* and the program will then continue with 
	the statements following the if-statement
  - If the condition evaluates to *false*, the code inside the code block 
    will be skipped (i.e. *not* executed), and the program will immediately 
	continue with the statements following the if-statement

If the code block only consists of one line, it is possible to write the code 
like this:

    if (balance >= amount)
        balance = balance – amount;

For readability, and to avoid bugs in the program, it is however recommended 
always to use the { and } to delimit the code block.

Watch out: Do *not* put a semicolon right after the condition. This is an 
error, but not a syntax error. The if-statement will then "do nothing" no 
matter the value of the condition.

## The if/else statement

In many situations there will also be a natural alternative action if the 
condition evaluates to false.

We could write this as:

    if (balance >= amount) {
        balance = balance – amount;
    }
    if (balance < amount) {
        Console.Writeline(“ERROR!!”);
    }

This is possible but somewhat dangerous. Can we be absolutely sure that 
the two conditions are mutually exclusive, and that one will always be executed?

It is more convenient (and safe) to include the alternative as an integrated part 
of the if-statement itself by adding an else-part to the statement:

    if (balance >= amount) {
        balance = balance – amount;
    } else {
        Console.Writeline("Error");
    }

This is a safer approach; we are guaranteed that *exactly* one of the statements 
is always executed. Never none, never both.

## Nested if-statement

It is also possible to "nest" if-statements within each other. We could have a 
condition like:

    if ((age >= 18) && (nationality == "Danish")) {
        Console.Writeline("You can vote");
    }

This is perfectly legal but could also be written as:

    if (age >= 18) {
        if (nationality == "Danish") {
            Console.Writeline(“You can vote!”);
        }
    }

Notice the indentation. It makes the code easier to read.

In general the code block can contain any code you want, like additional 
conditional statements as above. Watch out for very complex combinations.

You can, of course, also nest if/else-statements.

## Multi if/else-statements

Often you will have more than two possible alternatives. For instances translation 
of scores to grades:

If score is above 90, grade is A

If score is above 75, grade is B

If score is above 55, grade is C

If none of the above, grade is D

This can be written as a nested if/else-statement:

    if (score > 90) {
        grade = "A";
    } else {
        if (score > 75) {
            grade = "B";
        } else {
            if (score > 55) {
                grade = "C";
            } else {
                grade = "D";
            }
        }
    }

An alternative way of writing this is:

    if (score > 90) {
        grade = "A";
    } else if (score > 70) {
        grade = "B";
    } else if (score > 55) {
        grade = "C";
    } else {
        grade = "D";
    }

They are logically equivalent but the latter can be easier to read. Mostly a 
matter of style and preferences.

## Switch-statements

Sometimes the business logic has a nature where there is a distinct outcome 
for each possible specific value of a variable.

Maybe the logic for calculating child support could be like this:

0 children amounts to 0 kr. of child support per month

1 child amounts to 1,200 kr. of child support per month

2 children amounts to 2,000 kr. of child support per month

3 children amounts to 2,600 kr. of child support per month

more than 3 children amounts to 3,000 kr. of child support per month

There is no simple formula for this dependency so we could write it as a 
nested or multi *if/else*-statement. However, the switch-statement allows us 
to "directly" choose an alternative based on a specific value:

    switch (noOfChildren) {
        case 0:
            childSupport = 0;
            break;
        case 1:
            childSupport = 1200;
            break;
        case 2:
            childSupport = 2000;
            break;
        case 3:
            childSupport = 2600;
            break;
        default:
            childSupport = 3000;
            break;
    }

There are several important properties to note about the *switch*-statement:

  - At the outermost level, we use the keyword *switch* followed by the 
    expression (typically just a variable) that we "switch" on in brackets ().
  - We write a *case* statement for each of the cases that we wish to handle 
    individually, using the keyword case followed by the actual value, followed 
	by ":" (colon, not semicolon).
  - Each case contains a sequence of statements, concluded by a *break* statement. 
    The break statement indicates that no more of the code within the case 
	statement should be executed. It is perfectly legal to include if-statements, 
	etc. in the code before the break statement, but often you will put just a 
	single line of code.
  - If the value is not handled explicitly by a matching case statement, it is 
    caught in the *default* statement and the lines of code specified here are 
	executed.

Again, there is nothing you can do in a *switch*-statement that you cannot do 
in a *if*-statement. They are logically equivalent.

Choose the type of statement that you feel fits the problem best, and makes the
code easier to understand.

