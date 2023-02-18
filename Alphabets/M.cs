using System;
using System.Collections.Generic;
using System.Text;

namespace Darshit
{
    class Practise
    {
        static void Main(string[] args)
        {
            for (int i=1; i <= 5;i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (j==1||j==5||(i==2 && (j==2||j==4))||i==3&& j==3)
                    {
                        Console.Write("*");
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
*   *
** **
* * *
*   *
*   *

*/