using System;
using System.Collections.Generic;
using System.Collections;
namespace Encap1
{
    public class Encap
    {
        public static void Main()
        {
            Stack st = new Stack();
            Console.WriteLine("Original Stack :-");
            st.Push(11);
            st.Push(10);
            st.Push(9);
            st.Push(8);
            st.Push(7);
            st.Push(6);
            st.Push(5);
            st.Push(4);
            st.Push(3);
            st.Push(2);
            st.Push(1);
            foreach (var a in st)
            { Console.WriteLine(a); }

            Console.WriteLine();
            Console.WriteLine("The Peek of the Stack is:-");
            Console.WriteLine(st.Peek());

            Console.WriteLine();
            Console.WriteLine("After Pop:-");
            st.Pop();
           
            foreach (var z in st)
            { Console.WriteLine(z); }



        }

    }
}
