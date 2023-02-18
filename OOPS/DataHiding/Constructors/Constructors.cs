using System;
using System.Collections.Generic;
using System.Text;

namespace SmsApp
{
    class Ind
    {

        int add;
        static Ind()                                                    //Default Explicit Constructor
        {
            Console.WriteLine("This is Static Constructor");            
        }
        public Ind(int a, int b)                                        //Parameterised Constructor
        {
            int sum = a + b;
            add = a;
            Console.WriteLine("The Sum of a+b is:" + sum);
            Console.WriteLine("The Addition of the a+b are:" + add);
        }
        public Ind(Ind z)                                               //Copy Constructor
        {
            this.add = z.add;
            Console.WriteLine("The Addition of this is:" + add);
        }
        public static void Main(string[] args)
        {
            Ind n = new Ind(10, 12);
            Ind n2 = new Ind(n);

        }
    }
}
