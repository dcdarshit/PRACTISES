using System;
using System.Collections.Generic;
using System.Text;
namespace Darshit
{
    class Practise
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int s = 0; s < i; s++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}



/*
*****
 ****
  ***
   **
    *
*/