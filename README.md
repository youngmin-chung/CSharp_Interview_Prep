# CSharpInterviewPrep
C# Interview Prep

1. What is OOP?
It stands for Object-Oriented Programming. It’s supported by .NET Framework. 
OOP allows .NET developers to create classes containing methods, properties, fields, events and other logical modules.
It lets developers create modular programs, which they can assemble as applications.
OOP have four basic features – Encapsulation, abstraction, polymorphism and inheritance.

2. What is encapsulation?
It helps keep data from unwanted access through binding code and data.
Hiding!!!

3. What is the concept of inheritance?
Inheritance means that a class can be based on another class, with the child class taking on the attributes of the parent class.
.NET supports single inheritance only

4. What is the concept of abstraction?
Abstraction allows making relevant information visible.

5. What is the concept of polymorphism?
It’s when classes have different functionality while sharing the same interface.
Blue-ray player can play blue-ray, DVD and CD.

6. What’s reference types and value types?
-	Reference types are objects that store references to the actual data.
Ex. Class, Interface, delegate, object and string
-	Value types actually hold values. Assigning one value type to another literally copies that value.
Ex. Structs, enums, bools, numeric types

7. What’s an INTERFACE?
They’re used to specify methods and properties that a derived class will have access to.
-	Like a contract. If a class implements an interface.
-	DOES NOT contain code or data.

8. What’s an ABSTRACT CLASS?
Similar to interfaces but cannot be instantiated, and are frequently either partially implemented, or not at all implemented. Different from interface in that:
-	Abstract classes DO contain code and data
-	A class can inherit from only one abstract class but can implement an unlimited number of interfaces
-	You can specify methods as ‘virtual’ to force derived classes to create its own implementation.

9. What are static classes?
Static classes are used to create data and functions that can be accessed without creating an instance of the class. We use them when there is no data or behavior in the class that depends on object identity. So they:
-	Only contain static members.
-	Cannot be instantiated.
-	They cannot contain Instance Constructors
-	Are sealed.

10. What are GENERICS?
Generics let you tailor a method, class, structures, or interface to the precise data type it acts upon with type safety.
For example, we can have a single array class to store a list of Users or a list of Products, and when we use it, we access the items in the collection as a list of Users or Products, and not as objects (with boxing/unboxing, casting).

11. What’s the CLR and FCL?
Common Language Runtime (CLR) offers services like security, memory management, and exception handling.
Framework class library is a collection of reusable classes, interfaces, and value types.

12. What’s .NET?
Managed execution environment to build and run applications.
.NET consists of two major components; CLR and FCL 

13. What’s unmanaged code and managed code?
Managed code
-	What C# compilers create
-	Runs on the CLR (Common Language Runtime)
-	Garbage collection, runtime type checking, and reference checking
-	Think: “My code is managed by the CLR”
Unmanaged code
-	Compiled straight to machine code
-	Code not managed by the CLR

14. What’s Boxing and unboxing?
Boxing is the process of converting a value type to the type object.
Boxed values use more memory and take at minimum two memory lookups to access.
Int i = 123;
Object o = i; // boxing
Unboxing extracts the value type from the object.
Explicit
O = 456;
I = (int) o; // unboxing

15. What are the .NET page life-cycle events?
11 steps are PIIPL CLPS RU (People clips are you?)
1.	PreInit
2.	Init
3.	InitComplete
4.	PreLoad
5.	Load
6.	Control events
7.	LoadComplete
8.	PreRender
9.	SaveStatecomplete
10.	Render
11.	Unload

16. What are the .NET page life-cycle stages?
8 steps are PSIL VERU
1.	Page request
2.	Start
3.	Initialization
4.	Load
5.	Validate
6.	Event handling
7.	Render
8.	Unload

17. Describe the difference between ASP.NET and ASP.NET MVC
ASP.NET is a web development framework
It has services to build web applications
It’s part of the .NET framework with access to .NET libraries.

MVC is acronym Model-View-Controller and is design pattern.
Model manages data, controller makes calls on the model, and view display content.
MVC makes developing, testing and maintenance easier.

18. What is Razor?
Base on C#, Razor is a template markup syntax that lets you use an HTML construction workflow.

19. What’s an inner joins?
The INNER JOIN keyword selects records that have matching values in both tables.
SELECT column_name(s)
FROM table1
INNER JOIN table2 ON table1.column_name = table2.column_name;

20. Describe some joins
Left join, right join, full outer join

21. What’s a stored procedure?
It’s a subroutine.
It contains a collection of SQL commands
It saves time and memory with complex logic
It is just a subroutine with SQL statements an application uses to communicate with a database efficiently.

22. What’s dependency injection?
It allows your class to no longer be responsible for instantiating its own dependencies.
It helps you to develop loosely coupled code.
Three ways to implement it:
-	Constructor injection
-	Property injection
-	Method injection
It derives from the inversion of control(IoC) concept includes these IoC containers: 
