using System;
using System.Collections;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(01);
            al.Add("AMAN");
            al.Add(98.7);
            al.Add('A');

            foreach(var a in al)
                Console.WriteLine(a);
        }
    }
}
