using System;
using System.Collections.Generic;
using System.Text;

namespace SmsApp
{
    class Ind
    {
        int Id;
        string Name;
        public void set(int x)          //Setter Method
        {
            this.Id = x;
        }
        public int get()                //Getter Method
        {
            return this.Id;
        }
        public static void Main(string[] args)
        {
            Ind n = new Ind();
            n.set(21);
            Console.WriteLine(n.get());
        }
    }
     
        
}
