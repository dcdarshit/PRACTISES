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
                for (int j = 1; j <=6-i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
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