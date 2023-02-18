using System;
using System.Collections.Generic;
using System.Text;

namespace SmsApp
{
    public class Ind
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            string str = Console.ReadLine();
            string[] sp = str.Split(" ");

            Console.WriteLine(Reverse(sp));
        }
        public static string Reverse(string[] array)
        {
            string rev = string.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                string z = array[i];
                char[] arr = z.ToCharArray();
                for (int j = arr.Length - 1; j >= 0; j--)
                {
                    rev = (rev + arr[j]);
                }
                //Console.Write(rev+" ");
               // rev += " ";
            }
            return rev;
        }
    }   
}
     
