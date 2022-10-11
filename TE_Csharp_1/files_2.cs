using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_Csharp_1
{
    internal class files_2
    {
        public static void Main()
        {
            string[] content;
            content = File.ReadAllLines(@"C:\Users\EI13085\Desktop\c#\filemult.txt");
            Console.WriteLine(content[0]);

            var lineCount = File.ReadAllLines(@"C:\Users\EI13085\Desktop\c#\filemult.txt").Length;
            Console.WriteLine($"Total number of lines in TE.txt file are: {lineCount}");
        }
    }
}
