using System;
using System.IO;


namespace StringOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringsplittext = File.ReadAllText(@"D:\2022P4consolemon\Csharp2Opdrachten\StringOpdracht\stringsplit.txt");

            string[] text = stringsplittext.Split(':', ',');


            foreach (string splittext in text)
            {
                Console.WriteLine(splittext);
            }

        }
    }
}
