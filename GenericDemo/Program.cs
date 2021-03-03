using System;
using System.Collections.Generic;

/// <summary>
/// What are GENERICS? 
/// 
/// Generics let you tailor a method, class, structure, or interface to the precise 
/// data type it acts upon w/ type safety. 
/// 
/// For example, we can have a single array class 
/// to store a list of Users or a list of Products, and when we use it, we access the items 
/// in the collection as a list of Users or Products, and not as objects(with boxing/unboxing, casting).
/// </summary>

namespace GenericDemo
{
    class TestGenericList
    {
        private class ExampleClass { }
        static void Main()
        {
            // Declare a list of type int.
            List<int> list1 = new List<int>();

            // Declare a list of type string.
            List<string> list2 = new List<string>();

            // Declare a list of type ExampleClass.
            List<ExampleClass> list3 = new List<ExampleClass>();

            // TODO
            list2.Add("Generic Youngmin");
            Console.WriteLine(list2[0]);

        }
    }
}
