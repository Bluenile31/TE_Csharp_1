using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_Csharp_1
{
    internal class Task_18
    {
        public delegate T Area<T>(T a);
        class calculateArea
        {
            public double Circle(double r)
            {
                return 3.142 * r * r;
            }
            
            public int Cube(int b)
            {
                return b * b * b;
            }
            public int Sqaure(int a)
            {
                return a * a;
            }

        }
        class Areaof
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Area Calculator for Square, Cube and Circle");
                calculateArea c = new calculateArea();
        
                 Area<int> dlgt = new Area<int>(c.Sqaure);
                 Console.WriteLine("Area of a Square : " + dlgt(20));
            
                 dlgt = c.Cube;
                 Console.WriteLine("Area of a Cube : " + dlgt(8));
         
                Area<double> dlgt1 = new Area<double>(c.Circle);
                double a;
                Console.WriteLine("Area of a Circle: " + dlgt1(5));  
               
            }
        }
    }
}