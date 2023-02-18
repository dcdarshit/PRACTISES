using System;
using System.Collections.Generic;
using System.Text;

namespace SmsApp
{
    interface A
    {
         void M1();
    }
    interface B
    {
        void M1();
    }
    class C : A,B
    {
        public void M1()
        {
        Console.WriteLine("1st Parent");
        }

        /*public void M1()
        {
            Console.WriteLine("2nd Parent");
        }*/
    public static void Main(string[] args)
    {
            B cb = new C();
            cb.M1();

            A cz = new C();
            cz.M1();
       
    }
        
    }
}
