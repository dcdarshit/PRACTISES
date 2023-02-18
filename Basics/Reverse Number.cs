/* Q3-Reverse Number*/
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
            int store = 0;
            int rev = 0;
            while (a != 0)
            {
                store = a % 10;
                rev = rev * 10 + store;
                a = a / 10;
            }
            Console.WriteLine("The Reverse Number is"+rev);
        }
    }
}