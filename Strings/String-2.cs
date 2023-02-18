/* Q2-W.A.P. to enter name and print it in Abbrivated forms 
eg:-Enter the Strings
     I/P:-raj kumar singh
     O/P:-R.K.Singh
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
            for(int i=0;i<ar.Length-1;i++)
            {
                name += ar[i].Substring(0, 1).ToUpper()+(".");
            }
            Console.WriteLine(name+ar[ar.Length-1].Substring(0,1).ToUpper()+ar[ar.Length-1].Substring(1));
            
        }
    }

}



