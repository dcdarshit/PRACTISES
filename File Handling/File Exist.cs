using System;
using System.IO;

namespace Works
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\admin\Desktop\Darshit Chaudhary\File Handling\demo.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("Yes File Exist");
            }
            else
            {
                Console.WriteLine("Not Exist");
            }
        }
    }
}
