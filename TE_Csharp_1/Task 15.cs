using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_Csharp_1
{
    internal class Task_15
    {

        public static void Main()
        {
            excep ex = new excep();
            ex.Multiplecatch();
            ex.mcatch();
        }
    }
    public class excep
    {
        public void Multiplecatch()
        {
            int[] a = { 8, 4, 6, 4, 8 };
            int[] b = { 2, 4, 0, 5 };
            int c, d, f;

            for (int i = 0; i < a.Length; i++)
            {
                try
                {
                    Console.WriteLine(a[i] / b[i]);

                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public void mcatch()
        {
            int a, b, c;
            try
            {
                Console.WriteLine("Enter 1st number = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number = ");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine($"Result= {c}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter Only Integer Numbers");
            }
        }
    }
}