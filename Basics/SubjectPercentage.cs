using System;
using System.Collections.Generic;
using System.Text;

namespace Darshit
{
    class Practise
    {
        static void Main(string []args)
        {
            int total = 0;
            int per = 0;
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("Enter the Number's");
                int a = Convert.ToInt32(Console.ReadLine());
                total = total + a;
                i++;
            }
            per = total / 5;

            Console.WriteLine("The Total Marks of the Given Subject is" + total);
            Console.WriteLine("The Total Percentage is" + per);

            if (per > 90)
                Console.WriteLine("A+");
            else if (per > 80)
                Console.WriteLine("A");
            else if (per > 70)
                Console.WriteLine("B");
            else if (per > 60)
                Console.WriteLine("C");
            else if (per > 50)
                Console.WriteLine("D");
            else if (per > 40)
                Console.WriteLine("E");
            else if (per > 30)
                Console.WriteLine("F");
        }
    }
}
