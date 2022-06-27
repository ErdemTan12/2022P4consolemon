
using System;
using System.IO;

namespace FileDirOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"D:\indebidingingcomfromjapan");


            foreach (DirectoryInfo dir in directory.GetDirectories())
            {
                Console.WriteLine(dir.Name);
            }


            foreach (FileInfo files in directory.GetFiles())
            {
                Console.WriteLine(files.Name);
            }
        }
    }
}
