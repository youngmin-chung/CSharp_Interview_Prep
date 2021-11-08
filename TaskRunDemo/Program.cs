/*
 Task.Run example. This program runs a computation asynchronously on every line entered in the console. It keeps accepting lines even when computations are running.

Action : A lambda expression is specified as the argument to Task.Run. This is an action delegate.

Action

Allocate : This method does a slow-running computation. But when run asynchronously, it does not cause the program to freeze.

Result : Many user inputs can be handled while the computation is running. Each Allocate() call finishes at its own pace.
 
 */


using System;
using System.Threading.Tasks;

namespace TaskRunDemo
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                // Start computation.
                Example();
                // Handle user input.
                string result = Console.ReadLine();
                Console.WriteLine("You typed: " + result);
            }
        }

        static async void Example()
        {
            // This method runs asynchronously.
            int t = await Task.Run(() => Allocate());
            Console.WriteLine("Compute: " + t);
        }

        static int Allocate()
        {
            // Compute total count of digits in strings.
            int size = 0;
            for (int z = 0; z < 100; z++)
            {
                for (int i = 0; i < 1000000; i++)
                {
                    string value = i.ToString();
                    size += value.Length;
                }
            }
            return size;
        }
    }
}
