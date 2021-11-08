/*
First program. 

We use the async and await keywords to asynchronously run a method. The program begins a long-running method (HandleFileAsync).

Part 1 We create a Task instance by calling HandleFileAsync. The task starts, and (later in Main) we call Wait() for it to finish.

Part 2 This async method displays a status message, and does some long-running calculations. We use StreamReader and await ReadToEndAsync.

Part 3 We must be careful to call Wait() on the task we want to wait for. Sometimes the wrong Task can be waited on.

Info Please change the path to a large text file that exists on your computer. Any large text file will do.

 */


using System;
using System.IO;
using System.Threading.Tasks;

namespace AsyncAwaitDemo
{
    class Program
    {
        public static void Main()
        {
            // Part 1: start the HandleFile method.
            Task<int> task = HandleFileAsync();

            // Control returns here before HandleFileAsync returns.
            // ... Prompt the user.
            Console.WriteLine("Please wait patiently " +
                "while I do something important.");

            // Do something at the same time as the file is being read.
            string line = Console.ReadLine();
            Console.WriteLine("You entered (asynchronous logic): " + line);

            // Part 3: wait for the HandleFile task to complete.
            // ... Display its results.
            task.Wait();
            var x = task.Result;
            Console.WriteLine("Count: " + x);

            Console.WriteLine("[DONE]");
            Console.ReadLine();
        }

        static async Task<int> HandleFileAsync()
        {
            string file = @"C:\Backup\c_sharp_workplace\test1.txt";
            // Part 2: status messages and long-running calculations.
            Console.WriteLine("HandleFile enter");
            int count = 0;

            // Read in the specified file.
            // ... Use async StreamReader method.
            using (StreamReader reader = new StreamReader(file))
            {
                string v = await reader.ReadToEndAsync();

                // ... Process the file data somehow.
                count += v.Length;

                // ... A slow-running computation.
                //     Dummy code.
                for (int i = 0; i < 10000; i++)
                {
                    int x = v.GetHashCode();
                    if (x == 0)
                    {
                        count--;
                    }
                }
            }
            Console.WriteLine("HandleFile exit");
            return count;
        }
    }
}
