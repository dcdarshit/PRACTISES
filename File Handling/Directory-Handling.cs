using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Works
{
    class FH
    {
        public static void Main(string[] args)
        {
            string path = @"D:\Darchit Ch";
            string path1 = @"D:\Darshit";
            DirectoryInfo dd = new DirectoryInfo(path);
            //dd.Create();
            //dd.CreateSubdirectory("Child Directory");
            //dd.MoveTo(path1);
            Console.WriteLine("Folder Sub-Directory");

            string path3 = @"D:\Darchit Ch";
            DirectoryInfo dd2 = new DirectoryInfo(path3);
           // dd.Create();
            dd.Delete();
        }
    }
}
