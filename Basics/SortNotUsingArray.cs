using System;
using System.Collections.Generic;
using System.Text;

namespace Darshit
{
    class Practise
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a >= b && b >= c)
            {
                if (b > c)
                {
                    Console.WriteLine(c + b + a);
                }
            }
            else if (b >= a && b >= c)
            {
                if (a > c)
                {
                    Console.WriteLine(c + a + b);
                }
            }
            else if (c > a && c > b)
            {
                if (a > b)
                {
                    Console.WriteLine(b+ a+ + c);
                }
            }
        }
    }
}
