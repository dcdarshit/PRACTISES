/* Q1- W.A.P. to enter Email Id and Split the UserName and Domain. */
using System;
using System.Collections.Generic;
using System.Text;
namespace Darshit
{
    class Practise
    {
        public static void Main(string []args)
        {
            Console.WriteLine("Enter a Email Address");
            String str = Console.ReadLine();
            String[] str1 = str.Split('@');
            for (int i=0;i<str1.Length;i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("The Username is:-" + str1[0]);
                }
                else
                {
                    Console.WriteLine("The Domain is:-" + str1[1]);
                }
            }
        }
    }

}