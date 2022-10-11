using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_Csharp_1
{
    internal class files_1
    {
        public static void Main()
        {
            //move
            
            string source = @"C:\Users\EI13085\Desktop\c#\fileoperations.txt";
            string destination = @"C:\Users\EI13085\Desktop\c#\fileoperations.txt";
            File.Move(source, destination);
            File.Move(@"C:\Users\EI13085\Desktop\c#\fileoperations.txt", @"C:\Users\EI13085\Desktop\c#\fileoperations.txt");
            

            //copy
            
            string source_path = @"C:\Users\EI13085\Desktop\c#\filemult.txt";
            string dest_path = @"C:\Users\EI13085\Desktop\c#\filemult.txt";
            File.Copy(source_path, dest_path);
            

            //delete
            string path = @"C:\Users\EI13085\Desktop\c#\file_1.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
                try
                {
                    File.Delete(path);
                }
                catch
                {
                    Console.WriteLine("Cannot Delete");
                }
            }
            else
            {
                Console.WriteLine("File not Exist");
            }
        }
    }
}

