using System;
using System.Collections.Generic;
using System.Text;

namespace SmsApp
{
    class Ind
    {
        int Id;
        string Name;
        public int ID
        {
            set{ Id = value;}
            get { return Id; }
        }
        public static void Main(string[] args)
        {
            Ind n = new Ind();
            n.ID = 12;
            Console.WriteLine(n.ID);
        }
    }
     
        
}
