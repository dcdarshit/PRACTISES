using System;

namespace SmsApp
{

    class Employee
    {
        int emmp;
        
        public void set(int emmp)
        {
            this.emmp = emmp;
        }
        public int get()
        {
            return emmp;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.set(21);
            Console.WriteLine(emp.get());
        }
    }
}
