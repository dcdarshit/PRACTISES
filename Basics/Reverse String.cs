using System;
using System.Collections.Generic;
using System.Text;
namespace Darshit
{
    class Practise
    {
        public static void Main(string[] args)
        {
            //Reverse a String
            Console.WriteLine("Enter the String");
            String str = Console.ReadLine();
            String rev = String.Empty;
            char[] ch = str.ToCharArray();
            for (int i = ch.Length - 1; i >= 0; i--)
            {
                rev = rev + ch[i];
            }
            Console.WriteLine();
            Console.WriteLine("The Reverse of a String is"+rev);
        }
    }

}