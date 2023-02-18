/* Q3-WAP to Capitalize the First letter entered 
						eg:-	Enter the Strings
							raj kumar singh
							Raj Kumar Singh
*/

using System;
using System.Collections.Generic;
using System.Text;
namespace Darshit
{
    class Practise
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Strings");
            string str = Console.ReadLine();
            string[] ar = str.Split(" ");
            string name = string.Empty;
            for(int i=0;i<ar.Length;i++)
            {
                name += ar[i].Substring(0, 1).ToUpper()+ar[i].Substring(1)+(" ");
            }
            Console.WriteLine(name);
            
        }
    }

}



