using SmsApp;
using System;

namespace SmsApp
{

    class Employee
    {
        int emmp;

        public int Empz
        {
            set{emmp=value ;}
            get{return emmp;}
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
        Employee emp = new Employee();
            emp.Empz = 21;
            Console.WriteLine(emp.Empz);

        }
    }
}
