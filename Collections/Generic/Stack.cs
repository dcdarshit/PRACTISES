using System;
using System.Collections.Generic;
using System.Collections;
namespace Encap1
{
    public class Encap
    {
        public static void Main()
        {
            Stack <char>st = new Stack <char> ();
            Console.WriteLine("Original Stack :-");
            st.Push('A');
            st.Push('B');
            st.Push('C');
            st.Push('D');
            st.Push('E');
            st.Push('F');
            st.Push('G');
            st.Push('H');
            st.Push('I');
            st.Push('J');
            st.Push('K');
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
