using System;
using System.IO;

namespace FileIOOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Text = File.ReadAllLines(@"D:\2022P4consolemon\Csharp2Opdrachten\FileIOOpdracht\burger.txt");

            foreach (string Line in Text)

                Console.WriteLine(Line);
        }
    }
}


