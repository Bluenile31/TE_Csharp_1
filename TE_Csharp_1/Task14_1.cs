using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TE_Csharp_1
{
    internal class Task14_1
    {
        public static void Main()
        {
            add ad = new add(31, 47);
            add ad1 = new add(5.76f, 3.142f);
            add ad2 = new add("NIL", "ESH");
            number();
        }
        public class add
        {
            public add(int a, int b)
            {
                Console.WriteLine($"Output in int: {a + b}");
            }
            public add(float a, float b)
            {
                Console.WriteLine($"Output in float: {a + b}");
            }
            public add(string a, string b)
            {
                Console.WriteLine($"Output in string: {a + b}");
            }
        }

        public static void number()
        {
            Console.WriteLine("Mobile Number validation");
            Console.WriteLine("Enter the 10 digit mobile number");
            var number = Console.ReadLine();
            var validate_number = Regex.IsMatch(number, @"^[789]\d{9}$");
            Console.WriteLine(validate_number);
        }
    }
}
