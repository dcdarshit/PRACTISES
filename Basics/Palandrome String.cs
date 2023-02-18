using System;
using System.Collections.Generic;
using System.Text;
namespace Darshit
{
    class Practise
    {
        public static void Main(string[] args)
        {
            //String is Palandrome or Not
            Console.WriteLine("Enter the String:");
            string str = Console.ReadLine();
            string rev = string.Empty;
            char[] ch = str.ToCharArray();
            for (int i = ch.Length - 1; i >= 0; i--)
            {
                rev = rev + ch[i];
            }
            Console.WriteLine("The Reverse of a String is"+rev);
            if (rev == str)
            {
                Console.WriteLine("Palandrome");
            }
            else
            {
                Console.WriteLine("Not a Palandrome");
            }
        }
    }

}