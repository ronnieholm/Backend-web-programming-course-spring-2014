# Exercise 18: Beast battle

In this exercise, we will see how several classes can work together 
for a more complex task. The project is supposed to model a very 
simple game, where a "hero" can battle a "beast" until either beast 
or hero is dead.

The project contains four classes which are described in general 
terms here. See the code for more details:

  - The NumberGenerator class, with the method GetRandom-NumberInInterval. 
    This is a helper class for generating random numbers.
  - The BattleLog class where individual strings can be "saved" and later 
    on printed to the screen.
  - The Hero class which models a game character. It is a very simple 
    character since it just has a number of hit points (a typical game 
	element: your character has some hit points and if something damages 
	the character, it loses some hit points. When all hit points are 
	lost, the character dies.)
  - The Beast class which also models a game character. Actually, the 
    class is very similar to the Hero class.

Even though this is obviously a very simple setup, it does resemble the 
game mechanics from many popular role-playing games (RPG).

  1. Study the classes in details so you are sure of what they can do and 
     how they work. Note in particular how the Hero and Beast classes make 
	 use of the NumberGenerator and BattleLog classes.
  2. See if you can figure out how to code a battle between a Hero and a 
     Beast (until the death). This is done in InsertCodeHere.cs. The 
	 pre-made code creates one object of each of the classes. YOUR JOB is 
	 to add code that makes the Hero object battle against the Beast object.  
	 This will require some thinking, so before starting to code, try to 
	 sketch out how a battle proceeds in detail. You will probably need a 
	 while-loop in your code.
  3. When you can make the two objects battle each other, there are a number 
     of things to consider afterwards:
     a. It seems like the Hero wins most of the time (depending of course 
	    on how you coded the battle). Why is that? How could we make the battle 
	    more fair?
     b. It looks like the damage dealt by the Hero is always within the 
	    interval 10 to 30 points. How could we change that? Could we even 
		let the creator of the Hero object decide this interval? Could this 
		also be done for the number of hit points?
     c. Do we really need two separate classes for Hero and Beast? What would 
	    we need to add to obtain a more fundamental class like e.g. Character?
     d. How could you implement something like weapons and armor, healing 
	    abilities, etc?

