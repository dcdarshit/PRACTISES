using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            a.Add(12);
            a.Add(11);
            a.Add(10);
            a.Add(9);

                foreach(int z in a)
                Console.WriteLine(z);
        }
    }
}
