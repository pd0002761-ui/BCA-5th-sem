using System; 
 
// Base Class 
class Animal 
{ 
    public virtual void Speak() 
    { 
        Console.WriteLine("Animal makes a sound"); 
    } 
} 
 
// Derived Class 
class Dog : Animal 
{ 
    // Overriding 
    public override void Speak() 
    { 
        Console.WriteLine("Dog barks"); 
    } 
} 
 
class Program5 
{ 
    public static void Run() 
    { 
        Animal a1 = new Animal(); 
        Animal a2 = new Dog(); 
        a1.Speak(); 
        a2.Speak(); 
    } 
} 