using System;
using System.Collections.Generic;
using System.Collections;
namespace Encap1
{
    public class Encap
    {
        public static void Main()
        {
            Queue <char> qt = new Queue<char>();
            qt.Enqueue('a');
            qt.Enqueue('b');
            qt.Enqueue('c');
            qt.Enqueue('d');
            qt.Enqueue('e');
            qt.Enqueue('f');
            
            Console.WriteLine("Non-Generic->Queue");
            foreach(var a in qt)
                Console.WriteLine(a);
            qt.Dequeue();
            
            Console.WriteLine("After Removal");
            foreach(var z in qt)
                Console.WriteLine(z);

           
        }

    }
}
