using System;

/// <summary>
/// What are Static classes?
///     Static classes are used to create data and functions that can be accessed without creating an 
///     instance of the class. We use them when there is no data or behavior in the class that depends 
///     on object identity. So they: 
///     
///         i.      Only contain static members.
///         ii.     Cannot be instantiated.
///         iii.    They cannot contain Instance Constructors
///         iv.     Are sealed.
/// </summary>

namespace StaticDemo
{
    static class Program
    {
        static void Main(string[] args)
        {
            //TODO
            Console.WriteLine("Company Name = " +
                CompanyInfo.GetCompanyName());
        }
    }

    static class CompanyInfo
    {
        public static string GetCompanyName() { return "Apple Inc."; }
    }
}
