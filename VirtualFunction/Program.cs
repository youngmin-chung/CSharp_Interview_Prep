﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualFunction
{
    //class A
    //{
    //    public void Test() { Console.WriteLine("A::Test()"); }
    //}

    //class B : A
    //{
    //    public new virtual void Test() { Console.WriteLine("B::virtual Test()"); }
    //}

    //class C : B
    //{
    //    public override void Test() { Console.WriteLine("C::override Test()"); }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        A a = new A();
    //        B b = new B();
    //        C c = new C();

    //        a.Test(); // output --> "A::Test()"
    //        b.Test(); // output --> "B::virtual Test()"
    //        c.Test(); // output --> "C::override Test()"

    //        a = new B();
    //        a.Test(); // output --> "A::Test()"

    //        b = new C();
    //        b.Test(); // output --> "C::override Test()"

    //        Console.ReadKey();
    //    }
    //}

    class A
    {
        public virtual void Test() { Console.WriteLine("A::Test()"); }
    }

    class B : A
    {
        public override void Test() { Console.WriteLine("B::Test()"); }
    }

    class C : B
    {
        public override void Test() { Console.WriteLine("C::Test()"); }
    }

    class Program
    {
        static void Main(string[] args)
        {

            A a = new A();
            B b = new B();
            C c = new C();
            a.Test(); // output --> "A::Test()"
            b.Test(); // output --> "B::Test()"
            c.Test(); // output --> "C::Test()"

            a = new B();
            a.Test(); // output --> "B::Test()"

            b = new C();
            b.Test(); // output --> "C::Test()"

            Console.ReadKey();
        }
    }
}
