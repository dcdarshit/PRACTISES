using System;
using System.Collections.Generic;
using System.Text;

namespace Darshit
{
    class Practise
    {
        static void Main(string []args)
        {
            Console.WriteLine("Enter the Number");
            int a = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int Ag = 0;
            while (i <= 10)
            {
                Console.WriteLine("Enter the Number{0}");
                int z= Convert.ToInt32(Console.ReadLine());
                Ag = Ag + z;
                i++;
            }
            Console.WriteLine("The Sum of the Given Number is" + Ag);
        }
    }
}
