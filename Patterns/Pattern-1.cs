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
                for (int j = 1; i >= j; j++)
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

*/