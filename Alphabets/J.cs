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
                    if (i==1||j==3||(i==3 && j==1)||(i==4 && j==2))
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
*****
  *
* *
 **
  *
*/