using System;
using System.Collections.Generic;
using System.Text;
namespace Darshit
{
    class Practise
    {
        public static void Main(string[] args)
        {
            //Reverse the Every Words without changing in the Format
            //Eg: Welcome to Csharp ----> emoclew ot prahsC
            Console.WriteLine("Enter the String:-");
            string str = Console.ReadLine();
            string[] ar = str.Split(" ");
            string rev = string.Empty;
            for (int i=0;i<ar.Length; i++)
            {
                string a = ar[i];
                char []ch = a.ToCharArray();
                for (int j= ch.Length - 1; j>=0; j--)
                {
                    rev = rev + ch[j];
                }
                Console.Write(rev+" ");
                rev = string.Empty;
            }
        }
    }

}