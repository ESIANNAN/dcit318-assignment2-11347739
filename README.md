# dcit318-assignment2-11347739
# C# OOP Concepts Demo
This repository contains **three simple C# console applications** that demonstrate key Object-Oriented Programming (OOP) concepts:  
*Inheritance and Method Overriding 
 *Abstract Classes and Methods
 *Interfaces


How to Run:
1. Open Rider by JetBrains.  
2. Open the folder for the concept you want to run (`InheritanceDemo`, `AbstractClassesDemo`, or `InterfacesDemo`).  
3. Make sure the project’s `Program.cs` contains the `Main()` method.  
4. Press F5 or Run.

Inheritance and Method Overriding:
- Inheritance allows one class to use properties and methods of another class.
- Method Overriding allows a subclass to provide its own version of a method.

Example:
csharp
class Animal { public virtual void MakeSound() => Console.WriteLine("Generic sound"); }
class Dog : Animal { public override void MakeSound() => Console.WriteLine("Bark"); }



