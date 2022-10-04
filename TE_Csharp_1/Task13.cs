using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_Csharp_1
{
    internal class Task13
    {
        public static void Main()
        {
            //Array_add();
            Console.WriteLine("------------------------------------------");
            //int total = mul(3, 7, 2, 9, 3, 6, 1, 8);
            //Console.WriteLine(total);
            Console.WriteLine("---------------------------------");
            int sid;
            string sname;
            string sdept;
            detail(out sid, out sname, out sdept);

            Console.WriteLine($"Student id:{sid}");
            Console.WriteLine($"Student name:{sname}");
            Console.WriteLine($"Student Department:{sdept}");


        }
        public static void Array_add()
        {
            int i, j, n;
            int[,] arr1 = new int[20, 20];
            int[,] arr2 = new int[20, 20];
            int[,] arr3 = new int[20, 20];
            // setting matrix row and columns size
            n = 3;
            Console.Write("Enter elements in the first matrix:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("Enter elements in the second matrix:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("\nFirst matrix is:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }
            Console.Write("\nSecond matrix is:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", arr2[i, j]);
            }
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    arr3[i, j] = arr1[i, j] + arr2[i, j];
            Console.Write("\nAdding two matrices: \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", arr3[i, j]);
            }
            Console.Write("\n\n");
        }
        public static int mul(params int[] numbers)
        {
            int mul = 1;
            foreach (int i in numbers)
            {
                mul *= i;
            }
            return mul; 

        }
        public static void detail(out int sid, out string sname, out string sdept)
        {
            sid = 31;
            sname = "Nilesh SHrenik Hosure";
            sdept = "CSE";
        }
    }
}
