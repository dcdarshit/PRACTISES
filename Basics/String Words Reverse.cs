using System;
using System.Collections.Generic;
using System.Text;
namespace Darshit
{
    class Practise
    {
        public static void Main(string[] args)
        {
            //reverse the Order of the Words in given String
            Console.WriteLine("Enter the String");
            string str = Console.ReadLine();
            string[] ar =str.Split(" ");
            string rev = string.Empty;
            for (int i = ar.Length - 1; i >= 0; i--)
            {
                rev = rev + ar[i]+" ";
            }
            Console.WriteLine("The Reverse of the String Word is");
            Console.WriteLine(rev);          
        }
    }

}