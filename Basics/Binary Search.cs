using System;
using System.Collections.Generic;
using System.Text;
namespace Darshit
{
    class Practise
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 7 };
            Console.WriteLine("Enter the Number You want to Search");
            int num = int.Parse((Console.ReadLine());
            int LB = 0;
            int UB = arr.Length - 1;
           
            //while (LB <= UB)
            while(LB<UB)
            {
                int mid = (LB + UB) / 2;
                if (num >arr[mid])
                {
                     LB= (mid + 1) ;
                    Console.WriteLine($"Found the Number is{arr[mid]} on {mid}");
                }
                
                else if (num < arr[mid])
                {
                    UB= (mid - 1);
                    Console.WriteLine($"Found the Number is{arr[mid]} on {mid}");
                }
                else if (num == arr[mid])
                {
                    Console.WriteLine("Found the Number is{0}",arr[mid]);
                }
                
            }
           
        }
    }
}