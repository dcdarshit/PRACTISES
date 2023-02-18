using System;
using System.Collections.Generic;
using System.Text;

namespace SmsApp
{
    class Ind
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            string str = Console.ReadLine();
            string []ar = str.Split(" ");
            Console.WriteLine("Enter the Word you want to change:-");
            string rep = Console.ReadLine();
            Console.WriteLine("Enter the New Words");
            string up = Console.ReadLine();
            for (int i = 0; i<ar.Length;i++)
            {
                if (Equals(ar[i],rep))
                {
                    ar[i] = up;
                    break;
                }
            }
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write(ar[i]+" ");
            }
            Console.ReadLine();
        }
    }
}
     
