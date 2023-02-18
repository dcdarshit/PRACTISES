using System;
using System.IO;

namespace Works
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\admin\Desktop\Darshit Chaudhary\File Handling\demo.txt";
            string path1 = @"C:\Users\admin\Desktop\Darshit Chaudhary\File Handling\demo1.txt";
            File.Copy(path, path1);
            Console.ReadLine();
        }
       
    }
}
