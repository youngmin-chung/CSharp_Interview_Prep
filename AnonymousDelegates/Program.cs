using System;

namespace AnonymousDelegates
{
    // declare the delegate type
    public delegate string MyDelegate(int arg1, int arg2);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate f = delegate (int arg1, int arg2) {
                return (arg1 + arg2).ToString();
            };
            Console.WriteLine("The number is: " + f(10, 20));
        }
    }
}
