using System;
using System.Collections.Generic;
using System.Text;
namespace Darshit
{
    class Practise
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int s = i; s <= 5; s++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= (2 * i) - 1; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("0 ");
                    }
                    else
                    {
                        Console.Write("1 ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}




/*
     1
    1 0 1
   1 0 1 0 1
  1 0 1 0 1 0 1

*/