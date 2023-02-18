using System;
using System.Collections.Generic;
using System.Text;

namespace Darshit
{
    class Practise
    {
        static void Main(string[] args)
        {
            double d = 0;
            Console.WriteLine("Enter the Amount's");
            double a = Convert.ToDouble(Console.ReadLine());
            if (a > 10000)
            {
                d = (a* 25) / 100;
                Console.WriteLine("After Discount The Amount is" + d);
            }
            else if (a > 5000)
            {
                d = (a * 15) / 100;
                Console.WriteLine("After Discount The Amount is" + d);
            }
            else if (a > 1000)
            {
                d = (a * 10) / 100;
                Console.WriteLine("After Discount The Amount is" + d);
            }
            else
                d = (a * 3) / 100;
            Console.WriteLine("After Discount The Amount is" + d);
        }
    }
}
