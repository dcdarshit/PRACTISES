using System;
using System.IO;

namespace Works
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\admin\Desktop\Darshit Chaudhary\File Handling\demo.txt";
            Console.WriteLine(File.ReadAllText(path));
            Console.ReadLine();
        }
       
    }
}
