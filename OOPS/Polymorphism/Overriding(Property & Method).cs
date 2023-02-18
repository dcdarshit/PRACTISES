using System;
using System.Collections.Generic;
using System.Text;

namespace SmsApp
{
    public class Ind
    {
        public int a;
  public virtual int Pro
        {
            set{ a= value ;}
            get{ return a; }
        }

        public virtual void Print()
        {
            Console.WriteLine("This is Parent Class Called");
        }

        public Ind()
        {
            Console.WriteLine("Parent Class Constructor");
        }
    }

    class Child : Ind
    {
        //Constructor Can't Override 
        //public Ind()
        //{
        //    Console.WriteLine("Parent Class Constructor");
        //}

        public override void Print()                        //Method Override
        {
            Console.WriteLine("This is Child Class Called");
        }
        public override int Pro                                //Property Override
        {
            set{a=value;}
            get{return a;}
        }
        public static void Main(string[] args)
        {
            Child n1 = new Child();
            n1.Pro = 100;
            Console.WriteLine(n1.Pro);
        }
    }
}