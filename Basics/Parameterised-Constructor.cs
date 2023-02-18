using System;
using System.Collections.Generic;
using System.Text;
namespace Darshit
{
    class Practise
    {
      
	  Practise(int roll,string name,float per)
        {
            Console.WriteLine("The Roll Number is:"+roll);
            Console.WriteLine("The Name is:"+name);
            Console.WriteLine("The Percentage is:"+per);
        }
        public static void Main(string[] args)
        {
            Practise pr = new Practise(1,"Aman",76);
        }
        
    }
}
 
