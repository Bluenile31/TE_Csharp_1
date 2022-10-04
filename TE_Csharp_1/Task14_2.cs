using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_Csharp_1
{
    internal class Task14_2
    {
        class Program
        {
            public static void Main()
            {
                Staff s = new Staff();
                s.GetBonus1();
                NonStaff n = new NonStaff();
                n.GetBonus2();
            }
        }

    }
    public class Bonus
    {
        protected int bonus;
    }
    public class Staff : Bonus
    {
        protected int salary = 25000;
        public void GetBonus1()
        {
            bonus = 3 * salary;
            Console.WriteLine($"Staff salary: {salary} and Bonus= {bonus}");
        }
    }
    public class NonStaff : Staff
    {
        protected int salary = 15000;
        public void GetBonus2()
        {
            bonus = 2 * salary;
            Console.WriteLine($"Non Staff Salary: {salary} and Bonus= {bonus}");
        }
    }
}
