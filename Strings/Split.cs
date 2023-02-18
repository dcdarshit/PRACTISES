/* String Methods */
using System;
using System.Collections.Generic;
using System.Text;
namespace Darshit
{
    class Practise
    {
        
        public static void Main(string[] args)
        {
            String str = "Darshit@gmail.com";
            String[] arr = str.Split('@');
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("index:-"+i+" "+"Array:-"+arr[i]);
            }
        }
    }
}
