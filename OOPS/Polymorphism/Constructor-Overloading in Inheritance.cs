using System;
using System.Collections.Generic;
using System.Text;

namespace SmsApp
{
    class LoadParent
    {
        public void Show()
        {
            Console.WriteLine("Parent Show Method is called");
        }

        public void Test()
        {
            Console.WriteLine("Parent Test Method is called");
        }
    }
    class LoadChild : LoadParent
    {
        public void Show(int i)
        {
            Console.WriteLine("Child Show Method is called");
        }
        public static void Main(string[] args)
        {
            LoadChild lc = new LoadChild();
            lc.Show();

        }
    }
}
