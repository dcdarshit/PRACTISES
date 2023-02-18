using System;
using System.Collections.Generic;
using System.Text;

namespace Darshit
{
    class Practise
    {
        static void Main(string[] args)
        {
            int z = 1;
            for (int i=1; i <= 5;i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if ((i == 2 && j == z + 1) || (i == 3 && j == 2) || (i == 4) && (j == 2 || j == 4) || (i == 5 && j == 4))
                    {
                        Console.Write(" ");
                        z++;
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine("");
            }  
        }
    }
}


/*
*****
*
* ***
* * *
*** *

*/