using System;

namespace Encap1
{
    public class Encap
    {

        public void M1()
        {
            Console.WriteLine("Method-1");
        }
        public virtual void M1(int x)
        {
            Console.WriteLine("Method-2");
        }
        public void M1(int x, string y)
        {
            Console.WriteLine("Method-3");
        }
    }
    class Emp:Encap
    {
        public override void  M1(int x)
        {
            Console.WriteLine("Method-1 Changed by Overloading");
        }
    
        public static void Main(string[] args)
        {
            Encap n = new Encap();
            n.M1(12);

        }
    }   
}
