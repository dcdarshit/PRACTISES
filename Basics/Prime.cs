/* Q2-Prime Number*/
using System;
using System.Collections.Generic;
using System.Text;
namespace Darshit
{
    class Practise
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int a = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}