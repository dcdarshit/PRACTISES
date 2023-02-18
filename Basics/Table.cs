/* Q1-Print Table*/

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

            for (int i = 1; i <= 10; i++)
            {
                int c = i * a;
                Console.WriteLine("{0}*{1}={2}",a,i,c);
            }
        }
    }
}