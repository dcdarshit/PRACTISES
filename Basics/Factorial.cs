/* Q4-Factorial*/
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
            int fact = 1;
            for (int i = 1; i <=a; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("The Factorial is"+fact);
        }
    }
}