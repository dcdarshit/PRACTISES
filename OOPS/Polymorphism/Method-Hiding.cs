using System;
using System.Collections.Generic;
using System.Text;

namespace Works
{
    class Page1
    {
        
        public  void M1()
        {
            Console.WriteLine("Method");
        }
    }
    class Page2 :Page1
    {
        public new void M1()
        {
            Console.WriteLine("Method Hiding");
        }
        public static void Main(string[] args)
        {
            Page2 p2 = new Page2();
            p2.M1();
        }
    }
}
