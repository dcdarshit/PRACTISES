using System;
using System.Collections.Generic;
using System.Text;

namespace Project46
{
    class Class10
    {    static void Main (String []args)

        {
            int i = 1;
            Console.WriteLine("Enter the Value");
            int a = Convert.ToInt32(Console.ReadLine());
            int largest = a;
            while (i <= 10)
            {
                Console.WriteLine("Enter the Values");
                int b = Convert.ToInt32(Console.ReadLine());
                if (largest < b)
                    largest = b;
                i++;
            }
            Console.WriteLine("The Largest Number Entered is" + largest);
        }
    }
}
