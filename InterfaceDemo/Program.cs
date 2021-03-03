using System;

/// <summary>
/// 1.	What’s an INTERFACE?
/// 
/// They're used to specify methods and properties that a derived class 
/// will have access to.
/// - Like a contract. If a class implements an interface, 
///   the interface guarantees that the class contains specific 
///   methods specified.
/// - DOES NOT contain code or data
/// </summary>
/// 
namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "Interface Youngmin";
            s.PrintName();
        }
    }

    interface Person
    {
        void PrintName();
    }

    class Student : Person
    {
        public string Name { get; set; }
        public void PrintName()
        {
            Console.WriteLine($"Student name is {Name}.");
        }
    }
}
