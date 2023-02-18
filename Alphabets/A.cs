using System;
using System.Collections.Generic;
using System.Text;

namespace Darshit
{
    class Practise
    {
        static void Main(string[] args)
        {
            int z = 3;
            for (int i= 0; i < 5; i++)
            {
                for (int j= 0; j < 9; j++)
                {
                    if (j == 4- i ||j==4+i)
                    {
                        Console.Write("*");
                        
                    }
                    else if (i == 2 && j == z)
                    {
                        Console.Write("*");
                        z++;
                    }
              
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine("");
            }
        }
        
    }
}



/*

    *
   * *
  *****
 *     *
*       *

*/