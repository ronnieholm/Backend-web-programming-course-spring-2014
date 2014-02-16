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

