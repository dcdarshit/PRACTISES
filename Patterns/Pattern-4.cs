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
                int n = 1;
                for (int j = i; j <= 5; j++)
                {
                    Console.Write(n);
                    n++;
                }
                Console.WriteLine("");
            }
        }
    }
}

/*

12345
1234
123
12
1

*/
