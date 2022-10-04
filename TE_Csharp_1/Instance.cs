using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TE_Csharp_1
{
    internal class Instance
    {
        public static void Main()
        {
            Console.WriteLine("Control state");
            Conditional();
            Instance c = new Instance();
            c.Looping();
            Console.WriteLine("To accept all the employee details using static method and display the details in an instance method");
            acceptData();

        }

        public static void Conditional()
        {
            Console.WriteLine("Conditional");
            Console.WriteLine("--------------------");
            int a, b, c;
            Console.WriteLine("Enter values");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("A greater");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("B greater");
            }
            else
            {
                Console.WriteLine("C is greater");
            }
            Console.WriteLine("--------------------");

        }

        public void Looping()
        {
            Console.WriteLine("looping");
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            int[] num = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
            int[] n = { 1, 2, 3 };

            //for loop statements
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("--------------------");


            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--------------------");
            int s = 0;
            for (int i = 0; i < n.Length; i++)
            {
                s += n[i];
            }
            Console.WriteLine("Sum is: {0}", s);
            Console.WriteLine("--------------------");
            int si;
            Console.WriteLine("Enter size");
            si = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[si];
            for (int j = 0; j < si; j++)
            {
                Console.WriteLine("Enter the value of {0} of array", j + 1);
                a[j] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("--------------------");
            Console.WriteLine("array elements");

            foreach (int c in a)
            {
                Console.WriteLine(c);
            }



        }
        public static void acceptData()
        {
            int empid;
            string empname;
            int salary;
            string designation;

            Console.WriteLine("Enter Employee Details");
            Console.WriteLine("Enter number of employees");
            int size = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter employee ID");
                empid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter employee Name");
                empname = Console.ReadLine();
                Console.WriteLine("Enter employee Salary");
                salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter employee Designation");
                designation = Console.ReadLine();

                Instance e = new Instance();
                e.displayData(empid, empname, salary, designation);

                Console.WriteLine("---------------------");

            }

        }

        public void displayData(int id, string name, int salary, string designation)
        {
            Console.WriteLine();
            Console.WriteLine("Employee Details:-");
            Console.WriteLine("Employee id: {0}", id);
            Console.WriteLine("Employee Name: {0}", name);
            Console.WriteLine("Employee salary: {0}", salary);
            Console.WriteLine("Employee designation: {0}", designation);

        }

    }
}