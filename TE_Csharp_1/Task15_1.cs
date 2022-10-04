using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_Csharp_1
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(String message) : base(message)
        {
        }
    }
    public class TestUserDefinedException
    {
        static void validate(int age)
        {
            if (age < 22)
            {
                throw new InvalidAgeException("Access denied!! - You must be atleast 22 years old.");
            }
            else
            {
                Console.WriteLine("Go ahead!!");
            }
        }
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the age");
                var age = Convert.ToInt32(Console.ReadLine());
                validate(age);
            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine(e);

            }
        }
    }
}
