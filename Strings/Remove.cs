 using System;
using System.Collections.Generic;
using System.Text;
namespace Darshit
{
    class Practise
    {
	public static void Main(string []args)
        {
            String str = "Hello World";
            String str2 = str.Remove(str.IndexOf("W"));
            Console.WriteLine("After Removing the String is like:-"+str2);
        }
    }

}