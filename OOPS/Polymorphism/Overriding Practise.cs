using System;
using System.Collections.Generic;
using System.Text;


/* Which B2() Method will Run*/


namespace Works
{
    class Base
    {
        public void B1(){}
        public virtual void B2()
        {
            Console.WriteLine("Virtual Keyword Used");
        }
}
    class Derived : Base
    {
        public void Z() { }
        public override void  B2() 
        {
            Console.WriteLine("Override keyword used");
        }
    }

    class Z
    {
        public static void Main(string[] args)
        {
            Base dd = new Derived();
            dd.B2();
            Console.ReadLine();
        }
    }
}
