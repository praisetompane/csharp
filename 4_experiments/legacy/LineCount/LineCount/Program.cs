using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LineCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int Lines = 0;
            string[] FileContents;
            StreamReader reader = new StreamReader("Data.txt");
            FileContents = reader.ReadLine();
            while(FileContents != null)
            {
                for (int i = 0; i < FileContents.Length;i++ )
                {
                    if (FileContents[i] == '\0')
                    {

                    }
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
