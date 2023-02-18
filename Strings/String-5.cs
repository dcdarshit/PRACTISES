/* Q5- W.A.P to check the String is Palandrome or Not*/

using System;
using System.Collections.Generic;
using System.Text;
namespace Darshit
{
    class Practise
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Strings");
            string str = Console.ReadLine();
            string rev = string.Empty;
            char []ar = str.ToCharArray();
            int i = ar.Length - 1;
            while (i >= 0)
            {
                rev = rev + ar[i];
                i--;
            }
            Console.WriteLine("The Reverse of the String is");
            Console.WriteLine(rev);
            if (rev == str)
            {
                Console.WriteLine("Palandrome String");
            }
            else
            {
                Console.WriteLine("Not a Palandrome String");
            }
        }
    }

}



