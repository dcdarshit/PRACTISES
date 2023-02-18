using System;
using System.Collections.Generic;
using System.Text;
namespace Darshit
{
    class Practise
    {


        public string Fname;
        public string Lname;
        public decimal Salary;
    
        public void Display()
        {
            Console.WriteLine("Employee First Name is:-" +Fname);
            Console.WriteLine("Employee Last Name is:-" +Lname);
            Console.WriteLine("Employee Salary is:-" +Salary);
        }
   
        Practise(string fname,string lname,decimal salary)
        {
            Fname = fname;
            Lname = lname;
            Salary = salary;
        }
        Practise(Practise c4)
        {
            Fname = c4.Fname;
            Lname = c4.Lname;
            Salary = c4.Salary;
        }
        
        public static void Main(string[] args)
        {
            Practise c1 = new Practise("Rakesh","Kumar",12000);
            Practise c2 = new Practise(c1);
            c1.Display();
            Console.WriteLine("-------------------Updated-----------------");
            c1.Salary = 1000;
            c1.Lname = "Singh";
            c1.Display();
            Console.WriteLine("------------------Previous--------------");
            c2.Display();

            Console.ReadLine();
        }
        
    }
}
 
