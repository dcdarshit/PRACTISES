/*Q4-W.A.P. to find the specific word in the Entered String */

using System;
using System.Collections.Generic;
using System.Text;
namespace Darshit
{
    class Practise
    {
        public static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter String");
            string str = Console.ReadLine();
            Console.WriteLine("Enter the String you want to Search");
            string search = Console.ReadLine();
            string[] ar = str.Split(" ");
            foreach(var a in ar)
            {
                if (a==search)
                {
                    count++;
                }
            }
            Console.WriteLine($"The count of the {search}  is {count}");
        }
    }

}



