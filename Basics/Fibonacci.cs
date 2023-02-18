/* Q5-Fibonacci Series */
using System;
using System.Collections.Generic;
using System.Text;
namespace Darshit
{
    class Practise
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Input");
            int z = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int sum = 0;
            Console.Write("0");
            Console.Write("1");
            for (int i = 2; i < z-1; i++)
            {
                sum = a + b;
                Console.Write(sum);
                a = b;
                b = sum;

            }
        }
    }
}