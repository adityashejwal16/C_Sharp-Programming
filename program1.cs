using System; 
//////////////////////////////////////////////////////////////////////////////
// using is a keyword. It tells the compiler to use a namespace             //
// so you can access its classes without writing the full name every time.  //
//                                                                          //
//   Example:                                                               //
//   using System;                                                          // 
//   Without using, you would have to write:                                //
//   System.Console.WriteLine("Jay Ganesh");    
//
//   2. System
//   System is a namespace.
//  A namespace is like a folder that contains related classes.
//  Some classes inside the System namespace are:
//
//  1 Console
//  2 String
//  3 Math
//  4 DateTime 
//                             
//////////////////////////////////////////////////////////////////////////////

class Program
{
    static void Main()
    {
        Console.WriteLine("Jay Ganesh");
    }
}


/* 
//  4. class
  class Program
  class is a keyword.
  A class is a blueprint for creating objects.
  Every C# program is written inside a class.

  Think of it like:

  Blueprint → House

  Class → Object

  5. Program
  class Program
  Program is the class name.
  You can give it almost any valid name.

  Examples:

 1 class Student
 2 class Employee
 3 class Demo                 */


 /* 
  6. {

An opening curly brace begins a block of code.

Example:

class Program
{

Everything until the matching } belongs to the class.

7. static
static void Main()
static means the method belongs to the class, not to an object.
The Main method must be static so the program can start without creating an object.
8. void
void Main()
void means the method does not return any value.

Examples:

void Display()

Returns nothing.

int Add()

Returns an integer.

9. Main
Main()
Main is the entry point of a C# program.
Execution always starts from Main.

When you run the program, the computer looks for:

Main()

and starts executing from there.

10. ()
Main()

These parentheses hold parameters (inputs).

Since they're empty:

()

the method takes no input.

11. {

Starts the body of the Main method.

{
12. Console
Console.WriteLine()
Console is a class in the System namespace.
It lets you interact with the command window.

It can:

Display text
Read input
Change colors
Clear the screen
13. . (Dot Operator)
Console.WriteLine

The dot (.) is called the member access operator.

It is used to access methods or properties of a class.

General form:

ClassName.MethodName()
14. WriteLine
WriteLine("Jay Ganesh");
WriteLine is a method of the Console class.
It prints text and then moves the cursor to the next line.

Example:

Console.WriteLine("Hello");
Console.WriteLine("World");

Output:

Hello
World
15. "Jay Ganesh"
"Jay Ganesh"

Anything inside double quotes (" ") is a string (text).

Examples:

"Hello"
"C#"
"123"

Even "123" is a string because it's enclosed in quotes.

16. );
Console.WriteLine("Jay Ganesh");
) closes the method call.
; ends the statement.
17. }
}

Closes the Main method.

18. }
}

Closes the Program class.

Program Execution Flow

When you run the program, the computer executes it in this order:

Program starts
        │
        ▼
Find Main()
        │
        ▼
Execute Console.WriteLine("Jay Ganesh");
        │
        ▼
Display:
Jay Ganesh
        │
        ▼
Program ends

Summary Table
Word/Symbol	Meaning

using	           Imports a namespace
System	           Namespace containing built-in classes
class	           Defines a class
Program	           Class name
{ }	               Start and end of a code block
static	           Method belongs to the class itself
void	           Returns no value
Main()	           Entry point where execution begins
Console	           Class for console input/output
.	               Accesses a member of a class
WriteLine()	       Prints text and moves to a new line
"Jay Ganesh"	   A string (text literal)
;	               Ends a statement
                   
                    /*