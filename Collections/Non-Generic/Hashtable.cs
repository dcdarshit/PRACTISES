using System;
using System.Collections;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Id", 123);
            ht.Add("Name", "Aman");
            ht.Add("Grade",'A');
            ht.Add("E-mail","Darshitchaudhary1902@gmail.com");
            
            
            foreach(DictionaryEntry a in ht)
                Console.WriteLine(a.Key+":"+a.Value);
        }
    }
}
