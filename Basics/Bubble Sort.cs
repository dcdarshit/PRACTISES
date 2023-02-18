using SmsApp;
using System;

namespace SmsApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[5];
            
            Console.WriteLine("Enter the Values");
            for (int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {  if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("After sorting the Array is");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
