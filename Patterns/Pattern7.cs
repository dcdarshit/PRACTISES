using System;
using System.Collections.Generic;
using System.Text;

namespace Darshit
{
    class Practise
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {

                for (int s = i; s <= 5; s++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            for (int i = 1; i <= 5; i++)
            {

                for (int s = 1; s <= i; s++)
                {
                    Console.Write(" ");
                }

                for (int j = i; j <=5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
/*

     *
    **
   ***
  ****
 *****
 *****
  ****
   ***
    **
     *

*/