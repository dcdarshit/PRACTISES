using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    class Generics1
    {
        public static void Main(string[] args)
        {
            Dictionary<string,int> d1 = new Dictionary<string,int>();
            d1.Add("Id", 101);
            d1.Add("Phone No.",91 );
            d1.Add("PN", 991);
            d1.Add("Idi", 1234);
            foreach (var a in d1)
            {
                Console.WriteLine(a.Key+""+a.Value);
            }

        }
    }
}
