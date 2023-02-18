using System;
using System.Collections.Generic;
using System.Text;

namespace SmsApp
{
    class Ind
    {
        public Ind(int x)
        {
            Console.WriteLine("Parameterised Constructor the value of X is=" + x);
        }
    }
    class Child1 : Ind
    {
        public Child1() : base(21)
        {
            Console.WriteLine("I am the Child-1");
        }
    }
    class Child2 : Ind
    {
        public Child2() : base(21)
        {
            Console.WriteLine("I am the Child 2");
        }

        public static void Main(string[] args)
        {
            Child1 z = new Child1();
            Child2 y = new Child2();
        }
    }
}
     
