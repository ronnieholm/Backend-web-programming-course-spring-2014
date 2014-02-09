# What is backend web programming?

A typical modern application: A Web Shop 
 
What tasks are involved in a Web Shop? 

  * Presenting content 
  * Receiving user input 
  * Constructing an order 
  * Storing the resulting order 
  * Storing other data (user preferences, ...)We usually divide such an application into "layers" (although terms may vary).  * GUI Layer 
  * Logic Layer 
  * Data layer GUI Layer: responsible for presenting content and managing user 
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
supplement the GUI, while preserving logic/data parts## PBA Web terminology
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

