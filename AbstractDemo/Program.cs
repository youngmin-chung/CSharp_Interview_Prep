using System;

/// <summary>
/// 1.	What’s an ABSTRACT CLASS – 
///     
///     Similar to interfaces but cannot be instantiated, and are frequently 
///     either partially implemented, or not at all implemented. Different from interface in that:
///         a. Abstract classes DO contain code & data
///         b. A class can inherit from only one abstract class but can implement an unlimited number of 
///             interfaces
///         c. You can specify methods as ‘virtual’ to force derived classes to create its own implementation.
/// </summary>

namespace AbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student S = new Student();
            S.Name = "Abstract Youngmin";
            S.PrintName();
        }
    }

    abstract class Person
    {
        public int Year { get; set; } = 1983;
        public abstract void PrintName();
    }

    class Student : Person
    {
        public string Name { get; set; }
        public override void PrintName()
        {
            Console.WriteLine($"Student name is {Name} and was born in {Year}.");
        }
    }
}
