# Lecture notes

## What is Back-End Web Programming?

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

### Why bother to divide into these layers?

  * Right tools for the job. The tools used for constructing the 
different parts of an application are different in nature
  * Flexibility. Having an application pieced together by 
dedicated subsystems makes it easier to replace or 
supplement the GUI, while preserving logic/data parts### PBA Web terminology
  * GUI Layer is Front End (FE) 
  * Logic layer is Back End (BE) 
  * Data Layer is Databases (DB) 

In backend we'll thus concentrate on *tools and techniques 
for implementing business rules and logic, using a so-called 
Object-Oriented programming language*. 

