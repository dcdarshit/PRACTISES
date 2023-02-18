using System;
using System.Collections.Generic;
using System.Text;

namespace SmsApp
{
    class Ind
    { 
        public Ind(int x)
        {     
            Console.WriteLine("Parameterised Constructor the value of X is="+x);
        }
    }
    class B : Ind
    {
      public B(string y) : base(10)
        {
            Console.WriteLine($"Explicit Default Child Constructor The Value of  y={y}");
        }
    }
    class C:B
    {
        public C(string z):base("ABCD")
        {
            Console.WriteLine("The String value is"+z);
        }
    

        public static void Main(string[] args)
        {
            C z = new C("DEF");            
        }
    }
     
        
}
