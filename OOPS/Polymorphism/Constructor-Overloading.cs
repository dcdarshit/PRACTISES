using System;
using System.Collections.Generic;
using System.Text;

namespace SmsApp
{
    class Ind
    {
        public Ind()
        {
            Console.WriteLine("Default Constructor");
        }
       public  Ind(int x)
        {
            Console.WriteLine("Parameterised Constructor x:"+x);
        }
        public Ind(string a)
        {
            Console.WriteLine("Parameterised Constructor y:"+a);
        }
    }
    class A
    {
        public static void Main(string[] args)
        {
            Ind ab = new Ind("abcd");
        }
    }
}
     
